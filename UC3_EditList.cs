using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;


namespace Water_Bills
{
    public partial class UC3_EditList : UserControl
    {
        public UC3_EditList()
        {
            InitializeComponent();
            dataGridView2.CellFormatting += dataGridView2_CellFormatting;
            search1.KeyPress += new KeyPressEventHandler(search1_KeyPress);
        }


        // This method is called when the "Remove" button is clicked.
        public void remove_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=KERO-LAPTOP;Initial Catalog=waterbill;Integrated Security=True;Encrypt=False"))
                    {
                        con.Open();
                        foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                            if (row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString())))
                            {
                                MessageBox.Show("Selected row contains empty cells. Please select a valid row.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                var confirm = MessageBox.Show("Are you sure you want to remove this customer?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                if (confirm == DialogResult.OK)
                                {
                                    string customerName = row.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                                    using (SqlCommand cmd = new SqlCommand("DELETE FROM list1 WHERE [Customer Name] = @name", con))
                                    {
                                        cmd.Parameters.AddWithValue("@name", customerName);
                                        cmd.ExecuteNonQuery();
                                    }
                                    dataGridView2.Rows.Remove(row);
                                    MessageBox.Show("Customer removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while removing the row: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }


        // This method binds data to the DataGridView when the form loads. (refreshes the data)
        public void BindData2()
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
                    dataGridView2.DataSource = dt;
                }
                con.Close();
            }
        }


        // This method is called when the form loads.
        private void editlist_Load(object sender, EventArgs e)
        {
            name.Enabled = false;
            type.Enabled = false;
            number.Enabled = false;
            lastmonth.Enabled = false;
            thismonth.Enabled = false;
            datepick.Enabled = false;
            statement.Enabled = false;
            save.Visible = false;
            BindData2();
        }




        public int lastselectedRowIndex = 0; // Variable to store the last selected row index
        // This method is called when a cell in the DataGridView is clicked.
        public void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView2.Rows.Count)
            {
                return;
            }
            else if (e.RowIndex == lastselectedRowIndex)
            {
                return; // Ignore the click if it's the same row
            }

            string nameval = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() ?? " "; 
            string typeval = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() ?? " ";
            string numberval = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            string lastmonthval = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString().Replace(" m³", "") ?? " ";
            string thismonthval = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString().Replace(" m³", "") ?? " ";
            string dateval = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString() ?? " ";
            string statementval = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString() ?? " ";

            name.Text = nameval;
            type.Text = typeval;
            number.Text = numberval;
            lastmonth.Text = lastmonthval;
            thismonth.Text = thismonthval;
            datepick.Text = dateval;
            statement.Text = statementval;

