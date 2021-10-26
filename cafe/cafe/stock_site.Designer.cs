
namespace cafe
{
    partial class stock_site
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
            this.stock_label = new System.Windows.Forms.Label();
            this.stock_dataGridView = new System.Windows.Forms.DataGridView();
            this.refresh_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stock_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stock_label
            // 
            this.stock_label.AutoSize = true;
            this.stock_label.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stock_label.Location = new System.Drawing.Point(14, 0);
            this.stock_label.Name = "stock_label";
            this.stock_label.Size = new System.Drawing.Size(173, 81);
            this.stock_label.TabIndex = 1;
            this.stock_label.Text = "stock";
            // 
            // stock_dataGridView
            // 
            this.stock_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stock_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stock_dataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.stock_dataGridView.Location = new System.Drawing.Point(0, 442);
            this.stock_dataGridView.Name = "stock_dataGridView";
            this.stock_dataGridView.RowHeadersWidth = 51;
            this.stock_dataGridView.RowTemplate.Height = 29;
            this.stock_dataGridView.Size = new System.Drawing.Size(1746, 540);
            this.stock_dataGridView.TabIndex = 2;
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.refresh_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_button.FlatAppearance.BorderSize = 0;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refresh_button.Location = new System.Drawing.Point(1391, 297);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(310, 95);
            this.refresh_button.TabIndex = 4;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = false;
            // 
            // stock_site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.stock_dataGridView);
            this.Controls.Add(this.stock_label);
            this.Name = "stock_site";
            this.Size = new System.Drawing.Size(1746, 982);
            ((System.ComponentModel.ISupportInitialize)(this.stock_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stock_label;
        private System.Windows.Forms.DataGridView stock_dataGridView;
        private System.Windows.Forms.Button refresh_button;
    }
}
