namespace POO
{
    partial class Form_EditOccurrence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditOccurrence));
            btx_ok = new PictureBox();
            cbx_zipcode = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lbl_coordinates = new Label();
            lbl_description = new Label();
            lbl_id = new Label();
            txt_description = new TextBox();
            txt_coordinates = new TextBox();
            txt_city = new TextBox();
            txt_household = new TextBox();
            txt_id = new TextBox();
            dt_date = new DateTimePicker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)btx_ok).BeginInit();
            SuspendLayout();
            // 
            // btx_ok
            // 
            btx_ok.BackColor = Color.Transparent;
            btx_ok.Cursor = Cursors.Hand;
            btx_ok.Image = (Image)resources.GetObject("btx_ok.Image");
            btx_ok.Location = new Point(412, 353);
            btx_ok.Name = "btx_ok";
            btx_ok.Size = new Size(41, 39);
            btx_ok.SizeMode = PictureBoxSizeMode.StretchImage;
            btx_ok.TabIndex = 38;
            btx_ok.TabStop = false;
            btx_ok.Click += btx_ok_Click;
            // 
            // cbx_zipcode
            // 
            cbx_zipcode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_zipcode.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_zipcode.FormattingEnabled = true;
            cbx_zipcode.Location = new Point(179, 212);
            cbx_zipcode.Name = "cbx_zipcode";
            cbx_zipcode.Size = new Size(163, 23);
            cbx_zipcode.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(16, 262);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 35;
            label7.Text = "Cidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(16, 209);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 34;
            label6.Text = "Código Postal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(16, 161);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 33;
            label5.Text = "Morada";
            // 
            // lbl_coordinates
            // 
            lbl_coordinates.AutoSize = true;
            lbl_coordinates.BackColor = Color.Transparent;
            lbl_coordinates.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_coordinates.Location = new Point(16, 115);
            lbl_coordinates.Margin = new Padding(1, 0, 1, 0);
            lbl_coordinates.Name = "lbl_coordinates";
            lbl_coordinates.Size = new Size(110, 21);
            lbl_coordinates.TabIndex = 31;
            lbl_coordinates.Text = "Coordenadas";
            // 
            // lbl_description
            // 
            lbl_description.AutoSize = true;
            lbl_description.BackColor = Color.Transparent;
            lbl_description.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_description.Location = new Point(16, 67);
            lbl_description.Margin = new Padding(1, 0, 1, 0);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(84, 21);
            lbl_description.TabIndex = 30;
            lbl_description.Text = "Descrição";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.BackColor = Color.Transparent;
            lbl_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_id.Location = new Point(16, 28);
            lbl_id.Margin = new Padding(1, 0, 1, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(27, 21);
            lbl_id.TabIndex = 29;
            lbl_id.Text = "ID";
            // 
            // txt_description
            // 
            txt_description.Location = new Point(179, 70);
            txt_description.Margin = new Padding(1);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(163, 23);
            txt_description.TabIndex = 23;
            // 
            // txt_coordinates
            // 
            txt_coordinates.Location = new Point(179, 118);
            txt_coordinates.Margin = new Padding(1);
            txt_coordinates.Name = "txt_coordinates";
            txt_coordinates.Size = new Size(163, 23);
            txt_coordinates.TabIndex = 24;
            // 
            // txt_city
            // 
            txt_city.Location = new Point(179, 266);
            txt_city.Margin = new Padding(1);
            txt_city.Name = "txt_city";
            txt_city.Size = new Size(163, 23);
            txt_city.TabIndex = 28;
            // 
            // txt_household
            // 
            txt_household.Location = new Point(179, 164);
            txt_household.Margin = new Padding(1);
            txt_household.Name = "txt_household";
            txt_household.Size = new Size(163, 23);
            txt_household.TabIndex = 26;
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(179, 31);
            txt_id.Margin = new Padding(1);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(163, 23);
            txt_id.TabIndex = 22;
            // 
            // dt_date
            // 
            dt_date.Location = new Point(176, 318);
            dt_date.Margin = new Padding(1);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(166, 23);
            dt_date.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(13, 315);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 42;
            label4.Text = "Data";
            // 
            // Form_EditOccurrence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(463, 400);
            Controls.Add(dt_date);
            Controls.Add(label4);
            Controls.Add(btx_ok);
            Controls.Add(cbx_zipcode);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbl_coordinates);
            Controls.Add(lbl_description);
            Controls.Add(lbl_id);
            Controls.Add(txt_description);
            Controls.Add(txt_coordinates);
            Controls.Add(txt_city);
            Controls.Add(txt_household);
            Controls.Add(txt_id);
            Margin = new Padding(1);
            Name = "Form_EditOccurrence";
            Text = "Editar Ocorrência";
            Load += Form_EditOccurrence_Load;
            ((System.ComponentModel.ISupportInitialize)btx_ok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox btx_ok;
        private ComboBox cbx_zipcode;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lbl_coordinates;
        private Label lbl_description;
        private Label lbl_id;
        private TextBox txt_description;
        private TextBox txt_coordinates;
        private TextBox txt_city;
        private TextBox txt_household;
        private TextBox txt_id;
        private DateTimePicker dt_date;
        private Label label4;
    }
}