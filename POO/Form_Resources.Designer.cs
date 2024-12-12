namespace POO
{
    partial class Form_Resources
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
            gpx_resource = new GroupBox();
            dataGridView1 = new DataGridView();
            btn_update = new Button();
            btn_delete = new Button();
            btn_create = new Button();
            gpx_typeresource = new GroupBox();
            dtg_typeresource = new DataGridView();
            btx_updatetyperesource = new Button();
            btx_deletetyperesource = new Button();
            btx_CreateTypeResource = new Button();
            btn_typeresource = new Button();
            btn_managementresource = new Button();
            gpx_resource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gpx_typeresource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_typeresource).BeginInit();
            SuspendLayout();
            // 
            // gpx_resource
            // 
            gpx_resource.Controls.Add(dataGridView1);
            gpx_resource.Controls.Add(btn_update);
            gpx_resource.Controls.Add(btn_delete);
            gpx_resource.Controls.Add(btn_create);
            gpx_resource.Location = new Point(85, 4);
            gpx_resource.Margin = new Padding(1);
            gpx_resource.Name = "gpx_resource";
            gpx_resource.Padding = new Padding(1);
            gpx_resource.Size = new Size(429, 282);
            gpx_resource.TabIndex = 0;
            gpx_resource.TabStop = false;
            gpx_resource.Text = "Gestão Recursos";
            gpx_resource.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 28);
            dataGridView1.Margin = new Padding(1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 123;
            dataGridView1.Size = new Size(380, 197);
            dataGridView1.TabIndex = 3;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(182, 247);
            btn_update.Margin = new Padding(1);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(79, 22);
            btn_update.TabIndex = 2;
            btn_update.Text = "Editar";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btnUpdate_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(344, 247);
            btn_delete.Margin = new Padding(1);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(79, 22);
            btn_delete.TabIndex = 1;
            btn_delete.Text = "Eliminar";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btnDelete_Click;
            // 
            // btn_create
            // 
            btn_create.Location = new Point(263, 247);
            btn_create.Margin = new Padding(1);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(79, 22);
            btn_create.TabIndex = 0;
            btn_create.Text = "Novo";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btnCreate_Click;
            // 
            // gpx_typeresource
            // 
            gpx_typeresource.Controls.Add(dtg_typeresource);
            gpx_typeresource.Controls.Add(btx_updatetyperesource);
            gpx_typeresource.Controls.Add(btx_deletetyperesource);
            gpx_typeresource.Controls.Add(btx_CreateTypeResource);
            gpx_typeresource.Location = new Point(83, 4);
            gpx_typeresource.Margin = new Padding(1);
            gpx_typeresource.Name = "gpx_typeresource";
            gpx_typeresource.Padding = new Padding(1);
            gpx_typeresource.Size = new Size(429, 282);
            gpx_typeresource.TabIndex = 4;
            gpx_typeresource.TabStop = false;
            gpx_typeresource.Text = "Tipo Recursos";
            gpx_typeresource.Visible = false;
            // 
            // dtg_typeresource
            // 
            dtg_typeresource.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_typeresource.Location = new Point(24, 28);
            dtg_typeresource.Margin = new Padding(1);
            dtg_typeresource.Name = "dtg_typeresource";
            dtg_typeresource.RowHeadersWidth = 123;
            dtg_typeresource.Size = new Size(380, 197);
            dtg_typeresource.TabIndex = 3;
            // 
            // btx_updatetyperesource
            // 
            btx_updatetyperesource.Location = new Point(182, 247);
            btx_updatetyperesource.Margin = new Padding(1);
            btx_updatetyperesource.Name = "btx_updatetyperesource";
            btx_updatetyperesource.Size = new Size(79, 22);
            btx_updatetyperesource.TabIndex = 2;
            btx_updatetyperesource.Text = "Editar";
            btx_updatetyperesource.UseVisualStyleBackColor = true;
            // 
            // btx_deletetyperesource
            // 
            btx_deletetyperesource.Location = new Point(344, 247);
            btx_deletetyperesource.Margin = new Padding(1);
            btx_deletetyperesource.Name = "btx_deletetyperesource";
            btx_deletetyperesource.Size = new Size(79, 22);
            btx_deletetyperesource.TabIndex = 1;
            btx_deletetyperesource.Text = "Eliminar";
            btx_deletetyperesource.UseVisualStyleBackColor = true;
            // 
            // btx_CreateTypeResource
            // 
            btx_CreateTypeResource.Location = new Point(263, 247);
            btx_CreateTypeResource.Margin = new Padding(1);
            btx_CreateTypeResource.Name = "btx_CreateTypeResource";
            btx_CreateTypeResource.Size = new Size(79, 22);
            btx_CreateTypeResource.TabIndex = 0;
            btx_CreateTypeResource.Text = "Novo";
            btx_CreateTypeResource.UseVisualStyleBackColor = true;
            btx_CreateTypeResource.Click += btx_CreateTypeResource_Click;
            // 
            // btn_typeresource
            // 
            btn_typeresource.Location = new Point(4, 41);
            btn_typeresource.Margin = new Padding(1);
            btn_typeresource.Name = "btn_typeresource";
            btn_typeresource.Size = new Size(79, 22);
            btn_typeresource.TabIndex = 2;
            btn_typeresource.Text = "Tipos de Recursos";
            btn_typeresource.UseVisualStyleBackColor = true;
            btn_typeresource.Click += btn_typeresource_Click;
            // 
            // btn_managementresource
            // 
            btn_managementresource.Location = new Point(4, 18);
            btn_managementresource.Margin = new Padding(1);
            btn_managementresource.Name = "btn_managementresource";
            btn_managementresource.Size = new Size(79, 22);
            btn_managementresource.TabIndex = 3;
            btn_managementresource.Text = "Gestão Recursos";
            btn_managementresource.UseVisualStyleBackColor = true;
            btn_managementresource.Click += btn_managementresource_Click;
            // 
            // Form_Resources
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 289);
            Controls.Add(gpx_typeresource);
            Controls.Add(btn_typeresource);
            Controls.Add(btn_managementresource);
            Controls.Add(gpx_resource);
            Margin = new Padding(1);
            Name = "Form_Resources";
            Text = "Resources";
            Load += Form_Resources_Load;
            gpx_resource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gpx_typeresource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_typeresource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpx_resource;
        private Button btn_delete;
        private Button btn_create;
        private Button btn_typeresource;
        private Button btn_managementresource;
        private Button btn_update;
        private DataGridView dataGridView1;
        private GroupBox gpx_typeresource;
        private DataGridView dtg_typeresource;
        private Button btx_updatetyperesource;
        private Button btx_deletetyperesource;
        private Button btx_CreateTypeResource;
    }
}