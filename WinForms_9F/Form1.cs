using Microsoft.Data.SqlClient;
using System.Data;

namespace WinForms_9F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string Constring = @"Server=WIN-VD08C7OPT8H\SQLEXPRESS; Database=Ado9F;Trusted_Connection=true; Encrypt=false;";
        SqlConnection connection = new SqlConnection(Constring);

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Əlavə et
            try
            {
                connection.Open();

                string cmd = @"INSERT INTO Employee(E_name,E_position,E_salary) 
                    VALUES(@eName,@ePosition, @eSalary)";

                SqlCommand sqlCommand = new SqlCommand(cmd, connection);

                sqlCommand.Parameters.AddWithValue("@eName", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@ePosition", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@eSalary", textBox3.Text);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("İşçi əlavə olundu!");
                Show();
            }
            catch (Exception u)
            {
                MessageBox.Show("Xəta" + u.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Sil
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(item.Cells[0].Value);
                Delete(id);
                MessageBox.Show("İşçi silindi!");
                Show();

            }
        }

        //Methodlar
        private void Show()
        {
            //Göstər
            try
            {
                string cmd = @"SELECT * FROM Employee";

                SqlCommand sqlCommand = new SqlCommand(cmd, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception u)
            {
                MessageBox.Show("Xəta" + u.Message);
            }

        }
        private void Delete(int id)
        {
            //Silme
            try
            {
                connection.Open();
                string cmd = @"DELETE FROM Employee WHERE id=@id";
                SqlCommand sqlCommand = new SqlCommand(cmd, connection);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception u)
            {
                MessageBox.Show("Xətaa" + u.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Axtar
            try
            {
                connection.Open();
                string cmd = "SELECT * FROM Employee WHERE E_name=@name";
                SqlCommand sqlCommand = new SqlCommand(cmd, connection);
                sqlCommand.Parameters.AddWithValue("@name", textBox4.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception u)
            {
                MessageBox.Show("Xəta" + u.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}