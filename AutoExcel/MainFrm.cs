using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;

namespace AutoExcel
{
    public partial class MainFrm : Form
    {
        Microsoft.Office.Interop.Excel.Application app;
        List<string> filelist;
        public MainFrm()
        {
            InitializeComponent();
            filelist = new List<string>();
        }

        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            app.Quit();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string[] stCols = txtGroupColumns.Text.Split(',');
            int[] group_cols = new int[stCols.Length];
            for (int i = 0; i < stCols.Length; i++)
            {
                group_cols[i] = int.Parse(stCols[i]);
            }

            app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            foreach (string filename in filelist)
            {
                app.Workbooks.OpenText(filename, XlPlatform.xlMSDOS, 1, XlTextParsingType.xlDelimited,
                    XlTextQualifier.xlTextQualifierDoubleQuote,
                    ConsecutiveDelimiter: false, Tab: true, Semicolon: false, Comma: true, Space: false,
                    Other: false, TrailingMinusNumbers: true);

                // sort
                Worksheet activesheet = app.ActiveWorkbook.ActiveSheet;
                Range fullrange = activesheet.UsedRange;
                activesheet.Sort.SortFields.Clear();
                activesheet.Sort.SortFields.Add(activesheet.Range[txtSortBefore.Text],
                    XlSortOn.xlSortOnValues, XlSortOrder.xlAscending, XlSortDataOption.xlSortNormal);
                activesheet.Sort.SetRange(fullrange);
                activesheet.Sort.Header = XlYesNoGuess.xlYes;
                activesheet.Sort.MatchCase = false;
                activesheet.Sort.Orientation = XlSortOrientation.xlSortColumns;
                activesheet.Sort.SortMethod = XlSortMethod.xlPinYin;
                activesheet.Sort.Apply();

                fullrange.Subtotal(GroupBy: 2, Function: XlConsolidationFunction.xlAverage,
                    TotalList: group_cols, Replace: true, PageBreaks: false, SummaryBelowData: XlSummaryRow.xlSummaryBelow);
                activesheet.Outline.ShowLevels(RowLevels: 2);
                activesheet.Sort.SortFields.Clear();
                activesheet.Sort.SortFields.Add(activesheet.Range[txtSortAfter.Text], XlSortOn.xlSortOnValues, 
                    (chkSortAfterOrder.Checked) ? XlSortOrder.xlAscending : XlSortOrder.xlDescending, 
                    XlSortDataOption.xlSortNormal);
                activesheet.Sort.SetRange(fullrange);
                activesheet.Sort.Header = XlYesNoGuess.xlYes;
                activesheet.Sort.MatchCase = false;
                activesheet.Sort.Orientation = XlSortOrientation.xlSortColumns;
                activesheet.Sort.SortMethod = XlSortMethod.xlPinYin;
                activesheet.Sort.Apply();

                //app.ActiveWorkbook.Save();
                app.ActiveWorkbook.SaveAs(filename.Replace(".txt", ".xlsx"), FileFormat: XlFileFormat.xlOpenXMLWorkbook);
                app.ActiveWorkbook.Close();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            foreach (string filename in dlg.FileNames)
            {
                filelist.Add(filename);
                lstFiles.Items.Add(Path.GetFileName(filename));
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedIndex < 0)
                return;
            int k = lstFiles.SelectedIndex;
            filelist.RemoveAt(k);
            lstFiles.Items.RemoveAt(k);
        }

        string app_path;
        string default_setting_filename;
        private void MainFrm_Load(object sender, EventArgs e)
        {
            app_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";
            default_setting_filename = app_path + "default.setting";
            if (!File.Exists(default_setting_filename))
            {
                Save_Setting("default");
            }
            Load_Setting_List();
            cbSetting.SelectedIndex = 0;
        }

        private void Load_Setting_List()
        {
            string[] setting_filenames = Directory.GetFiles(app_path, "*.setting");
            cbSetting.Items.Clear();
            foreach (string filename in setting_filenames)
                cbSetting.Items.Add(Path.GetFileNameWithoutExtension(filename));
        }
        private void Load_Setting(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            List<string> settings = new List<string>();
            while (!reader.EndOfStream)
                settings.Add(reader.ReadLine());
            reader.Close();
            txtSortBefore.Text = settings[0];
            txtGroupColumns.Text = settings[1];
            txtSortAfter.Text = settings[2];
        }

        private void Save_Setting(string settingname)
        {
            List<string> settings = new List<string>();
            settings.Add(txtSortBefore.Text);
            settings.Add(txtGroupColumns.Text);
            settings.Add(txtSortAfter.Text);
            string setting_filename = app_path + settingname + ".setting";
            StreamWriter writer = new StreamWriter(setting_filename);
            for (int i = 0; i < settings.Count; i++)
                writer.WriteLine(settings[i]);
            writer.Close();
        }

        private void btnNewSetting_Click(object sender, EventArgs e)
        {
            if (cbSetting.Text.Trim() == "")
                MessageBox.Show("Please input the new name setting", "Error");
            Process_Save_Setting();
        }

        private void cbSetting_TextChanged(object sender, EventArgs e)
        {
            bool status_new = false;
            if (cbSetting.SelectedItem == null)
                status_new = true;
            btnNewSetting.Enabled = status_new;
            btnUpdateSetting.Enabled = !status_new;

        }

        private void btnUpdateSetting_Click(object sender, EventArgs e)
        {
            Process_Save_Setting();
        }

        private void Process_Save_Setting()
        {
            string current_setting = cbSetting.Text;
            Save_Setting(current_setting);
            Load_Setting_List();
            for (int i = 0; i < cbSetting.Items.Count; i++)
                if (cbSetting.Items[i].ToString() == current_setting)
                    cbSetting.SelectedIndex = i;
        }

        private void cbSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSetting.SelectedItem == null)
                return;
            string current_setting_filename = app_path + cbSetting.SelectedItem + ".setting";
            Load_Setting(current_setting_filename);
        }
    }
}
