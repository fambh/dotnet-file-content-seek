namespace FileContentSeek
{
    partial class ContentSeekForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkFileName = new System.Windows.Forms.CheckBox();
            this.txtContentNot = new System.Windows.Forms.TextBox();
            this.chkOutput = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.chkMultiExp = new System.Windows.Forms.CheckBox();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.txtGroupIdx = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkExtrairRegEx = new System.Windows.Forms.CheckBox();
            this.chkRegexNot = new System.Windows.Forms.CheckBox();
            this.chkRegex = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtExtracted = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSize);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chkFileName);
            this.panel1.Controls.Add(this.txtContentNot);
            this.panel1.Controls.Add(this.chkOutput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtReplace);
            this.panel1.Controls.Add(this.btnReplace);
            this.panel1.Controls.Add(this.chkMultiExp);
            this.panel1.Controls.Add(this.chkCase);
            this.panel1.Controls.Add(this.txtGroupIdx);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtDepth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkExtrairRegEx);
            this.panel1.Controls.Add(this.chkRegexNot);
            this.panel1.Controls.Add(this.chkRegex);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDir);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 281);
            this.panel1.TabIndex = 0;
            // 
            // chkFileName
            // 
            this.chkFileName.AutoSize = true;
            this.chkFileName.Location = new System.Drawing.Point(450, 194);
            this.chkFileName.Name = "chkFileName";
            this.chkFileName.Size = new System.Drawing.Size(107, 17);
            this.chkFileName.TabIndex = 21;
            this.chkFileName.Text = "Nome do arquivo";
            this.chkFileName.UseVisualStyleBackColor = true;
            // 
            // txtContentNot
            // 
            this.txtContentNot.Location = new System.Drawing.Point(82, 159);
            this.txtContentNot.Multiline = true;
            this.txtContentNot.Name = "txtContentNot";
            this.txtContentNot.Size = new System.Drawing.Size(291, 45);
            this.txtContentNot.TabIndex = 20;
            // 
            // chkOutput
            // 
            this.chkOutput.AutoSize = true;
            this.chkOutput.Checked = true;
            this.chkOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOutput.Location = new System.Drawing.Point(450, 217);
            this.chkOutput.Name = "chkOutput";
            this.chkOutput.Size = new System.Drawing.Size(101, 17);
            this.chkOutput.TabIndex = 19;
            this.chkOutput.Text = "Diretório OutPut";
            this.chkOutput.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Substituir:";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(82, 217);
            this.txtReplace.Multiline = true;
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(291, 47);
            this.txtReplace.TabIndex = 17;
            this.txtReplace.TextChanged += new System.EventHandler(this.txtReplace_TextChanged);
            // 
            // btnReplace
            // 
            this.btnReplace.Enabled = false;
            this.btnReplace.Location = new System.Drawing.Point(450, 241);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 16;
            this.btnReplace.Text = "Substituir";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // chkMultiExp
            // 
            this.chkMultiExp.AutoSize = true;
            this.chkMultiExp.Location = new System.Drawing.Point(82, 136);
            this.chkMultiExp.Name = "chkMultiExp";
            this.chkMultiExp.Size = new System.Drawing.Size(142, 17);
            this.chkMultiExp.TabIndex = 15;
            this.chkMultiExp.Text = "Uma expressão por linha";
            this.chkMultiExp.UseVisualStyleBackColor = true;
            this.chkMultiExp.CheckedChanged += new System.EventHandler(this.chkMultiExp_CheckedChanged);
            // 
            // chkCase
            // 
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(450, 40);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(96, 17);
            this.chkCase.TabIndex = 14;
            this.chkCase.Text = "Case Sensitive";
            this.chkCase.UseVisualStyleBackColor = true;
            // 
            // txtGroupIdx
            // 
            this.txtGroupIdx.Location = new System.Drawing.Point(578, 14);
            this.txtGroupIdx.Name = "txtGroupIdx";
            this.txtGroupIdx.Size = new System.Drawing.Size(31, 20);
            this.txtGroupIdx.TabIndex = 13;
            this.txtGroupIdx.Text = "2";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(450, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Localizar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(557, 74);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(47, 20);
            this.txtDepth.TabIndex = 8;
            this.txtDepth.Text = "0";
            this.txtDepth.TextChanged += new System.EventHandler(this.txtDepth_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SubPastas:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chkExtrairRegEx
            // 
            this.chkExtrairRegEx.AutoSize = true;
            this.chkExtrairRegEx.Location = new System.Drawing.Point(450, 17);
            this.chkExtrairRegEx.Name = "chkExtrairRegEx";
            this.chkExtrairRegEx.Size = new System.Drawing.Size(122, 17);
            this.chkExtrairRegEx.TabIndex = 6;
            this.chkExtrairRegEx.Text = "Extrair Grupo RegEx";
            this.chkExtrairRegEx.UseVisualStyleBackColor = true;
            // 
            // chkRegexNot
            // 
            this.chkRegexNot.AutoSize = true;
            this.chkRegexNot.Location = new System.Drawing.Point(15, 187);
            this.chkRegexNot.Name = "chkRegexNot";
            this.chkRegexNot.Size = new System.Drawing.Size(58, 17);
            this.chkRegexNot.TabIndex = 5;
            this.chkRegexNot.Text = "RegEx";
            this.chkRegexNot.UseVisualStyleBackColor = true;
            this.chkRegexNot.CheckStateChanged += new System.EventHandler(this.chkRegex_CheckStateChanged);
            // 
            // chkRegex
            // 
            this.chkRegex.AutoSize = true;
            this.chkRegex.Location = new System.Drawing.Point(15, 86);
            this.chkRegex.Name = "chkRegex";
            this.chkRegex.Size = new System.Drawing.Size(58, 17);
            this.chkRegex.TabIndex = 5;
            this.chkRegex.Text = "RegEx";
            this.chkRegex.UseVisualStyleBackColor = true;
            this.chkRegex.CheckStateChanged += new System.EventHandler(this.chkRegex_CheckStateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Filtro:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(82, 41);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(291, 20);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.Text = "*.*";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Não contendo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(82, 67);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(291, 63);
            this.txtContent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pasta:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(82, 15);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(291, 20);
            this.txtDir.TabIndex = 1;
            this.txtDir.Text = "D:\\DEV\\Site\\erp";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 512);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(773, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Pronto";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Controls.Add(this.lstFiles);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 231);
            this.panel3.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(569, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 231);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // lstFiles
            // 
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(0, 0);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(573, 231);
            this.lstFiles.TabIndex = 4;
            this.lstFiles.DoubleClick += new System.EventHandler(this.lstFiles_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtExtracted);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(573, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 231);
            this.panel2.TabIndex = 3;
            // 
            // txtExtracted
            // 
            this.txtExtracted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExtracted.Location = new System.Drawing.Point(0, 0);
            this.txtExtracted.Multiline = true;
            this.txtExtracted.Name = "txtExtracted";
            this.txtExtracted.ReadOnly = true;
            this.txtExtracted.Size = new System.Drawing.Size(200, 231);
            this.txtExtracted.TabIndex = 0;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(557, 100);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(47, 20);
            this.txtSize.TabIndex = 23;
            this.txtSize.Text = "1024";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tamanho Máx. (KB):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(535, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "(Replace file content. Be careful.)";
            // 
            // ContentSeekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 534);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.Name = "ContentSeekForm";
            this.Text = "File Content Seeker";
            this.Load += new System.EventHandler(this.ContentSeekForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkExtrairRegEx;
        private System.Windows.Forms.CheckBox chkRegex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtExtracted;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TextBox txtGroupIdx;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.CheckBox chkMultiExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.CheckBox chkOutput;
        private System.Windows.Forms.TextBox txtContentNot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkRegexNot;
        private System.Windows.Forms.CheckBox chkFileName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

