namespace MJLFO_v2_0
{
    partial class MJLFO_v2_0
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">Prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.inputBrowse = new System.Windows.Forms.Button();
            this.inputPath = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputPath = new System.Windows.Forms.TextBox();
            this.labelKeepOnlyMessages = new System.Windows.Forms.Label();
            this.addKeepOnlyMessages = new System.Windows.Forms.Button();
            this.removeKeepOnlyMessages = new System.Windows.Forms.Button();
            this.listKeepOnlyMessages = new System.Windows.Forms.ListBox();
            this.previewLabel = new System.Windows.Forms.Label();
            this.preview = new System.Windows.Forms.Button();
            this.outputSave = new System.Windows.Forms.Button();
            this.outputSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.previewTimer = new System.Windows.Forms.Timer(this.components);
            this.encodingLabel = new System.Windows.Forms.Label();
            this.listGetRidMessages = new System.Windows.Forms.ListBox();
            this.inputGetRidMessages = new System.Windows.Forms.TextBox();
            this.removeGetRidMessages = new System.Windows.Forms.Button();
            this.addGetRidMessages = new System.Windows.Forms.Button();
            this.labelGetRidMessages = new System.Windows.Forms.Label();
            this.listGetRidStrings = new System.Windows.Forms.ListBox();
            this.inputGetRidStrings = new System.Windows.Forms.TextBox();
            this.removeGetRidStrings = new System.Windows.Forms.Button();
            this.addGetRidStrings = new System.Windows.Forms.Button();
            this.labelGetRidStrings = new System.Windows.Forms.Label();
            this.mainToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.inputSetPath = new System.Windows.Forms.Button();
            this.encodingSelectBorder = new System.Windows.Forms.Panel();
            this.outputBoxBorder = new System.Windows.Forms.Panel();
            this.listKeepOnlyMessagesBorder = new System.Windows.Forms.Panel();
            this.listGetRidMessagesBorder = new System.Windows.Forms.Panel();
            this.listGetRidStringsBorder = new System.Windows.Forms.Panel();
            this.encodingSelect = new System.Windows.Forms.ComboBox();
            this.inputKeepOnlyMessages = new System.Windows.Forms.TextBox();
            this.footerGitHubTimer = new System.Windows.Forms.Timer(this.components);
            this.inputSetPathTimer = new System.Windows.Forms.Timer(this.components);
            this.inputBrowseTimer = new System.Windows.Forms.Timer(this.components);
            this.footerGitHub = new System.Windows.Forms.PictureBox();
            this.footer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.footerGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footer)).BeginInit();
            this.SuspendLayout();
            // 
            // inputOpenFile
            // 
            this.inputOpenFile.Filter = "Log files (*.log)|*.log|All files (*.*)|*.*";
            this.inputOpenFile.Title = "Minecraft Java Log File Organizer - Browse";
            // 
            // inputBrowse
            // 
            this.inputBrowse.BackColor = System.Drawing.SystemColors.Window;
            this.inputBrowse.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.inputBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputBrowse.Font = new System.Drawing.Font("Arial", 12F);
            this.inputBrowse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputBrowse.Location = new System.Drawing.Point(748, 17);
            this.inputBrowse.Name = "inputBrowse";
            this.inputBrowse.Size = new System.Drawing.Size(26, 26);
            this.inputBrowse.TabIndex = 3;
            this.mainToolTips.SetToolTip(this.inputBrowse, "Browse");
            this.inputBrowse.UseVisualStyleBackColor = false;
            this.inputBrowse.Click += new System.EventHandler(this.inputBrowse_Click);
            // 
            // inputPath
            // 
            this.inputPath.BackColor = System.Drawing.SystemColors.Window;
            this.inputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPath.Font = new System.Drawing.Font("Arial", 12F);
            this.inputPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputPath.Location = new System.Drawing.Point(61, 17);
            this.inputPath.MaxLength = 2147483647;
            this.inputPath.Name = "inputPath";
            this.inputPath.ReadOnly = true;
            this.inputPath.Size = new System.Drawing.Size(649, 26);
            this.inputPath.TabIndex = 1;
            // 
            // inputLabel
            // 
            this.inputLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.inputLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputLabel.Location = new System.Drawing.Point(17, 17);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(50, 26);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input:";
            this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainToolTips.SetToolTip(this.inputLabel, "The system path of where the source file is read from.");
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.Window;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.Font = new System.Drawing.Font("Arial", 12F);
            this.outputBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.outputBox.Location = new System.Drawing.Point(21, 246);
            this.outputBox.MaxLength = 2147483647;
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(752, 198);
            this.outputBox.TabIndex = 28;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.outputLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.outputLabel.Location = new System.Drawing.Point(16, 462);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(63, 26);
            this.outputLabel.TabIndex = 29;
            this.outputLabel.Text = "Output:";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainToolTips.SetToolTip(this.outputLabel, "The system path of where the destination file is written to.\r\n\"yyyy-MM-dd_HH-mm-s" +
        "s\" is set from your system\'s date and time.");
            // 
            // outputPath
            // 
            this.outputPath.BackColor = System.Drawing.SystemColors.Window;
            this.outputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPath.Font = new System.Drawing.Font("Arial", 12F);
            this.outputPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.outputPath.Location = new System.Drawing.Point(73, 462);
            this.outputPath.MaxLength = 2147483647;
            this.outputPath.Name = "outputPath";
            this.outputPath.ReadOnly = true;
            this.outputPath.Size = new System.Drawing.Size(669, 26);
            this.outputPath.TabIndex = 30;
            // 
            // labelKeepOnlyMessages
            // 
            this.labelKeepOnlyMessages.BackColor = System.Drawing.Color.Transparent;
            this.labelKeepOnlyMessages.Font = new System.Drawing.Font("Arial", 12F);
            this.labelKeepOnlyMessages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelKeepOnlyMessages.Location = new System.Drawing.Point(16, 60);
            this.labelKeepOnlyMessages.Name = "labelKeepOnlyMessages";
            this.labelKeepOnlyMessages.Size = new System.Drawing.Size(164, 26);
            this.labelKeepOnlyMessages.TabIndex = 4;
            this.labelKeepOnlyMessages.Text = "Keep only messages:";
            this.labelKeepOnlyMessages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainToolTips.SetToolTip(this.labelKeepOnlyMessages, "Only keep the messages with at least one occurrence of any string from the list b" +
        "elow.\r\nCase-sensitive, leave empty if you want the program to keep every message" +
        ".");
            // 
            // addKeepOnlyMessages
            // 
            this.addKeepOnlyMessages.BackColor = System.Drawing.SystemColors.Window;
            this.addKeepOnlyMessages.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.addKeepOnlyMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addKeepOnlyMessages.Font = new System.Drawing.Font("Arial", 12F);
            this.addKeepOnlyMessages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.addKeepOnlyMessages.Location = new System.Drawing.Point(202, 88);
            this.addKeepOnlyMessages.Name = "addKeepOnlyMessages";
            this.addKeepOnlyMessages.Size = new System.Drawing.Size(26, 26);
            this.addKeepOnlyMessages.TabIndex = 6;
            this.mainToolTips.SetToolTip(this.addKeepOnlyMessages, "Add");
            this.addKeepOnlyMessages.UseVisualStyleBackColor = false;
            this.addKeepOnlyMessages.Click += new System.EventHandler(this.addKeepOnly_Click);
            // 
            // removeKeepOnlyMessages
            // 
            this.removeKeepOnlyMessages.BackColor = System.Drawing.SystemColors.Window;
            this.removeKeepOnlyMessages.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.removeKeepOnlyMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeKeepOnlyMessages.Font = new System.Drawing.Font("Arial", 12F);
            this.removeKeepOnlyMessages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.removeKeepOnlyMessages.Location = new System.Drawing.Point(234, 88);
            this.removeKeepOnlyMessages.Name = "removeKeepOnlyMessages";
            this.removeKeepOnlyMessages.Size = new System.Drawing.Size(26, 26);
            this.removeKeepOnlyMessages.TabIndex = 7;
            this.mainToolTips.SetToolTip(this.removeKeepOnlyMessages, "Remove");
            this.removeKeepOnlyMessages.UseVisualStyleBackColor = false;
            this.removeKeepOnlyMessages.Click += new System.EventHandler(this.removeKeepOnly_Click);
            // 
            // listKeepOnlyMessages
            // 
            this.listKeepOnlyMessages.BackColor = System.Drawing.SystemColors.Window;
            this.listKeepOnlyMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listKeepOnlyMessages.Font = new System.Drawing.Font("Arial", 12F);
            this.listKeepOnlyMessages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listKeepOnlyMessages.FormattingEnabled = true;
            this.listKeepOnlyMessages.ItemHeight = 18;
            this.listKeepOnlyMessages.Location = new System.Drawing.Point(21, 121);
            this.listKeepOnlyMessages.Name = "listKeepOnlyMessages";
            this.listKeepOnlyMessages.ScrollAlwaysVisible = true;
            this.listKeepOnlyMessages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listKeepOnlyMessages.Size = new System.Drawing.Size(238, 72);
            this.listKeepOnlyMessages.TabIndex = 9;
            // 
            // previewLabel
            // 
            this.previewLabel.BackColor = System.Drawing.Color.Transparent;
            this.previewLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.previewLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.previewLabel.Location = new System.Drawing.Point(546, 211);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(200, 28);
            this.previewLabel.TabIndex = 25;
            this.previewLabel.Text = "Preview your output below:";
            this.previewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainToolTips.SetToolTip(this.previewLabel, "Click the button on the right to see the output before saving.");
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.SystemColors.Window;
            this.preview.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preview.Font = new System.Drawing.Font("Arial", 12F);
            this.preview.ForeColor = System.Drawing.SystemColors.WindowText;
            this.preview.Location = new System.Drawing.Point(746, 211);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(28, 28);
            this.preview.TabIndex = 26;
            this.mainToolTips.SetToolTip(this.preview, "Preview");
            this.preview.UseVisualStyleBackColor = false;
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // outputSave
            // 
            this.outputSave.BackColor = System.Drawing.SystemColors.Window;
            this.outputSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.outputSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputSave.Font = new System.Drawing.Font("Arial", 12F);
            this.outputSave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.outputSave.Location = new System.Drawing.Point(748, 462);
            this.outputSave.Name = "outputSave";
            this.outputSave.Size = new System.Drawing.Size(26, 26);
            this.outputSave.TabIndex = 31;
            this.mainToolTips.SetToolTip(this.outputSave, "Save");
            this.outputSave.UseVisualStyleBackColor = false;
            this.outputSave.Click += new System.EventHandler(this.outputSave_Click);
            // 
            // outputSaveTimer
            // 
            this.outputSaveTimer.Interval = 2000;
            this.outputSaveTimer.Tick += new System.EventHandler(this.outputSaveTimer_Tick);
            // 
            // previewTimer
            // 
            this.previewTimer.Interval = 2000;
            this.previewTimer.Tick += new System.EventHandler(this.previewTimer_Tick);
            // 
            // encodingLabel
            // 
            this.encodingLabel.BackColor = System.Drawing.Color.Transparent;
            this.encodingLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.encodingLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.encodingLabel.Location = new System.Drawing.Point(16, 211);
            this.encodingLabel.Name = "encodingLabel";
            this.encodingLabel.Size = new System.Drawing.Size(84, 28);
            this.encodingLabel.TabIndex = 22;
            this.encodingLabel.Text = "Encoding:";
            this.encodingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainToolTips.SetToolTip(this.encodingLabel, "The program\'s way of reading and writing characters.");
            // 
            // listGetRidMessages
            // 
            this.listGetRidMessages.BackColor = System.Drawing.SystemColors.Window;
            this.listGetRidMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listGetRidMessages.Font = new System.Drawing.Font("Arial", 12F);
            this.listGetRidMessages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listGetRidMessages.FormattingEnabled = true;
            this.listGetRidMessages.ItemHeight = 18;
            this.listGetRidMessages.Location = new System.Drawing.Point(278, 121);
            this.listGetRidMessages.Name = "listGetRidMessages";
            this.listGetRidMessages.ScrollAlwaysVisible = true;
            this.listGetRidMessages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listGetRidMessages.Size = new System.Drawing.Size(238, 72);
            this.listGetRidMessages.TabIndex = 15;
            // 
            // inputGetRidMessages
            // 
            this.inputGetRidMessages.BackColor = System.Drawing.SystemColors.Window;
            this.inputGetRidMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputGetRidMessages.Font = new System.Drawing.Font("Arial", 12F);
            this.inputGetRidMessages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputGetRidMessages.Location = new System.Drawing.Point(277, 88);
            this.inputGetRidMessages.MaxLength = 2147483647;
            this.inputGetRidMessages.Name = "inputGetRidMessages";
            this.inputGetRidMessages.Size = new System.Drawing.Size(176, 26);
            this.inputGetRidMessages.TabIndex = 11;
            // 
            // removeGetRidMessages
            // 
            this.removeGetRidMessages.BackColor = System.Drawing.SystemColors.Window;
            this.removeGetRidMessages.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.removeGetRidMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeGetRidMessages.Font = new System.Drawing.Font("Arial", 12F);
            this.removeGetRidMessages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.removeGetRidMessages.Location = new System.Drawing.Point(491, 88);
            this.removeGetRidMessages.Name = "removeGetRidMessages";
            this.removeGetRidMessages.Size = new System.Drawing.Size(26, 26);
            this.removeGetRidMessages.TabIndex = 13;
            this.mainToolTips.SetToolTip(this.removeGetRidMessages, "Remove");
            this.removeGetRidMessages.UseVisualStyleBackColor = false;
            this.removeGetRidMessages.Click += new System.EventHandler(this.removeGetRidMessages_Click);
            // 
            // addGetRidMessages
            // 
            this.addGetRidMessages.BackColor = System.Drawing.SystemColors.Window;
            this.addGetRidMessages.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.addGetRidMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGetRidMessages.Font = new System.Drawing.Font("Arial", 12F);
            this.addGetRidMessages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.addGetRidMessages.Location = new System.Drawing.Point(459, 88);
            this.addGetRidMessages.Name = "addGetRidMessages";
            this.addGetRidMessages.Size = new System.Drawing.Size(26, 26);
            this.addGetRidMessages.TabIndex = 12;
            this.mainToolTips.SetToolTip(this.addGetRidMessages, "Add");
            this.addGetRidMessages.UseVisualStyleBackColor = false;
            this.addGetRidMessages.Click += new System.EventHandler(this.addGetRidMessages_Click);
            // 
            // labelGetRidMessages
            // 
            this.labelGetRidMessages.BackColor = System.Drawing.Color.Transparent;
            this.labelGetRidMessages.Font = new System.Drawing.Font("Arial", 12F);
            this.labelGetRidMessages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelGetRidMessages.Location = new System.Drawing.Point(273, 60);
            this.labelGetRidMessages.Name = "labelGetRidMessages";
            this.labelGetRidMessages.Size = new System.Drawing.Size(142, 26);
            this.labelGetRidMessages.TabIndex = 10;
            this.labelGetRidMessages.Text = "Get rid messages:";
            this.labelGetRidMessages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainToolTips.SetToolTip(this.labelGetRidMessages, "Remove all the messages with at least one occurrence of any string from the list " +
        "below.\r\nCase-sensitive, leave empty if you don\'t want the program to remove any " +
        "message.");
            // 
            // listGetRidStrings
            // 
            this.listGetRidStrings.BackColor = System.Drawing.SystemColors.Window;
            this.listGetRidStrings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listGetRidStrings.Font = new System.Drawing.Font("Arial", 12F);
            this.listGetRidStrings.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listGetRidStrings.FormattingEnabled = true;
            this.listGetRidStrings.ItemHeight = 18;
            this.listGetRidStrings.Location = new System.Drawing.Point(535, 121);
            this.listGetRidStrings.Name = "listGetRidStrings";
            this.listGetRidStrings.ScrollAlwaysVisible = true;
            this.listGetRidStrings.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listGetRidStrings.Size = new System.Drawing.Size(238, 72);
            this.listGetRidStrings.TabIndex = 21;
            // 
            // inputGetRidStrings
            // 
            this.inputGetRidStrings.BackColor = System.Drawing.SystemColors.Window;
            this.inputGetRidStrings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputGetRidStrings.Font = new System.Drawing.Font("Arial", 12F);
            this.inputGetRidStrings.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputGetRidStrings.Location = new System.Drawing.Point(534, 88);
            this.inputGetRidStrings.MaxLength = 2147483647;
            this.inputGetRidStrings.Name = "inputGetRidStrings";
            this.inputGetRidStrings.Size = new System.Drawing.Size(176, 26);
            this.inputGetRidStrings.TabIndex = 17;
            // 
            // removeGetRidStrings
            // 
            this.removeGetRidStrings.BackColor = System.Drawing.SystemColors.Window;
            this.removeGetRidStrings.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.removeGetRidStrings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeGetRidStrings.Font = new System.Drawing.Font("Arial", 12F);
            this.removeGetRidStrings.ForeColor = System.Drawing.SystemColors.WindowText;
            this.removeGetRidStrings.Location = new System.Drawing.Point(748, 88);
            this.removeGetRidStrings.Name = "removeGetRidStrings";
            this.removeGetRidStrings.Size = new System.Drawing.Size(26, 26);
            this.removeGetRidStrings.TabIndex = 19;
            this.mainToolTips.SetToolTip(this.removeGetRidStrings, "Remove");
            this.removeGetRidStrings.UseVisualStyleBackColor = false;
            this.removeGetRidStrings.Click += new System.EventHandler(this.removeGetRidStrings_Click);
            // 
            // addGetRidStrings
            // 
            this.addGetRidStrings.BackColor = System.Drawing.SystemColors.Window;
            this.addGetRidStrings.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.addGetRidStrings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGetRidStrings.Font = new System.Drawing.Font("Arial", 12F);
            this.addGetRidStrings.ForeColor = System.Drawing.SystemColors.WindowText;
            this.addGetRidStrings.Location = new System.Drawing.Point(716, 88);
            this.addGetRidStrings.Name = "addGetRidStrings";
            this.addGetRidStrings.Size = new System.Drawing.Size(26, 26);
            this.addGetRidStrings.TabIndex = 18;
            this.mainToolTips.SetToolTip(this.addGetRidStrings, "Add");
            this.addGetRidStrings.UseVisualStyleBackColor = false;
            this.addGetRidStrings.Click += new System.EventHandler(this.addGetRidStrings_Click);
            // 
            // labelGetRidStrings
            // 
            this.labelGetRidStrings.BackColor = System.Drawing.Color.Transparent;
            this.labelGetRidStrings.Font = new System.Drawing.Font("Arial", 12F);
            this.labelGetRidStrings.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelGetRidStrings.Location = new System.Drawing.Point(530, 60);
            this.labelGetRidStrings.Name = "labelGetRidStrings";
            this.labelGetRidStrings.Size = new System.Drawing.Size(115, 26);
            this.labelGetRidStrings.TabIndex = 16;
            this.labelGetRidStrings.Text = "Get rid strings:";
            this.labelGetRidStrings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainToolTips.SetToolTip(this.labelGetRidStrings, "Remove all the strings included on the list below from all of the messages.\r\nCase" +
        "-sensitive, leave empty if you\'re fine with the program\'s default message organi" +
        "zing.");
            // 
            // inputSetPath
            // 
            this.inputSetPath.BackColor = System.Drawing.SystemColors.Window;
            this.inputSetPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.inputSetPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputSetPath.Font = new System.Drawing.Font("Arial", 12F);
            this.inputSetPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputSetPath.Location = new System.Drawing.Point(716, 17);
            this.inputSetPath.Name = "inputSetPath";
            this.inputSetPath.Size = new System.Drawing.Size(26, 26);
            this.inputSetPath.TabIndex = 2;
            this.mainToolTips.SetToolTip(this.inputSetPath, "Set path");
            this.inputSetPath.UseVisualStyleBackColor = false;
            this.inputSetPath.Click += new System.EventHandler(this.inputSetPath_Click);
            // 
            // encodingSelectBorder
            // 
            this.encodingSelectBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encodingSelectBorder.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.encodingSelectBorder.Location = new System.Drawing.Point(94, 211);
            this.encodingSelectBorder.Name = "encodingSelectBorder";
            this.encodingSelectBorder.Size = new System.Drawing.Size(277, 28);
            this.encodingSelectBorder.TabIndex = 23;
            // 
            // outputBoxBorder
            // 
            this.outputBoxBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBoxBorder.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.outputBoxBorder.Location = new System.Drawing.Point(20, 245);
            this.outputBoxBorder.Name = "outputBoxBorder";
            this.outputBoxBorder.Size = new System.Drawing.Size(754, 200);
            this.outputBoxBorder.TabIndex = 27;
            // 
            // listKeepOnlyMessagesBorder
            // 
            this.listKeepOnlyMessagesBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listKeepOnlyMessagesBorder.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listKeepOnlyMessagesBorder.Location = new System.Drawing.Point(20, 120);
            this.listKeepOnlyMessagesBorder.Name = "listKeepOnlyMessagesBorder";
            this.listKeepOnlyMessagesBorder.Size = new System.Drawing.Size(240, 74);
            this.listKeepOnlyMessagesBorder.TabIndex = 8;
            // 
            // listGetRidMessagesBorder
            // 
            this.listGetRidMessagesBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listGetRidMessagesBorder.Location = new System.Drawing.Point(277, 120);
            this.listGetRidMessagesBorder.Name = "listGetRidMessagesBorder";
            this.listGetRidMessagesBorder.Size = new System.Drawing.Size(240, 74);
            this.listGetRidMessagesBorder.TabIndex = 14;
            // 
            // listGetRidStringsBorder
            // 
            this.listGetRidStringsBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listGetRidStringsBorder.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listGetRidStringsBorder.Location = new System.Drawing.Point(534, 120);
            this.listGetRidStringsBorder.Name = "listGetRidStringsBorder";
            this.listGetRidStringsBorder.Size = new System.Drawing.Size(240, 74);
            this.listGetRidStringsBorder.TabIndex = 20;
            // 
            // encodingSelect
            // 
            this.encodingSelect.BackColor = System.Drawing.SystemColors.Window;
            this.encodingSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encodingSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encodingSelect.Font = new System.Drawing.Font("Arial", 12F);
            this.encodingSelect.ForeColor = System.Drawing.SystemColors.WindowText;
            this.encodingSelect.FormattingEnabled = true;
            this.encodingSelect.IntegralHeight = false;
            this.encodingSelect.ItemHeight = 18;
            this.encodingSelect.Items.AddRange(new object[] {
            "[Local encoding of your system]",
            "Arabic (Macintosh)",
            "Arabic (ISO 8859-6)",
            "Arabic (Windows-1256)",
            "Chinese [Simplified] (Macintosh)",
            "Chinese [Simplified] (GB2312)",
            "Chinese [Simplified] (GB2312-80)",
            "Chinese [Simplified] (HZ-GB2312)",
            "Chinese [Simplified] (GB18030)",
            "Chinese [Simplified] (ISO-2022-CN)",
            "Chinese [Simplified] (EUC-CN)",
            "Chinese [Traditional] (Macintosh)",
            "Chinese [Traditional] (BIG5)",
            "Chinese [Traditional] (CNS)",
            "Cyrillic (Macintosh Cyrillic)",
            "Cyrillic (Macintosh Ukrainian)",
            "Cyrillic (KOI8-R)",
            "Cyrillic (KOI8-U)",
            "Cyrillic (ISO 8859-5)",
            "Cyrillic (Windows-1251)",
            "Europe (Macintosh Croatian)",
            "Europe (Macintosh Icelandic)",
            "Europe (Macintosh Romanian)",
            "Europe [Central] (Macintosh)",
            "Europe [Central] (ISO 8859-2)",
            "Europe [Central] (Windows-1250)",
            "Europe [Northern] (ISO 8859-4)",
            "Europe [Northern] (ISO 8859-13)",
            "Europe [Northern] (Windows-1257)",
            "Europe [Southern] (ISO 8859-3)",
            "Europe [Western] (Macintosh)",
            "Europe [Western] (ISO 8859-1)",
            "Europe [Western] (ISO 8859-15)",
            "Europe [Western] (Windows-1252)",
            "Greek (Macintosh)",
            "Greek (ISO 8859-7)",
            "Greek (Windows-1253)",
            "Hebrew (Macintosh)",
            "Hebrew (ISO 8859-8)",
            "Hebrew (ISO 8859-8-I)",
            "Hebrew (Windows-1255)",
            "Indian [Devanagari] (ISCII-DE)",
            "Indian [Bangla] (ISCII-BE)",
            "Indian [Tamil] (ISCII-TA)",
            "Indian [Telugu] (ISCII-TE)",
            "Indian [Assamese] (ISCII-AS)",
            "Indian [Odia] (ISCII-OR)",
            "Indian [Kannada] (ISCII-KA)",
            "Indian [Malayalam] (ISCII-MA)",
            "Indian [Gujarati] (ISCII-GU)",
            "Indian [Punjabi] (ISCII-PA)",
            "Japanese (Macintosh)",
            "Japanese (Shift-JIS)",
            "Japanese (ISO-2022-JP)",
            "Japanese (EUC-JP)",
            "Korean (Macintosh)",
            "Korean (Windows-949)",
            "Korean (ISO-2022-KR)",
            "Korean (EUC-KR)",
            "Thai (Macintosh)",
            "Thai (Windows-874)",
            "Turkish (Macintosh)",
            "Turkish (ISO 8859-9)",
            "Turkish (Windows-1254)",
            "Vietnamese (Windows-1258)"});
            this.encodingSelect.Location = new System.Drawing.Point(95, 212);
            this.encodingSelect.Name = "encodingSelect";
            this.encodingSelect.Size = new System.Drawing.Size(275, 26);
            this.encodingSelect.TabIndex = 24;
            this.encodingSelect.SelectedIndexChanged += new System.EventHandler(this.encodingSelect_SelectedIndexChanged);
            // 
            // inputKeepOnlyMessages
            // 
            this.inputKeepOnlyMessages.BackColor = System.Drawing.SystemColors.Window;
            this.inputKeepOnlyMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputKeepOnlyMessages.Font = new System.Drawing.Font("Arial", 12F);
            this.inputKeepOnlyMessages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputKeepOnlyMessages.Location = new System.Drawing.Point(20, 88);
            this.inputKeepOnlyMessages.MaxLength = 2147483647;
            this.inputKeepOnlyMessages.Name = "inputKeepOnlyMessages";
            this.inputKeepOnlyMessages.Size = new System.Drawing.Size(176, 26);
            this.inputKeepOnlyMessages.TabIndex = 5;
            // 
            // footerGitHubTimer
            // 
            this.footerGitHubTimer.Interval = 2000;
            this.footerGitHubTimer.Tick += new System.EventHandler(this.footerGitHubTimer_Tick);
            // 
            // inputSetPathTimer
            // 
            this.inputSetPathTimer.Interval = 2000;
            this.inputSetPathTimer.Tick += new System.EventHandler(this.inputSetPathTimer_Tick);
            // 
            // inputBrowseTimer
            // 
            this.inputBrowseTimer.Interval = 2000;
            this.inputBrowseTimer.Tick += new System.EventHandler(this.inputBrowseTimer_Tick);
            // 
            // footerGitHub
            // 
            this.footerGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.footerGitHub.Location = new System.Drawing.Point(422, 532);
            this.footerGitHub.Name = "footerGitHub";
            this.footerGitHub.Size = new System.Drawing.Size(285, 24);
            this.footerGitHub.TabIndex = 22;
            this.footerGitHub.TabStop = false;
            this.footerGitHub.Tag = "";
            this.footerGitHub.Click += new System.EventHandler(this.footerGitHub_Click);
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(6, 505);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(782, 74);
            this.footer.TabIndex = 21;
            this.footer.TabStop = false;
            // 
            // MJLFO_v2_0
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.footerGitHub);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.outputSave);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.outputBoxBorder);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.encodingSelect);
            this.Controls.Add(this.encodingSelectBorder);
            this.Controls.Add(this.encodingLabel);
            this.Controls.Add(this.listGetRidStrings);
            this.Controls.Add(this.listGetRidStringsBorder);
            this.Controls.Add(this.removeGetRidStrings);
            this.Controls.Add(this.addGetRidStrings);
            this.Controls.Add(this.inputGetRidStrings);
            this.Controls.Add(this.labelGetRidStrings);
            this.Controls.Add(this.listGetRidMessages);
            this.Controls.Add(this.listGetRidMessagesBorder);
            this.Controls.Add(this.removeGetRidMessages);
            this.Controls.Add(this.addGetRidMessages);
            this.Controls.Add(this.inputGetRidMessages);
            this.Controls.Add(this.labelGetRidMessages);
            this.Controls.Add(this.listKeepOnlyMessages);
            this.Controls.Add(this.listKeepOnlyMessagesBorder);
            this.Controls.Add(this.removeKeepOnlyMessages);
            this.Controls.Add(this.addKeepOnlyMessages);
            this.Controls.Add(this.inputKeepOnlyMessages);
            this.Controls.Add(this.labelKeepOnlyMessages);
            this.Controls.Add(this.inputBrowse);
            this.Controls.Add(this.inputSetPath);
            this.Controls.Add(this.inputPath);
            this.Controls.Add(this.inputLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MJLFO_v2_0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Minecraft Java Log File Organizer";
            this.Load += new System.EventHandler(this.MJLFO_v2_0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.footerGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Button inputBrowse;
        private System.Windows.Forms.TextBox inputPath;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputPath;
        private System.Windows.Forms.Label labelKeepOnlyMessages;
        private System.Windows.Forms.Button addKeepOnlyMessages;
        private System.Windows.Forms.Button removeKeepOnlyMessages;
        private System.Windows.Forms.ListBox listKeepOnlyMessages;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.OpenFileDialog inputOpenFile;
        private System.Windows.Forms.Button preview;
        private System.Windows.Forms.Button outputSave;
        private System.Windows.Forms.PictureBox footer;
        private System.Windows.Forms.PictureBox footerGitHub;
        private System.Windows.Forms.Timer outputSaveTimer;
        private System.Windows.Forms.Timer previewTimer;
        private System.Windows.Forms.Label encodingLabel;
        private System.Windows.Forms.ListBox listGetRidMessages;
        private System.Windows.Forms.TextBox inputGetRidMessages;
        private System.Windows.Forms.Button removeGetRidMessages;
        private System.Windows.Forms.Button addGetRidMessages;
        private System.Windows.Forms.Label labelGetRidMessages;
        private System.Windows.Forms.ListBox listGetRidStrings;
        private System.Windows.Forms.TextBox inputGetRidStrings;
        private System.Windows.Forms.Button removeGetRidStrings;
        private System.Windows.Forms.Button addGetRidStrings;
        private System.Windows.Forms.Label labelGetRidStrings;
        private System.Windows.Forms.ToolTip mainToolTips;
        private System.Windows.Forms.Panel encodingSelectBorder;
        private System.Windows.Forms.Panel outputBoxBorder;
        private System.Windows.Forms.Panel listKeepOnlyMessagesBorder;
        private System.Windows.Forms.Panel listGetRidMessagesBorder;
        private System.Windows.Forms.Panel listGetRidStringsBorder;
        private System.Windows.Forms.ComboBox encodingSelect;
        private System.Windows.Forms.TextBox inputKeepOnlyMessages;
        private System.Windows.Forms.Timer footerGitHubTimer;
        private System.Windows.Forms.Timer inputSetPathTimer;
        private System.Windows.Forms.Timer inputBrowseTimer;
        private System.Windows.Forms.Button inputSetPath;
    }
}