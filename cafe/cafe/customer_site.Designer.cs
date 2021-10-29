
namespace cafe
{
    partial class customer_site
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
            this.add_customer_button = new System.Windows.Forms.Button();
            this.show_customer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.customer_label = new System.Windows.Forms.Label();
            this.add_customer1 = new cafe.add_customer();
            this.show_customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_customer_button
            // 
            this.add_customer_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.add_customer_button.FlatAppearance.BorderSize = 0;
            this.add_customer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_customer_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_customer_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.add_customer_button.Location = new System.Drawing.Point(912, 38);
            this.add_customer_button.Name = "add_customer_button";
            this.add_customer_button.Size = new System.Drawing.Size(436, 91);
            this.add_customer_button.TabIndex = 13;
            this.add_customer_button.Text = "+  Add New Supplier";
            this.add_customer_button.UseVisualStyleBackColor = false;
            this.add_customer_button.Click += new System.EventHandler(this.add_customer_button_Click);
            // 
            // show_customer
            // 
            this.show_customer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.show_customer.Controls.Add(this.panel1);
            this.show_customer.Controls.Add(this.search_txtbox);
            this.show_customer.Location = new System.Drawing.Point(66, 142);
            this.show_customer.Name = "show_customer";
            this.show_customer.Size = new System.Drawing.Size(1282, 784);
            this.show_customer.TabIndex = 15;
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
            this.search_txtbox.Text = "Search Customers.....";
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customer_label.Location = new System.Drawing.Point(66, 63);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(173, 45);
            this.customer_label.TabIndex = 14;
            this.customer_label.Text = "Customers";
            // 
            // add_customer1
            // 
            this.add_customer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.add_customer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_customer1.Location = new System.Drawing.Point(0, 0);
            this.add_customer1.Name = "add_customer1";
            this.add_customer1.Size = new System.Drawing.Size(1746, 982);
            this.add_customer1.TabIndex = 16;
            // 
            // customer_site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.add_customer1);
            this.Controls.Add(this.add_customer_button);
            this.Controls.Add(this.show_customer);
            this.Controls.Add(this.customer_label);
            this.Name = "customer_site";
            this.Size = new System.Drawing.Size(1746, 982);
            this.show_customer.ResumeLayout(false);
            this.show_customer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_customer_button;
        private System.Windows.Forms.Panel show_customer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.Label customer_label;
        private add_customer add_customer1;
    }
}
