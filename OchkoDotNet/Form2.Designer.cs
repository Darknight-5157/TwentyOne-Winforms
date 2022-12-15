namespace OchkoDotNet
{
    partial class Form2
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
            this.takeBtn = new System.Windows.Forms.Button();
            this.dropBtn = new System.Windows.Forms.Button();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.bankBox = new System.Windows.Forms.TextBox();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card6 = new System.Windows.Forms.PictureBox();
            this.card7 = new System.Windows.Forms.PictureBox();
            this.card8 = new System.Windows.Forms.PictureBox();
            this.botScoreBox = new System.Windows.Forms.TextBox();
            this.botBalanceBox = new System.Windows.Forms.TextBox();
            this.betInBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.betBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upgradeBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).BeginInit();
            this.SuspendLayout();
            // 
            // takeBtn
            // 
            this.takeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.takeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.takeBtn.Location = new System.Drawing.Point(25, 476);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(140, 44);
            this.takeBtn.TabIndex = 0;
            this.takeBtn.Text = "Взять карту";
            this.takeBtn.UseVisualStyleBackColor = false;
            this.takeBtn.Click += new System.EventHandler(this.takeBtn_Click);
            // 
            // dropBtn
            // 
            this.dropBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dropBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dropBtn.Location = new System.Drawing.Point(234, 476);
            this.dropBtn.Name = "dropBtn";
            this.dropBtn.Size = new System.Drawing.Size(140, 44);
            this.dropBtn.TabIndex = 1;
            this.dropBtn.Text = "Готово";
            this.dropBtn.UseVisualStyleBackColor = false;
            this.dropBtn.Visible = false;
            this.dropBtn.Click += new System.EventHandler(this.dropBtn_Click);
            // 
            // balanceBox
            // 
            this.balanceBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.balanceBox.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balanceBox.Location = new System.Drawing.Point(25, 22);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.ReadOnly = true;
            this.balanceBox.Size = new System.Drawing.Size(174, 30);
            this.balanceBox.TabIndex = 3;
            this.balanceBox.Text = "Ваш баланс  -";
            // 
            // bankBox
            // 
            this.bankBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bankBox.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bankBox.Location = new System.Drawing.Point(234, 22);
            this.bankBox.Name = "bankBox";
            this.bankBox.ReadOnly = true;
            this.bankBox.Size = new System.Drawing.Size(140, 30);
            this.bankBox.TabIndex = 4;
            this.bankBox.Text = "Банк - 0";
            // 
            // scoreBox
            // 
            this.scoreBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.scoreBox.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreBox.Location = new System.Drawing.Point(415, 22);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.ReadOnly = true;
            this.scoreBox.Size = new System.Drawing.Size(166, 30);
            this.scoreBox.TabIndex = 5;
            this.scoreBox.Text = "Очков         - 0";
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.Transparent;
            this.card1.Location = new System.Drawing.Point(25, 114);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(106, 150);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card1.TabIndex = 6;
            this.card1.TabStop = false;
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.Transparent;
            this.card2.Location = new System.Drawing.Point(234, 114);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(106, 150);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card2.TabIndex = 6;
            this.card2.TabStop = false;
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.Transparent;
            this.card3.Location = new System.Drawing.Point(445, 114);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(106, 150);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card3.TabIndex = 6;
            this.card3.TabStop = false;
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.Color.Transparent;
            this.card4.Location = new System.Drawing.Point(662, 114);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(106, 150);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card4.TabIndex = 6;
            this.card4.TabStop = false;
            // 
            // card5
            // 
            this.card5.BackColor = System.Drawing.Color.Transparent;
            this.card5.Location = new System.Drawing.Point(25, 290);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(106, 150);
            this.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card5.TabIndex = 6;
            this.card5.TabStop = false;
            // 
            // card6
            // 
            this.card6.BackColor = System.Drawing.Color.Transparent;
            this.card6.Location = new System.Drawing.Point(234, 290);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(106, 150);
            this.card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card6.TabIndex = 6;
            this.card6.TabStop = false;
            // 
            // card7
            // 
            this.card7.BackColor = System.Drawing.Color.Transparent;
            this.card7.Location = new System.Drawing.Point(445, 290);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(106, 150);
            this.card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card7.TabIndex = 6;
            this.card7.TabStop = false;
            // 
            // card8
            // 
            this.card8.BackColor = System.Drawing.Color.Transparent;
            this.card8.Location = new System.Drawing.Point(662, 290);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(106, 150);
            this.card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card8.TabIndex = 6;
            this.card8.TabStop = false;
            // 
            // botScoreBox
            // 
            this.botScoreBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.botScoreBox.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botScoreBox.Location = new System.Drawing.Point(415, 67);
            this.botScoreBox.Name = "botScoreBox";
            this.botScoreBox.ReadOnly = true;
            this.botScoreBox.Size = new System.Drawing.Size(166, 30);
            this.botScoreBox.TabIndex = 5;
            this.botScoreBox.Text = "Очков  бота - 0";
            // 
            // botBalanceBox
            // 
            this.botBalanceBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.botBalanceBox.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botBalanceBox.Location = new System.Drawing.Point(25, 67);
            this.botBalanceBox.Name = "botBalanceBox";
            this.botBalanceBox.ReadOnly = true;
            this.botBalanceBox.Size = new System.Drawing.Size(174, 30);
            this.botBalanceBox.TabIndex = 3;
            this.botBalanceBox.Text = "Баланс бота -";
            // 
            // betInBox
            // 
            this.betInBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.betInBox.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.betInBox.Location = new System.Drawing.Point(649, 67);
            this.betInBox.Name = "betInBox";
            this.betInBox.Size = new System.Drawing.Size(62, 30);
            this.betInBox.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox4.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(649, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(139, 30);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Введите ставку";
            // 
            // betBtn
            // 
            this.betBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.betBtn.Location = new System.Drawing.Point(726, 67);
            this.betBtn.Name = "betBtn";
            this.betBtn.Size = new System.Drawing.Size(62, 30);
            this.betBtn.TabIndex = 7;
            this.betBtn.Text = "Принять";
            this.betBtn.UseVisualStyleBackColor = true;
            this.betBtn.Click += new System.EventHandler(this.betBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(805, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 8;
            // 
            // upgradeBtn
            // 
            this.upgradeBtn.BackColor = System.Drawing.Color.LightCoral;
            this.upgradeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.upgradeBtn.Location = new System.Drawing.Point(445, 476);
            this.upgradeBtn.Name = "upgradeBtn";
            this.upgradeBtn.Size = new System.Drawing.Size(140, 44);
            this.upgradeBtn.TabIndex = 9;
            this.upgradeBtn.Text = "Улучшить";
            this.upgradeBtn.UseVisualStyleBackColor = false;
            this.upgradeBtn.Visible = false;
            this.upgradeBtn.Click += new System.EventHandler(this.begemot_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.restartBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restartBtn.Location = new System.Drawing.Point(648, 476);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(140, 44);
            this.restartBtn.TabIndex = 10;
            this.restartBtn.Text = "Рестарт";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Visible = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(819, 543);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.upgradeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betBtn);
            this.Controls.Add(this.card8);
            this.Controls.Add(this.card7);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.botScoreBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.betInBox);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.bankBox);
            this.Controls.Add(this.botBalanceBox);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.dropBtn);
            this.Controls.Add(this.takeBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Геймплей ОЧКА";
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button takeBtn;
        private Button dropBtn;
        private TextBox balanceBox;
        private TextBox bankBox;
        private TextBox scoreBox;
        private PictureBox card1;
        private PictureBox card2;
        private PictureBox card3;
        private PictureBox card4;
        private PictureBox card5;
        private PictureBox card6;
        private PictureBox card7;
        private PictureBox card8;
        private TextBox botScoreBox;
        private TextBox botBalanceBox;
        private TextBox betInBox;
        private TextBox textBox4;
        private Button betBtn;
        private Label label1;
        private Button upgradeBtn;
        private Button restartBtn;
    }
}