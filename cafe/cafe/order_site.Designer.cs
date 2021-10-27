
namespace cafe
{
    partial class order_site
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
            this.refresh_button = new System.Windows.Forms.Button();
            this.order_dataGridView = new System.Windows.Forms.DataGridView();
            this.order_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.order_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.refresh_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_button.FlatAppearance.BorderSize = 0;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refresh_button.Location = new System.Drawing.Point(1433, 407);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(310, 90);
            this.refresh_button.TabIndex = 7;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = false;
            // 
            // order_dataGridView
            // 
            this.order_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.order_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.order_dataGridView.Location = new System.Drawing.Point(0, 503);
            this.order_dataGridView.Name = "order_dataGridView";
            this.order_dataGridView.RowHeadersWidth = 51;
            this.order_dataGridView.RowTemplate.Height = 29;
            this.order_dataGridView.Size = new System.Drawing.Size(1746, 479);
            this.order_dataGridView.TabIndex = 6;
            // 
            // order_label
            // 
            this.order_label.AutoSize = true;
            this.order_label.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_label.Location = new System.Drawing.Point(15, 16);
            this.order_label.Name = "order_label";
            this.order_label.Size = new System.Drawing.Size(325, 81);
            this.order_label.TabIndex = 8;
            this.order_label.Text = "The Orders";
            // 
            // order_site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.order_label);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.order_dataGridView);
            this.Name = "order_site";
            this.Size = new System.Drawing.Size(1746, 982);
            ((System.ComponentModel.ISupportInitialize)(this.order_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.DataGridView order_dataGridView;
        private System.Windows.Forms.Label order_label;
    }
}
