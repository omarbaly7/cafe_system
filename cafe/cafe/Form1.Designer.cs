
namespace cafe
{
    partial class Cafe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cafe));
            this.login_button = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.pass_textbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.manger_site1 = new cafe.manger_site();
            this.cashier_site1 = new cafe.cashier_site();
            this.waiter_site1 = new cafe.waiter_site();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.login_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.login_button.Location = new System.Drawing.Point(702, 662);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(483, 102);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.login_label.Location = new System.Drawing.Point(820, 233);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(241, 106);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Login";
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.username_textbox.Location = new System.Drawing.Point(702, 407);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(483, 65);
            this.username_textbox.TabIndex = 3;
            this.username_textbox.Text = "Username :";
            this.username_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.username_textbox_MouseClick);
            this.username_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_textbox_KeyPress);
            // 
            // pass_textbox
            // 
            this.pass_textbox.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.pass_textbox.Location = new System.Drawing.Point(702, 538);
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.Size = new System.Drawing.Size(483, 65);
            this.pass_textbox.TabIndex = 4;
            this.pass_textbox.Text = "Password :";
            this.pass_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_textbox_MouseClick);
            this.pass_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pass_textbox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(871, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // manger_site1
            // 
            this.manger_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manger_site1.Location = new System.Drawing.Point(0, 0);
            this.manger_site1.Name = "manger_site1";
            this.manger_site1.Size = new System.Drawing.Size(1902, 1033);
            this.manger_site1.TabIndex = 6;
            // 
            // cashier_site1
            // 
            this.cashier_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashier_site1.Location = new System.Drawing.Point(0, 0);
            this.cashier_site1.Name = "cashier_site1";
            this.cashier_site1.Size = new System.Drawing.Size(1902, 1033);
            this.cashier_site1.TabIndex = 7;
            // 
            // waiter_site1
            // 
            this.waiter_site1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.waiter_site1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waiter_site1.Location = new System.Drawing.Point(0, 0);
            this.waiter_site1.Name = "waiter_site1";
            this.waiter_site1.Size = new System.Drawing.Size(1902, 1033);
            this.waiter_site1.TabIndex = 8;
            // 
            // Cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.waiter_site1);
            this.Controls.Add(this.cashier_site1);
            this.Controls.Add(this.manger_site1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pass_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.login_button);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Cafe";
            this.Text = "Cafe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox pass_textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private manger_site manger_site1;
        private cashier_site cashier_site1;
        private waiter_site waiter_site1;
    }
}

