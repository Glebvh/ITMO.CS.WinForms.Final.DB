using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITMO.CS.WinForms.Final.DB
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnExit.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WFdb;Data Source=."))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand($"Select Login, Pass from tUsers where Login = '{textBox_login.Text}' and Pass = '{textBox_pass.Text}'", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DataBaseForm form = new DataBaseForm();
                                this.Hide();
                                form.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Error!");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox_login.Text = "Type 'Login' here";
            textBox_login.ForeColor = Color.Gray;
            textBox_pass.Text = "Type 'Password' here";
            textBox_pass.ForeColor = Color.Gray;
            
        }

        private void textBox_login_Enter(object sender, EventArgs e)
        {
            if (textBox_login.Text == "Type 'Login' here")
            {
                textBox_login.Clear();
                textBox_login.ForeColor = Color.Black;
            }
        }

        private void textBox_pass_Enter(object sender, EventArgs e)
        {
            if (textBox_pass.Text == "Type 'Password' here")
            {
                textBox_pass.Clear();
                textBox_pass.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
