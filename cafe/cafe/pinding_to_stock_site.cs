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
    public partial class pinding_to_stock_site : UserControl
    {
        public pinding_to_stock_site()
        {
            InitializeComponent();
        }

        private void add_materials_to_stock_Click(object sender, EventArgs e)
        {
            add_materials_to_stock ad = new add_materials_to_stock();
            ad.Show();
        }
    }
}
