namespace KDM_Lab_3
{
    partial class ResultsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsScreen));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pdnfLbl = new System.Windows.Forms.Label();
            this.pcnfLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(723, 372);
            this.dataGridView.TabIndex = 0;
            // 
            // pdnfLbl
            // 
            this.pdnfLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pdnfLbl.AutoSize = true;
            this.pdnfLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdnfLbl.Location = new System.Drawing.Point(20, 422);
            this.pdnfLbl.Name = "pdnfLbl";
            this.pdnfLbl.Size = new System.Drawing.Size(59, 25);
            this.pdnfLbl.TabIndex = 1;
            this.pdnfLbl.Text = "PDNF";
            // 
            // pcnfLbl
            // 
            this.pcnfLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcnfLbl.AutoSize = true;
            this.pcnfLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcnfLbl.Location = new System.Drawing.Point(20, 462);
            this.pcnfLbl.Name = "pcnfLbl";
            this.pcnfLbl.Size = new System.Drawing.Size(58, 25);
            this.pcnfLbl.TabIndex = 2;
            this.pcnfLbl.Text = "PCNF";
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 512);
            this.Controls.Add(this.pcnfLbl);
            this.Controls.Add(this.pdnfLbl);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultsScreen";
            this.Text = "Results Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label pdnfLbl;
        private System.Windows.Forms.Label pcnfLbl;
    }
}