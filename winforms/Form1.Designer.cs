namespace winforms
{
    partial class frmDataVisualizer
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
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwData
            // 
            this.dgwData.AllowUserToAddRows = false;
            this.dgwData.AllowUserToDeleteRows = false;
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Location = new System.Drawing.Point(12, 41);
            this.dgwData.Name = "dgwData";
            this.dgwData.ReadOnly = true;
            this.dgwData.Size = new System.Drawing.Size(776, 397);
            this.dgwData.TabIndex = 0;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFile.Location = new System.Drawing.Point(12, 12);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(776, 23);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Load Data File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // frmDataVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.dgwData);
            this.Name = "frmDataVisualizer";
            this.Text = "Data Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.Button btnLoadFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

