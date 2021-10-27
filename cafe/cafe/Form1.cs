using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class Cafe : Form
    {
        public Cafe()
        {
            InitializeComponent();
           
            //hide user_controls
            manger_site1.Hide();
            cashier_site1.Hide();
            waiter_site1.Hide();
        }
        public void clear_textboxs()
        {
            username_textbox.Text = string.Empty;
            pass_textbox.Text = string.Empty;
        }

        private void username_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            username_textbox.Text = string.Empty;
            user_name_pictureBox.Hide();
        }

        private void pass_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            pass_textbox.Text = string.Empty;
            pass_textbox.PasswordChar = '*';
            pass_pictureBox.Hide();
        }

        private void username_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                pass_textbox.Focus();
                pass_textbox.Text = string.Empty;
                pass_textbox.PasswordChar = '*';
                pass_pictureBox.Hide();

            }
        }

        private void pass_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                e.Handled = true;
                login_button.PerformClick();
                pass_textbox.PasswordChar = '*';
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            username_textbox.Text = username_textbox.Text.ToLower();
            pass_textbox.Text = pass_textbox.Text.ToLower();
            if (username_textbox.Text == "sam" &&pass_textbox.Text=="sam")
            {
                //delete textboxs for another login
                clear_textboxs();
                //show manger_site
                manger_site1.Show();
                //hide user_controls             
                cashier_site1.Hide();
                waiter_site1.Hide();
            }   
            else if (username_textbox.Text == "omar" && pass_textbox.Text == "omar")
            {
                //delete textboxs for another login
                clear_textboxs();
                //show manger_site
                waiter_site1.Show();
                //hide user_controls             
                cashier_site1.Hide();
                manger_site1.Hide();
            }
            else if (username_textbox.Text == "cash" && pass_textbox.Text == "cash")
            {
                //delete textboxs for another login
                clear_textboxs();
                //show manger_site
                cashier_site1.Show();
                //hide user_controls             
                waiter_site1.Hide();
                manger_site1.Hide();
            }
            else
            {
                MessageBox.Show("Your username and your password are incorrect ", "Alert");
            }
        }

       
    }
}
