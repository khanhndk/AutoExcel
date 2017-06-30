namespace AutoExcel
{
    partial class MainFrm
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSortBefore = new System.Windows.Forms.TextBox();
            this.txtGroupColumns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSortAfter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSortAfterOrder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(1004, 650);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(184, 50);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 25;
            this.lstFiles.Location = new System.Drawing.Point(32, 30);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(935, 304);
            this.lstFiles.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(991, 30);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(184, 50);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(991, 117);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(184, 50);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sort By [before group]:";
            // 
            // txtSortBefore
            // 
            this.txtSortBefore.Location = new System.Drawing.Point(259, 381);
            this.txtSortBefore.Name = "txtSortBefore";
            this.txtSortBefore.Size = new System.Drawing.Size(100, 31);
            this.txtSortBefore.TabIndex = 5;
            this.txtSortBefore.Text = "B2";
            // 
            // txtGroupColumns
            // 
            this.txtGroupColumns.Location = new System.Drawing.Point(259, 447);
            this.txtGroupColumns.Name = "txtGroupColumns";
            this.txtGroupColumns.Size = new System.Drawing.Size(100, 31);
            this.txtGroupColumns.TabIndex = 7;
            this.txtGroupColumns.Text = "10, 15";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Group Columns:";
            // 
            // txtSortAfter
            // 
            this.txtSortAfter.Location = new System.Drawing.Point(259, 513);
            this.txtSortAfter.Name = "txtSortAfter";
            this.txtSortAfter.Size = new System.Drawing.Size(100, 31);
            this.txtSortAfter.TabIndex = 9;
            this.txtSortAfter.Text = "J1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sort By [after group]:";
            // 
            // chkSortAfterOrder
            // 
            this.chkSortAfterOrder.AutoSize = true;
            this.chkSortAfterOrder.Checked = true;
            this.chkSortAfterOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSortAfterOrder.Location = new System.Drawing.Point(23, 582);
            this.chkSortAfterOrder.Name = "chkSortAfterOrder";
            this.chkSortAfterOrder.Size = new System.Drawing.Size(265, 29);
            this.chkSortAfterOrder.TabIndex = 11;
            this.chkSortAfterOrder.Text = "Sort Ascent after group";
            this.chkSortAfterOrder.UseVisualStyleBackColor = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 712);
            this.Controls.Add(this.chkSortAfterOrder);
            this.Controls.Add(this.txtSortAfter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGroupColumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSortBefore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnProcess);
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSortBefore;
        private System.Windows.Forms.TextBox txtGroupColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSortAfter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSortAfterOrder;
    }
}

