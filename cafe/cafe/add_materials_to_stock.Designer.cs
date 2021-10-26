
namespace cafe
{
    partial class add_materials_to_stock
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
            this.add_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_label = new System.Windows.Forms.Label();
            this.quantity_label = new System.Windows.Forms.Label();
            this.nam_label = new System.Windows.Forms.Label();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_dateTimePicker
            // 
            this.add_dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_dateTimePicker.Location = new System.Drawing.Point(58, 343);
            this.add_dateTimePicker.Name = "add_dateTimePicker";
            this.add_dateTimePicker.Size = new System.Drawing.Size(421, 43);
            this.add_dateTimePicker.TabIndex = 43;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_label.Location = new System.Drawing.Point(58, 280);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(88, 45);
            this.date_label.TabIndex = 42;
            this.date_label.Text = "Date";
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity_label.Location = new System.Drawing.Point(58, 152);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(146, 45);
            this.quantity_label.TabIndex = 41;
            this.quantity_label.Text = "Quantity";
            // 
            // nam_label
            // 
            this.nam_label.AutoSize = true;
            this.nam_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nam_label.Location = new System.Drawing.Point(58, 24);
            this.nam_label.Name = "nam_label";
            this.nam_label.Size = new System.Drawing.Size(107, 45);
            this.nam_label.TabIndex = 40;
            this.nam_label.Text = "Name";
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity_textbox.Location = new System.Drawing.Point(58, 215);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(421, 47);
            this.quantity_textbox.TabIndex = 39;
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_textbox.Location = new System.Drawing.Point(58, 87);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(421, 47);
            this.name_textbox.TabIndex = 38;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.add_button.Location = new System.Drawing.Point(43, 445);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(436, 91);
            this.add_button.TabIndex = 37;
            this.add_button.Text = "+  Add ";
            this.add_button.UseVisualStyleBackColor = false;
            // 
            // add_materials_to_stock
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
            this.Controls.Add(this.add_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "add_materials_to_stock";
            this.Text = "add_materials_to_stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker add_dateTimePicker;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Label nam_label;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button add_button;
    }
}