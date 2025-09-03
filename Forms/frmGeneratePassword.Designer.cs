namespace Kbg.NppPluginNET
{
    partial class frmGeneratePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneratePassword));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkAppendToStart = new System.Windows.Forms.CheckBox();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lnkGitHubLink = new System.Windows.Forms.LinkLabel();
            this.chkSaveToClipboard = new System.Windows.Forms.CheckBox();
            this.numWordCount = new System.Windows.Forms.NumericUpDown();
            this.ddlWordDictionary = new System.Windows.Forms.ComboBox();
            this.lblWordDictionary = new System.Windows.Forms.Label();
            this.numMinWordLen = new System.Windows.Forms.NumericUpDown();
            this.lblMinWordLen = new System.Windows.Forms.Label();
            this.numMaxWordLen = new System.Windows.Forms.NumericUpDown();
            this.lblMaxWordLen = new System.Windows.Forms.Label();
            this.numPaddingDigitsBefore = new System.Windows.Forms.NumericUpDown();
            this.lblPaddingDigitsBefore = new System.Windows.Forms.Label();
            this.numPaddingDigitsAfter = new System.Windows.Forms.NumericUpDown();
            this.lblPaddingDigitsAfter = new System.Windows.Forms.Label();
            this.numPaddingSymbolsBefore = new System.Windows.Forms.NumericUpDown();
            this.lblPaddingSymbolsBefore = new System.Windows.Forms.Label();
            this.numPaddingSymbolsAfter = new System.Windows.Forms.NumericUpDown();
            this.lblPaddingSymbolsAfter = new System.Windows.Forms.Label();
            this.chkAppendToEnd = new System.Windows.Forms.CheckBox();
            this.chkNewFile = new System.Windows.Forms.CheckBox();
            this.numPasswordCount = new System.Windows.Forms.NumericUpDown();
            this.lblPasswordCount = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpWords = new System.Windows.Forms.GroupBox();
            this.grpTransformation = new System.Windows.Forms.GroupBox();
            this.ddlTransformation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSeparators = new System.Windows.Forms.GroupBox();
            this.btnSeparator_SemiColon = new System.Windows.Forms.Button();
            this.btnSeparator_Period = new System.Windows.Forms.Button();
            this.btnSeparator_Slash = new System.Windows.Forms.Button();
            this.btnSeparator_Question = new System.Windows.Forms.Button();
            this.btnSeparator_Tilda = new System.Windows.Forms.Button();
            this.btnSeparator_Pipe = new System.Windows.Forms.Button();
            this.btnSeparator_Colon = new System.Windows.Forms.Button();
            this.btnSeparator_Equals = new System.Windows.Forms.Button();
            this.btnSeparator_Plus = new System.Windows.Forms.Button();
            this.btnSeparator_Underscore = new System.Windows.Forms.Button();
            this.btnSeparator_Dash = new System.Windows.Forms.Button();
            this.btnSeparator_Star = new System.Windows.Forms.Button();
            this.btnSeparator_And = new System.Windows.Forms.Button();
            this.btnSeparator_Caret = new System.Windows.Forms.Button();
            this.btnSeparator_Percent = new System.Windows.Forms.Button();
            this.btnSeparator_Dollar = new System.Windows.Forms.Button();
            this.btnSeparator_At = new System.Windows.Forms.Button();
            this.btnSeparator_Exclamation = new System.Windows.Forms.Button();
            this.grpPaddingDigits = new System.Windows.Forms.GroupBox();
            this.grpPaddingSymbols = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.lnkxkPasswdLink = new System.Windows.Forms.LinkLabel();
            this.lblInspiredBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinWordLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxWordLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaddingDigitsBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaddingDigitsAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaddingSymbolsBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaddingSymbolsAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordCount)).BeginInit();
            this.grpWords.SuspendLayout();
            this.grpTransformation.SuspendLayout();
            this.grpSeparators.SuspendLayout();
            this.grpPaddingDigits.SuspendLayout();
            this.grpPaddingSymbols.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(406, 130);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(123, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // chkAppendToStart
            // 
            this.chkAppendToStart.AutoSize = true;
            this.chkAppendToStart.Location = new System.Drawing.Point(409, 62);
            this.chkAppendToStart.Name = "chkAppendToStart";
            this.chkAppendToStart.Size = new System.Drawing.Size(100, 17);
            this.chkAppendToStart.TabIndex = 2;
            this.chkAppendToStart.Text = "Append to Start";
            this.chkAppendToStart.UseVisualStyleBackColor = true;
            this.chkAppendToStart.CheckedChanged += new System.EventHandler(this.OutputType_CheckChange);
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(11, 84);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(95, 13);
            this.lblWordCount.TabIndex = 4;
            this.lblWordCount.Text = "Number Of Words:";
            // 
            // lnkGitHubLink
            // 
            this.lnkGitHubLink.AutoSize = true;
            this.lnkGitHubLink.Location = new System.Drawing.Point(509, 480);
            this.lnkGitHubLink.Name = "lnkGitHubLink";
            this.lnkGitHubLink.Size = new System.Drawing.Size(40, 13);
            this.lnkGitHubLink.TabIndex = 5;
            this.lnkGitHubLink.TabStop = true;
            this.lnkGitHubLink.Text = "GitHub";
            this.lnkGitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHub_LinkClicked);
            // 
            // chkSaveToClipboard
            // 
            this.chkSaveToClipboard.AutoSize = true;
            this.chkSaveToClipboard.Location = new System.Drawing.Point(409, 39);
            this.chkSaveToClipboard.Name = "chkSaveToClipboard";
            this.chkSaveToClipboard.Size = new System.Drawing.Size(110, 17);
            this.chkSaveToClipboard.TabIndex = 6;
            this.chkSaveToClipboard.Text = "Save to Clipboard";
            this.chkSaveToClipboard.UseVisualStyleBackColor = true;
            this.chkSaveToClipboard.CheckedChanged += new System.EventHandler(this.OutputType_CheckChange);
            // 
            // numWordCount
            // 
            this.numWordCount.Location = new System.Drawing.Point(133, 82);
            this.numWordCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numWordCount.Name = "numWordCount";
            this.numWordCount.Size = new System.Drawing.Size(77, 20);
            this.numWordCount.TabIndex = 7;
            this.numWordCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ddlWordDictionary
            // 
            this.ddlWordDictionary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlWordDictionary.FormattingEnabled = true;
            this.ddlWordDictionary.Items.AddRange(new object[] {
            "English"});
            this.ddlWordDictionary.Location = new System.Drawing.Point(133, 27);
            this.ddlWordDictionary.Name = "ddlWordDictionary";
            this.ddlWordDictionary.Size = new System.Drawing.Size(77, 21);
            this.ddlWordDictionary.TabIndex = 8;
            // 
            // lblWordDictionary
            // 
            this.lblWordDictionary.AutoSize = true;
            this.lblWordDictionary.Location = new System.Drawing.Point(11, 30);
            this.lblWordDictionary.Name = "lblWordDictionary";
            this.lblWordDictionary.Size = new System.Drawing.Size(57, 13);
            this.lblWordDictionary.TabIndex = 9;
            this.lblWordDictionary.Text = "Dictionary:";
            // 
            // numMinWordLen
            // 
            this.numMinWordLen.Location = new System.Drawing.Point(133, 108);
            this.numMinWordLen.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMinWordLen.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numMinWordLen.Name = "numMinWordLen";
            this.numMinWordLen.Size = new System.Drawing.Size(77, 20);
            this.numMinWordLen.TabIndex = 11;
            this.numMinWordLen.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblMinWordLen
            // 
            this.lblMinWordLen.AutoSize = true;
            this.lblMinWordLen.Location = new System.Drawing.Point(11, 110);
            this.lblMinWordLen.Name = "lblMinWordLen";
            this.lblMinWordLen.Size = new System.Drawing.Size(87, 13);
            this.lblMinWordLen.TabIndex = 10;
            this.lblMinWordLen.Text = "Minimum Length:";
            // 
            // numMaxWordLen
            // 
            this.numMaxWordLen.Location = new System.Drawing.Point(133, 134);
            this.numMaxWordLen.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMaxWordLen.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numMaxWordLen.Name = "numMaxWordLen";
            this.numMaxWordLen.Size = new System.Drawing.Size(77, 20);
            this.numMaxWordLen.TabIndex = 13;
            this.numMaxWordLen.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblMaxWordLen
            // 
            this.lblMaxWordLen.AutoSize = true;
            this.lblMaxWordLen.Location = new System.Drawing.Point(11, 136);
            this.lblMaxWordLen.Name = "lblMaxWordLen";
            this.lblMaxWordLen.Size = new System.Drawing.Size(90, 13);
            this.lblMaxWordLen.TabIndex = 12;
            this.lblMaxWordLen.Text = "Maximum Length:";
            // 
            // numPaddingDigitsBefore
            // 
            this.numPaddingDigitsBefore.Location = new System.Drawing.Point(133, 26);
            this.numPaddingDigitsBefore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPaddingDigitsBefore.Name = "numPaddingDigitsBefore";
            this.numPaddingDigitsBefore.Size = new System.Drawing.Size(77, 20);
            this.numPaddingDigitsBefore.TabIndex = 15;
            this.numPaddingDigitsBefore.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblPaddingDigitsBefore
            // 
            this.lblPaddingDigitsBefore.AutoSize = true;
            this.lblPaddingDigitsBefore.Location = new System.Drawing.Point(11, 28);
            this.lblPaddingDigitsBefore.Name = "lblPaddingDigitsBefore";
            this.lblPaddingDigitsBefore.Size = new System.Drawing.Size(112, 13);
            this.lblPaddingDigitsBefore.TabIndex = 14;
            this.lblPaddingDigitsBefore.Text = "Padding Digits Before:";
            // 
            // numPaddingDigitsAfter
            // 
            this.numPaddingDigitsAfter.Location = new System.Drawing.Point(133, 52);
            this.numPaddingDigitsAfter.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPaddingDigitsAfter.Name = "numPaddingDigitsAfter";
            this.numPaddingDigitsAfter.Size = new System.Drawing.Size(77, 20);
            this.numPaddingDigitsAfter.TabIndex = 17;
            this.numPaddingDigitsAfter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblPaddingDigitsAfter
            // 
            this.lblPaddingDigitsAfter.AutoSize = true;
            this.lblPaddingDigitsAfter.Location = new System.Drawing.Point(11, 54);
            this.lblPaddingDigitsAfter.Name = "lblPaddingDigitsAfter";
            this.lblPaddingDigitsAfter.Size = new System.Drawing.Size(103, 13);
            this.lblPaddingDigitsAfter.TabIndex = 16;
            this.lblPaddingDigitsAfter.Text = "Padding Digits After:";
            // 
            // numPaddingSymbolsBefore
            // 
            this.numPaddingSymbolsBefore.Location = new System.Drawing.Point(142, 26);
            this.numPaddingSymbolsBefore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPaddingSymbolsBefore.Name = "numPaddingSymbolsBefore";
            this.numPaddingSymbolsBefore.Size = new System.Drawing.Size(77, 20);
            this.numPaddingSymbolsBefore.TabIndex = 19;
            this.numPaddingSymbolsBefore.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblPaddingSymbolsBefore
            // 
            this.lblPaddingSymbolsBefore.AutoSize = true;
            this.lblPaddingSymbolsBefore.Location = new System.Drawing.Point(11, 28);
            this.lblPaddingSymbolsBefore.Name = "lblPaddingSymbolsBefore";
            this.lblPaddingSymbolsBefore.Size = new System.Drawing.Size(125, 13);
            this.lblPaddingSymbolsBefore.TabIndex = 18;
            this.lblPaddingSymbolsBefore.Text = "Padding Symbols Before:";
            // 
            // numPaddingSymbolsAfter
            // 
            this.numPaddingSymbolsAfter.Location = new System.Drawing.Point(142, 52);
            this.numPaddingSymbolsAfter.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPaddingSymbolsAfter.Name = "numPaddingSymbolsAfter";
            this.numPaddingSymbolsAfter.Size = new System.Drawing.Size(77, 20);
            this.numPaddingSymbolsAfter.TabIndex = 21;
            this.numPaddingSymbolsAfter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblPaddingSymbolsAfter
            // 
            this.lblPaddingSymbolsAfter.AutoSize = true;
            this.lblPaddingSymbolsAfter.Location = new System.Drawing.Point(11, 54);
            this.lblPaddingSymbolsAfter.Name = "lblPaddingSymbolsAfter";
            this.lblPaddingSymbolsAfter.Size = new System.Drawing.Size(116, 13);
            this.lblPaddingSymbolsAfter.TabIndex = 20;
            this.lblPaddingSymbolsAfter.Text = "Padding Symbols After:";
            // 
            // chkAppendToEnd
            // 
            this.chkAppendToEnd.AutoSize = true;
            this.chkAppendToEnd.Location = new System.Drawing.Point(409, 85);
            this.chkAppendToEnd.Name = "chkAppendToEnd";
            this.chkAppendToEnd.Size = new System.Drawing.Size(97, 17);
            this.chkAppendToEnd.TabIndex = 24;
            this.chkAppendToEnd.Text = "Append to End";
            this.chkAppendToEnd.UseVisualStyleBackColor = true;
            this.chkAppendToEnd.CheckedChanged += new System.EventHandler(this.OutputType_CheckChange);
            // 
            // chkNewFile
            // 
            this.chkNewFile.AutoSize = true;
            this.chkNewFile.Location = new System.Drawing.Point(409, 108);
            this.chkNewFile.Name = "chkNewFile";
            this.chkNewFile.Size = new System.Drawing.Size(67, 17);
            this.chkNewFile.TabIndex = 25;
            this.chkNewFile.Text = "New File";
            this.chkNewFile.UseVisualStyleBackColor = true;
            this.chkNewFile.CheckedChanged += new System.EventHandler(this.OutputType_CheckChange);
            // 
            // numPasswordCount
            // 
            this.numPasswordCount.Location = new System.Drawing.Point(133, 54);
            this.numPasswordCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPasswordCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPasswordCount.Name = "numPasswordCount";
            this.numPasswordCount.Size = new System.Drawing.Size(77, 20);
            this.numPasswordCount.TabIndex = 28;
            this.numPasswordCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPasswordCount
            // 
            this.lblPasswordCount.AutoSize = true;
            this.lblPasswordCount.Location = new System.Drawing.Point(11, 56);
            this.lblPasswordCount.Name = "lblPasswordCount";
            this.lblPasswordCount.Size = new System.Drawing.Size(115, 13);
            this.lblPasswordCount.TabIndex = 27;
            this.lblPasswordCount.Text = "Number Of Passwords:";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOutput.Location = new System.Drawing.Point(6, 22);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(394, 131);
            this.txtOutput.TabIndex = 29;
            this.txtOutput.WordWrap = false;
            // 
            // grpWords
            // 
            this.grpWords.Controls.Add(this.lblWordDictionary);
            this.grpWords.Controls.Add(this.ddlWordDictionary);
            this.grpWords.Controls.Add(this.lblPasswordCount);
            this.grpWords.Controls.Add(this.lblWordCount);
            this.grpWords.Controls.Add(this.numPasswordCount);
            this.grpWords.Controls.Add(this.numWordCount);
            this.grpWords.Controls.Add(this.numMinWordLen);
            this.grpWords.Controls.Add(this.lblMinWordLen);
            this.grpWords.Controls.Add(this.numMaxWordLen);
            this.grpWords.Controls.Add(this.lblMaxWordLen);
            this.grpWords.Location = new System.Drawing.Point(12, 12);
            this.grpWords.Name = "grpWords";
            this.grpWords.Size = new System.Drawing.Size(230, 168);
            this.grpWords.TabIndex = 31;
            this.grpWords.TabStop = false;
            this.grpWords.Text = "WORDS";
            // 
            // grpTransformation
            // 
            this.grpTransformation.Controls.Add(this.ddlTransformation);
            this.grpTransformation.Controls.Add(this.label1);
            this.grpTransformation.Location = new System.Drawing.Point(253, 12);
            this.grpTransformation.Name = "grpTransformation";
            this.grpTransformation.Size = new System.Drawing.Size(294, 69);
            this.grpTransformation.TabIndex = 32;
            this.grpTransformation.TabStop = false;
            this.grpTransformation.Text = "TRANSFORMATION";
            // 
            // ddlTransformation
            // 
            this.ddlTransformation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTransformation.FormattingEnabled = true;
            this.ddlTransformation.Items.AddRange(new object[] {
            "alternation WORD case",
            "Capitalise First Letter",
            "cAPITALISE eVERY lETTER eXCEPT tHe fIRST",
            "lower case",
            "UPPER CASE",
            "EVERY word randomly CAPITALISED or NOT"});
            this.ddlTransformation.Location = new System.Drawing.Point(96, 27);
            this.ddlTransformation.Name = "ddlTransformation";
            this.ddlTransformation.Size = new System.Drawing.Size(182, 21);
            this.ddlTransformation.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Transformation:";
            // 
            // grpSeparators
            // 
            this.grpSeparators.Controls.Add(this.btnSeparator_SemiColon);
            this.grpSeparators.Controls.Add(this.btnSeparator_Period);
            this.grpSeparators.Controls.Add(this.btnSeparator_Slash);
            this.grpSeparators.Controls.Add(this.btnSeparator_Question);
            this.grpSeparators.Controls.Add(this.btnSeparator_Tilda);
            this.grpSeparators.Controls.Add(this.btnSeparator_Pipe);
            this.grpSeparators.Controls.Add(this.btnSeparator_Colon);
            this.grpSeparators.Controls.Add(this.btnSeparator_Equals);
            this.grpSeparators.Controls.Add(this.btnSeparator_Plus);
            this.grpSeparators.Controls.Add(this.btnSeparator_Underscore);
            this.grpSeparators.Controls.Add(this.btnSeparator_Dash);
            this.grpSeparators.Controls.Add(this.btnSeparator_Star);
            this.grpSeparators.Controls.Add(this.btnSeparator_And);
            this.grpSeparators.Controls.Add(this.btnSeparator_Caret);
            this.grpSeparators.Controls.Add(this.btnSeparator_Percent);
            this.grpSeparators.Controls.Add(this.btnSeparator_Dollar);
            this.grpSeparators.Controls.Add(this.btnSeparator_At);
            this.grpSeparators.Controls.Add(this.btnSeparator_Exclamation);
            this.grpSeparators.Location = new System.Drawing.Point(253, 87);
            this.grpSeparators.Name = "grpSeparators";
            this.grpSeparators.Size = new System.Drawing.Size(294, 93);
            this.grpSeparators.TabIndex = 33;
            this.grpSeparators.TabStop = false;
            this.grpSeparators.Text = "SEPARATOR ALPHABET";
            // 
            // btnSeparator_SemiColon
            // 
            this.btnSeparator_SemiColon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_SemiColon.Location = new System.Drawing.Point(250, 53);
            this.btnSeparator_SemiColon.Name = "btnSeparator_SemiColon";
            this.btnSeparator_SemiColon.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_SemiColon.TabIndex = 51;
            this.btnSeparator_SemiColon.Tag = false;
            this.btnSeparator_SemiColon.Text = ";";
            this.btnSeparator_SemiColon.UseVisualStyleBackColor = true;
            this.btnSeparator_SemiColon.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Period
            // 
            this.btnSeparator_Period.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Period.Location = new System.Drawing.Point(221, 53);
            this.btnSeparator_Period.Name = "btnSeparator_Period";
            this.btnSeparator_Period.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Period.TabIndex = 50;
            this.btnSeparator_Period.Tag = false;
            this.btnSeparator_Period.Text = ".";
            this.btnSeparator_Period.UseVisualStyleBackColor = true;
            this.btnSeparator_Period.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Slash
            // 
            this.btnSeparator_Slash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Slash.Location = new System.Drawing.Point(192, 53);
            this.btnSeparator_Slash.Name = "btnSeparator_Slash";
            this.btnSeparator_Slash.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Slash.TabIndex = 49;
            this.btnSeparator_Slash.Tag = false;
            this.btnSeparator_Slash.Text = "/";
            this.btnSeparator_Slash.UseVisualStyleBackColor = true;
            this.btnSeparator_Slash.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Question
            // 
            this.btnSeparator_Question.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Question.Location = new System.Drawing.Point(165, 53);
            this.btnSeparator_Question.Name = "btnSeparator_Question";
            this.btnSeparator_Question.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Question.TabIndex = 48;
            this.btnSeparator_Question.Tag = false;
            this.btnSeparator_Question.Text = "?";
            this.btnSeparator_Question.UseVisualStyleBackColor = true;
            this.btnSeparator_Question.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Tilda
            // 
            this.btnSeparator_Tilda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Tilda.Location = new System.Drawing.Point(136, 53);
            this.btnSeparator_Tilda.Name = "btnSeparator_Tilda";
            this.btnSeparator_Tilda.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Tilda.TabIndex = 47;
            this.btnSeparator_Tilda.Tag = false;
            this.btnSeparator_Tilda.Text = "~";
            this.btnSeparator_Tilda.UseVisualStyleBackColor = true;
            this.btnSeparator_Tilda.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Pipe
            // 
            this.btnSeparator_Pipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Pipe.Location = new System.Drawing.Point(107, 53);
            this.btnSeparator_Pipe.Name = "btnSeparator_Pipe";
            this.btnSeparator_Pipe.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Pipe.TabIndex = 46;
            this.btnSeparator_Pipe.Tag = false;
            this.btnSeparator_Pipe.Text = "|";
            this.btnSeparator_Pipe.UseVisualStyleBackColor = true;
            this.btnSeparator_Pipe.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Colon
            // 
            this.btnSeparator_Colon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Colon.Location = new System.Drawing.Point(78, 53);
            this.btnSeparator_Colon.Name = "btnSeparator_Colon";
            this.btnSeparator_Colon.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Colon.TabIndex = 45;
            this.btnSeparator_Colon.Tag = false;
            this.btnSeparator_Colon.Text = ":";
            this.btnSeparator_Colon.UseVisualStyleBackColor = true;
            this.btnSeparator_Colon.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Equals
            // 
            this.btnSeparator_Equals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Equals.Location = new System.Drawing.Point(49, 53);
            this.btnSeparator_Equals.Name = "btnSeparator_Equals";
            this.btnSeparator_Equals.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Equals.TabIndex = 44;
            this.btnSeparator_Equals.Tag = false;
            this.btnSeparator_Equals.Text = "=";
            this.btnSeparator_Equals.UseVisualStyleBackColor = true;
            this.btnSeparator_Equals.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Plus
            // 
            this.btnSeparator_Plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Plus.Location = new System.Drawing.Point(20, 53);
            this.btnSeparator_Plus.Name = "btnSeparator_Plus";
            this.btnSeparator_Plus.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Plus.TabIndex = 43;
            this.btnSeparator_Plus.Tag = false;
            this.btnSeparator_Plus.Text = "+";
            this.btnSeparator_Plus.UseVisualStyleBackColor = true;
            this.btnSeparator_Plus.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Underscore
            // 
            this.btnSeparator_Underscore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Underscore.Location = new System.Drawing.Point(250, 24);
            this.btnSeparator_Underscore.Name = "btnSeparator_Underscore";
            this.btnSeparator_Underscore.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Underscore.TabIndex = 42;
            this.btnSeparator_Underscore.Tag = false;
            this.btnSeparator_Underscore.Text = "_";
            this.btnSeparator_Underscore.UseVisualStyleBackColor = true;
            this.btnSeparator_Underscore.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Dash
            // 
            this.btnSeparator_Dash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Dash.Location = new System.Drawing.Point(221, 24);
            this.btnSeparator_Dash.Name = "btnSeparator_Dash";
            this.btnSeparator_Dash.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Dash.TabIndex = 41;
            this.btnSeparator_Dash.Tag = false;
            this.btnSeparator_Dash.Text = "-";
            this.btnSeparator_Dash.UseVisualStyleBackColor = true;
            this.btnSeparator_Dash.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Star
            // 
            this.btnSeparator_Star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Star.Location = new System.Drawing.Point(192, 24);
            this.btnSeparator_Star.Name = "btnSeparator_Star";
            this.btnSeparator_Star.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Star.TabIndex = 40;
            this.btnSeparator_Star.Tag = false;
            this.btnSeparator_Star.Text = "*";
            this.btnSeparator_Star.UseVisualStyleBackColor = true;
            this.btnSeparator_Star.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_And
            // 
            this.btnSeparator_And.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_And.Location = new System.Drawing.Point(165, 24);
            this.btnSeparator_And.Name = "btnSeparator_And";
            this.btnSeparator_And.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_And.TabIndex = 39;
            this.btnSeparator_And.Tag = false;
            this.btnSeparator_And.Text = "&&";
            this.btnSeparator_And.UseVisualStyleBackColor = true;
            this.btnSeparator_And.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Caret
            // 
            this.btnSeparator_Caret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Caret.Location = new System.Drawing.Point(136, 24);
            this.btnSeparator_Caret.Name = "btnSeparator_Caret";
            this.btnSeparator_Caret.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Caret.TabIndex = 38;
            this.btnSeparator_Caret.Tag = false;
            this.btnSeparator_Caret.Text = "^";
            this.btnSeparator_Caret.UseVisualStyleBackColor = true;
            this.btnSeparator_Caret.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Percent
            // 
            this.btnSeparator_Percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Percent.Location = new System.Drawing.Point(107, 24);
            this.btnSeparator_Percent.Name = "btnSeparator_Percent";
            this.btnSeparator_Percent.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Percent.TabIndex = 37;
            this.btnSeparator_Percent.Tag = false;
            this.btnSeparator_Percent.Text = "%";
            this.btnSeparator_Percent.UseVisualStyleBackColor = true;
            this.btnSeparator_Percent.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Dollar
            // 
            this.btnSeparator_Dollar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Dollar.Location = new System.Drawing.Point(78, 24);
            this.btnSeparator_Dollar.Name = "btnSeparator_Dollar";
            this.btnSeparator_Dollar.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Dollar.TabIndex = 36;
            this.btnSeparator_Dollar.Tag = false;
            this.btnSeparator_Dollar.Text = "$";
            this.btnSeparator_Dollar.UseVisualStyleBackColor = true;
            this.btnSeparator_Dollar.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_At
            // 
            this.btnSeparator_At.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_At.Location = new System.Drawing.Point(49, 24);
            this.btnSeparator_At.Name = "btnSeparator_At";
            this.btnSeparator_At.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_At.TabIndex = 35;
            this.btnSeparator_At.Tag = false;
            this.btnSeparator_At.Text = "@";
            this.btnSeparator_At.UseVisualStyleBackColor = true;
            this.btnSeparator_At.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // btnSeparator_Exclamation
            // 
            this.btnSeparator_Exclamation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparator_Exclamation.Location = new System.Drawing.Point(20, 24);
            this.btnSeparator_Exclamation.Name = "btnSeparator_Exclamation";
            this.btnSeparator_Exclamation.Size = new System.Drawing.Size(23, 23);
            this.btnSeparator_Exclamation.TabIndex = 34;
            this.btnSeparator_Exclamation.Tag = false;
            this.btnSeparator_Exclamation.Text = "!";
            this.btnSeparator_Exclamation.UseVisualStyleBackColor = true;
            this.btnSeparator_Exclamation.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // grpPaddingDigits
            // 
            this.grpPaddingDigits.Controls.Add(this.lblPaddingDigitsBefore);
            this.grpPaddingDigits.Controls.Add(this.numPaddingDigitsBefore);
            this.grpPaddingDigits.Controls.Add(this.numPaddingDigitsAfter);
            this.grpPaddingDigits.Controls.Add(this.lblPaddingDigitsAfter);
            this.grpPaddingDigits.Location = new System.Drawing.Point(12, 186);
            this.grpPaddingDigits.Name = "grpPaddingDigits";
            this.grpPaddingDigits.Size = new System.Drawing.Size(230, 115);
            this.grpPaddingDigits.TabIndex = 34;
            this.grpPaddingDigits.TabStop = false;
            this.grpPaddingDigits.Text = "PADDING DIGITS";
            // 
            // grpPaddingSymbols
            // 
            this.grpPaddingSymbols.Controls.Add(this.numPaddingSymbolsBefore);
            this.grpPaddingSymbols.Controls.Add(this.lblPaddingSymbolsBefore);
            this.grpPaddingSymbols.Controls.Add(this.numPaddingSymbolsAfter);
            this.grpPaddingSymbols.Controls.Add(this.lblPaddingSymbolsAfter);
            this.grpPaddingSymbols.Location = new System.Drawing.Point(253, 186);
            this.grpPaddingSymbols.Name = "grpPaddingSymbols";
            this.grpPaddingSymbols.Size = new System.Drawing.Size(294, 115);
            this.grpPaddingSymbols.TabIndex = 35;
            this.grpPaddingSymbols.TabStop = false;
            this.grpPaddingSymbols.Text = "PADDING SYMBOLS";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblOther);
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Controls.Add(this.btnGenerate);
            this.grpOutput.Controls.Add(this.chkAppendToStart);
            this.grpOutput.Controls.Add(this.chkSaveToClipboard);
            this.grpOutput.Controls.Add(this.chkAppendToEnd);
            this.grpOutput.Controls.Add(this.chkNewFile);
            this.grpOutput.Location = new System.Drawing.Point(12, 307);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(535, 170);
            this.grpOutput.TabIndex = 36;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "OUTPUT";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(406, 22);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(36, 13);
            this.lblOther.TabIndex = 30;
            this.lblOther.Text = "Other:";
            // 
            // lnkxkPasswdLink
            // 
            this.lnkxkPasswdLink.AutoSize = true;
            this.lnkxkPasswdLink.Location = new System.Drawing.Point(68, 480);
            this.lnkxkPasswdLink.Name = "lnkxkPasswdLink";
            this.lnkxkPasswdLink.Size = new System.Drawing.Size(55, 13);
            this.lnkxkPasswdLink.TabIndex = 37;
            this.lnkxkPasswdLink.TabStop = true;
            this.lnkxkPasswdLink.Text = "xkPasswd";
            this.lnkxkPasswdLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkxkPasswd_LinkClicked);
            // 
            // lblInspiredBy
            // 
            this.lblInspiredBy.AutoSize = true;
            this.lblInspiredBy.Location = new System.Drawing.Point(9, 480);
            this.lblInspiredBy.Name = "lblInspiredBy";
            this.lblInspiredBy.Size = new System.Drawing.Size(62, 13);
            this.lblInspiredBy.TabIndex = 38;
            this.lblInspiredBy.Text = "Inspired By:";
            this.lblInspiredBy.Click += new System.EventHandler(this.lblInspiredBy_Click);
            // 
            // frmGeneratePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 502);
            this.Controls.Add(this.lnkGitHubLink);
            this.Controls.Add(this.lnkxkPasswdLink);
            this.Controls.Add(this.lblInspiredBy);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpPaddingSymbols);
            this.Controls.Add(this.grpPaddingDigits);
            this.Controls.Add(this.grpSeparators);
            this.Controls.Add(this.grpTransformation);
            this.Controls.Add(this.grpWords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGeneratePassword";
            this.Text = "xkPasswd";
            this.Load += new System.EventHandler(this.frmGeneratePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinWordLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxWordLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaddingDigitsBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaddingDigitsAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaddingSymbolsBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaddingSymbolsAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordCount)).EndInit();
            this.grpWords.ResumeLayout(false);
            this.grpWords.PerformLayout();
            this.grpTransformation.ResumeLayout(false);
            this.grpTransformation.PerformLayout();
            this.grpSeparators.ResumeLayout(false);
            this.grpPaddingDigits.ResumeLayout(false);
            this.grpPaddingDigits.PerformLayout();
            this.grpPaddingSymbols.ResumeLayout(false);
            this.grpPaddingSymbols.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkAppendToStart;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.LinkLabel lnkGitHubLink;
        private System.Windows.Forms.CheckBox chkSaveToClipboard;
        private System.Windows.Forms.NumericUpDown numWordCount;
        private System.Windows.Forms.ComboBox ddlWordDictionary;
        private System.Windows.Forms.Label lblWordDictionary;
        private System.Windows.Forms.NumericUpDown numMinWordLen;
        private System.Windows.Forms.Label lblMinWordLen;
        private System.Windows.Forms.NumericUpDown numMaxWordLen;
        private System.Windows.Forms.Label lblMaxWordLen;
        private System.Windows.Forms.NumericUpDown numPaddingDigitsBefore;
        private System.Windows.Forms.Label lblPaddingDigitsBefore;
        private System.Windows.Forms.NumericUpDown numPaddingDigitsAfter;
        private System.Windows.Forms.Label lblPaddingDigitsAfter;
        private System.Windows.Forms.NumericUpDown numPaddingSymbolsBefore;
        private System.Windows.Forms.Label lblPaddingSymbolsBefore;
        private System.Windows.Forms.NumericUpDown numPaddingSymbolsAfter;
        private System.Windows.Forms.Label lblPaddingSymbolsAfter;
        private System.Windows.Forms.CheckBox chkAppendToEnd;
        private System.Windows.Forms.CheckBox chkNewFile;
        private System.Windows.Forms.NumericUpDown numPasswordCount;
        private System.Windows.Forms.Label lblPasswordCount;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox grpWords;
        private System.Windows.Forms.GroupBox grpTransformation;
        private System.Windows.Forms.ComboBox ddlTransformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSeparators;
        private System.Windows.Forms.GroupBox grpPaddingDigits;
        private System.Windows.Forms.GroupBox grpPaddingSymbols;
        private System.Windows.Forms.Button btnSeparator_Exclamation;
        private System.Windows.Forms.Button btnSeparator_At;
        private System.Windows.Forms.Button btnSeparator_SemiColon;
        private System.Windows.Forms.Button btnSeparator_Period;
        private System.Windows.Forms.Button btnSeparator_Slash;
        private System.Windows.Forms.Button btnSeparator_Question;
        private System.Windows.Forms.Button btnSeparator_Tilda;
        private System.Windows.Forms.Button btnSeparator_Pipe;
        private System.Windows.Forms.Button btnSeparator_Colon;
        private System.Windows.Forms.Button btnSeparator_Equals;
        private System.Windows.Forms.Button btnSeparator_Plus;
        private System.Windows.Forms.Button btnSeparator_Underscore;
        private System.Windows.Forms.Button btnSeparator_Dash;
        private System.Windows.Forms.Button btnSeparator_Star;
        private System.Windows.Forms.Button btnSeparator_And;
        private System.Windows.Forms.Button btnSeparator_Caret;
        private System.Windows.Forms.Button btnSeparator_Percent;
        private System.Windows.Forms.Button btnSeparator_Dollar;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.LinkLabel lnkxkPasswdLink;
        private System.Windows.Forms.Label lblInspiredBy;
    }
}