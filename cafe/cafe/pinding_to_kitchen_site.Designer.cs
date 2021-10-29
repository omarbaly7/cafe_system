
namespace cafe
{
    partial class pinding_to_kitchen_site
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
            this.pinding_to_kitchen_stock_dataGridView = new System.Windows.Forms.DataGridView();
            this.pinding_to_kitchen_stock_label = new System.Windows.Forms.Label();
            this.add_materials_to_kitchen_stock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pinding_to_kitchen_stock_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.refresh_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_button.FlatAppearance.BorderSize = 0;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refresh_button.Location = new System.Drawing.Point(1433, 325);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(310, 108);
            this.refresh_button.TabIndex = 8;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // pinding_to_kitchen_stock_dataGridView
            // 
            this.pinding_to_kitchen_stock_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pinding_to_kitchen_stock_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pinding_to_kitchen_stock_dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pinding_to_kitchen_stock_dataGridView.Location = new System.Drawing.Point(0, 484);
            this.pinding_to_kitchen_stock_dataGridView.Name = "pinding_to_kitchen_stock_dataGridView";
            this.pinding_to_kitchen_stock_dataGridView.RowHeadersWidth = 51;
            this.pinding_to_kitchen_stock_dataGridView.RowTemplate.Height = 29;
            this.pinding_to_kitchen_stock_dataGridView.Size = new System.Drawing.Size(1746, 498);
            this.pinding_to_kitchen_stock_dataGridView.TabIndex = 7;
            // 
            // pinding_to_kitchen_stock_label
            // 
            this.pinding_to_kitchen_stock_label.AutoSize = true;
            this.pinding_to_kitchen_stock_label.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pinding_to_kitchen_stock_label.Location = new System.Drawing.Point(3, 7);
            this.pinding_to_kitchen_stock_label.Name = "pinding_to_kitchen_stock_label";
            this.pinding_to_kitchen_stock_label.Size = new System.Drawing.Size(526, 81);
            this.pinding_to_kitchen_stock_label.TabIndex = 6;
            this.pinding_to_kitchen_stock_label.Text = "Pinding To Kitchen";
            // 
            // add_materials_to_kitchen_stock
            // 
            this.add_materials_to_kitchen_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.add_materials_to_kitchen_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_materials_to_kitchen_stock.FlatAppearance.BorderSize = 0;
            this.add_materials_to_kitchen_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_materials_to_kitchen_stock.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_materials_to_kitchen_stock.Location = new System.Drawing.Point(1081, 325);
            this.add_materials_to_kitchen_stock.Name = "add_materials_to_kitchen_stock";
            this.add_materials_to_kitchen_stock.Size = new System.Drawing.Size(346, 108);
            this.add_materials_to_kitchen_stock.TabIndex = 9;
            this.add_materials_to_kitchen_stock.Text = "Add Materials To Kitchen Stock";
            this.add_materials_to_kitchen_stock.UseVisualStyleBackColor = false;
            this.add_materials_to_kitchen_stock.Click += new System.EventHandler(this.add_materials_to_kitchen_stock_Click);
            // 
            // pinding_to_kitchen_site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.add_materials_to_kitchen_stock);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.pinding_to_kitchen_stock_dataGridView);
            this.Controls.Add(this.pinding_to_kitchen_stock_label);
            this.Name = "pinding_to_kitchen_site";
            this.Size = new System.Drawing.Size(1746, 982);
            ((System.ComponentModel.ISupportInitialize)(this.pinding_to_kitchen_stock_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.DataGridView pinding_to_kitchen_stock_dataGridView;
        private System.Windows.Forms.Label pinding_to_kitchen_stock_label;
        private System.Windows.Forms.Button add_materials_to_kitchen_stock;
    }
}
