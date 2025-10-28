using System;
using System.Drawing;
using System.Windows.Forms;
namespace MJLFO_v2_0
{
    public partial class MJLFO_v2_0_SP : Form
    {
        public TextBox spTextBox;
        public bool spConfirmed = false;
        public MJLFO_v2_0_SP()
        {
            InitializeComponent();
            spTextBox = setPath;
        }
        private void MJLFO_v2_0_SF_Load(object sender, EventArgs e)
        {
            ActiveControl = setPathLabel;
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
        private void outputSave_Click(object sender, EventArgs e)
        {
            Close();
            spConfirmed = true;
        }
    }
}