            // Disable all text boxes and hide save button
            name.Enabled = false;
            type.Enabled = false;
            number.Enabled = false;
            lastmonth.Enabled = false;
            thismonth.Enabled = false;
            datepick.Enabled = false;
            statement.Enabled = false;
            save.Visible = false;
        }


        // This method is called when the "Edit" button is clicked.
        private void edit_Click(object sender, EventArgs e)
        {
            editico.Visible = false;
            if (dataGridView2.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    if (row.Cells.Cast<DataGridViewCell>().All(cell => cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString())))
                    {
                        name.Enabled = true;
                        type.Enabled = true;
                        number.Enabled = true;
                        lastmonth.Enabled = true;
                        thismonth.Enabled = true;
                        datepick.Enabled = true;
                        statement.Enabled = true;
                        save.Visible = true;
                        save.BringToFront();
                        return;
                    }
                }
                MessageBox.Show("Selected row contains empty cells. Please select a valid row.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public decimal basePrice { get; set; }
        public decimal protectionFee { get; set; }
        // This method is called when the "Save" button is clicked.
        public void save_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=KERO-LAPTOP;Initial Catalog=waterbill;Integrated Security=True;Encrypt=False"))
                    {
                        con.Open();
                        string selectedType = type.SelectedItem.ToString();
                        string statementValue = statement.Text.ToString();
                        string dueDate = datepick.Value.ToString("dd/MM/yyyy");


                        int numberOfPeople = int.Parse(number.Text);
                        float lastMonthReading = float.Parse(lastmonth.Text);
                        float thisMonthReading = float.Parse(thismonth.Text);
                        int consumptionValue = (int)(thisMonthReading - lastMonthReading);

                        BillCalculate bill = new BillCalculate();
                        decimal totalBill = bill.billCal(selectedType, numberOfPeople, consumptionValue);
                        decimal vat = bill.includeVat(totalBill);
                        foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                        {
                            string customerName = row.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                            using (SqlCommand cmd = new SqlCommand("UPDATE list1 SET [Customer Name] = @name, [Customer Type] = @type, [Number Of People] = @number, [Consumption] = @consum, [Last Month Reading] = @lastmonth, [This Month Reading] = @thismonth, [Total Bill] = @totalbill, [Include (VAT)] = @vat, [Due Date] = @date, [Statement] = @state WHERE [Customer Name] = @oldname", con))
                            {
                                cmd.Parameters.AddWithValue("@name", name.Text);
                                cmd.Parameters.AddWithValue("@type", type.Text);
                                cmd.Parameters.AddWithValue("@number", number.Text);
                                cmd.Parameters.AddWithValue("@consum", consumptionValue.ToString("N2") + " m³");
                                if (lastMonthReading > thisMonthReading)
                                {
                                    consumptionValue = 0;
                                    return;
                                }
                                else if (consumptionValue == 0)
                                {
                                    totalBill = 0;
                                    vat = 0;
                                    statementValue = "Canceled";
                                }
                                cmd.Parameters.AddWithValue("@lastmonth", lastMonthReading.ToString("N2") + " m³");
                                cmd.Parameters.AddWithValue("@thismonth", thisMonthReading.ToString("N2") + " m³");
                                cmd.Parameters.AddWithValue("@totalbill", totalBill.ToString("N0") + " VND");
                                cmd.Parameters.AddWithValue("@vat", vat.ToString("N0") + " VND");
                                cmd.Parameters.AddWithValue("@date", datepick.Value);
                                cmd.Parameters.AddWithValue("@oldname", customerName);
                                cmd.Parameters.AddWithValue("@state", statementValue);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        con.Close();
                    }
                    // In your form initialization (e.g., constructor or Load event)
                    BindData2();
                    MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editlist_Load(sender, e);
                    save.SendToBack();
                    editico.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to save.");
            }
        }


        // This method is called when the "Type" combo box selection changes.
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


        // This method is called when the "Search" button is clicked.
        private void searchbt1_Click(object sender, EventArgs e)
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Customer Name] LIKE '%{0}%'", search1.Text);

        }
        private void search1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchbt1_Click(sender, e);
                e.Handled = true; // Prevent the system sound
            }
        }


        // This method used to hide elements when mouse enters and leaves the search box.
        private void search1_MouseEnter(object sender, EventArgs e)
        {
            searchhidetext2.Visible = false;
        }
        private void search1_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(search1.Text))
            {
                searchhidetext2.Visible = true;
            }
        }
        private void search1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(search1.Text))
            {
                searchhidetext2.Visible = true;
            }
            else
            {
                searchhidetext2.Visible = false;
            }
        }



        // This method is called to format statement values in the DataGridView.
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "statementDataGridViewTextBoxColumn" && e.Value != null)
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



        // This method is called when the "Remove All" button is clicked.
        private void removeall_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                var confirmResult1 = MessageBox.Show("Are you sure you want to remove all customers?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirmResult1 == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=KERO-LAPTOP;Initial Catalog=waterbill;Integrated Security=True;Encrypt=False"))
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM list1", con))
                            {
                                cmd.ExecuteNonQuery();
                            }
                            con.Close();
                        }
                        // Refresh dataGridView2 in editlist
                        BindData2();
                        MessageBox.Show("All customers removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while removing all rows: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no customers to remove!");
            }
        }
    }
}
