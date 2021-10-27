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
    public partial class add_supplier : UserControl
    {
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
    }
}
