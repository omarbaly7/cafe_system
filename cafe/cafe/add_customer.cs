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
    public partial class add_customer : UserControl
    {
        SqlConnection cn = new SqlConnection(@"data source = DESKTOP-UIFKEN5\SQLEXPRESS;database =cafe_system;integrated security =True ");
        SqlCommand cmd;
        public add_customer()
        {
            InitializeComponent();
        }
        public void remove_textboxs()
        {
            name_textbox.Text = string.Empty;
            phone_textbox.Text = string.Empty;
            email_textbox.Text = string.Empty;
            address_textbox.Text = string.Empty;
            country_textbox.Text = string.Empty;
            state_textBox.Text = string.Empty;
            city_textbox.Text = string.Empty;
            pincode_textBox.Text = string.Empty;

        }

        private void go_back_button_Click(object sender, EventArgs e)
        {
            //hide site
            this.Hide();
            //show site
            customer_site cs = new customer_site();
            this.Controls.Add(cs);
        }

        private void add_customer_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to save the information ?", "Alert", MessageBoxButtons.YesNo);
            if (name_textbox.Text != string.Empty && phone_textbox.Text != string.Empty && address_textbox.Text != string.Empty&&email_textbox.Text!=string.Empty&&country_textbox.Text != string.Empty&&state_textBox.Text!=string.Empty&&city_textbox.Text!=string.Empty&&pincode_textBox.Text!=string.Empty)
            {
                if (result == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("insert into customer values('" + name_textbox.Text + "','" + phone_textbox.Text + "','" + email_textbox.Text + "','" + address_textbox.Text + "','" + country_textbox.Text + "','"+state_textBox.Text+ "','" + city_textbox.Text + "','" + pincode_textBox.Text + "')", cn);
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
                phone_textbox.Focus();
            }
        }

        private void phone_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                email_textbox.Focus();
            }
        }

        private void email_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
               address_textbox.Focus();
            }
        }

        private void address_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                country_textbox.Focus();
            }
        }

        private void country_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                state_textBox.Focus();
            }
        }

        private void state_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                city_textbox.Focus();
            }
        }

        private void city_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                pincode_textBox.Focus();
            }
        }

        private void pincode_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                add_customer_button.PerformClick();
            }
        }
    }
}
