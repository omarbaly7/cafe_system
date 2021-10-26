
namespace cafe
{
    partial class materials_site
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
            this.add_items_panel = new System.Windows.Forms.Panel();
            this.buy_date_datetimepacker = new System.Windows.Forms.DateTimePicker();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.supplier_name_textbox = new System.Windows.Forms.TextBox();
            this.buy_date_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.quantity_label = new System.Windows.Forms.Label();
            this.supplier_name_label = new System.Windows.Forms.Label();
            this.add_supplier_button = new System.Windows.Forms.Button();
            this.add_material_label = new System.Windows.Forms.Label();
            this.add_items_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_items_panel
            // 
            this.add_items_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.add_items_panel.Controls.Add(this.buy_date_datetimepacker);
            this.add_items_panel.Controls.Add(this.quantity_textbox);
            this.add_items_panel.Controls.Add(this.name_textbox);
            this.add_items_panel.Controls.Add(this.supplier_name_textbox);
            this.add_items_panel.Controls.Add(this.buy_date_label);
            this.add_items_panel.Controls.Add(this.name_label);
            this.add_items_panel.Controls.Add(this.quantity_label);
            this.add_items_panel.Controls.Add(this.supplier_name_label);
            this.add_items_panel.Controls.Add(this.add_supplier_button);
            this.add_items_panel.Location = new System.Drawing.Point(106, 97);
            this.add_items_panel.Name = "add_items_panel";
            this.add_items_panel.Size = new System.Drawing.Size(1390, 764);
            this.add_items_panel.TabIndex = 15;
            // 
            // buy_date_datetimepacker
            // 
            this.buy_date_datetimepacker.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buy_date_datetimepacker.Location = new System.Drawing.Point(41, 466);
            this.buy_date_datetimepacker.Name = "buy_date_datetimepacker";
            this.buy_date_datetimepacker.Size = new System.Drawing.Size(1272, 57);
            this.buy_date_datetimepacker.TabIndex = 20;
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity_textbox.Location = new System.Drawing.Point(41, 345);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(1272, 57);
            this.quantity_textbox.TabIndex = 19;
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_textbox.Location = new System.Drawing.Point(41, 211);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(1272, 57);
            this.name_textbox.TabIndex = 18;
            this.name_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_textbox_KeyPress);
            // 
            // supplier_name_textbox
            // 
            this.supplier_name_textbox.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supplier_name_textbox.Location = new System.Drawing.Point(41, 77);
            this.supplier_name_textbox.Name = "supplier_name_textbox";
            this.supplier_name_textbox.Size = new System.Drawing.Size(1272, 57);
            this.supplier_name_textbox.TabIndex = 17;
            this.supplier_name_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.supplier_name_textbox_KeyPress);
            // 
            // buy_date_label
            // 
            this.buy_date_label.AutoSize = true;
            this.buy_date_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buy_date_label.Location = new System.Drawing.Point(41, 418);
            this.buy_date_label.Name = "buy_date_label";
            this.buy_date_label.Size = new System.Drawing.Size(88, 45);
            this.buy_date_label.TabIndex = 15;
            this.buy_date_label.Text = "Date";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label.Location = new System.Drawing.Point(41, 150);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(107, 45);
            this.name_label.TabIndex = 14;
            this.name_label.Text = "Name";
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity_label.Location = new System.Drawing.Point(41, 284);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(146, 45);
            this.quantity_label.TabIndex = 13;
            this.quantity_label.Text = "Quantity";
            // 
            // supplier_name_label
            // 
            this.supplier_name_label.AutoSize = true;
            this.supplier_name_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supplier_name_label.Location = new System.Drawing.Point(41, 16);
            this.supplier_name_label.Name = "supplier_name_label";
            this.supplier_name_label.Size = new System.Drawing.Size(235, 45);
            this.supplier_name_label.TabIndex = 12;
            this.supplier_name_label.Text = "Supplier Name";
            // 
            // add_supplier_button
            // 
            this.add_supplier_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.add_supplier_button.FlatAppearance.BorderSize = 0;
            this.add_supplier_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_supplier_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_supplier_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.add_supplier_button.Location = new System.Drawing.Point(41, 603);
            this.add_supplier_button.Name = "add_supplier_button";
            this.add_supplier_button.Size = new System.Drawing.Size(436, 91);
            this.add_supplier_button.TabIndex = 11;
            this.add_supplier_button.Text = "+  Add Materials";
            this.add_supplier_button.UseVisualStyleBackColor = false;
            // 
            // add_material_label
            // 
            this.add_material_label.AutoSize = true;
            this.add_material_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_material_label.Location = new System.Drawing.Point(39, 19);
            this.add_material_label.Name = "add_material_label";
            this.add_material_label.Size = new System.Drawing.Size(221, 45);
            this.add_material_label.TabIndex = 16;
            this.add_material_label.Text = "Add Materials";
            // 
            // materials_site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.add_material_label);
            this.Controls.Add(this.add_items_panel);
            this.Name = "materials_site";
            this.Size = new System.Drawing.Size(1746, 982);
            this.add_items_panel.ResumeLayout(false);
            this.add_items_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel add_items_panel;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox supplier_name_textbox;
        private System.Windows.Forms.Label buy_date_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Label supplier_name_label;
        private System.Windows.Forms.Button add_supplier_button;
        private System.Windows.Forms.Label add_material_label;
        private System.Windows.Forms.DateTimePicker buy_date_datetimepacker;
    }
}
