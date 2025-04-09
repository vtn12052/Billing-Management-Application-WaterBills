using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Water_Bills
{
    public class RefreshHelper
    {


        // This method used for update table data.
        public void RefreshDataGridView(DataGridView dataGridView)
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
                    dataGridView.DataSource = dt;
                }
                con.Close();
            }
        }
    }
}
