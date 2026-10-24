namespace ShoesTest1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pbLogo = new PictureBox();
            pnMain = new Panel();
            bntLogin = new Button();
            btnGuest = new Button();
            txtLogin = new TextBox();
            lbLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(142, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.None;
            pnMain.Controls.Add(bntLogin);
            pnMain.Controls.Add(btnGuest);
            pnMain.Controls.Add(txtLogin);
            pnMain.Controls.Add(lbLogin);
            pnMain.Location = new Point(12, 118);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(360, 231);
            pnMain.TabIndex = 1;
            // 
            // bntLogin
            // 
            bntLogin.Anchor = AnchorStyles.None;
            bntLogin.BackColor = Color.FromArgb(210, 246, 231);
            bntLogin.FlatAppearance.BorderColor = Color.Black;
            bntLogin.FlatStyle = FlatStyle.Flat;
            bntLogin.Location = new Point(246, 132);
            bntLogin.Name = "bntLogin";
            bntLogin.Size = new Size(75, 26);
            bntLogin.TabIndex = 5;
            bntLogin.Text = "Войти";
            bntLogin.UseVisualStyleBackColor = false;
            bntLogin.Click += BntLogin_Click;
            // 
            // btnGuest
            // 
            btnGuest.Anchor = AnchorStyles.None;
            btnGuest.BackColor = Color.FromArgb(210, 246, 231);
            btnGuest.FlatAppearance.BorderColor = Color.Black;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(143, 22);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(75, 26);
            btnGuest.TabIndex = 4;
            btnGuest.Text = "Гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += BigGuest_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(40, 132);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(200, 26);
            txtLogin.TabIndex = 1;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(40, 110);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(52, 19);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Логин";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(pnMain);
            Controls.Add(pbLogo);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход1";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel pnMain;
        private Button bntLogin;
        private Button btnGuest;
        private TextBox txtLogin;
        private Label lbLogin;
    }
}