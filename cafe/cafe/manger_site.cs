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
            home_site1.Hide();
            customer_site1.Hide();
            materials_site1.Hide();
            stock_site1.Hide();
            order_site1.Hide();
            tables_site1.Hide();
            settings_site1.Hide();
            reports_site1.Hide();
            stock_pannel.Hide();
            pinding_to_kitchen_site1.Hide();
            pinding_to_stock_site1.Hide();
            kitchen_stock_site1.Hide();
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
            supplier_button.ForeColor = Color.FromArgb(252, 128, 25);
            supplier_button.BackColor = Color.FromArgb(255, 242, 232);
            //change colors of other buttons
            customer_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            customer_button.ForeColor = Color.Black;
            customer_button.BackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            reports_button.ForeColor = Color.Black;
            reports_button.BackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            settings_button.ForeColor = Color.Black;
            settings_button.BackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            order_button.ForeColor = Color.Black;
            order_button.BackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            tables_button.ForeColor = Color.Black;
            tables_button.BackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            stock_button.ForeColor = Color.Black;
            stock_button.BackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            material_button.ForeColor = Color.Black;
            material_button.BackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            home_button.ForeColor = Color.Black;
            home_button.BackColor = Color.FromArgb(240, 240, 240);
            //show sites
            supplier_site1.Show();
            //hide sites
            home_site1.Hide();
            customer_site1.Hide();
            materials_site1.Hide();
            stock_site1.Hide();
            order_site1.Hide();
            tables_site1.Hide();
            settings_site1.Hide();
            reports_site1.Hide();
            stock_pannel.Hide();
            pinding_to_kitchen_site1.Hide();
            pinding_to_stock_site1.Hide();
            kitchen_stock_site1.Hide();
        }

        private void log_out_button_Click(object sender, EventArgs e)
        {
            //hide manger site
            this.Hide();
            //restore the colors of the buttons
            supplier_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.ForeColor = Color.Black;
            supplier_button.BackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            customer_button.ForeColor = Color.Black;
            customer_button.BackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            reports_button.ForeColor = Color.Black;
            reports_button.BackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            settings_button.ForeColor = Color.Black;
            settings_button.BackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            order_button.ForeColor = Color.Black;
            order_button.BackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            tables_button.ForeColor = Color.Black;
            tables_button.BackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            stock_button.ForeColor = Color.Black;
            stock_button.BackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            material_button.ForeColor = Color.Black;
            material_button.BackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            home_button.ForeColor = Color.Black;
            home_button.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void search_txtbox_MouseEnter(object sender, EventArgs e)
        {
            search_textbox.Text = string.Empty;
        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            //change colors of buttons
            customer_button.FlatAppearance.BorderColor = Color.FromArgb(252, 128, 25);
            customer_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 242, 232);
            customer_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 242, 232);
            customer_button.ForeColor = Color.FromArgb(252, 128, 25);
            customer_button.BackColor = Color.FromArgb(255, 242, 232);
            //change colors of other buttons
            reports_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            reports_button.ForeColor = Color.Black;
            reports_button.BackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            settings_button.ForeColor = Color.Black;
            settings_button.BackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            order_button.ForeColor = Color.Black;
            order_button.BackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            tables_button.ForeColor = Color.Black;
            tables_button.BackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            stock_button.ForeColor = Color.Black;
            stock_button.BackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            material_button.ForeColor = Color.Black;
            material_button.BackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            home_button.ForeColor = Color.Black;
            home_button.BackColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.ForeColor = Color.Black;
            supplier_button.BackColor = Color.FromArgb(240, 240, 240);
            //show sites
            customer_site1.Show();
            //hide sites
            supplier_site1.Hide();
            home_site1.Hide();
            materials_site1.Hide();
            stock_site1.Hide();
            order_site1.Hide();
            tables_site1.Hide();
            settings_site1.Hide();
            reports_site1.Hide();
            stock_pannel.Hide();
            pinding_to_kitchen_site1.Hide();
            pinding_to_stock_site1.Hide();
            kitchen_stock_site1.Hide();
        }
        private void home_button_Click(object sender, EventArgs e)
        {
            //change colors of buttons
            home_button.FlatAppearance.BorderColor = Color.FromArgb(252, 128, 25);
            home_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 242, 232);
            home_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 242, 232);
            home_button.ForeColor = Color.FromArgb(252, 128, 25);
            home_button.BackColor = Color.FromArgb(255, 242, 232);
            //change colors of other buttons
            supplier_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.ForeColor = Color.Black;
            supplier_button.BackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            reports_button.ForeColor = Color.Black;
            reports_button.BackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            settings_button.ForeColor = Color.Black;
            settings_button.BackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            order_button.ForeColor = Color.Black;
            order_button.BackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            tables_button.ForeColor = Color.Black;
            tables_button.BackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            stock_button.ForeColor = Color.Black;
            stock_button.BackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            material_button.ForeColor = Color.Black;
            material_button.BackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            customer_button.ForeColor = Color.Black;
            customer_button.BackColor = Color.FromArgb(240, 240, 240);
            //show sites
            home_site1.Show();
            //hide sites
            supplier_site1.Hide();
            customer_site1.Hide();
            materials_site1.Hide();
            stock_site1.Hide();
            order_site1.Hide();
            tables_site1.Hide();
            settings_site1.Hide();
            reports_site1.Hide();
            stock_pannel.Hide();
            pinding_to_kitchen_site1.Hide();
            pinding_to_stock_site1.Hide();
            kitchen_stock_site1.Hide();
        }

        private void material_button_Click(object sender, EventArgs e)
        {
            //change colors of buttons
            material_button.FlatAppearance.BorderColor = Color.FromArgb(252, 128, 25);
            material_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 242, 232);
            material_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 242, 232);
            material_button.ForeColor = Color.FromArgb(252, 128, 25);
            material_button.BackColor = Color.FromArgb(255, 242, 232);
            //change colors of other buttons
            supplier_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.ForeColor = Color.Black;
            supplier_button.BackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            reports_button.ForeColor = Color.Black;
            reports_button.BackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            settings_button.ForeColor = Color.Black;
            settings_button.BackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            order_button.ForeColor = Color.Black;
            order_button.BackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            tables_button.ForeColor = Color.Black;
            tables_button.BackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            stock_button.ForeColor = Color.Black;
            stock_button.BackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            home_button.ForeColor = Color.Black;
            home_button.BackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            customer_button.ForeColor = Color.Black;
            customer_button.BackColor = Color.FromArgb(240, 240, 240);
            //show sites
            materials_site1.Show();
            //hide sites
            supplier_site1.Hide();
            home_site1.Hide();
            customer_site1.Hide();
            stock_site1.Hide();
            order_site1.Hide();
            tables_site1.Hide();
            settings_site1.Hide();
            reports_site1.Hide();
            stock_pannel.Hide();
            pinding_to_kitchen_site1.Hide();
            pinding_to_stock_site1.Hide();
            kitchen_stock_site1.Hide();
        }

        private void stock_button_Click(object sender, EventArgs e)
        {
            //change colors of buttons
            stock_button.FlatAppearance.BorderColor = Color.FromArgb(252, 128, 25);
            stock_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 242, 232);
            stock_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 242, 232);
            stock_button.ForeColor = Color.FromArgb(252, 128, 25);
            stock_button.BackColor = Color.FromArgb(255, 242, 232);
            //change colors of other buttons
            supplier_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.ForeColor = Color.Black;
            supplier_button.BackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            reports_button.ForeColor = Color.Black;
            reports_button.BackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            settings_button.ForeColor = Color.Black;
            settings_button.BackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            order_button.ForeColor = Color.Black;
            order_button.BackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            tables_button.ForeColor = Color.Black;
            tables_button.BackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            material_button.ForeColor = Color.Black;
            material_button.BackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            home_button.ForeColor = Color.Black;
            home_button.BackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            customer_button.ForeColor = Color.Black;
            customer_button.BackColor = Color.FromArgb(240, 240, 240);
            //show sites
            stock_pannel.Show();

            //hide sites
            supplier_site1.Hide();
            home_site1.Hide();
            customer_site1.Hide();
            materials_site1.Hide();
            order_site1.Hide();
            tables_site1.Hide();
            settings_site1.Hide();
            reports_site1.Hide();
            pinding_to_kitchen_site1.Hide();
            pinding_to_stock_site1.Hide();
            kitchen_stock_site1.Hide();
        }

        private void tables_button_Click(object sender, EventArgs e)
        {
            //change colors of buttons
            tables_button.FlatAppearance.BorderColor = Color.FromArgb(252, 128, 25);
            tables_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 242, 232);
            tables_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 242, 232);
            tables_button.ForeColor = Color.FromArgb(252, 128, 25);
            tables_button.BackColor = Color.FromArgb(255, 242, 232);
            //change colors of other buttons
            supplier_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.ForeColor = Color.Black;
            supplier_button.BackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            reports_button.ForeColor = Color.Black;
            reports_button.BackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            settings_button.ForeColor = Color.Black;
            settings_button.BackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            order_button.ForeColor = Color.Black;
            order_button.BackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            stock_button.ForeColor = Color.Black;
            stock_button.BackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            material_button.ForeColor = Color.Black;
            material_button.BackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            home_button.ForeColor = Color.Black;
            home_button.BackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            customer_button.ForeColor = Color.Black;
            customer_button.BackColor = Color.FromArgb(240, 240, 240);
            //show sites
            tables_site1.Show();
            //hide sites
            supplier_site1.Hide();
            home_site1.Hide();
            customer_site1.Hide();
            materials_site1.Hide();
            stock_site1.Hide();
            order_site1.Hide();          
            settings_site1.Hide();
            reports_site1.Hide();
            stock_pannel.Hide();
            pinding_to_kitchen_site1.Hide();
            pinding_to_stock_site1.Hide();
            kitchen_stock_site1.Hide();
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            //change colors of buttons
            order_button.FlatAppearance.BorderColor = Color.FromArgb(252, 128, 25);
            order_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 242, 232);
            order_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 242, 232);
            order_button.ForeColor = Color.FromArgb(252, 128, 25);
            order_button.BackColor = Color.FromArgb(255, 242, 232);
            //change colors of other buttons
            supplier_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.ForeColor = Color.Black;
            supplier_button.BackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            reports_button.ForeColor = Color.Black;
            reports_button.BackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            settings_button.ForeColor = Color.Black;
            settings_button.BackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            tables_button.ForeColor = Color.Black;
            tables_button.BackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            stock_button.ForeColor = Color.Black;
            stock_button.BackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            material_button.ForeColor = Color.Black;
            material_button.BackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            home_button.ForeColor = Color.Black;
            home_button.BackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            customer_button.ForeColor = Color.Black;
            customer_button.BackColor = Color.FromArgb(240, 240, 240);
            //show sites
            order_site1.Show();
            //hide sites
            supplier_site1.Hide();
            home_site1.Hide();
            customer_site1.Hide();
            materials_site1.Hide();
            stock_site1.Hide();
            tables_site1.Hide();
            settings_site1.Hide();
            reports_site1.Hide();
            stock_pannel.Hide();
            pinding_to_kitchen_site1.Hide();
            pinding_to_stock_site1.Hide();
            kitchen_stock_site1.Hide();
        }

        private void reports_button_Click(object sender, EventArgs e)
        {
            //change colors of buttons
            reports_button.FlatAppearance.BorderColor = Color.FromArgb(252, 128, 25);
            reports_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 242, 232);
            reports_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 242, 232);
            reports_button.ForeColor = Color.FromArgb(252, 128, 25);
            reports_button.BackColor = Color.FromArgb(255, 242, 232);
            //change colors of other buttons
            supplier_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.ForeColor = Color.Black;
            supplier_button.BackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            order_button.ForeColor = Color.Black;
            order_button.BackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            settings_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            settings_button.ForeColor = Color.Black;
            settings_button.BackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            tables_button.ForeColor = Color.Black;
            tables_button.BackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            stock_button.ForeColor = Color.Black;
            stock_button.BackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            material_button.ForeColor = Color.Black;
            material_button.BackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            home_button.ForeColor = Color.Black;
            home_button.BackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            customer_button.ForeColor = Color.Black;
            customer_button.BackColor = Color.FromArgb(240, 240, 240);
            //show sites
            reports_site1.Show();
            //hide sites
            supplier_site1.Hide();
            home_site1.Hide();
            customer_site1.Hide();
            materials_site1.Hide();
            stock_site1.Hide();
            tables_site1.Hide();
            settings_site1.Hide();
            order_site1.Hide();
            stock_pannel.Hide();
            pinding_to_kitchen_site1.Hide();
            pinding_to_stock_site1.Hide();
            kitchen_stock_site1.Hide();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            //change colors of buttons
            settings_button.FlatAppearance.BorderColor = Color.FromArgb(252, 128, 25);
            settings_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 242, 232);
            settings_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 242, 232);
            settings_button.ForeColor = Color.FromArgb(252, 128, 25);
            settings_button.BackColor = Color.FromArgb(255, 242, 232);
            //change colors of other buttons
            supplier_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            supplier_button.ForeColor = Color.Black;
            supplier_button.BackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            order_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            order_button.ForeColor = Color.Black;
            order_button.BackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            reports_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            reports_button.ForeColor = Color.Black;
            reports_button.BackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            tables_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            tables_button.ForeColor = Color.Black;
            tables_button.BackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            stock_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            stock_button.ForeColor = Color.Black;
            stock_button.BackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            material_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            material_button.ForeColor = Color.Black;
            material_button.BackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            home_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            home_button.ForeColor = Color.Black;
            home_button.BackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            customer_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            customer_button.ForeColor = Color.Black;
            customer_button.BackColor = Color.FromArgb(240, 240, 240);
            //show sites
            settings_site1.Show();
            //hide sites
            supplier_site1.Hide();
            home_site1.Hide();
            customer_site1.Hide();
            materials_site1.Hide();
            stock_site1.Hide();
            tables_site1.Hide();
            order_site1.Hide();
            reports_site1.Hide();
            stock_pannel.Hide();
            pinding_to_kitchen_site1.Hide();
            pinding_to_stock_site1.Hide();
            kitchen_stock_site1.Hide();
        }

        private void stock_but_Click(object sender, EventArgs e)
        {
            //show sites
            stock_site1.Show();
            //hide sites
            supplier_site1.Hide();
            home_site1.Hide();
            customer_site1.Hide();
            materials_site1.Hide();
            order_site1.Hide();
            tables_site1.Hide();
            settings_site1.Hide();
            reports_site1.Hide();
            stock_pannel.Hide();
            pinding_to_kitchen_site1.Hide();
            pinding_to_stock_site1.Hide();
            kitchen_stock_site1.Hide();
        }

        private void pinding_to_stock_button_Click(object sender, EventArgs e)
        {
            //show sites
            pinding_to_stock_site1.Show();
            //hide sites
            supplier_site1.Hide();
            home_site1.Hide();
            customer_site1.Hide();
            materials_site1.Hide();
            stock_site1.Hide();
            order_site1.Hide();
            tables_site1.Hide();
            settings_site1.Hide();
            reports_site1.Hide();
            stock_pannel.Hide();
            pinding_to_kitchen_site1.Hide();   
            kitchen_stock_site1.Hide();
        }

        private void pinding_to_kitchen_button_Click(object sender, EventArgs e)
        {
            //show sites
            pinding_to_kitchen_site1.Show();
            //hide sites
            supplier_site1.Hide();
            home_site1.Hide();
            customer_site1.Hide();
            materials_site1.Hide();
            stock_site1.Hide();
            order_site1.Hide();
            tables_site1.Hide();
            settings_site1.Hide();
            reports_site1.Hide();
            stock_pannel.Hide();    
            pinding_to_stock_site1.Hide();
            kitchen_stock_site1.Hide();
        }

        private void kitchen_stock_button_Click(object sender, EventArgs e)
        {
            //show sites
            kitchen_stock_site1.Show();
            //hide sites
            supplier_site1.Hide();
            home_site1.Hide();
            customer_site1.Hide();
            materials_site1.Hide();
            stock_site1.Hide();
            order_site1.Hide();
            tables_site1.Hide();
            settings_site1.Hide();
            reports_site1.Hide();
            stock_pannel.Hide();
            pinding_to_kitchen_site1.Hide();
            pinding_to_stock_site1.Hide();
        }
    }
}
