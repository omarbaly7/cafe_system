﻿
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
            this.number_of_seats_label = new System.Windows.Forms.Label();
            this.nam_label = new System.Windows.Forms.Label();
            this.number_of_seats_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number_of_seats_label
            // 
            this.number_of_seats_label.AutoSize = true;
            this.number_of_seats_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_of_seats_label.Location = new System.Drawing.Point(48, 152);
            this.number_of_seats_label.Name = "number_of_seats_label";
            this.number_of_seats_label.Size = new System.Drawing.Size(269, 45);
            this.number_of_seats_label.TabIndex = 41;
            this.number_of_seats_label.Text = "Number_of_seats";
            // 
            // nam_label
            // 
            this.nam_label.AutoSize = true;
            this.nam_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nam_label.Location = new System.Drawing.Point(48, 24);
            this.nam_label.Name = "nam_label";
            this.nam_label.Size = new System.Drawing.Size(107, 45);
            this.nam_label.TabIndex = 40;
            this.nam_label.Text = "Name";
            // 
            // number_of_seats_textbox
            // 
            this.number_of_seats_textbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_of_seats_textbox.Location = new System.Drawing.Point(48, 215);
            this.number_of_seats_textbox.Name = "number_of_seats_textbox";
            this.number_of_seats_textbox.Size = new System.Drawing.Size(421, 47);
            this.number_of_seats_textbox.TabIndex = 39;
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_textbox.Location = new System.Drawing.Point(48, 87);
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
            this.add_button.Location = new System.Drawing.Point(48, 320);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(421, 91);
            this.add_button.TabIndex = 37;
            this.add_button.Text = "+  Add ";
            this.add_button.UseVisualStyleBackColor = false;
            // 
            // add_materials_to_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(522, 500);
            this.Controls.Add(this.number_of_seats_label);
            this.Controls.Add(this.nam_label);
            this.Controls.Add(this.number_of_seats_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.add_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "add_materials_to_stock";
            this.Text = "add_materials_to_stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label number_of_seats_label;
        private System.Windows.Forms.Label nam_label;
        private System.Windows.Forms.TextBox number_of_seats_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button add_button;
    }
}