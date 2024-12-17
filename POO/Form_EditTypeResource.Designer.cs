namespace POO
{
    partial class Form_EditTypeResource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditTypeResource));
            cbx_Enable = new CheckBox();
            txt_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_id = new TextBox();
            btx_ok = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btx_ok).BeginInit();
            SuspendLayout();
            // 
            // cbx_Enable
            // 
            cbx_Enable.AutoSize = true;
            cbx_Enable.BackColor = Color.Transparent;
            cbx_Enable.CheckAlign = ContentAlignment.MiddleRight;
            cbx_Enable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cbx_Enable.Location = new Point(12, 120);
            cbx_Enable.Name = "cbx_Enable";
            cbx_Enable.Size = new Size(70, 25);
            cbx_Enable.TabIndex = 1;
            cbx_Enable.Text = "Ativo";
            cbx_Enable.UseVisualStyleBackColor = false;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(64, 79);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(1, 77);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(31, 36);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(64, 38);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 5;
            // 
            // btx_ok
            // 
            btx_ok.BackColor = Color.Transparent;
            btx_ok.Cursor = Cursors.Hand;
            btx_ok.Image = (Image)resources.GetObject("btx_ok.Image");
            btx_ok.Location = new Point(223, 199);
            btx_ok.Name = "btx_ok";
            btx_ok.Size = new Size(41, 39);
            btx_ok.SizeMode = PictureBoxSizeMode.StretchImage;
            btx_ok.TabIndex = 17;
            btx_ok.TabStop = false;
            btx_ok.Click += btn_ok_Click;
            // 
            // Form_EditTypeResource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(276, 250);
            Controls.Add(btx_ok);
            Controls.Add(txt_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_name);
            Controls.Add(cbx_Enable);
            Name = "Form_EditTypeResource";
            Text = "Editar Tipo Recurso";
            Load += Form_EditTypeResource_Load;
            ((System.ComponentModel.ISupportInitialize)btx_ok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox cbx_Enable;
        private TextBox txt_name;
        private Label label1;
        private Label label2;
        private TextBox txt_id;
        private PictureBox btx_ok;
    }
}