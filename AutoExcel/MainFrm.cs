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
    }
}
