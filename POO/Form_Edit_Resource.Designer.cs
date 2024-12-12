namespace POO
{
    partial class Form_Edit_Resource
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
            txt_id = new TextBox();
            txt_household = new TextBox();
            txt_city = new TextBox();
            txt_nif = new TextBox();
            txt_name = new TextBox();
            btn_ok = new Button();
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
            SuspendLayout();
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(155, 16);
            txt_id.Margin = new Padding(1);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(163, 23);
            txt_id.TabIndex = 0;
            // 
            // txt_household
            // 
            txt_household.Location = new Point(155, 112);
            txt_household.Margin = new Padding(1);
            txt_household.Name = "txt_household";
            txt_household.Size = new Size(163, 23);
            txt_household.TabIndex = 4;
            // 
            // txt_city
            // 
            txt_city.Location = new Point(155, 160);
            txt_city.Margin = new Padding(1);
            txt_city.Name = "txt_city";
            txt_city.Size = new Size(163, 23);
            txt_city.TabIndex = 6;
            // 
            // txt_nif
            // 
            txt_nif.Location = new Point(155, 62);
            txt_nif.Margin = new Padding(1);
            txt_nif.Name = "txt_nif";
            txt_nif.Size = new Size(163, 23);
            txt_nif.TabIndex = 2;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(155, 39);
            txt_name.Margin = new Padding(1);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(163, 23);
            txt_name.TabIndex = 1;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(182, 218);
            btn_ok.Margin = new Padding(1);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(79, 22);
            btn_ok.TabIndex = 8;
            btn_ok.Text = "Ok";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(14, 17);
            lbl_id.Margin = new Padding(1, 0, 1, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(18, 15);
            lbl_id.TabIndex = 9;
            lbl_id.Text = "ID";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(14, 40);
            lbl_name.Margin = new Padding(1, 0, 1, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(40, 15);
            lbl_name.TabIndex = 10;
            lbl_name.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 63);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 11;
            label3.Text = "NIF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 89);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 12;
            label4.Text = "Data Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 113);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 13;
            label5.Text = "Morada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 139);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 14;
            label6.Text = "Código Postal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 163);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 15;
            label7.Text = "Cidade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 186);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 16;
            label8.Text = "Tipo de Recurso";
            // 
            // dt_dateofbirth
            // 
            dt_dateofbirth.Location = new Point(152, 89);
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
            cbx_zipcode.Location = new Point(155, 136);
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
            cbx_typeresource.Location = new Point(155, 187);
            cbx_typeresource.Name = "cbx_typeresource";
            cbx_typeresource.Size = new Size(163, 23);
            cbx_typeresource.TabIndex = 17;
            // 
            // Form_Edit_Resource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 400);
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
            Controls.Add(btn_ok);
            Controls.Add(txt_name);
            Controls.Add(txt_nif);
            Controls.Add(txt_city);
            Controls.Add(txt_household);
            Controls.Add(txt_id);
            Margin = new Padding(1);
            Name = "Form_Edit_Resource";
            Text = "Form_Edit_Resource";
            Load += Form_Edit_Resource_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_id;
        private TextBox txt_household;
        private TextBox txt_city;
        private TextBox txt_nif;
        private TextBox txt_name;
        private Button btn_ok;
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
    }
}