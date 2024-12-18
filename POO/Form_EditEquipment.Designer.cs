namespace POO
{
    partial class Form_EditEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditEquipment));
            btx_ok = new PictureBox();
            cbx_equipmentType = new ComboBox();
            label8 = new Label();
            label3 = new Label();
            lbl_name = new Label();
            lbl_id = new Label();
            txt_description = new TextBox();
            txt_serialNumber = new TextBox();
            txt_id = new TextBox();
            cbx_Enable = new CheckBox();
            cbx_available = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)btx_ok).BeginInit();
            SuspendLayout();
            // 
            // btx_ok
            // 
            btx_ok.BackColor = Color.Transparent;
            btx_ok.Cursor = Cursors.Hand;
            btx_ok.Image = (Image)resources.GetObject("btx_ok.Image");
            btx_ok.Location = new Point(406, 334);
            btx_ok.Name = "btx_ok";
            btx_ok.Size = new Size(41, 39);
            btx_ok.SizeMode = PictureBoxSizeMode.StretchImage;
            btx_ok.TabIndex = 35;
            btx_ok.TabStop = false;
            btx_ok.Click += btx_ok_Click;
            // 
            // cbx_equipmentType
            // 
            cbx_equipmentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_equipmentType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_equipmentType.FormattingEnabled = true;
            cbx_equipmentType.Location = new Point(188, 165);
            cbx_equipmentType.Name = "cbx_equipmentType";
            cbx_equipmentType.Size = new Size(163, 23);
            cbx_equipmentType.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(10, 165);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(174, 21);
            label8.TabIndex = 33;
            label8.Text = "Tipo de Equipamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(10, 97);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 21);
            label3.TabIndex = 28;
            label3.Text = "Matricula/Nº Série";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.BackColor = Color.Transparent;
            lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_name.Location = new Point(10, 48);
            lbl_name.Margin = new Padding(1, 0, 1, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(84, 21);
            lbl_name.TabIndex = 27;
            lbl_name.Text = "Descrição";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.BackColor = Color.Transparent;
            lbl_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_id.Location = new Point(10, 9);
            lbl_id.Margin = new Padding(1, 0, 1, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(27, 21);
            lbl_id.TabIndex = 26;
            lbl_id.Text = "ID";
            // 
            // txt_description
            // 
            txt_description.Location = new Point(188, 50);
            txt_description.Margin = new Padding(1);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(163, 23);
            txt_description.TabIndex = 20;
            // 
            // txt_serialNumber
            // 
            txt_serialNumber.Location = new Point(188, 99);
            txt_serialNumber.Margin = new Padding(1);
            txt_serialNumber.Name = "txt_serialNumber";
            txt_serialNumber.Size = new Size(163, 23);
            txt_serialNumber.TabIndex = 21;
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(188, 11);
            txt_id.Margin = new Padding(1);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(163, 23);
            txt_id.TabIndex = 19;
            // 
            // cbx_Enable
            // 
            cbx_Enable.AutoSize = true;
            cbx_Enable.BackColor = Color.Transparent;
            cbx_Enable.CheckAlign = ContentAlignment.MiddleRight;
            cbx_Enable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cbx_Enable.Location = new Point(129, 137);
            cbx_Enable.Name = "cbx_Enable";
            cbx_Enable.Size = new Size(70, 25);
            cbx_Enable.TabIndex = 36;
            cbx_Enable.Text = "Ativo";
            cbx_Enable.UseVisualStyleBackColor = false;
            // 
            // cbx_available
            // 
            cbx_available.AutoSize = true;
            cbx_available.BackColor = Color.Transparent;
            cbx_available.CheckAlign = ContentAlignment.MiddleRight;
            cbx_available.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cbx_available.Location = new Point(88, 211);
            cbx_available.Name = "cbx_available";
            cbx_available.Size = new Size(111, 25);
            cbx_available.TabIndex = 37;
            cbx_available.Text = "Disponível";
            cbx_available.UseVisualStyleBackColor = false;
            // 
            // Form_EditEquipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(459, 383);
            Controls.Add(cbx_available);
            Controls.Add(cbx_Enable);
            Controls.Add(btx_ok);
            Controls.Add(cbx_equipmentType);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(lbl_name);
            Controls.Add(lbl_id);
            Controls.Add(txt_description);
            Controls.Add(txt_serialNumber);
            Controls.Add(txt_id);
            Name = "Form_EditEquipment";
            Text = "Form_EditEquipment";
            Load += Form_EditEquipment_Load;
            ((System.ComponentModel.ISupportInitialize)btx_ok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btx_ok;
        private ComboBox cbx_equipmentType;
        private Label label8;
        private Label label3;
        private Label lbl_name;
        private Label lbl_id;
        private TextBox txt_description;
        private TextBox txt_serialNumber;
        private TextBox txt_id;
        private CheckBox cbx_Enable;
        private CheckBox cbx_available;
    }
}