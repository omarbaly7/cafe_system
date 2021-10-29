
namespace cafe
{
    partial class reports_site
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
            this.report_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // report_label
            // 
            this.report_label.AutoSize = true;
            this.report_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report_label.Location = new System.Drawing.Point(598, 469);
            this.report_label.Name = "report_label";
            this.report_label.Size = new System.Drawing.Size(159, 54);
            this.report_label.TabIndex = 0;
            this.report_label.Text = "Reports";
            // 
            // reports_site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.report_label);
            this.Name = "reports_site";
            this.Size = new System.Drawing.Size(1746, 982);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label report_label;
    }
}
