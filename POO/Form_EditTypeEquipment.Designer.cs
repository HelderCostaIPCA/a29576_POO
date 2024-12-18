namespace POO
{
    partial class Form_EditTypeEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditTypeEquipment));
            btx_ok = new PictureBox();
            txt_id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_description = new TextBox();
            cbx_enable = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)btx_ok).BeginInit();
            SuspendLayout();
            // 
            // btx_ok
            // 
            btx_ok.BackColor = Color.Transparent;
            btx_ok.Cursor = Cursors.Hand;
            btx_ok.Image = (Image)resources.GetObject("btx_ok.Image");
            btx_ok.Location = new Point(227, 173);
            btx_ok.Name = "btx_ok";
            btx_ok.Size = new Size(41, 39);
            btx_ok.SizeMode = PictureBoxSizeMode.StretchImage;
            btx_ok.TabIndex = 23;
            btx_ok.TabStop = false;
            btx_ok.Click += btx_ok_Click;
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(95, 12);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(35, 10);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 21;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(5, 51);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 20;
            label1.Text = "Descrição";
            // 
            // txt_description
            // 
            txt_description.Location = new Point(95, 53);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(100, 23);
            txt_description.TabIndex = 19;
            // 
            // cbx_enable
            // 
            cbx_enable.AutoSize = true;
            cbx_enable.BackColor = Color.Transparent;
            cbx_enable.CheckAlign = ContentAlignment.MiddleRight;
            cbx_enable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cbx_enable.Location = new Point(35, 98);
            cbx_enable.Name = "cbx_enable";
            cbx_enable.Size = new Size(70, 25);
            cbx_enable.TabIndex = 18;
            cbx_enable.Text = "Ativo";
            cbx_enable.UseVisualStyleBackColor = false;
            // 
            // Form_EditTypeEquipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(284, 228);
            Controls.Add(btx_ok);
            Controls.Add(txt_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_description);
            Controls.Add(cbx_enable);
            Name = "Form_EditTypeEquipment";
            Text = "Form_EditTypeEquipment";
            ((System.ComponentModel.ISupportInitialize)btx_ok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btx_ok;
        private TextBox txt_id;
        private Label label2;
        private Label label1;
        private TextBox txt_description;
        private CheckBox cbx_enable;
    }
}