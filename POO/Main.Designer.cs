
namespace POO
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_resources = new Button();
            bt_occurrences = new Button();
            bt_fireman = new Button();
            bt_cvprotection = new Button();
            bt_users = new Button();
            SuspendLayout();
            // 
            // bt_resources
            // 
            bt_resources.Location = new Point(24, 44);
            bt_resources.Name = "bt_resources";
            bt_resources.Size = new Size(225, 69);
            bt_resources.TabIndex = 0;
            bt_resources.Text = "Recursos";
            bt_resources.UseVisualStyleBackColor = true;
            bt_resources.Click += this.bt_resources_click;
            // 
            // bt_occurrences
            // 
            bt_occurrences.Location = new Point(24, 119);
            bt_occurrences.Name = "bt_occurrences";
            bt_occurrences.Size = new Size(225, 69);
            bt_occurrences.TabIndex = 1;
            bt_occurrences.Text = "Ocorrências";
            bt_occurrences.UseVisualStyleBackColor = true;
            // 
            // bt_fireman
            // 
            bt_fireman.Location = new Point(24, 194);
            bt_fireman.Name = "bt_fireman";
            bt_fireman.Size = new Size(225, 69);
            bt_fireman.TabIndex = 2;
            bt_fireman.Text = "Bombeiros";
            bt_fireman.UseVisualStyleBackColor = true;
            // 
            // bt_cvprotection
            // 
            bt_cvprotection.Location = new Point(24, 269);
            bt_cvprotection.Name = "bt_cvprotection";
            bt_cvprotection.Size = new Size(225, 69);
            bt_cvprotection.TabIndex = 3;
            bt_cvprotection.Text = "Proteção Cívil";
            bt_cvprotection.UseVisualStyleBackColor = true;
            // 
            // bt_users
            // 
            bt_users.Location = new Point(24, 344);
            bt_users.Name = "bt_users";
            bt_users.Size = new Size(225, 69);
            bt_users.TabIndex = 4;
            bt_users.Text = "Utilizadores";
            bt_users.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1933, 905);
            Controls.Add(bt_users);
            Controls.Add(bt_cvprotection);
            Controls.Add(bt_fireman);
            Controls.Add(bt_occurrences);
            Controls.Add(bt_resources);
            Name = "Main";
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        private void bt_resources_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button bt_resources;
        private Button bt_occurrences;
        private Button bt_fireman;
        private Button bt_cvprotection;
        private Button bt_users;
    }
}
