using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_SAR_Task_Concat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkAllFilesReady()
        {
            
            if(string.IsNullOrEmpty(txtTaskReportFile.Text) || string.IsNullOrEmpty(txtReimbursementFile.Text) || string.IsNullOrEmpty(txtPersonnelFile.Text))
            {
                btnGo.Enabled = false;
            } else { btnGo.Enabled = true; }
             
        }

        private void btnBrowseTaskReport_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog1.FileName)) { txtTaskReportFile.Text = openFileDialog1.FileName; }
            checkAllFilesReady();
        }

        private void btnBrowseEquipment_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog1.FileName)) { txtReimbursementFile.Text = openFileDialog1.FileName; }
            checkAllFilesReady();
        }

        private void btnBrowsePersonnel_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog1.FileName)) { txtPersonnelFile.Text = openFileDialog1.FileName; }
            checkAllFilesReady();
        }

        private void txtTaskReportFile_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog1.FileName)) { txtTaskReportFile.Text = openFileDialog1.FileName; }
            checkAllFilesReady();
        }

        private void txtReimbursementFile_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog1.FileName)) { txtReimbursementFile.Text = openFileDialog1.FileName; }
            checkAllFilesReady();
        }

        private void txtPersonnelFile_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog1.FileName)) { txtPersonnelFile.Text = openFileDialog1.FileName; }
            checkAllFilesReady();
        }

        private void BCTaskPDFToolsForm_Load(object sender, EventArgs e)
        {
            checkAllFilesReady();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            BCTaskPDFService service = new BCTaskPDFService();
            string outputFileName = null;

            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                outputFileName = saveFileDialog1.FileName;


                string path = service.GenerateSinglePDFWithFields(txtTaskReportFile.Text, txtReimbursementFile.Text, txtPersonnelFile.Text, outputFileName, chkAddFillableFields.Checked);

                if (!string.IsNullOrEmpty(path))
                {
                    System.Diagnostics.Process.Start(path);
                }
            }
        }

        private void btnLearnMore_Click(object sender, EventArgs e)
        {
            HelpInfo info = new HelpInfo();
            if (info.loadByTopic("Concat"))
            {
                using (BasicHelpInfo help = new BasicHelpInfo())
                {
                    help.Title = info.Title;
                    help.Body = info.Body;
                    help.ShowDialog();
                }
            }
        }
    }
}
