
namespace cafe
{
    partial class supplier_site
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
            this.add_supplier_button = new System.Windows.Forms.Button();
            this.show_supplier = new System.Windows.Forms.Panel();
            this.add_supplier1 = new cafe.add_supplier();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.supplier_label = new System.Windows.Forms.Label();
            this.show_supplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_supplier_button
            // 
            this.add_supplier_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.add_supplier_button.FlatAppearance.BorderSize = 0;
            this.add_supplier_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_supplier_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_supplier_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.add_supplier_button.Location = new System.Drawing.Point(1000, 54);
            this.add_supplier_button.Name = "add_supplier_button";
            this.add_supplier_button.Size = new System.Drawing.Size(436, 91);
            this.add_supplier_button.TabIndex = 10;
            this.add_supplier_button.Text = "+  Add New Supplier";
            this.add_supplier_button.UseVisualStyleBackColor = false;
            this.add_supplier_button.Click += new System.EventHandler(this.add_supplier_button_Click);
            // 
            // show_supplier
            // 
            this.show_supplier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.show_supplier.Controls.Add(this.panel1);
            this.show_supplier.Controls.Add(this.search_txtbox);
            this.show_supplier.Location = new System.Drawing.Point(154, 158);
            this.show_supplier.Name = "show_supplier";
            this.show_supplier.Size = new System.Drawing.Size(1282, 784);
            this.show_supplier.TabIndex = 12;
            // 
            // add_supplier1
            // 
            this.add_supplier1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.add_supplier1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_supplier1.Location = new System.Drawing.Point(0, 0);
            this.add_supplier1.Name = "add_supplier1";
            this.add_supplier1.Size = new System.Drawing.Size(1920, 982);
            this.add_supplier1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 3);
            this.panel1.TabIndex = 1;
            // 
            // search_txtbox
            // 
            this.search_txtbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_txtbox.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_txtbox.Location = new System.Drawing.Point(0, 0);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(1282, 57);
            this.search_txtbox.TabIndex = 0;
            this.search_txtbox.Text = "Search suppliers.....";
            // 
            // supplier_label
            // 
            this.supplier_label.AutoSize = true;
            this.supplier_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supplier_label.Location = new System.Drawing.Point(154, 79);
            this.supplier_label.Name = "supplier_label";
            this.supplier_label.Size = new System.Drawing.Size(153, 45);
            this.supplier_label.TabIndex = 11;
            this.supplier_label.Text = "Suppliers";
            // 
            // supplier_site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.add_supplier1);
            this.Controls.Add(this.add_supplier_button);
            this.Controls.Add(this.show_supplier);
            this.Controls.Add(this.supplier_label);
            this.Name = "supplier_site";
            this.Size = new System.Drawing.Size(1920, 982);
            this.show_supplier.ResumeLayout(false);
            this.show_supplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_supplier_button;
        private System.Windows.Forms.Panel show_supplier;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.Label supplier_label;
        private System.Windows.Forms.Panel panel1;
        private add_supplier add_supplier1;
    }
}
