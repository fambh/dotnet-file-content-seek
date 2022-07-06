using FileContentSeek.Settings;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileContentSeek
{
    public partial class ContentSeekForm : Form
    {
        bool _substituir = false;
        bool _cancelar = false;
        int _maxSize = 1024;
        public ContentSeekForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = txtDir.Text;

                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtDir.Text = fbd.SelectedPath;
                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public int GetFileSizeKb(string filename)
        {
            FileInfo fi = new FileInfo(filename);
            return Convert.ToInt32(fi.Length / 1000);
        }

        bool DoSearch(string filePath)
        {
            statusStrip.Items[0].Text = String.Format("Procurando: {0}", filePath);

            bool result = false;

            if (GetFileSizeKb(filePath) > _maxSize)
                return false;

            try
            {
                if (chkMultiExp.Checked)
                {
                    foreach (string sPattern in txtContent.Lines)
                    {
                        if (chkRegex.Checked)
                        {
                            result = result || DoSearchContentRegex(filePath, sPattern);
                        }
                        else
                        {
                            result = result || DoSearchContent(filePath, sPattern);
                        }

                        if (result) break;
                    }
                }
                else
                {
                    result = DoSearchContent(filePath, txtContent.Text);
                }

                if (!String.IsNullOrEmpty(txtContentNot.Text))
                {
                    if (chkRegexNot.Checked)
                    {
                        result = result && !DoSearchContentRegex(filePath, txtContentNot.Text);
                    }
                    else
                    {
                        result = result && !DoSearchContent(filePath, txtContentNot.Text);
                    }
                }

                if (result && _substituir)
                {
                    DoReplaceContent(filePath, txtContent.Text, txtReplace.Text);
                }
            }
            catch (Exception e)
            {
                if (MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    _cancelar = true;
                }
            }

            return result;
        }

        bool DoSearchContent(string filePath, string pattern)
        {
            bool result = false;

            using (StreamReader sr = File.OpenText(filePath))
            {
                string text = sr.ReadToEnd();

                sr.Close();

                if (chkCase.Checked)
                {
                    result = text.IndexOf(pattern, 0) != -1;
                }
                else
                {
                    result = text.IndexOf(pattern, 0, StringComparison.CurrentCultureIgnoreCase) != -1;
                }                
            }

            return result;
        }

        void DoReplaceContent(string filePath, string oldText, string newText)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string text = sr.ReadToEnd();

                sr.Close();

                if (!String.IsNullOrEmpty(text) && _substituir && !String.IsNullOrEmpty(newText))
                {
                    if (chkCase.Checked)
                    {
                        text = text.Replace(oldText, newText);
                    }
                    else
                    {
                        text = Regex.Replace(text, oldText, newText, RegexOptions.IgnoreCase);
                    }

                    string outputFile;

                    if (chkOutput.Checked)
                    {
                        string outputDir = String.Format("{0}\\output\\", Path.GetDirectoryName(filePath));

                        outputFile = String.Format("{0}{1}", outputDir, Path.GetFileName(filePath));

                        if (!Directory.Exists(outputDir))
                        {
                            Directory.CreateDirectory(outputDir);
                        }
                    }
                    else
                    {
                        outputFile = filePath;
                    }

                    using (StreamWriter sw = new StreamWriter(outputFile))
                    {
                        sw.Write(text);
                    }
                }
            }
        }

        bool DoSearchContentRegex(string filePath, string pattern)
        {
            bool result = false;

            Regex regex = new Regex(pattern);


            using (StreamReader sr = File.OpenText(filePath))
            {
                string sLine = "";

                while ((sLine = sr.ReadLine()) != null)
                {

                    Match match = regex.Match(sLine);

                    while (match.Success)
                    {
                        result = true;

                        if (!chkExtrairRegEx.Checked)
                        {
                            sr.Close();
                            return true;
                        }
                        else
                        {
                            foreach (Group group in match.Groups)
                            {
                                if ((group.Name == txtGroupIdx.Text) && !String.IsNullOrEmpty(group.Value.Trim()))
                                    if (!txtExtracted.Text.Contains(group.Value + "\r\n"))
                                        txtExtracted.AppendText(group.Value + "\r\n");
                            }
                        }


                        match = match.NextMatch();
                    }
                }
                sr.Close();
            }

            return result;
        }



        void DirSearch(string sDir, int iDepth)
        {
            try
            {
                statusStrip.Items[0].Text = String.Format("Procurando: {0}", sDir);

                Application.DoEvents();

                if (chkFileName.Checked)
                {
                    foreach (string f in Directory.GetFiles(sDir, txtFilter.Text))
                    {
                        string filename = Path.GetFileName(f);
                        string dirname = Path.GetDirectoryName(f);
                        {
                            if (filename.ToLower().Contains(txtContent.Text.ToLower()))
                            {
                                string newFilename = Regex.Replace(filename, txtContent.Text, txtReplace.Text, chkCase.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);

                                if (newFilename != filename)
                                    File.Move(f, Path.Combine(dirname, newFilename));
                            }
                        }
                    }
                }

                foreach (string f in Directory.GetFiles(sDir, txtFilter.Text))
                {
                    {
                        if (DoSearch(f))                          
                            lstFiles.Items.Add(f);
                        if (_cancelar) return;
                    }
                }

                iDepth++;

                if (iDepth <= Convert.ToInt32(txtDepth.Text))
                {
                    foreach (string d in Directory.GetDirectories(sDir))
                    {
                        DirSearch(d, iDepth);
                        if (_cancelar) return;
                    }
                }
            }
            catch (System.Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void IniciaBusca()
        {
            _maxSize = Convert.ToInt32(txtSize.Text);
            _cancelar = false;
            try
            {
                lstFiles.Items.Clear();
                txtExtracted.Clear();

                var sDir = txtDir.Text;

                DirSearch(sDir, 0);
            }
            finally
            {
                statusStrip.Items[0].Text = "Pronto";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AppSettings.DefaultDir = txtDir.Text;
            AppSettings.Save();

            _substituir = false;            

            IniciaBusca();
        }

        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = AppSettings.OpenWith;
            proc.StartInfo.Arguments = lstFiles.SelectedItem.ToString();
            proc.StartInfo.UseShellExecute = true;           
            proc.Start();
        }

        private void chkRegex_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkRegex.Checked)
            {
                chkMultiExp.Checked = true;
            }
            chkMultiExp.Enabled = !chkRegex.Checked;
        }

        private void txtReplace_TextChanged(object sender, EventArgs e)
        {
            btnReplace.Enabled = !chkMultiExp.Checked && !String.IsNullOrEmpty(txtReplace.Text);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            _substituir = true;

            IniciaBusca();
        }

        private void chkMultiExp_CheckedChanged(object sender, EventArgs e)
        {
            txtReplace_TextChanged(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDepth_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContentSeekForm_Load(object sender, EventArgs e)
        {
            txtDir.Text = AppSettings.DefaultDir;
        }
    }
}
