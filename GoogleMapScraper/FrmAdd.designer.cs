namespace GMapExtractor
{
    partial class FrmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdd));
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.btnOk = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLink = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(660, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 292);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            this.kryptonPanel1.Size = new System.Drawing.Size(660, 71);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btnCancel);
            this.kryptonPanel3.Controls.Add(this.btnOk);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel3.Location = new System.Drawing.Point(433, 0);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            this.kryptonPanel3.Size = new System.Drawing.Size(227, 71);
            this.kryptonPanel3.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.CornerRoundingRadius = -1F;
            this.btnCancel.Location = new System.Drawing.Point(120, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            this.btnCancel.Size = new System.Drawing.Size(99, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Values.Image")));
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.CornerRoundingRadius = -1F;
            this.btnOk.Location = new System.Drawing.Point(16, 17);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            this.btnOk.Size = new System.Drawing.Size(99, 45);
            this.btnOk.TabIndex = 0;
            this.btnOk.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Values.Image")));
            this.btnOk.Values.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 1);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            this.kryptonPanel2.Size = new System.Drawing.Size(660, 291);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.txtLink, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 291);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtLink
            // 
            this.txtLink.CueHint.CueHintText = "please enter your keyword";
            this.txtLink.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLink.Location = new System.Drawing.Point(167, 2);
            this.txtLink.Margin = new System.Windows.Forms.Padding(2);
            this.txtLink.Multiline = true;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(491, 287);
            this.txtLink.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(2, 2);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            this.kryptonLabel1.Size = new System.Drawing.Size(88, 29);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Keyword:";
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 363);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdd";
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Your Keyword";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonTextBox txtLink;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonButton btnOk;
        private Krypton.Toolkit.KryptonButton btnCancel;
    }
}