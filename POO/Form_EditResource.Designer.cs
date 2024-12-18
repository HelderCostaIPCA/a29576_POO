namespace POO
{
    partial class Form_EditResource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditResource));
            txt_id = new TextBox();
            txt_household = new TextBox();
            txt_city = new TextBox();
            txt_nif = new TextBox();
            txt_name = new TextBox();
            lbl_id = new Label();
            lbl_name = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dt_dateofbirth = new DateTimePicker();
            cbx_zipcode = new ComboBox();
            cbx_typeresource = new ComboBox();
            btx_ok = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btx_ok).BeginInit();
            SuspendLayout();
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(177, 28);
            txt_id.Margin = new Padding(1);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(163, 23);
            txt_id.TabIndex = 0;
            // 
            // txt_household
            // 
            txt_household.Location = new Point(177, 201);
            txt_household.Margin = new Padding(1);
            txt_household.Name = "txt_household";
            txt_household.Size = new Size(163, 23);
            txt_household.TabIndex = 4;
            // 
            // txt_city
            // 
            txt_city.Location = new Point(177, 292);
            txt_city.Margin = new Padding(1);
            txt_city.Name = "txt_city";
            txt_city.Size = new Size(163, 23);
            txt_city.TabIndex = 6;
            // 
            // txt_nif
            // 
            txt_nif.Location = new Point(177, 115);
            txt_nif.Margin = new Padding(1);
            txt_nif.Name = "txt_nif";
            txt_nif.Size = new Size(163, 23);
            txt_nif.TabIndex = 2;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(177, 67);
            txt_name.Margin = new Padding(1);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(163, 23);
            txt_name.TabIndex = 1;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.BackColor = Color.Transparent;
            lbl_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_id.Location = new Point(14, 24);
            lbl_id.Margin = new Padding(1, 0, 1, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(27, 21);
            lbl_id.TabIndex = 9;
            lbl_id.Text = "ID";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.BackColor = Color.Transparent;
            lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_name.Location = new Point(14, 63);
            lbl_name.Margin = new Padding(1, 0, 1, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(57, 21);
            lbl_name.TabIndex = 10;
            lbl_name.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(14, 112);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 21);
            label3.TabIndex = 11;
            label3.Text = "NIF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(14, 158);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 12;
            label4.Text = "Data Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(14, 198);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 13;
            label5.Text = "Morada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(14, 239);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 14;
            label6.Text = "Código Postal";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(14, 289);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 15;
            label7.Text = "Cidade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(14, 332);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(131, 21);
            label8.TabIndex = 16;
            label8.Text = "Tipo de Recurso";
            // 
            // dt_dateofbirth
            // 
            dt_dateofbirth.Location = new Point(177, 160);
            dt_dateofbirth.Margin = new Padding(1);
            dt_dateofbirth.Name = "dt_dateofbirth";
            dt_dateofbirth.Size = new Size(166, 23);
            dt_dateofbirth.TabIndex = 3;
            // 
            // cbx_zipcode
            // 
            cbx_zipcode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_zipcode.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_zipcode.FormattingEnabled = true;
            cbx_zipcode.Location = new Point(177, 242);
            cbx_zipcode.Name = "cbx_zipcode";
            cbx_zipcode.Size = new Size(163, 23);
            cbx_zipcode.TabIndex = 5;
            cbx_zipcode.SelectedIndexChanged += cbx_zipcode_SelectedIndexChanged;
            // 
            // cbx_typeresource
            // 
            cbx_typeresource.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_typeresource.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_typeresource.FormattingEnabled = true;
            cbx_typeresource.Location = new Point(177, 335);
            cbx_typeresource.Name = "cbx_typeresource";
            cbx_typeresource.Size = new Size(163, 23);
            cbx_typeresource.TabIndex = 17;
            cbx_typeresource.SelectedIndexChanged += cbx_typeresource_SelectedIndexChanged;
            // 
            // btx_ok
            // 
            btx_ok.BackColor = Color.Transparent;
            btx_ok.Cursor = Cursors.Hand;
            btx_ok.Image = (Image)resources.GetObject("btx_ok.Image");
            btx_ok.Location = new Point(410, 349);
            btx_ok.Name = "btx_ok";
            btx_ok.Size = new Size(41, 39);
            btx_ok.SizeMode = PictureBoxSizeMode.StretchImage;
            btx_ok.TabIndex = 18;
            btx_ok.TabStop = false;
            btx_ok.Click += btn_ok_Click;
            // 
            // Form_Edit_Resource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(463, 400);
            Controls.Add(btx_ok);
            Controls.Add(cbx_typeresource);
            Controls.Add(cbx_zipcode);
            Controls.Add(dt_dateofbirth);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_name);
            Controls.Add(lbl_id);
            Controls.Add(txt_name);
            Controls.Add(txt_nif);
            Controls.Add(txt_city);
            Controls.Add(txt_household);
            Controls.Add(txt_id);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            MaximizeBox = false;
            Name = "Form_Edit_Resource";
            Text = "Editar Recurso";
            Load += Form_Edit_Resource_Load;
            ((System.ComponentModel.ISupportInitialize)btx_ok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_id;
        private TextBox txt_household;
        private TextBox txt_city;
        private TextBox txt_nif;
        private TextBox txt_name;
        private Label lbl_id;
        private Label lbl_name;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dt_dateofbirth;
        private ComboBox cbx_zipcode;
        private ComboBox cbx_typeresource;
        private PictureBox btx_ok;
    }
}