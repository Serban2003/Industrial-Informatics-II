using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsUniv;
        DataSet dsFac;

        public Form1()
        {
            InitializeComponent();
            myCon.ConnectionString = Properties.Settings.Default.DatabaseConnectionString;
         
            dsUniv = new DataSet();
            dsFac = new DataSet();

            updateDataSet();
        }

        private void listBox_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            listFaculties.Items.Clear();

            int code = 0;
            if(listUniversities.SelectedItem != null)
            {
                String UnivSelected = listUniversities.SelectedItem.ToString();
                foreach (DataRow dr in dsUniv.Tables["Universities"].Rows)
                {
                    if (UnivSelected == $"{dr.ItemArray.GetValue(1)} [ID: {dr.ItemArray.GetValue(0)}]")
                    {
                        cityTextBox.Text = dr.ItemArray.GetValue(2).ToString();
                        code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                        codeTextBox.Text = code.ToString();
                    }
                }
                foreach (DataRow dr in dsFac.Tables["Faculties"].Rows)
                {
                    if (code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                    {
                        String nameFac = dr.ItemArray.GetValue(2).ToString();
                        listFaculties.Items.Add(nameFac);
                    }
                }
            }
        }

        private void updateDataSet()
        {
            listFaculties.Items.Clear();
            listUniversities.Items.Clear();
            dsUniv.Clear();
            dsFac.Clear();

            cityTextBox.Text = "";
            codeTextBox.Text = "";

            try
            {
                myCon.Open();

                SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universities", myCon);
                daUniv.Fill(dsUniv, "Universities");
                SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Faculties", myCon);
                daFac.Fill(dsFac, "Faculties");

                foreach (DataRow dr in dsUniv.Tables["Universities"].Rows)
                {
                    String name = $"{dr.ItemArray.GetValue(1)} [ID: {dr.ItemArray.GetValue(0)}]";
                    listUniversities.Items.Add(name);
                }

                myCon.Close();
            }
            catch
            {
                MessageBox.Show("Couldn't update data set!");
            }

            facultiesTableAdapter.Fill(databaseDataSet.Faculties);
        }


        private void add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                String name = add_Name_TextBox.Text;
                String city = add_City_TextBox.Text;
                Int32 code = Int32.Parse(add_Code_TextBox.Text);

                myCon.Open();
                string sql = $"INSERT INTO [Universities] (Name, City, Code) VALUES (@name, @city, @code)";

                using (SqlCommand command = new SqlCommand(sql, myCon))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@code", code);

                    command.ExecuteNonQuery();
                }
                myCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            updateDataSet();
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            String ID = delete_ID_TextBox.Text;

            try
            {
                myCon.Open();

                String deleteQuery = "DELETE FROM Faculties WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, myCon))
                {
                    cmd.Parameters.AddWithValue("@Id", ID);
                    int affected = cmd.ExecuteNonQuery();
                }

                deleteQuery = "DELETE FROM Universities WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, myCon))
                {
                    cmd.Parameters.AddWithValue("@Id", ID);
                    int affected = cmd.ExecuteNonQuery();
                }

                myCon.Close();
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            
            updateDataSet();
        }

        private void update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                String ID = update_ID_TextBox.Text;
                String name = update_Name_TextBox.Text;
                String city = update_City_TextBox.Text;
                Int32 code = Int32.Parse(update_Code_TextBox.Text);

                myCon.Open();

                String sql = $"UPDATE Universities SET Name = @name, City = @city, code = @code WHERE Id = @id";
                
                using (SqlCommand command = new SqlCommand(sql, myCon))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@code", code);
                    command.Parameters.AddWithValue("@id", ID);

                    command.ExecuteNonQuery();
                }

                myCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            updateDataSet();
        }
    }
}
