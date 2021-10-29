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

namespace cafe
{
    public partial class add_materials_to_stock : Form
    {
        SqlConnection cn = new SqlConnection(@"data source = DESKTOP-UIFKEN5\SQLEXPRESS;database =cafe_system;integrated security =True ");
        SqlCommand cmd;
        public add_materials_to_stock()
        {
            InitializeComponent();
        }
        public void remove_textboxs()
        {
            name_textbox.Text = string.Empty;
            quantity_textbox.Text = string.Empty;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to save the information ?", "Alert", MessageBoxButtons.YesNo);
            if (name_textbox.Text != string.Empty && quantity_textbox.Text != string.Empty)
            {
                if (result == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("insert into pinding_stock values('" + name_textbox.Text + "','" + quantity_textbox.Text + "','" + add_dateTimePicker.Value + "')", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    //delete data in text boxs
                    remove_textboxs();
                    name_textbox.Focus();
                }
            }
            else
            {
                MessageBox.Show("There are missing information ");
            }
        }

        private void name_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                quantity_textbox.Focus();
            }
        }

        private void quantity_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                add_button.PerformClick();
            }
        }
    }
}
