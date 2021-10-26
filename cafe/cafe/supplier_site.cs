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
    public partial class supplier_site : UserControl
    {
        public supplier_site()
        {
            InitializeComponent();
            //hide sites
            add_supplier1.Hide();
            
        }

        private void add_supplier_button_Click(object sender, EventArgs e)
        {
            //show sites
            add_supplier1.Show();
        }

        
    }
}
