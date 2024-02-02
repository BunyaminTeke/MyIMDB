namespace MyIMDB
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            viewpassword = new PictureBox();
            lbl_signup = new Label();
            ((System.ComponentModel.ISupportInitialize)viewpassword).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(286, 165);
            label1.Name = "label1";
            label1.Size = new Size(111, 22);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(286, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(286, 277);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 31);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(286, 246);
            label2.Name = "label2";
            label2.Size = new Size(46, 22);
            label2.TabIndex = 2;
            label2.Text = "Şifre";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(286, 356);
            button1.Name = "button1";
            button1.Size = new Size(111, 44);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(286, 323);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 5;
            label3.Text = "Şifremi Unuttum?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(286, 416);
            label4.Name = "label4";
            label4.Size = new Size(205, 20);
            label4.TabIndex = 6;
            label4.Text = "Kullanıcı adı veya şifre yanlış !";
            label4.Visible = false;
            // 
            // viewpassword
            // 
            viewpassword.BackColor = Color.White;
            viewpassword.Cursor = Cursors.Hand;
            viewpassword.Image = (Image)resources.GetObject("viewpassword.Image");
            viewpassword.Location = new Point(492, 278);
            viewpassword.Name = "viewpassword";
            viewpassword.Size = new Size(27, 27);
            viewpassword.SizeMode = PictureBoxSizeMode.StretchImage;
            viewpassword.TabIndex = 9;
            viewpassword.TabStop = false;
            viewpassword.Click += viewpassword_Click;
            // 
            // lbl_signup
            // 
            lbl_signup.AutoSize = true;
            lbl_signup.BackColor = Color.Transparent;
            lbl_signup.Cursor = Cursors.Hand;
            lbl_signup.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_signup.ForeColor = Color.Orange;
            lbl_signup.Location = new Point(414, 369);
            lbl_signup.Name = "lbl_signup";
            lbl_signup.Size = new Size(67, 21);
            lbl_signup.TabIndex = 10;
            lbl_signup.Text = "Sign up";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(992, 600);
            Controls.Add(lbl_signup);
            Controls.Add(viewpassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            FormClosing += FormMenu_FormClosing;
            Load += FormMenu_Load;
            Click += FormMenu_Click;
            ((System.ComponentModel.ISupportInitialize)viewpassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private PictureBox viewpassword;
        private Label lbl_signup;
    }
}