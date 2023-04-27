namespace MantenimientoClientes
{
    partial class MantCliente
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
            this.panelcreateCliente = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pxbox = new System.Windows.Forms.PictureBox();
            this.linkSelect = new System.Windows.Forms.LinkLabel();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btnNavForm = new System.Windows.Forms.Button();
            this.btnNavSlist = new System.Windows.Forms.Button();
            this.fileDfoto = new System.Windows.Forms.OpenFileDialog();
            this.panelViewCliente = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtaGridClientes = new System.Windows.Forms.DataGridView();
            this.panelcreateCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbox)).BeginInit();
            this.panelViewCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcreateCliente
            // 
            this.panelcreateCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.panelcreateCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelcreateCliente.Controls.Add(this.label2);
            this.panelcreateCliente.Controls.Add(this.label1);
            this.panelcreateCliente.Controls.Add(this.pxbox);
            this.panelcreateCliente.Controls.Add(this.linkSelect);
            this.panelcreateCliente.Controls.Add(this.txtApellidos);
            this.panelcreateCliente.Controls.Add(this.txtNombre);
            this.panelcreateCliente.Controls.Add(this.btn_Guardar);
            this.panelcreateCliente.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.panelcreateCliente.Location = new System.Drawing.Point(193, 97);
            this.panelcreateCliente.Name = "panelcreateCliente";
            this.panelcreateCliente.Size = new System.Drawing.Size(600, 532);
            this.panelcreateCliente.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(189, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellifdo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(189, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // pxbox
            // 
            this.pxbox.BackColor = System.Drawing.Color.Teal;
            this.pxbox.Location = new System.Drawing.Point(189, 46);
            this.pxbox.Name = "pxbox";
            this.pxbox.Size = new System.Drawing.Size(245, 160);
            this.pxbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbox.TabIndex = 8;
            this.pxbox.TabStop = false;
            // 
            // linkSelect
            // 
            this.linkSelect.AutoSize = true;
            this.linkSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkSelect.Location = new System.Drawing.Point(189, 221);
            this.linkSelect.Name = "linkSelect";
            this.linkSelect.Size = new System.Drawing.Size(111, 28);
            this.linkSelect.TabIndex = 7;
            this.linkSelect.TabStop = true;
            this.linkSelect.Text = "Seleccionar";
            this.linkSelect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelect_LinkClicked);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellidos.Location = new System.Drawing.Point(189, 392);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(245, 34);
            this.txtApellidos.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(189, 307);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 34);
            this.txtNombre.TabIndex = 4;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.Location = new System.Drawing.Point(189, 452);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(160, 41);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Save";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btnNavForm
            // 
            this.btnNavForm.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNavForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavForm.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNavForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNavForm.Location = new System.Drawing.Point(540, 28);
            this.btnNavForm.Name = "btnNavForm";
            this.btnNavForm.Size = new System.Drawing.Size(123, 41);
            this.btnNavForm.TabIndex = 1;
            this.btnNavForm.Text = "From";
            this.btnNavForm.UseVisualStyleBackColor = false;
            this.btnNavForm.Click += new System.EventHandler(this.btnNavForm_Click);
            // 
            // btnNavSlist
            // 
            this.btnNavSlist.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNavSlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSlist.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNavSlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSlist.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNavSlist.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnNavSlist.Location = new System.Drawing.Point(670, 28);
            this.btnNavSlist.Name = "btnNavSlist";
            this.btnNavSlist.Size = new System.Drawing.Size(123, 41);
            this.btnNavSlist.TabIndex = 2;
            this.btnNavSlist.Text = "Show List";
            this.btnNavSlist.UseVisualStyleBackColor = false;
            this.btnNavSlist.Click += new System.EventHandler(this.btnNavSlist_Click);
            // 
            // fileDfoto
            // 
            this.fileDfoto.FileName = "openFileDialog1";
            // 
            // panelViewCliente
            // 
            this.panelViewCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.panelViewCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelViewCliente.Controls.Add(this.label3);
            this.panelViewCliente.Controls.Add(this.dtaGridClientes);
            this.panelViewCliente.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.panelViewCliente.Location = new System.Drawing.Point(193, 93);
            this.panelViewCliente.Name = "panelViewCliente";
            this.panelViewCliente.Size = new System.Drawing.Size(600, 532);
            this.panelViewCliente.TabIndex = 10;
            this.panelViewCliente.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Listado de clientes";
            // 
            // dtaGridClientes
            // 
            this.dtaGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridClientes.Location = new System.Drawing.Point(10, 189);
            this.dtaGridClientes.Name = "dtaGridClientes";
            this.dtaGridClientes.RowHeadersWidth = 51;
            this.dtaGridClientes.RowTemplate.Height = 29;
            this.dtaGridClientes.Size = new System.Drawing.Size(580, 337);
            this.dtaGridClientes.TabIndex = 0;
            this.dtaGridClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGridClientes_CellContentDoubleClick);
            // 
            // MantCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panelViewCliente);
            this.Controls.Add(this.btnNavSlist);
            this.Controls.Add(this.btnNavForm);
            this.Controls.Add(this.panelcreateCliente);
            this.Name = "MantCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MantCliente_Load);
            this.panelcreateCliente.ResumeLayout(false);
            this.panelcreateCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbox)).EndInit();
            this.panelViewCliente.ResumeLayout(false);
            this.panelViewCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelcreateCliente;
        private Button btnNavForm;
        private Button btnNavSlist;
        private Label label2;
        private Label label1;
        private PictureBox pxbox;
        private LinkLabel linkSelect;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Button btn_Guardar;
        private OpenFileDialog fileDfoto;
        private Panel panelViewCliente;
        private Label label3;
        private DataGridView dtaGridClientes;
    }
}