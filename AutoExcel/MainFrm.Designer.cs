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
            this.cbSetting = new System.Windows.Forms.ComboBox();
            this.btnNewSetting = new System.Windows.Forms.Button();
            this.btnUpdateSetting = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(502, 338);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(92, 26);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(16, 16);
            this.lstFiles.Margin = new System.Windows.Forms.Padding(2);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(470, 160);
            this.lstFiles.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(496, 16);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(92, 26);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(496, 61);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(92, 26);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sort By [before group]:";
            // 
            // txtSortBefore
            // 
            this.txtSortBefore.Location = new System.Drawing.Point(130, 198);
            this.txtSortBefore.Margin = new System.Windows.Forms.Padding(2);
            this.txtSortBefore.Name = "txtSortBefore";
            this.txtSortBefore.Size = new System.Drawing.Size(52, 20);
            this.txtSortBefore.TabIndex = 5;
            this.txtSortBefore.Text = "B2";
            // 
            // txtGroupColumns
            // 
            this.txtGroupColumns.Location = new System.Drawing.Point(130, 232);
            this.txtGroupColumns.Margin = new System.Windows.Forms.Padding(2);
            this.txtGroupColumns.Name = "txtGroupColumns";
            this.txtGroupColumns.Size = new System.Drawing.Size(52, 20);
            this.txtGroupColumns.TabIndex = 7;
            this.txtGroupColumns.Text = "10, 16";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Group Columns:";
            // 
            // txtSortAfter
            // 
            this.txtSortAfter.Location = new System.Drawing.Point(130, 267);
            this.txtSortAfter.Margin = new System.Windows.Forms.Padding(2);
            this.txtSortAfter.Name = "txtSortAfter";
            this.txtSortAfter.Size = new System.Drawing.Size(52, 20);
            this.txtSortAfter.TabIndex = 9;
            this.txtSortAfter.Text = "J1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sort By [after group]:";
            // 
            // chkSortAfterOrder
            // 
            this.chkSortAfterOrder.AutoSize = true;
            this.chkSortAfterOrder.Checked = true;
            this.chkSortAfterOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSortAfterOrder.Location = new System.Drawing.Point(12, 303);
            this.chkSortAfterOrder.Margin = new System.Windows.Forms.Padding(2);
            this.chkSortAfterOrder.Name = "chkSortAfterOrder";
            this.chkSortAfterOrder.Size = new System.Drawing.Size(135, 17);
            this.chkSortAfterOrder.TabIndex = 11;
            this.chkSortAfterOrder.Text = "Sort Ascent after group";
            this.chkSortAfterOrder.UseVisualStyleBackColor = true;
            // 
            // cbSetting
            // 
            this.cbSetting.FormattingEnabled = true;
            this.cbSetting.Location = new System.Drawing.Point(334, 197);
            this.cbSetting.Name = "cbSetting";
            this.cbSetting.Size = new System.Drawing.Size(152, 21);
            this.cbSetting.TabIndex = 12;
            this.cbSetting.SelectedIndexChanged += new System.EventHandler(this.cbSetting_SelectedIndexChanged);
            this.cbSetting.TextChanged += new System.EventHandler(this.cbSetting_TextChanged);
            // 
            // btnNewSetting
            // 
            this.btnNewSetting.Location = new System.Drawing.Point(289, 229);
            this.btnNewSetting.Name = "btnNewSetting";
            this.btnNewSetting.Size = new System.Drawing.Size(77, 23);
            this.btnNewSetting.TabIndex = 13;
            this.btnNewSetting.Text = "New Setting";
            this.btnNewSetting.UseVisualStyleBackColor = true;
            this.btnNewSetting.Click += new System.EventHandler(this.btnNewSetting_Click);
            // 
            // btnUpdateSetting
            // 
            this.btnUpdateSetting.Location = new System.Drawing.Point(372, 229);
            this.btnUpdateSetting.Name = "btnUpdateSetting";
            this.btnUpdateSetting.Size = new System.Drawing.Size(114, 23);
            this.btnUpdateSetting.TabIndex = 14;
            this.btnUpdateSetting.Text = "Update setting";
            this.btnUpdateSetting.UseVisualStyleBackColor = true;
            this.btnUpdateSetting.Click += new System.EventHandler(this.btnUpdateSetting_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Load setting:";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdateSetting);
            this.Controls.Add(this.btnNewSetting);
            this.Controls.Add(this.cbSetting);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainFrm";
            this.Text = "Auto Excel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.Load += new System.EventHandler(this.MainFrm_Load);
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
        private System.Windows.Forms.ComboBox cbSetting;
        private System.Windows.Forms.Button btnNewSetting;
        private System.Windows.Forms.Button btnUpdateSetting;
        private System.Windows.Forms.Label label4;
    }
}

