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
    public partial class customer_site : UserControl
    {
        public customer_site()
        {
            InitializeComponent();
            //hide site
            add_customer1.Hide();
        }

        private void add_customer_button_Click(object sender, EventArgs e)
        {
            //show site
            add_customer1.Show();
        }
    }
}
