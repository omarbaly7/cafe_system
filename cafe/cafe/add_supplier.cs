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
    public partial class add_supplier : UserControl
    {
        SqlConnection cn = new SqlConnection(@"data source = DESKTOP-UIFKEN5\SQLEXPRESS;database =cafe_system;integrated security =True ");
        SqlCommand cmd;
        public add_supplier()
        {
            InitializeComponent();
            //hide delete button
            remove_button.Hide();
            email_label.Location = new Point(41, 284);
            email_textbox.Location = new Point(41, 345);
            address_label.Location = new Point(41, 418);
            address_textbox.Location = new Point(41, 479);
        }
        public void remove_textboxs()
        {
            name_textbox.Text = string.Empty;
            phone_textbox.Text = string.Empty;
            phone_2_textbox.Text = string.Empty;
            email_textbox.Text = string.Empty;
            address_textbox.Text = string.Empty;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            //show 
            phone_2_label.Show();
            phone_2_textbox.Show();
            remove_button.Show();
            //location of label and text box
            phone_2_label.Location = new Point(41, 284);
            phone_2_textbox.Location = new Point(41, 345);
            email_label.Location = new Point(41, 418);
            email_textbox.Location = new Point(41, 479);
            address_label.Location = new Point(41, 552);
            address_textbox.Location = new Point(41, 613);

        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            //hide
            phone_2_label.Hide();
            phone_2_textbox.Hide();
            remove_button.Hide();
            //location of label and text box
            email_label.Location = new Point(41, 284);
            email_textbox.Location = new Point(41, 345);
            address_label.Location = new Point(41, 418);
            address_textbox.Location = new Point(41, 479);
        }

        private void go_back_button_Click(object sender, EventArgs e)
        {
            //hide sites
            this.Hide();
            //show sites
            supplier_site s = new supplier_site();
            this.Controls.Add(s);


        }

        private void add_supplier_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to save the information ?", "Alert", MessageBoxButtons.YesNo);
            if (name_textbox.Text != string.Empty && phone_textbox.Text != string.Empty && address_textbox.Text != string.Empty)
            {
                if (result == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("insert into supplier values('" + name_textbox.Text + "','" + phone_textbox.Text + "','" + phone_2_textbox.Text + "','" + email_textbox.Text + "','" + address_textbox.Text + "' )", cn);
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
                if (phone_2_textbox.Visible == true)
                {
                    phone_2_textbox.Focus();
                }
                else
                {
                    email_textbox.Focus();
                }
            }
        }

        private void phone_2_textbox_KeyPress(object sender, KeyPressEventArgs e)
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
                add_supplier_button.PerformClick();
            }
        }
    }
}
