namespace FFBatch
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_l = new System.Windows.Forms.Label();
            this.pic_linux = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_linux)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.InitialImage = null;
            this.pic1.Location = new System.Drawing.Point(8, 8);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(311, 75);
            this.pic1.TabIndex = 12;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(130, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 13;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_l
            // 
            this.lbl_l.Location = new System.Drawing.Point(13, 87);
            this.lbl_l.Name = "lbl_l";
            this.lbl_l.Size = new System.Drawing.Size(304, 17);
            this.lbl_l.TabIndex = 14;
            this.lbl_l.Text = "Loading wine/mono libraries, please wait";
            this.lbl_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_linux
            // 
            this.pic_linux.Image = ((System.Drawing.Image)(resources.GetObject("pic_linux.Image")));
            this.pic_linux.Location = new System.Drawing.Point(219, 26);
            this.pic_linux.Name = "pic_linux";
            this.pic_linux.Size = new System.Drawing.Size(16, 28);
            this.pic_linux.TabIndex = 15;
            this.pic_linux.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            // 
            // Form6
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(329, 114);
            this.ControlBox = false;
            this.Controls.Add(this.pic_linux);
            this.Controls.Add(this.lbl_l);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form6_Load);
            this.Shown += new System.EventHandler(this.Form6_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form6_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_linux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic_linux;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Label lbl_l;
    }
}