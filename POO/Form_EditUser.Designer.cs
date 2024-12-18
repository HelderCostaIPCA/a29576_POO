namespace POO
{
    partial class Form_EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditUser));
            label5 = new Label();
            lbl_coordinates = new Label();
            lbl_description = new Label();
            lbl_id = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            txt_mail = new TextBox();
            txt_id = new TextBox();
            pictureBox1 = new PictureBox();
            cbx_Enable = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(17, 169);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 43;
            label5.Text = "E-Mail";
            // 
            // lbl_coordinates
            // 
            lbl_coordinates.AutoSize = true;
            lbl_coordinates.BackColor = Color.Transparent;
            lbl_coordinates.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_coordinates.Location = new Point(17, 123);
            lbl_coordinates.Margin = new Padding(1, 0, 1, 0);
            lbl_coordinates.Name = "lbl_coordinates";
            lbl_coordinates.Size = new Size(82, 21);
            lbl_coordinates.TabIndex = 42;
            lbl_coordinates.Text = "Password";
            // 
            // lbl_description
            // 
            lbl_description.AutoSize = true;
            lbl_description.BackColor = Color.Transparent;
            lbl_description.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_description.Location = new Point(17, 75);
            lbl_description.Margin = new Padding(1, 0, 1, 0);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(86, 21);
            lbl_description.TabIndex = 41;
            lbl_description.Text = "Utilizador";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.BackColor = Color.Transparent;
            lbl_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_id.Location = new Point(17, 36);
            lbl_id.Margin = new Padding(1, 0, 1, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(27, 21);
            lbl_id.TabIndex = 40;
            lbl_id.Text = "ID";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(180, 78);
            txt_username.Margin = new Padding(1);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(163, 23);
            txt_username.TabIndex = 36;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(180, 126);
            txt_password.Margin = new Padding(1);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(163, 23);
            txt_password.TabIndex = 37;
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(180, 172);
            txt_mail.Margin = new Padding(1);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(163, 23);
            txt_mail.TabIndex = 38;
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(180, 39);
            txt_id.Margin = new Padding(1);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(163, 23);
            txt_id.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(333, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btn_ok_Click;
            // 
            // cbx_Enable
            // 
            cbx_Enable.AutoSize = true;
            cbx_Enable.BackColor = Color.Transparent;
            cbx_Enable.CheckAlign = ContentAlignment.MiddleRight;
            cbx_Enable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cbx_Enable.Location = new Point(17, 207);
            cbx_Enable.Name = "cbx_Enable";
            cbx_Enable.Size = new Size(70, 25);
            cbx_Enable.TabIndex = 47;
            cbx_Enable.Text = "Ativo";
            cbx_Enable.UseVisualStyleBackColor = false;
            // 
            // Form_EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(386, 271);
            Controls.Add(cbx_Enable);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(lbl_coordinates);
            Controls.Add(lbl_description);
            Controls.Add(lbl_id);
            Controls.Add(txt_username);
            Controls.Add(txt_password);
            Controls.Add(txt_mail);
            Controls.Add(txt_id);
            Name = "Form_EditUser";
            Text = "Form_Edit_User";
            Load += Form_EditUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_zipcode;
        private Label label6;
        private Label label5;
        private Label lbl_coordinates;
        private Label lbl_description;
        private Label lbl_id;
        private TextBox txt_username;
        private TextBox txt_password;
        private TextBox txt_mail;
        private TextBox txt_id;
        private PictureBox pictureBox1;
        private CheckBox cbx_Enable;
    }
}