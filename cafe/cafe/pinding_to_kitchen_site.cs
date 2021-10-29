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
    public partial class pinding_to_kitchen_site : UserControl
    {
        SqlConnection cn = new SqlConnection(@"data source = DESKTOP-UIFKEN5\SQLEXPRESS;database =cafe_system;integrated security =True ");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public pinding_to_kitchen_site()
        {
            InitializeComponent();
            //filling data grid view
            ds.Reset();
            da = new SqlDataAdapter("select * from pinding_kitchen ", cn);
            da.Fill(ds, "kitchen_stock");
            pinding_to_kitchen_stock_dataGridView.DataSource = ds.Tables["kitchen_stock"];
        }

        private void add_materials_to_kitchen_stock_Click(object sender, EventArgs e)
        {
            add_materials_to_kitchen add = new add_materials_to_kitchen();
            add.Show();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            //filling data grid view
            ds.Reset();
            da = new SqlDataAdapter("select * from pinding_kitchen ", cn);
            da.Fill(ds, "kitchen_stock");
            pinding_to_kitchen_stock_dataGridView.DataSource = ds.Tables["kitchen_stock"];
        }
    }
}
