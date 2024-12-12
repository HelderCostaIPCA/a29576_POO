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
            btx_ok = new Button();
            cbx_Enable = new CheckBox();
            txt_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_id = new TextBox();
            SuspendLayout();
            // 
            // btx_ok
            // 
            btx_ok.Location = new Point(380, 377);
            btx_ok.Name = "btx_ok";
            btx_ok.Size = new Size(75, 23);
            btx_ok.TabIndex = 0;
            btx_ok.Text = "Ok";
            btx_ok.UseVisualStyleBackColor = true;
            btx_ok.Click += btn_ok_Click;
            // 
            // cbx_Enable
            // 
            cbx_Enable.AutoSize = true;
            cbx_Enable.Location = new Point(212, 175);
            cbx_Enable.Name = "cbx_Enable";
            cbx_Enable.Size = new Size(54, 19);
            cbx_Enable.TabIndex = 1;
            cbx_Enable.Text = "Ativo";
            cbx_Enable.UseVisualStyleBackColor = true;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(194, 115);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 119);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 83);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(194, 75);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 5;
            // 
            // Form_EditTypeResource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_name);
            Controls.Add(cbx_Enable);
            Controls.Add(btx_ok);
            Name = "Form_EditTypeResource";
            Text = "Form_EditeTypeResource";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btx_ok;
        private CheckBox cbx_Enable;
        private TextBox txt_name;
        private Label label1;
        private Label label2;
        private TextBox txt_id;
    }
}