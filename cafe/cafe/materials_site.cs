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
    public partial class materials_site : UserControl
    {
        SqlConnection cn = new SqlConnection(@"data source = DESKTOP-UIFKEN5\SQLEXPRESS;database =cafe_system;integrated security =True ");
        SqlCommand cmd;
        public materials_site()
        {
            InitializeComponent();
        }
        public void remove_textboxs()
        {
            name_textbox.Text = string.Empty;
            supplier_name_textbox.Text = string.Empty;
            quantity_textbox.Text = string.Empty;

        }
        private void supplier_name_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                name_textbox.Focus();
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

        private void add_supplier_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to save the information ?", "Alert", MessageBoxButtons.YesNo);
            if (name_textbox.Text != string.Empty && supplier_name_textbox.Text != string.Empty && quantity_textbox.Text != string.Empty)
            {
                if (result == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("insert into material values('" + supplier_name_textbox.Text + "','" + name_textbox.Text + "','" + quantity_textbox.Text + "','" + buy_date_datetimepacker.Value + "' )", cn);
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
    }
}
