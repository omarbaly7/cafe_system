
namespace cafe
{
    partial class kitchen_stock_site
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
            this.kitchen_stock_label = new System.Windows.Forms.Label();
            this.kitchen_stock_dataGridView = new System.Windows.Forms.DataGridView();
            this.refresh_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kitchen_stock_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kitchen_stock_label
            // 
            this.kitchen_stock_label.AutoSize = true;
            this.kitchen_stock_label.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kitchen_stock_label.Location = new System.Drawing.Point(3, 13);
            this.kitchen_stock_label.Name = "kitchen_stock_label";
            this.kitchen_stock_label.Size = new System.Drawing.Size(381, 81);
            this.kitchen_stock_label.TabIndex = 2;
            this.kitchen_stock_label.Text = "kitchen stock";
            // 
            // kitchen_stock_dataGridView
            // 
            this.kitchen_stock_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kitchen_stock_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitchen_stock_dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kitchen_stock_dataGridView.Location = new System.Drawing.Point(0, 503);
            this.kitchen_stock_dataGridView.Name = "kitchen_stock_dataGridView";
            this.kitchen_stock_dataGridView.RowHeadersWidth = 51;
            this.kitchen_stock_dataGridView.RowTemplate.Height = 29;
            this.kitchen_stock_dataGridView.Size = new System.Drawing.Size(1746, 479);
            this.kitchen_stock_dataGridView.TabIndex = 4;
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.refresh_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_button.FlatAppearance.BorderSize = 0;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refresh_button.Location = new System.Drawing.Point(1433, 349);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(310, 90);
            this.refresh_button.TabIndex = 5;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = false;
            // 
            // kitchen_stock_site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.kitchen_stock_dataGridView);
            this.Controls.Add(this.kitchen_stock_label);
            this.Name = "kitchen_stock_site";
            this.Size = new System.Drawing.Size(1746, 982);
            ((System.ComponentModel.ISupportInitialize)(this.kitchen_stock_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kitchen_stock_label;
        private System.Windows.Forms.DataGridView kitchen_stock_dataGridView;
        private System.Windows.Forms.Button refresh_button;
    }
}
