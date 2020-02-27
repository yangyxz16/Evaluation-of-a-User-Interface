namespace Asg3_xxy180008
{
    partial class Form1
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
            this.container = new System.Windows.Forms.Panel();
            this.lbWarning = new System.Windows.Forms.Label();
            this.btAnalysis = new System.Windows.Forms.Button();
            this.btSelectFile = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.lbWarning);
            this.container.Controls.Add(this.btAnalysis);
            this.container.Controls.Add(this.btSelectFile);
            this.container.Controls.Add(this.tb);
            this.container.Controls.Add(this.dataGrid);
            this.container.Location = new System.Drawing.Point(12, 12);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(776, 426);
            this.container.TabIndex = 0;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Location = new System.Drawing.Point(172, 99);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(0, 17);
            this.lbWarning.TabIndex = 6;
            // 
            // btAnalysis
            // 
            this.btAnalysis.Location = new System.Drawing.Point(648, 101);
            this.btAnalysis.Name = "btAnalysis";
            this.btAnalysis.Size = new System.Drawing.Size(90, 26);
            this.btAnalysis.TabIndex = 5;
            this.btAnalysis.Text = "Analysis";
            this.btAnalysis.UseVisualStyleBackColor = true;
            this.btAnalysis.Click += new System.EventHandler(this.btAnalysis_Click);
            // 
            // btSelectFile
            // 
            this.btSelectFile.Location = new System.Drawing.Point(648, 69);
            this.btSelectFile.Name = "btSelectFile";
            this.btSelectFile.Size = new System.Drawing.Size(90, 26);
            this.btSelectFile.TabIndex = 3;
            this.btSelectFile.Text = "Select File";
            this.btSelectFile.UseVisualStyleBackColor = true;
            this.btSelectFile.Click += new System.EventHandler(this.btSelectFile_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(40, 28);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(698, 22);
            this.tb.TabIndex = 2;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.ColumnHeadersVisible = false;
            this.dataGrid.Enabled = false;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.Location = new System.Drawing.Point(175, 135);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGrid.Size = new System.Drawing.Size(423, 268);
            this.dataGrid.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.container);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btSelectFile;
        private System.Windows.Forms.Button btAnalysis;
        private System.Windows.Forms.Label lbWarning;
    }
}

