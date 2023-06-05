using Microsoft.Data.SqlClient;

namespace WinForms_9F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Constring = @"Server=WIN-VD08C7OPT8H\SQLEXPRESS; Database=Ado9F;Trusted_Connection=true; Encrypt=false;";
        private void button1_Click(object sender, EventArgs e)
        {
            //ADO.NET
            

            SqlConnection connection = new SqlConnection(Constring);

            try
            {
                connection.Open();
                MessageBox.Show("Database Open");

                string cmd = @"INSERT INTO Register(Username,UserPassword) 
                    VALUES(@usern,@userpass)";

                SqlCommand sqlCommand = new SqlCommand(cmd, connection);

                sqlCommand.Parameters.AddWithValue("@usern", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@userpass", textBox2.Text);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Daxil edildi");
            }
            catch (Exception u)
            {
                MessageBox.Show("Error"+ u.Message);
            }
            finally
            {
                connection.Close();
                MessageBox.Show("Database Close");
            }

        }
    }
}