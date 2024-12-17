namespace POO
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_name = new Label();
            lbl_id = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(216, 224);
            txt_username.Margin = new Padding(1);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(108, 23);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(216, 256);
            txt_password.Margin = new Padding(1);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(108, 23);
            txt_password.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Transparent;
            btn_login.Image = (Image)resources.GetObject("btn_login.Image");
            btn_login.Location = new Point(397, 256);
            btn_login.Margin = new Padding(1);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(49, 47);
            btn_login.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_login.TabIndex = 2;
            btn_login.TabStop = false;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 26);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.BackColor = Color.Transparent;
            lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_name.Location = new Point(107, 254);
            lbl_name.Margin = new Padding(1, 0, 1, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(82, 21);
            lbl_name.TabIndex = 12;
            lbl_name.Text = "Password";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.BackColor = Color.Transparent;
            lbl_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_id.Location = new Point(107, 222);
            lbl_id.Margin = new Padding(1, 0, 1, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(87, 21);
            lbl_id.TabIndex = 11;
            lbl_id.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(462, 319);
            Controls.Add(lbl_name);
            Controls.Add(lbl_id);
            Controls.Add(pictureBox1);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Margin = new Padding(1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)btn_login).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_password;
        private PictureBox btn_login;
        private PictureBox pictureBox1;
        private Label lbl_name;
        private Label lbl_id;
    }
}