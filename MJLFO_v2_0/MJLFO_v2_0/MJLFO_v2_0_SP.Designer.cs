namespace MJLFO_v2_0
{
    partial class MJLFO_v2_0_SP
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
            this.setPath = new System.Windows.Forms.TextBox();
            this.setPathConfirm = new System.Windows.Forms.Button();
            this.setPathLabel = new System.Windows.Forms.Label();
            this.pathToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // setPath
            // 
            this.setPath.BackColor = System.Drawing.SystemColors.Window;
            this.setPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPath.Font = new System.Drawing.Font("Arial", 12F);
            this.setPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.setPath.Location = new System.Drawing.Point(60, 17);
            this.setPath.Margin = new System.Windows.Forms.Padding(4);
            this.setPath.MaxLength = 2147483647;
            this.setPath.Name = "setPath";
            this.setPath.Size = new System.Drawing.Size(667, 26);
            this.setPath.TabIndex = 1;
            // 
            // setPathConfirm
            // 
            this.setPathConfirm.BackColor = System.Drawing.SystemColors.Window;
            this.setPathConfirm.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.setPathConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setPathConfirm.Font = new System.Drawing.Font("Arial", 12F);
            this.setPathConfirm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.setPathConfirm.Location = new System.Drawing.Point(733, 17);
            this.setPathConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.setPathConfirm.Name = "setPathConfirm";
            this.setPathConfirm.Size = new System.Drawing.Size(41, 26);
            this.setPathConfirm.TabIndex = 2;
            this.setPathConfirm.Text = "OK";
            this.pathToolTips.SetToolTip(this.setPathConfirm, "Confirm");
            this.setPathConfirm.UseVisualStyleBackColor = false;
            this.setPathConfirm.Click += new System.EventHandler(this.outputSave_Click);
            // 
            // setPathLabel
            // 
            this.setPathLabel.BackColor = System.Drawing.Color.Transparent;
            this.setPathLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.setPathLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.setPathLabel.Location = new System.Drawing.Point(16, 17);
            this.setPathLabel.Name = "setPathLabel";
            this.setPathLabel.Size = new System.Drawing.Size(50, 26);
            this.setPathLabel.TabIndex = 0;
            this.setPathLabel.Text = "Path:";
            this.setPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pathToolTips.SetToolTip(this.setPathLabel, "Set the system path of the source file.");
            // 
            // MJLFO_v2_0_SP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(784, 51);
            this.Controls.Add(this.setPathConfirm);
            this.Controls.Add(this.setPath);
            this.Controls.Add(this.setPathLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 90);
            this.MinimumSize = new System.Drawing.Size(800, 90);
            this.Name = "MJLFO_v2_0_SP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Minecraft Java Log File Organizer - Set path";
            this.Load += new System.EventHandler(this.MJLFO_v2_0_SF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.TextBox setPath;
        private System.Windows.Forms.Button setPathConfirm;
        private System.Windows.Forms.Label setPathLabel;
        private System.Windows.Forms.ToolTip pathToolTips;
    }
}