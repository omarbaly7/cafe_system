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
    public partial class manger_site : UserControl
    {
        public manger_site()
        {
            InitializeComponent();
            //hide sites
            supplier_site1.Hide();

        }

        private void search_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            search_textbox.Text = string.Empty;
        }

        private void search_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                search_button.PerformClick();
            }
        }

        private void supplier_button_Click(object sender, EventArgs e)
        {
            //change colors of buttons
            supplier_button.FlatAppearance.BorderColor = Color.FromArgb(252, 128, 25);
            supplier_button.FlatAppearance.MouseDownBackColor= Color.FromArgb(255, 242, 232);
            supplier_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 242, 232);
            supplier_button.ForeColor= Color.FromArgb(252, 128, 25);//برتقاني
            supplier_button.BackColor = Color.FromArgb(255, 242, 232);//جملي
            //show sites
            supplier_site1.Show();
        }

        private void log_out_button_Click(object sender, EventArgs e)
        {
            //hide manger site
            this.Hide();         

        }

        private void search_txtbox_MouseEnter(object sender, EventArgs e)
        {
            search_textbox.Text = string.Empty;
        }

       
    }
}
