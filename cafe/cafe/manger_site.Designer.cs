
namespace cafe
{
    partial class manger_site
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manger_site));
            this.top_panel = new System.Windows.Forms.Panel();
            this.search_button = new System.Windows.Forms.Button();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.left_pannel = new System.Windows.Forms.Panel();
            this.settings_button = new System.Windows.Forms.Button();
            this.log_out_button = new System.Windows.Forms.Button();
            this.manger_pictureBox = new System.Windows.Forms.PictureBox();
            this.reports_button = new System.Windows.Forms.Button();
            this.order_button = new System.Windows.Forms.Button();
            this.tables_button = new System.Windows.Forms.Button();
            this.stock_button = new System.Windows.Forms.Button();
            this.material_button = new System.Windows.Forms.Button();
            this.customer_button = new System.Windows.Forms.Button();
            this.supplier_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.separating_panel = new System.Windows.Forms.Panel();
            this.center_panel = new System.Windows.Forms.Panel();
            this.stock_pannel = new System.Windows.Forms.Panel();
            this.stock_but = new System.Windows.Forms.Button();
            this.kitchen_stock_button = new System.Windows.Forms.Button();
            this.pinding_to_kitchen_button = new System.Windows.Forms.Button();
            this.pinding_to_stock_button = new System.Windows.Forms.Button();
            this.order_site1 = new cafe.order_site();
            this.settings_site1 = new cafe.settings_site();
            this.reports_site1 = new cafe.reports_site();
            this.tables_site1 = new cafe.tables_site();
            this.stock_site1 = new cafe.stock_site();
            this.materials_site1 = new cafe.materials_site();
            this.customer_site1 = new cafe.customer_site();
            this.home_site1 = new cafe.home_site();
            this.supplier_site1 = new cafe.supplier_site();
            this.pinding_to_kitchen_site1 = new cafe.pinding_to_kitchen_site();
            this.pinding_to_stock_site1 = new cafe.pinding_to_stock_site();
            this.kitchen_stock_site1 = new cafe.kitchen_stock_site();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            this.left_pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manger_pictureBox)).BeginInit();
            this.center_panel.SuspendLayout();
            this.stock_pannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.search_button);
            this.top_panel.Controls.Add(this.search_textbox);
            this.top_panel.Controls.Add(this.logo_pictureBox);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1920, 95);
            this.top_panel.TabIndex = 2;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Image = ((System.Drawing.Image)(resources.GetObject("search_button.Image")));
            this.search_button.Location = new System.Drawing.Point(863, 27);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(58, 43);
            this.search_button.TabIndex = 5;
            this.search_button.UseVisualStyleBackColor = false;
            // 
            // search_textbox
            // 
            this.search_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.search_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_textbox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_textbox.Location = new System.Drawing.Point(304, 27);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(617, 44);
            this.search_textbox.TabIndex = 4;
            this.search_textbox.Text = "Search Products.....";
            this.search_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search_textbox_MouseClick);
            this.search_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_textbox_KeyPress);
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(218, 95);
            this.logo_pictureBox.TabIndex = 0;
            this.logo_pictureBox.TabStop = false;
            // 
            // left_pannel
            // 
            this.left_pannel.BackColor = System.Drawing.SystemColors.Control;
            this.left_pannel.Controls.Add(this.settings_button);
            this.left_pannel.Controls.Add(this.log_out_button);
            this.left_pannel.Controls.Add(this.manger_pictureBox);
            this.left_pannel.Controls.Add(this.reports_button);
            this.left_pannel.Controls.Add(this.order_button);
            this.left_pannel.Controls.Add(this.tables_button);
            this.left_pannel.Controls.Add(this.stock_button);
            this.left_pannel.Controls.Add(this.material_button);
            this.left_pannel.Controls.Add(this.customer_button);
            this.left_pannel.Controls.Add(this.supplier_button);
            this.left_pannel.Controls.Add(this.home_button);
            this.left_pannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_pannel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.left_pannel.Location = new System.Drawing.Point(0, 0);
            this.left_pannel.Name = "left_pannel";
            this.left_pannel.Size = new System.Drawing.Size(174, 982);
            this.left_pannel.TabIndex = 3;
            // 
            // settings_button
            // 
            this.settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.settings_button.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.settings_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.settings_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settings_button.Image = global::cafe.Properties.Resources.setting;
            this.settings_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settings_button.Location = new System.Drawing.Point(9, 674);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(145, 80);
            this.settings_button.TabIndex = 14;
            this.settings_button.Text = "Settings";
            this.settings_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // log_out_button
            // 
            this.log_out_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_out_button.FlatAppearance.BorderSize = 0;
            this.log_out_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_out_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.log_out_button.Image = global::cafe.Properties.Resources.log_out;
            this.log_out_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.log_out_button.Location = new System.Drawing.Point(31, 868);
            this.log_out_button.Name = "log_out_button";
            this.log_out_button.Size = new System.Drawing.Size(99, 68);
            this.log_out_button.TabIndex = 13;
            this.log_out_button.Text = "Log Out";
            this.log_out_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.log_out_button.UseVisualStyleBackColor = true;
            this.log_out_button.Click += new System.EventHandler(this.log_out_button_Click);
            // 
            // manger_pictureBox
            // 
            this.manger_pictureBox.Location = new System.Drawing.Point(12, 782);
            this.manger_pictureBox.Name = "manger_pictureBox";
            this.manger_pictureBox.Size = new System.Drawing.Size(142, 62);
            this.manger_pictureBox.TabIndex = 12;
            this.manger_pictureBox.TabStop = false;
            // 
            // reports_button
            // 
            this.reports_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reports_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.reports_button.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.reports_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.reports_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.reports_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reports_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reports_button.Image = global::cafe.Properties.Resources.pie_chart;
            this.reports_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reports_button.Location = new System.Drawing.Point(9, 590);
            this.reports_button.Name = "reports_button";
            this.reports_button.Size = new System.Drawing.Size(145, 80);
            this.reports_button.TabIndex = 11;
            this.reports_button.Text = "Reports";
            this.reports_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reports_button.UseVisualStyleBackColor = true;
            this.reports_button.Click += new System.EventHandler(this.reports_button_Click);
            // 
            // order_button
            // 
            this.order_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.order_button.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.order_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.order_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.order_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_button.Image = global::cafe.Properties.Resources.order;
            this.order_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.order_button.Location = new System.Drawing.Point(9, 506);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(145, 80);
            this.order_button.TabIndex = 10;
            this.order_button.Text = "Order";
            this.order_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.order_button.UseVisualStyleBackColor = true;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // tables_button
            // 
            this.tables_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tables_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.tables_button.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.tables_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.tables_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.tables_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tables_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tables_button.Image = global::cafe.Properties.Resources.dinner_table;
            this.tables_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tables_button.Location = new System.Drawing.Point(9, 422);
            this.tables_button.Name = "tables_button";
            this.tables_button.Size = new System.Drawing.Size(145, 80);
            this.tables_button.TabIndex = 9;
            this.tables_button.Text = "Tables";
            this.tables_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tables_button.UseVisualStyleBackColor = true;
            this.tables_button.Click += new System.EventHandler(this.tables_button_Click);
            // 
            // stock_button
            // 
            this.stock_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stock_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.stock_button.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.stock_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.stock_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.stock_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stock_button.Image = global::cafe.Properties.Resources.stock;
            this.stock_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stock_button.Location = new System.Drawing.Point(9, 338);
            this.stock_button.Name = "stock_button";
            this.stock_button.Size = new System.Drawing.Size(145, 80);
            this.stock_button.TabIndex = 8;
            this.stock_button.Text = "Stock";
            this.stock_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stock_button.UseVisualStyleBackColor = true;
            this.stock_button.Click += new System.EventHandler(this.stock_button_Click);
            // 
            // material_button
            // 
            this.material_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.material_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.material_button.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.material_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.material_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.material_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.material_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.material_button.Image = global::cafe.Properties.Resources.material;
            this.material_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.material_button.Location = new System.Drawing.Point(9, 254);
            this.material_button.Name = "material_button";
            this.material_button.Size = new System.Drawing.Size(145, 80);
            this.material_button.TabIndex = 7;
            this.material_button.Text = "Materials";
            this.material_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.material_button.UseVisualStyleBackColor = true;
            this.material_button.Click += new System.EventHandler(this.material_button_Click);
            // 
            // customer_button
            // 
            this.customer_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customer_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.customer_button.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.customer_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.customer_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.customer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customer_button.Image = global::cafe.Properties.Resources.user1;
            this.customer_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customer_button.Location = new System.Drawing.Point(9, 170);
            this.customer_button.Name = "customer_button";
            this.customer_button.Size = new System.Drawing.Size(151, 80);
            this.customer_button.TabIndex = 6;
            this.customer_button.Text = "Customer";
            this.customer_button.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.customer_button.UseVisualStyleBackColor = true;
            this.customer_button.Click += new System.EventHandler(this.customer_button_Click);
            // 
            // supplier_button
            // 
            this.supplier_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplier_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.supplier_button.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.supplier_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.supplier_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.supplier_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplier_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supplier_button.Image = global::cafe.Properties.Resources.supplier__1_;
            this.supplier_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.supplier_button.Location = new System.Drawing.Point(12, 86);
            this.supplier_button.Name = "supplier_button";
            this.supplier_button.Size = new System.Drawing.Size(145, 80);
            this.supplier_button.TabIndex = 5;
            this.supplier_button.Text = "Supplier";
            this.supplier_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.supplier_button.UseVisualStyleBackColor = true;
            this.supplier_button.Click += new System.EventHandler(this.supplier_button_Click);
            // 
            // home_button
            // 
            this.home_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.home_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.home_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_button.Image = ((System.Drawing.Image)(resources.GetObject("home_button.Image")));
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.home_button.Location = new System.Drawing.Point(12, 6);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(145, 76);
            this.home_button.TabIndex = 4;
            this.home_button.Text = "Home";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // separating_panel
            // 
            this.separating_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.separating_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.separating_panel.Location = new System.Drawing.Point(0, 95);
            this.separating_panel.Name = "separating_panel";
            this.separating_panel.Size = new System.Drawing.Size(1920, 3);
            this.separating_panel.TabIndex = 15;
            // 
            // center_panel
            // 
            this.center_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.center_panel.Controls.Add(this.kitchen_stock_site1);
            this.center_panel.Controls.Add(this.pinding_to_stock_site1);
            this.center_panel.Controls.Add(this.pinding_to_kitchen_site1);
            this.center_panel.Controls.Add(this.stock_pannel);
            this.center_panel.Controls.Add(this.order_site1);
            this.center_panel.Controls.Add(this.settings_site1);
            this.center_panel.Controls.Add(this.reports_site1);
            this.center_panel.Controls.Add(this.tables_site1);
            this.center_panel.Controls.Add(this.stock_site1);
            this.center_panel.Controls.Add(this.materials_site1);
            this.center_panel.Controls.Add(this.customer_site1);
            this.center_panel.Controls.Add(this.home_site1);
            this.center_panel.Controls.Add(this.supplier_site1);
            this.center_panel.Controls.Add(this.left_pannel);
            this.center_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center_panel.Location = new System.Drawing.Point(0, 98);
            this.center_panel.Name = "center_panel";
            this.center_panel.Size = new System.Drawing.Size(1920, 982);
            this.center_panel.TabIndex = 0;
            // 
            // stock_pannel
            // 
            this.stock_pannel.Controls.Add(this.stock_but);
            this.stock_pannel.Controls.Add(this.kitchen_stock_button);
            this.stock_pannel.Controls.Add(this.pinding_to_kitchen_button);
            this.stock_pannel.Controls.Add(this.pinding_to_stock_button);
            this.stock_pannel.Location = new System.Drawing.Point(174, 338);
            this.stock_pannel.Name = "stock_pannel";
            this.stock_pannel.Size = new System.Drawing.Size(279, 306);
            this.stock_pannel.TabIndex = 6;
            // 
            // stock_but
            // 
            this.stock_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stock_but.Dock = System.Windows.Forms.DockStyle.Top;
            this.stock_but.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.stock_but.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.stock_but.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.stock_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_but.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stock_but.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stock_but.Location = new System.Drawing.Point(0, 228);
            this.stock_but.Name = "stock_but";
            this.stock_but.Size = new System.Drawing.Size(279, 76);
            this.stock_but.TabIndex = 18;
            this.stock_but.Text = "Stock";
            this.stock_but.UseVisualStyleBackColor = true;
            this.stock_but.Click += new System.EventHandler(this.stock_but_Click);
            // 
            // kitchen_stock_button
            // 
            this.kitchen_stock_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitchen_stock_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.kitchen_stock_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.kitchen_stock_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.kitchen_stock_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.kitchen_stock_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitchen_stock_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kitchen_stock_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.kitchen_stock_button.Location = new System.Drawing.Point(0, 152);
            this.kitchen_stock_button.Name = "kitchen_stock_button";
            this.kitchen_stock_button.Size = new System.Drawing.Size(279, 76);
            this.kitchen_stock_button.TabIndex = 17;
            this.kitchen_stock_button.Text = "Kitchen Stock";
            this.kitchen_stock_button.UseVisualStyleBackColor = true;
            this.kitchen_stock_button.Click += new System.EventHandler(this.kitchen_stock_button_Click);
            // 
            // pinding_to_kitchen_button
            // 
            this.pinding_to_kitchen_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pinding_to_kitchen_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pinding_to_kitchen_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.pinding_to_kitchen_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.pinding_to_kitchen_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.pinding_to_kitchen_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinding_to_kitchen_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pinding_to_kitchen_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.pinding_to_kitchen_button.Location = new System.Drawing.Point(0, 76);
            this.pinding_to_kitchen_button.Name = "pinding_to_kitchen_button";
            this.pinding_to_kitchen_button.Size = new System.Drawing.Size(279, 76);
            this.pinding_to_kitchen_button.TabIndex = 16;
            this.pinding_to_kitchen_button.Text = "Pinding To Kitchen";
            this.pinding_to_kitchen_button.UseVisualStyleBackColor = true;
            this.pinding_to_kitchen_button.Click += new System.EventHandler(this.pinding_to_kitchen_button_Click);
            // 
            // pinding_to_stock_button
            // 
            this.pinding_to_stock_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pinding_to_stock_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pinding_to_stock_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.pinding_to_stock_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.pinding_to_stock_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.pinding_to_stock_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinding_to_stock_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pinding_to_stock_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.pinding_to_stock_button.Location = new System.Drawing.Point(0, 0);
            this.pinding_to_stock_button.Name = "pinding_to_stock_button";
            this.pinding_to_stock_button.Size = new System.Drawing.Size(279, 76);
            this.pinding_to_stock_button.TabIndex = 15;
            this.pinding_to_stock_button.Text = "Pinding To Stock";
            this.pinding_to_stock_button.UseVisualStyleBackColor = true;
            this.pinding_to_stock_button.Click += new System.EventHandler(this.pinding_to_stock_button_Click);
            // 
            // order_site1
            // 
            this.order_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_site1.Location = new System.Drawing.Point(174, 0);
            this.order_site1.Name = "order_site1";
            this.order_site1.Size = new System.Drawing.Size(1746, 982);
            this.order_site1.TabIndex = 12;
            // 
            // settings_site1
            // 
            this.settings_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_site1.Location = new System.Drawing.Point(174, 0);
            this.settings_site1.Name = "settings_site1";
            this.settings_site1.Size = new System.Drawing.Size(1746, 982);
            this.settings_site1.TabIndex = 11;
            // 
            // reports_site1
            // 
            this.reports_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reports_site1.Location = new System.Drawing.Point(174, 0);
            this.reports_site1.Name = "reports_site1";
            this.reports_site1.Size = new System.Drawing.Size(1746, 982);
            this.reports_site1.TabIndex = 10;
            // 
            // tables_site1
            // 
            this.tables_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tables_site1.Location = new System.Drawing.Point(174, 0);
            this.tables_site1.Name = "tables_site1";
            this.tables_site1.Size = new System.Drawing.Size(1746, 982);
            this.tables_site1.TabIndex = 9;
            // 
            // stock_site1
            // 
            this.stock_site1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.stock_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stock_site1.Location = new System.Drawing.Point(174, 0);
            this.stock_site1.Name = "stock_site1";
            this.stock_site1.Size = new System.Drawing.Size(1746, 982);
            this.stock_site1.TabIndex = 8;
            // 
            // materials_site1
            // 
            this.materials_site1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.materials_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materials_site1.Location = new System.Drawing.Point(174, 0);
            this.materials_site1.Name = "materials_site1";
            this.materials_site1.Size = new System.Drawing.Size(1746, 982);
            this.materials_site1.TabIndex = 7;
            // 
            // customer_site1
            // 
            this.customer_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer_site1.Location = new System.Drawing.Point(174, 0);
            this.customer_site1.Name = "customer_site1";
            this.customer_site1.Size = new System.Drawing.Size(1746, 982);
            this.customer_site1.TabIndex = 6;
            // 
            // home_site1
            // 
            this.home_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_site1.Location = new System.Drawing.Point(174, 0);
            this.home_site1.Name = "home_site1";
            this.home_site1.Size = new System.Drawing.Size(1746, 982);
            this.home_site1.TabIndex = 5;
            // 
            // supplier_site1
            // 
            this.supplier_site1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.supplier_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplier_site1.Location = new System.Drawing.Point(174, 0);
            this.supplier_site1.Name = "supplier_site1";
            this.supplier_site1.Size = new System.Drawing.Size(1746, 982);
            this.supplier_site1.TabIndex = 4;
            // 
            // pinding_to_kitchen_site1
            // 
            this.pinding_to_kitchen_site1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.pinding_to_kitchen_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pinding_to_kitchen_site1.Location = new System.Drawing.Point(174, 0);
            this.pinding_to_kitchen_site1.Name = "pinding_to_kitchen_site1";
            this.pinding_to_kitchen_site1.Size = new System.Drawing.Size(1746, 982);
            this.pinding_to_kitchen_site1.TabIndex = 13;
            // 
            // pinding_to_stock_site1
            // 
            this.pinding_to_stock_site1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.pinding_to_stock_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pinding_to_stock_site1.Location = new System.Drawing.Point(174, 0);
            this.pinding_to_stock_site1.Name = "pinding_to_stock_site1";
            this.pinding_to_stock_site1.Size = new System.Drawing.Size(1746, 982);
            this.pinding_to_stock_site1.TabIndex = 14;
            // 
            // kitchen_stock_site1
            // 
            this.kitchen_stock_site1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.kitchen_stock_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kitchen_stock_site1.Location = new System.Drawing.Point(174, 0);
            this.kitchen_stock_site1.Name = "kitchen_stock_site1";
            this.kitchen_stock_site1.Size = new System.Drawing.Size(1746, 982);
            this.kitchen_stock_site1.TabIndex = 15;
            // 
            // manger_site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.center_panel);
            this.Controls.Add(this.separating_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "manger_site";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            this.left_pannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manger_pictureBox)).EndInit();
            this.center_panel.ResumeLayout(false);
            this.stock_pannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel left_pannel;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button log_out_button;
        private System.Windows.Forms.PictureBox manger_pictureBox;
        private System.Windows.Forms.Button reports_button;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Button tables_button;
        private System.Windows.Forms.Button stock_button;
        private System.Windows.Forms.Button material_button;
        private System.Windows.Forms.Button customer_button;
        private System.Windows.Forms.Button supplier_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.PictureBox logo_pictureBox;
        private System.Windows.Forms.Panel separating_panel;
        private System.Windows.Forms.Panel center_panel;
        private supplier_site supplier_site1;
        private stock_site stock_site1;
        private materials_site materials_site1;
        private customer_site customer_site1;
        private home_site home_site1;
        private settings_site settings_site1;
        private reports_site reports_site1;
        private tables_site tables_site1;
        private order_site order_site1;
        private System.Windows.Forms.Panel stock_pannel;
        private System.Windows.Forms.Button pinding_to_stock_button;
        private System.Windows.Forms.Button pinding_to_kitchen_button;
        private System.Windows.Forms.Button stock_but;
        private System.Windows.Forms.Button kitchen_stock_button;
        private kitchen_stock_site kitchen_stock_site1;
        private pinding_to_stock_site pinding_to_stock_site1;
        private pinding_to_kitchen_site pinding_to_kitchen_site1;
    }
}
