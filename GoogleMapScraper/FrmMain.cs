
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMapExtractor
{
    public partial class FrmMain : KryptonForm
    {
        public List<CustomInfo> List = new List<CustomInfo>();
        public bool IsExtractEmail = false;
        public CancellationTokenSource cancellationToken = new CancellationTokenSource();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BindLang()
        {
            this.comLang.DataSource = LangList.GetList();
            this.comLang.DisplayMember = "Name";
            this.comLang.ValueMember = "Code";
            this.comLang.SelectedIndex = 0;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.BindLang();
        }

        private void btnAddKeyword_Click(object sender, EventArgs e)
        {
            var frm = new FrmAdd();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.lbKeyword.Items.Add(frm.Keyword);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lbKeyword?.Items.Clear();
        }

        private  void btnStart_Click(object sender, EventArgs e)
        {
            if (this.lbKeyword.Items.Count == 0)
            {
                KryptonMessageBox.Show("plese Add keyword!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, showCtrlCopy: false);
                return;
            }
            var keyword = this.lbKeyword.Items.Cast<string>().ToList();
            var langCode = (this.comLang.SelectedItem as Language).Code;
            var isEmail = this.cbEmail.Checked;
            var maxNum = (int)this.nudMax.Value;
            var delay = (int)this.nudDelay.Value;

     
            var token = this.cancellationToken.Token;
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;

          

           
        }

        private void Loading(bool visible, int num)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                this.panelWait.Visible = visible;
                this.labLoadNum.Text = num.ToString();
            });
        }
        private void AddRow(bool isEmail, CustomInfo custom)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                this.dgvList.Rows.Insert(0, new object[]
                {
                    custom.Id,
                    custom.Name,
                    custom.Rating,
                    custom.Reviews,
                    custom.Category,
                    custom.Longitude,
                    custom.Latitude,
                    custom.Phone,
                    custom.Email,
                    custom.WebSite,
                    custom.PlusCode,
                    custom.Address,
                    custom.Image,
                });

                this.labTotal.Text = this.List.Count.ToString();
            });
            if (isEmail)
            {
                if (!string.IsNullOrEmpty(custom.WebSite))
                {
                    var emailIn = new EmailIn() { Id = custom.Id, Url = custom.WebSite };
                    BulkExtractEmail.EmailQueue.Enqueue(emailIn);
                }
            }

        }

        private void EditRow(EmailOut emailModel)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                var index = this.List.FindIndex(m => m.Id == emailModel.Id);
                if (index >= 0)
                {
                    this.List[index].Email = emailModel.Email;

                    var rowIndex = this.dgvList.Rows.Cast<DataGridViewRow>()
                   .FirstOrDefault(row => row.Cells["ColId"].Value.ToString() == emailModel.Id).Index;
                    if (rowIndex >= 0)
                    {
                        this.dgvList.Rows[rowIndex].Cells["ColEmail"].Value = emailModel.Email;
                    }
                }
            });
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            this.cancellationToken.Cancel();
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                this.dgvList.Rows.Clear();
                this.List.Clear();
                this.labTotal.Text = "0";
            });

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
           

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }
    }
}
