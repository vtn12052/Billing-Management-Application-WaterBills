using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Water_Bills
{
    public partial class UC2_BillsManagement : UserControl
    {
        public UC2_BillsManagement()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            search.KeyPress += new KeyPressEventHandler(search_KeyPress);
        }


        // This method is called when the "Add" button is clicked.
        private void add_Click(object sender, EventArgs e)
        {
            // Check if any text box is empty
            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(type.Text) ||
                string.IsNullOrWhiteSpace(number.Text) ||
                string.IsNullOrWhiteSpace(lastmonth.Text) ||
                string.IsNullOrWhiteSpace(thismonth.Text))
            {
                MessageBox.Show("Please fill in all fields before adding a customer!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(number.Text, out int numberOfPeople) || numberOfPeople <= 0)
            {
                MessageBox.Show("Number of people can't be zero or negative!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(lastmonth.Text, out float lastMonthReading) || lastMonthReading <= 0)
            {
                MessageBox.Show("Last month's reading can't be zero or negative!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(thismonth.Text, out float thisMonthReading))
            {
                MessageBox.Show("Invalid value! Please enter a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (thisMonthReading <= 0 || thisMonthReading < lastMonthReading)
            {
                MessageBox.Show("This month's reading can't be zero, negative, or less than last month's reading!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Database connection
            using (SqlConnection con = new SqlConnection("Data Source=KERO-LAPTOP;Initial Catalog=waterbill;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    // Check if customer already exists
                    using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM list1 WHERE [Customer Name] = @name", con))
                    {
                        checkCommand.Parameters.AddWithValue("@name", name.Text);
                        int count = (int)checkCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Customer already added.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    string selectedType = type.SelectedItem.ToString();
                    string dueDate = datepick.Value.ToString("dd/MM/yyyy");
                    int consumptionValue = (int)(thisMonthReading - lastMonthReading);
                    string defaultStatus = "Pending";
                    // Calculate the bill
                    BillCalculate bill = new BillCalculate();
                    decimal totalBill = bill.billCal(selectedType, numberOfPeople, consumptionValue);
                    decimal vat = bill.includeVat(totalBill);
                    using (SqlCommand command = new SqlCommand("insert into list1 ([Customer Name], [Customer Type], [Number Of People], [Consumption], [Last Month Reading], [This Month Reading], [Total Bill], [Include (VAT)], [Due Date], [Statement]) values (@name, @type, @number, @consum, @lastmonth, @thismonth, @totalbill, @vat, @due, @state)", con))
                    {
                        command.Parameters.AddWithValue("@name", name.Text);
                        command.Parameters.AddWithValue("@type", selectedType);
                        command.Parameters.AddWithValue("@number", numberOfPeople);
                        command.Parameters.AddWithValue("@consum", consumptionValue.ToString("N2") + " m³");
                        command.Parameters.AddWithValue("@lastmonth", lastMonthReading.ToString("N2") + " m³");
                        command.Parameters.AddWithValue("@thismonth", thisMonthReading.ToString("N2") + " m³");
                        command.Parameters.AddWithValue("@totalbill", totalBill.ToString("N0") + " VND");
                        command.Parameters.AddWithValue("@vat", vat.ToString("N0") + " VND");
                        command.Parameters.AddWithValue("@due", dueDate);
                        command.Parameters.AddWithValue("@state", defaultStatus);
                        command.ExecuteNonQuery(); // Ensure the command is executed
                        MessageBox.Show("Customer added Successfully");
                    }
                    con.Close();
                    BindData1(); // Refresh the data grid view
                }
        }


        // This method is called to bind data to the DataGridView. (refresh data)
        public void BindData1()
        {
            using (SqlConnection con = new SqlConnection("Data Source=KERO-LAPTOP;Initial Catalog=waterbill;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("select * from list1", con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    // Set the DataSource to the DataTable
                    dataGridView1.DataSource = dt;
                }
                con.Close();
            }
        }


        // This method used for form load.
        private void bill_management_Load(object sender, EventArgs e)
        {
            number.Enabled = false;
            BindData1(); //calling the BindData function
        }


        // This method used for unable to edit the number of people when the type is not "Household".
        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.SelectedItem != null && type.SelectedItem.ToString() == "Household")
            {
                number.ReadOnly = false;
                number.Enabled = true;
            }
            else
            {
                number.Text = "1";
                number.ReadOnly = true;
                number.Enabled = false;
            }
        }


        // This method clears the input fields.
        private void clear_Click(object sender, EventArgs e)
        {
            name.Clear();
            if (type.Items.Count > 0)
            {
                type.SelectedIndex = -1;
            }
            number.Clear();
            lastmonth.Clear();
            thismonth.Clear();
            datepick.Value = DateTime.Now;
        }


        // This method used for searching the customer name.
        private void searchbt_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Customer Name] LIKE '%{0}%'", search.Text);
        }
        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchbt_Click(sender, e);
                e.Handled = true; // Prevent the system sound
            }
        }


        // This method is used to show the hint text when the search box is empty.
        private void search_MouseEnter(object sender, EventArgs e)
        {
            searchhidetext1.Visible = false;
        }
        private void search_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(search.Text))
            {
                searchhidetext1.Visible = true;
            }
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(search.Text))
            {
                searchhidetext1.Visible = true;
            }
            else
            {
                searchhidetext1.Visible = false;
            }
        }


        // Print the data grid view to PDF.
        private void print_Click(object sender, EventArgs e)
        {
            ExportPDF pdfExporter = new ExportPDF();
            pdfExporter.ExportDataGridViewToPDF(dataGridView1, "waterbill.pdf");
        }


        // Format the DataGridView cells based on the statement value.
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "statementDataGridViewTextBoxColumn" && e.Value != null)
            {
                string statementValue = e.Value.ToString();

                if (statementValue == "Paid")
                {
                    e.CellStyle.ForeColor = Color.DarkGreen;
                }
                else if (statementValue == "Pending")
                {
                    e.CellStyle.ForeColor = Color.DarkOrange;
                }
                else if (statementValue == "Overdue")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}


