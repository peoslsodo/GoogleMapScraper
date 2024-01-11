using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace GMapExtractor
{
    public partial class FrmAdd : KryptonForm
    {
        public string Keyword { get; set; }
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtLink.Text.Trim()))
            {
                KryptonMessageBox.Show("Please enter your site url!", "Info",
                    MessageBoxButtons.OK, KryptonMessageBoxIcon.Error, showCtrlCopy: false);
                return;
            }
            var keyword = this.txtLink.Text.Trim();
            this.Keyword = keyword;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
           
        }
    }
}
