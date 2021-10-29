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
    public partial class pinding_to_stock_site : UserControl
    {
        SqlConnection cn = new SqlConnection(@"data source = DESKTOP-UIFKEN5\SQLEXPRESS;database =cafe_system;integrated security =True ");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public pinding_to_stock_site()
        {
            InitializeComponent();
            //filling data grid view
            ds.Reset();
            da = new SqlDataAdapter("select * from pinding_stock ", cn);
            da.Fill(ds, "stock");
            pinding_to_stock_dataGridView.DataSource = ds.Tables["stock"];
        }

        private void add_materials_to_stock_Click(object sender, EventArgs e)
        {
            add_materials_to_stock ad = new add_materials_to_stock();
            ad.Show();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            ds.Reset();
            da = new SqlDataAdapter("select * from pinding_stock ", cn);
            da.Fill(ds, "product");
            pinding_to_stock_dataGridView.DataSource = ds.Tables["product"];
        }
    }
}
