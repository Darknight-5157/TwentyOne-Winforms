namespace OchkoDotNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.nosorogPic = new System.Windows.Forms.PictureBox();
            this.nosorog2Pic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nosorogPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosorog2Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(81, 248);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(264, 61);
            this.btn.TabIndex = 0;
            this.btn.Text = "Начать";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(81, 315);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(264, 61);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exit_Click);
            // 
            // nosorogPic
            // 
            this.nosorogPic.BackColor = System.Drawing.Color.Transparent;
            this.nosorogPic.ImageLocation = "https://www.pvsm.ru/images/2022/01/19/pogromist-moi-samye-epichnye-provaly-za-vsy" +
    "u-kareru.jpeg";
            this.nosorogPic.Location = new System.Drawing.Point(26, 12);
            this.nosorogPic.Name = "nosorogPic";
            this.nosorogPic.Size = new System.Drawing.Size(387, 230);
            this.nosorogPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nosorogPic.TabIndex = 1;
            this.nosorogPic.TabStop = false;
            // 
            // nosorog2Pic
            // 
            this.nosorog2Pic.BackColor = System.Drawing.Color.Transparent;
            this.nosorog2Pic.ImageLocation = "https://s00.yaplakal.com/pics/pics_original/0/9/2/11986290.jpg";
            this.nosorog2Pic.Location = new System.Drawing.Point(26, 382);
            this.nosorog2Pic.Name = "nosorog2Pic";
            this.nosorog2Pic.Size = new System.Drawing.Size(387, 215);
            this.nosorog2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nosorog2Pic.TabIndex = 2;
            this.nosorog2Pic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer_tick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(441, 608);
            this.Controls.Add(this.nosorog2Pic);
            this.Controls.Add(this.nosorogPic);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Игра \"ОЧКО\"";
            ((System.ComponentModel.ISupportInitialize)(this.nosorogPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosorog2Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn;
        private Button exitBtn;
        private PictureBox nosorogPic;
        private PictureBox nosorog2Pic;
        private System.Windows.Forms.Timer timer1;
    }
}