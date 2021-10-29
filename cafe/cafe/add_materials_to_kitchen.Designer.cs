
namespace cafe
{
    partial class add_materials_to_kitchen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.phone_2_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.nam_label = new System.Windows.Forms.Label();
            this.quantity_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.add_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity_textbox.Location = new System.Drawing.Point(52, 202);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(421, 47);
            this.quantity_textbox.TabIndex = 29;
            this.quantity_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_textbox_KeyPress);
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_textbox.Location = new System.Drawing.Point(52, 74);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(421, 47);
            this.name_textbox.TabIndex = 28;
            this.name_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_textbox_KeyPress);
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_label.Location = new System.Drawing.Point(-234, 435);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(135, 45);
            this.address_label.TabIndex = 27;
            this.address_label.Text = "Address";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_label.Location = new System.Drawing.Point(-234, 301);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(111, 45);
            this.email_label.TabIndex = 26;
            this.email_label.Text = "E-mail";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone_label.Location = new System.Drawing.Point(-234, 33);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(112, 45);
            this.phone_label.TabIndex = 25;
            this.phone_label.Text = "Phone";
            // 
            // phone_2_label
            // 
            this.phone_2_label.AutoSize = true;
            this.phone_2_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone_2_label.Location = new System.Drawing.Point(-234, 167);
            this.phone_2_label.Name = "phone_2_label";
            this.phone_2_label.Size = new System.Drawing.Size(139, 45);
            this.phone_2_label.TabIndex = 24;
            this.phone_2_label.Text = "Phone 2";
            this.phone_2_label.Visible = false;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label.Location = new System.Drawing.Point(-234, -101);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(107, 45);
            this.name_label.TabIndex = 23;
            this.name_label.Text = "Name";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.add_button.Location = new System.Drawing.Point(37, 432);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(436, 91);
            this.add_button.TabIndex = 22;
            this.add_button.Text = "+  Add ";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // nam_label
            // 
            this.nam_label.AutoSize = true;
            this.nam_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nam_label.Location = new System.Drawing.Point(52, 11);
            this.nam_label.Name = "nam_label";
            this.nam_label.Size = new System.Drawing.Size(107, 45);
            this.nam_label.TabIndex = 33;
            this.nam_label.Text = "Name";
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity_label.Location = new System.Drawing.Point(52, 139);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(146, 45);
            this.quantity_label.TabIndex = 34;
            this.quantity_label.Text = "Quantity";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_label.Location = new System.Drawing.Point(52, 267);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(88, 45);
            this.date_label.TabIndex = 35;
            this.date_label.Text = "Date";
            // 
            // add_dateTimePicker
            // 
            this.add_dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_dateTimePicker.Location = new System.Drawing.Point(52, 330);
            this.add_dateTimePicker.Name = "add_dateTimePicker";
            this.add_dateTimePicker.Size = new System.Drawing.Size(421, 43);
            this.add_dateTimePicker.TabIndex = 36;
            // 
            // add_materials_to_kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(522, 560);
            this.Controls.Add(this.add_dateTimePicker);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.nam_label);
            this.Controls.Add(this.quantity_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.phone_2_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.add_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "add_materials_to_kitchen";
            this.Text = "add_materials_to_kitchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label phone_2_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label nam_label;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.DateTimePicker add_dateTimePicker;
    }
}