using Microsoft.Win32;
using MJLFO_v2_0.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace MJLFO_v2_0
{
    public partial class MJLFO_v2_0 : Form
    {
        int encoding = 0;
        Bitmap[] imagesMod = new Bitmap[6];
        bool imported = false;
        string indir = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft"), "logs");
        public MJLFO_v2_0()
        {
            InitializeComponent();
        }
        private void MJLFO_v2_0_Load(object sender, EventArgs e)
        {
            ActiveControl = inputLabel;
            encodingSelect.SelectedIndex = 0;
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            loadImages();
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
            SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
        }
        private void SystemEvents_UserPreferenceChanged(object sender, EventArgs e)
        {
            loadImages();
        }
        private void loadImages()
        {
            Bitmap[] images = { Resources.footer, Resources.github, Resources.add, Resources.remove, Resources.setpath, Resources.browse, Resources.preview, Resources.save, Resources.success, Resources.failure };
            Color textColor = Color.FromKnownColor(KnownColor.WindowText);
            foreach (var image in images)
            {
                Bitmap imageMod = new Bitmap(image);
                int width = image.Width;
                int height = image.Height;
                for (int a = 0; a < width; a++)
                {
                    for (int b = 0; b < height; b++)
                    {
                        Color c = image.GetPixel(a, b);
                        if (c.A == 255 && c.R == 0 && c.G == 0 && c.B == 0) imageMod.SetPixel(a, b, Color.FromArgb(textColor.A, textColor.R, textColor.G, textColor.B));
                    }
                }
                if (image == images[0]) footer.Image = imageMod;
                if (image == images[1]) footerGitHub.Image = imageMod;
                if (image == images[2])
                {
                    addKeepOnlyMessages.Image = imageMod;
                    addGetRidMessages.Image = imageMod;
                    addGetRidStrings.Image = imageMod;
                }
                if (image == images[3])
                {
                    removeKeepOnlyMessages.Image = imageMod;
                    removeGetRidMessages.Image = imageMod;
                    removeGetRidStrings.Image = imageMod;
                }
                if (image == images[4])
                {
                    imagesMod[0] = imageMod;
                    inputSetPath.Image = imageMod;
                }
                if (image == images[5])
                {
                    imagesMod[1] = imageMod;
                    inputBrowse.Image = imageMod;
                }
                if (image == images[6])
                {
                    imagesMod[2] = imageMod;
                    preview.Image = imageMod;
                }
                if (image == images[7])
                {
                    imagesMod[3] = imageMod;
                    outputSave.Image = imageMod;
                }
                if (image == images[8]) imagesMod[4] = imageMod;
                if (image == images[9]) imagesMod[5] = imageMod;
            }
        }
        private void inputSetPath_Click(object sender, EventArgs e)
        {
            if (inputSetPathTimer.Enabled == false)
            {
                MJLFO_v2_0_SP sp = new MJLFO_v2_0_SP();
                sp.ShowDialog();
                if (File.Exists(sp.spTextBox.Text) == true && sp.spConfirmed == true)
                {
                    try
                    {
                        FileStream setTest = File.Open(sp.spTextBox.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
                        inputPath.Text = sp.spTextBox.Text;
                        string setDirectory = sp.spTextBox.Text.Substring(0, sp.spTextBox.Text.Length - (Path.GetFileNameWithoutExtension(sp.spTextBox.Text).Length + Path.GetExtension(sp.spTextBox.Text).Length));
                        outputPath.Text = setDirectory + Path.GetFileNameWithoutExtension(sp.spTextBox.Text) + "_organized_yyyy-MM-dd_HH-mm-ss" + Path.GetExtension(sp.spTextBox.Text);
                        imported = true;
                        inputSetPath.Image = imagesMod[4];
                    }
                    catch { inputSetPath.Image = imagesMod[5]; }
                }
                else inputSetPath.Image = imagesMod[5];
                inputSetPathTimer.Enabled = true;
            }
        }
        private void inputSetPathTimer_Tick(object sender, EventArgs e)
        {
            inputSetPath.Image = imagesMod[0];
            inputSetPathTimer.Enabled = false;
        }
        private void inputBrowse_Click(object sender, EventArgs e)
        {
            if (inputBrowseTimer.Enabled == false)
            {
                inputOpenFile.InitialDirectory = indir;
                if (inputOpenFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileStream browsedTest = File.Open(inputOpenFile.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                        inputPath.Text = inputOpenFile.FileName;
                        string browsedDirectory = inputOpenFile.FileName.Substring(0, inputOpenFile.FileName.Length - (Path.GetFileNameWithoutExtension(inputOpenFile.FileName).Length + Path.GetExtension(inputOpenFile.FileName).Length));
                        outputPath.Text = browsedDirectory + Path.GetFileNameWithoutExtension(inputOpenFile.FileName) + "_organized_yyyy-MM-dd_HH-mm-ss" + Path.GetExtension(inputOpenFile.FileName);
                        imported = true;
                        inputBrowse.Image = imagesMod[4];
                    }
                    catch { inputBrowse.Image = imagesMod[5]; }
                }
                else inputBrowse.Image = imagesMod[5];
                inputBrowseTimer.Enabled = true;
            }
        }
        private void inputBrowseTimer_Tick(object sender, EventArgs e)
        {
            inputBrowse.Image = imagesMod[1];
            inputBrowseTimer.Enabled = false;
        }
        private void addKeepOnly_Click(object sender, EventArgs e)
        {
            if (inputKeepOnlyMessages.Text != "")
            {
                listKeepOnlyMessages.Items.Add(inputKeepOnlyMessages.Text);
                inputKeepOnlyMessages.Text = "";
            }
        }
        private void removeKeepOnly_Click(object sender, EventArgs e)
        {
            for (int d = listKeepOnlyMessages.SelectedIndices.Count - 1; d >= 0; d--) listKeepOnlyMessages.Items.RemoveAt(listKeepOnlyMessages.SelectedIndices[d]);
        }
        private void addGetRidMessages_Click(object sender, EventArgs e)
        {
            if (inputGetRidMessages.Text != "")
            {
                listGetRidMessages.Items.Add(inputGetRidMessages.Text);
                inputGetRidMessages.Text = "";
            }
        }
        private void removeGetRidMessages_Click(object sender, EventArgs e)
        {
            for (int f = listGetRidMessages.SelectedIndices.Count - 1; f >= 0; f--) listGetRidMessages.Items.RemoveAt(listGetRidMessages.SelectedIndices[f]);
        }
        private void addGetRidStrings_Click(object sender, EventArgs e)
        {
            if (inputGetRidStrings.Text != "")
            {
                listGetRidStrings.Items.Add(inputGetRidStrings.Text);
                inputGetRidStrings.Text = "";
            }
        }
        private void removeGetRidStrings_Click(object sender, EventArgs e)
        {
            for (int g = listGetRidStrings.SelectedIndices.Count - 1; g >= 0; g--) listGetRidStrings.Items.RemoveAt(listGetRidStrings.SelectedIndices[g]);
        }
        private void encodingSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (encodingSelect.SelectedIndex)
            {
                case 0: encoding = 0; break;
                case 1: encoding = 10004; break;
                case 2: encoding = 28596; break;
                case 3: encoding = 1256; break;
                case 4: encoding = 10008; break;
                case 5: encoding = 936; break;
                case 6: encoding = 20936; break;
                case 7: encoding = 52936; break;
                case 8: encoding = 54936; break;
                case 9: encoding = 50227; break;
                case 10: encoding = 51936; break;
                case 11: encoding = 10002; break;
                case 12: encoding = 950; break;
                case 13: encoding = 20000; break;
                case 14: encoding = 10007; break;
                case 15: encoding = 10017; break;
                case 16: encoding = 20866; break;
                case 17: encoding = 21866; break;
                case 18: encoding = 28595; break;
                case 19: encoding = 1251; break;
                case 20: encoding = 10082; break;
                case 21: encoding = 10079; break;
                case 22: encoding = 10010; break;
                case 23: encoding = 10029; break;
                case 24: encoding = 28592; break;
                case 25: encoding = 1250; break;
                case 26: encoding = 28594; break;
                case 27: encoding = 28603; break;
                case 28: encoding = 1257; break;
                case 29: encoding = 28593; break;
                case 30: encoding = 10000; break;
                case 31: encoding = 28591; break;
                case 32: encoding = 28605; break;
                case 33: encoding = 1252; break;
                case 34: encoding = 10006; break;
                case 35: encoding = 28597; break;
                case 36: encoding = 1253; break;
                case 37: encoding = 10005; break;
                case 38: encoding = 28598; break;
                case 39: encoding = 38598; break;
                case 40: encoding = 1255; break;
                case 41: encoding = 57002; break;
                case 42: encoding = 57003; break;
                case 43: encoding = 57004; break;
                case 44: encoding = 57005; break;
                case 45: encoding = 57006; break;
                case 46: encoding = 57007; break;
                case 47: encoding = 57008; break;
                case 48: encoding = 57009; break;
                case 49: encoding = 57010; break;
                case 50: encoding = 57011; break;
                case 51: encoding = 10001; break;
                case 52: encoding = 932; break;
                case 53: encoding = 50222; break;
                case 54: encoding = 51932; break;
                case 55: encoding = 10003; break;
                case 56: encoding = 949; break;
                case 57: encoding = 50225; break;
                case 58: encoding = 51949; break;
                case 59: encoding = 10021; break;
                case 60: encoding = 874; break;
                case 61: encoding = 10081; break;
                case 62: encoding = 28599; break;
                case 63: encoding = 1254; break;
                case 64: encoding = 1258; break;
            }
        }
        private void preview_Click(object sender, EventArgs e)
        {
            if (imported == true && previewTimer.Enabled == false)
            {
                try
                {
                    var enctype = Encoding.Default;
                    if (encoding == 0) enctype = Encoding.Default;
                    else enctype = Encoding.GetEncoding(encoding);
                    string outputDirectory = inputPath.Text.Substring(0, inputPath.Text.Length - (Path.GetFileNameWithoutExtension(inputPath.Text).Length + Path.GetExtension(inputPath.Text).Length));
                    string outputFile = outputDirectory + Path.GetFileNameWithoutExtension(inputPath.Text) + "_organized_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + Path.GetExtension(inputPath.Text);
                    var startindex = 0;
                    var endindex = 0;
                    string[] first = { "§", "�" };
                    string[] second = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "k", "l", "m", "n", "o", "r" };
                    using (FileStream fileStreamRead = File.Open(inputPath.Text, FileMode.Open, FileAccess.Read, FileShare.Read))
                    using (BufferedStream bufferedStreamRead = new BufferedStream(fileStreamRead))
                    using (StreamReader streamReader = new StreamReader(bufferedStreamRead, enctype))
                    {
                        string line = string.Empty;
                        StringBuilder stringBuilder = new StringBuilder();
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            if (line.Contains("[CHAT]") == true)
                            {
                                var length = line.Length;
                                var h = 1;
                                for (var j = 0; j < length; j++) if (j == 0 && line[j] == '[') h = 0;
                                var i = 0;
                                bool keepLine = true;
                                for (var k = 0; k < length - 1; k++)
                                {
                                    if (line[k] == '[')
                                    {
                                        h++;
                                        if (h == 2) startindex = k;
                                    }
                                    if (line[k] == '[' && line[k + 1] == 'C' && line[k + 2] == 'H' && line[k + 3] == 'A' && line[k + 4] == 'T' && line[k + 5] == ']' && line[k + 6] == ' ')
                                    {
                                        i++;
                                        if (i == 1) endindex = k + 7;
                                    }
                                }
                                line = line.Remove(startindex, endindex - startindex);
                                foreach (var l in first) foreach (var m in second) line = line.Replace((l + m), "");
                                if (listKeepOnlyMessages.Items.Count != 0) foreach (var n in listKeepOnlyMessages.Items) if (line.Contains(n.ToString()) == false) keepLine = false;
                                foreach (var o in listGetRidMessages.Items) if (line.Contains(o.ToString()) == true) keepLine = false;
                                foreach (var p in listGetRidStrings.Items) if (line.Contains(p.ToString()) == true) line = line.Replace(p.ToString(), "");
                                if (keepLine == true) stringBuilder.Append(line + Environment.NewLine);
                            }
                        }
                        outputBox.Text = stringBuilder.ToString();
                    }
                    preview.Image = imagesMod[4];
                }
                catch { preview.Image = imagesMod[5]; }
                finally { previewTimer.Enabled = true; }
            }
        }
        private void previewTimer_Tick(object sender, EventArgs e)
        {
            preview.Image = imagesMod[2];
            previewTimer.Enabled = false;
        }
        private void outputSave_Click(object sender, EventArgs e)
        {
            if (imported == true && outputSaveTimer.Enabled == false)
            {
                try
                {
                    var enctype = Encoding.Default;
                    if (encoding == 0) enctype = Encoding.Default;
                    else enctype = Encoding.GetEncoding(encoding);
                    string outputDirectory = inputPath.Text.Substring(0, inputPath.Text.Length - (Path.GetFileNameWithoutExtension(inputPath.Text).Length + Path.GetExtension(inputPath.Text).Length));
                    string outputFile = outputDirectory + Path.GetFileNameWithoutExtension(inputPath.Text) + "_organized_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + Path.GetExtension(inputPath.Text);
                    var startindex = 0;
                    var endindex = 0;
                    string[] first = { "§", "�" };
                    string[] second = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "k", "l", "m", "n", "o", "r" };
                    using (FileStream fileStreamRead = File.Open(inputPath.Text, FileMode.Open, FileAccess.Read, FileShare.Read))
                    using (BufferedStream bufferedStreamRead = new BufferedStream(fileStreamRead))
                    using (StreamReader streamReader = new StreamReader(bufferedStreamRead, enctype))
                    using (FileStream fileStreamWrite = File.Open(outputFile, FileMode.Append, FileAccess.Write, FileShare.Write))
                    using (BufferedStream bufferedStreamWrite = new BufferedStream(fileStreamWrite))
                    using (StreamWriter streamWriter = new StreamWriter(bufferedStreamWrite, enctype))
                    {
                        string line = string.Empty;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            if (line.Contains("[CHAT]") == true)
                            {
                                var length = line.Length;
                                var h = 1;
                                for (var j = 0; j < length; j++) if (j == 0 && line[j] == '[') h = 0;
                                var i = 0;
                                bool keepLine = true;
                                for (var k = 0; k < length - 1; k++)
                                {
                                    if (line[k] == '[')
                                    {
                                        h++;
                                        if (h == 2) startindex = k;
                                    }
                                    if (line[k] == '[' && line[k + 1] == 'C' && line[k + 2] == 'H' && line[k + 3] == 'A' && line[k + 4] == 'T' && line[k + 5] == ']' && line[k + 6] == ' ')
                                    {
                                        i++;
                                        if (i == 1) endindex = k + 7;
                                    }
                                }
                                line = line.Remove(startindex, endindex - startindex);
                                foreach (var l in first) foreach (var m in second) line = line.Replace((l + m), "");
                                if (listKeepOnlyMessages.Items.Count != 0) foreach (var n in listKeepOnlyMessages.Items) if (line.Contains(n.ToString()) == false) keepLine = false;
                                foreach (var o in listGetRidMessages.Items) if (line.Contains(o.ToString()) == true) keepLine = false;
                                foreach (var p in listGetRidStrings.Items) if (line.Contains(p.ToString()) == true) line = line.Replace(p.ToString(), "");
                                if (keepLine == true) streamWriter.Write(line + Environment.NewLine);
                            }
                        }
                    }
                    outputSave.Image = imagesMod[4];
                }
                catch { outputSave.Image = imagesMod[5]; }
                finally { outputSaveTimer.Enabled = true; }
            }
        }
        private void outputSaveTimer_Tick(object sender, EventArgs e)
        {
            outputSave.Image = imagesMod[3];
            outputSaveTimer.Enabled = false;
        }
        private void footerGitHub_Click(object sender, EventArgs e)
        {
            if (footerGitHubTimer.Enabled == false)
            {
                try { Process.Start("https://github.com/xFellern"); }
                catch { }
                finally { footerGitHubTimer.Enabled = true; }
            }
        }
        private void footerGitHubTimer_Tick(object sender, EventArgs e)
        {
            footerGitHubTimer.Enabled = false;
        }
    }
}