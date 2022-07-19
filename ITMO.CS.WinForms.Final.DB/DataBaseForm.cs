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
    public partial class DataBaseForm : Form
    {
        public DataBaseForm()
        {
            InitializeComponent();
        }

        private void DataBaseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Item", "Item");
            dataGridView1.Columns.Add("Color", "Color");
            dataGridView1.Columns.Add("Qty", "Qty");

            RefreshTable();
        }
        
        public void RefreshTable()
        {
            try
            {
                dataGridView1.Rows.Clear();

                using (SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WFdb;Data Source=."))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("Select * from tContent", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                            }

                        }
                    }
                    textBoxDel_ID.Clear();
                    textBoxAdd_Item.Clear();
                    textBoxAdd_Color.Clear();
                    textBoxAdd_Qty.Clear();
                    textBoxAdd_Item.Text = "Enter Item";
                    textBoxAdd_Item.ForeColor = Color.Gray;
                    textBoxAdd_Color.Text = "Enter Color";
                    textBoxAdd_Color.ForeColor = Color.Gray;
                    textBoxAdd_Qty.Text = "Enter Qty";
                    textBoxAdd_Qty.ForeColor = Color.Gray;
                    textBoxDel_ID.Text = "Enter ID";
                    textBoxDel_ID.ForeColor = Color.Gray;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var item = textBoxAdd_Item.Text;
                var color = textBoxAdd_Color.Text;
                var qty = textBoxAdd_Qty.Text;

                using (SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WFdb;Data Source=."))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand($"insert into tContent (Item, Color, Qty) values ('{item}','{color}','{qty}')", conn);
                    cmd.ExecuteNonQuery();

                    RefreshTable();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WFdb;Data Source=."))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand($"delete from tContent where ID = '{textBoxDel_ID.Text}'", conn);
                    cmd.ExecuteNonQuery();

                    RefreshTable();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxAdd_Item_Enter(object sender, EventArgs e)
        {
            if (textBoxAdd_Item.Text == "Enter Item")
            {
                textBoxAdd_Item.Clear();
                textBoxAdd_Item.ForeColor = Color.Black;
            }
        }

        private void textBoxAdd_Color_Enter(object sender, EventArgs e)
        {
            if (textBoxAdd_Color.Text == "Enter Color")
            {
                textBoxAdd_Color.Clear();
                textBoxAdd_Color.ForeColor = Color.Black;
            }
        }

        private void textBoxAdd_Qty_Enter(object sender, EventArgs e)
        {
            if (textBoxAdd_Qty.Text == "Enter Qty")
            {
                textBoxAdd_Qty.Clear();
                textBoxAdd_Qty.ForeColor = Color.Black;
            }
        }

        private void textBoxDel_ID_Enter(object sender, EventArgs e)
        {
            if (textBoxDel_ID.Text == "Enter ID")
            {
                textBoxDel_ID.Clear();
                textBoxDel_ID.ForeColor = Color.Black;
            }
        }
    }
}
