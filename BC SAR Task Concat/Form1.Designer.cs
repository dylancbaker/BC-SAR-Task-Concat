
namespace BC_SAR_Task_Concat
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
            this.chkAddFillableFields = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowsePersonnel = new System.Windows.Forms.Button();
            this.btnBrowseEquipment = new System.Windows.Forms.Button();
            this.btnBrowseTaskReport = new System.Windows.Forms.Button();
            this.txtPersonnelFile = new System.Windows.Forms.TextBox();
            this.txtReimbursementFile = new System.Windows.Forms.TextBox();
            this.txtTaskReportFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnLearnMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAddFillableFields
            // 
            this.chkAddFillableFields.AutoSize = true;
            this.chkAddFillableFields.Checked = true;
            this.chkAddFillableFields.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddFillableFields.Location = new System.Drawing.Point(143, 361);
            this.chkAddFillableFields.Name = "chkAddFillableFields";
            this.chkAddFillableFields.Size = new System.Drawing.Size(185, 28);
            this.chkAddFillableFields.TabIndex = 21;
            this.chkAddFillableFields.Text = "Add Fillable Fields";
            this.chkAddFillableFields.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(334, 342);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(150, 64);
            this.btnGo.TabIndex = 20;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Personnel Supplement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Equipment Reimbursement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Task Report";
            // 
            // btnBrowsePersonnel
            // 
            this.btnBrowsePersonnel.Location = new System.Drawing.Point(384, 261);
            this.btnBrowsePersonnel.Name = "btnBrowsePersonnel";
            this.btnBrowsePersonnel.Size = new System.Drawing.Size(100, 38);
            this.btnBrowsePersonnel.TabIndex = 16;
            this.btnBrowsePersonnel.Text = "Browse...";
            this.btnBrowsePersonnel.UseVisualStyleBackColor = true;
            this.btnBrowsePersonnel.Click += new System.EventHandler(this.btnBrowsePersonnel_Click);
            // 
            // btnBrowseEquipment
            // 
            this.btnBrowseEquipment.Location = new System.Drawing.Point(384, 169);
            this.btnBrowseEquipment.Name = "btnBrowseEquipment";
            this.btnBrowseEquipment.Size = new System.Drawing.Size(100, 38);
            this.btnBrowseEquipment.TabIndex = 15;
            this.btnBrowseEquipment.Text = "Browse...";
            this.btnBrowseEquipment.UseVisualStyleBackColor = true;
            this.btnBrowseEquipment.Click += new System.EventHandler(this.btnBrowseEquipment_Click);
            // 
            // btnBrowseTaskReport
            // 
            this.btnBrowseTaskReport.Location = new System.Drawing.Point(384, 77);
            this.btnBrowseTaskReport.Name = "btnBrowseTaskReport";
            this.btnBrowseTaskReport.Size = new System.Drawing.Size(100, 38);
            this.btnBrowseTaskReport.TabIndex = 14;
            this.btnBrowseTaskReport.Text = "Browse...";
            this.btnBrowseTaskReport.UseVisualStyleBackColor = true;
            this.btnBrowseTaskReport.Click += new System.EventHandler(this.btnBrowseTaskReport_Click);
            // 
            // txtPersonnelFile
            // 
            this.txtPersonnelFile.Location = new System.Drawing.Point(16, 265);
            this.txtPersonnelFile.Name = "txtPersonnelFile";
            this.txtPersonnelFile.ReadOnly = true;
            this.txtPersonnelFile.Size = new System.Drawing.Size(351, 29);
            this.txtPersonnelFile.TabIndex = 13;
            this.txtPersonnelFile.DoubleClick += new System.EventHandler(this.txtPersonnelFile_DoubleClick);
            // 
            // txtReimbursementFile
            // 
            this.txtReimbursementFile.Location = new System.Drawing.Point(16, 173);
            this.txtReimbursementFile.Name = "txtReimbursementFile";
            this.txtReimbursementFile.ReadOnly = true;
            this.txtReimbursementFile.Size = new System.Drawing.Size(351, 29);
            this.txtReimbursementFile.TabIndex = 12;
            this.txtReimbursementFile.DoubleClick += new System.EventHandler(this.txtReimbursementFile_DoubleClick);
            // 
            // txtTaskReportFile
            // 
            this.txtTaskReportFile.Location = new System.Drawing.Point(16, 81);
            this.txtTaskReportFile.Name = "txtTaskReportFile";
            this.txtTaskReportFile.ReadOnly = true;
            this.txtTaskReportFile.Size = new System.Drawing.Size(351, 29);
            this.txtTaskReportFile.TabIndex = 11;
            this.txtTaskReportFile.DoubleClick += new System.EventHandler(this.txtTaskReportFile_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "BC SAR Task Package Concat Tool";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Adobe Portable Document Format |*.pdf";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "pdf";
            this.saveFileDialog1.Filter = "Adobe Portable Document Format |*.pdf";
            // 
            // btnLearnMore
            // 
            this.btnLearnMore.Location = new System.Drawing.Point(17, 342);
            this.btnLearnMore.Name = "btnLearnMore";
            this.btnLearnMore.Size = new System.Drawing.Size(100, 64);
            this.btnLearnMore.TabIndex = 23;
            this.btnLearnMore.Text = "Learn more";
            this.btnLearnMore.UseVisualStyleBackColor = true;
            this.btnLearnMore.Click += new System.EventHandler(this.btnLearnMore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 436);
            this.Controls.Add(this.btnLearnMore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkAddFillableFields);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowsePersonnel);
            this.Controls.Add(this.btnBrowseEquipment);
            this.Controls.Add(this.btnBrowseTaskReport);
            this.Controls.Add(this.txtPersonnelFile);
            this.Controls.Add(this.txtReimbursementFile);
            this.Controls.Add(this.txtTaskReportFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "BC SAR Task Concat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAddFillableFields;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowsePersonnel;
        private System.Windows.Forms.Button btnBrowseEquipment;
        private System.Windows.Forms.Button btnBrowseTaskReport;
        private System.Windows.Forms.TextBox txtPersonnelFile;
        private System.Windows.Forms.TextBox txtReimbursementFile;
        private System.Windows.Forms.TextBox txtTaskReportFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnLearnMore;
    }
}

