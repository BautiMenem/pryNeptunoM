namespace pryNeptunoM
{
    partial class frmDatos
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
            this.lblCon = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCiu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(530, 9);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(68, 25);
            this.lblCon.TabIndex = 0;
            this.lblCon.Text = "Datos";
            this.lblCon.Click += new System.EventHandler(this.lblConectar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNomCo,
            this.colNomCon,
            this.colCarg,
            this.colDire,
            this.colCiu,
            this.colReg,
            this.colCod,
            this.colPais,
            this.colTel,
            this.colFax});
            this.dgvDatos.Location = new System.Drawing.Point(24, 80);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1040, 200);
            this.dgvDatos.TabIndex = 2;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id. Cliente";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNomCo
            // 
            this.colNomCo.HeaderText = "Nombre de Compañía";
            this.colNomCo.Name = "colNomCo";
            this.colNomCo.ReadOnly = true;
            // 
            // colNomCon
            // 
            this.colNomCon.HeaderText = "Nombre de Concatcto";
            this.colNomCon.Name = "colNomCon";
            this.colNomCon.ReadOnly = true;
            // 
            // colCarg
            // 
            this.colCarg.HeaderText = "Cargo de Contacto";
            this.colCarg.Name = "colCarg";
            this.colCarg.ReadOnly = true;
            // 
            // colDire
            // 
            this.colDire.HeaderText = "Dirección";
            this.colDire.Name = "colDire";
            this.colDire.ReadOnly = true;
            // 
            // colCiu
            // 
            this.colCiu.HeaderText = "Ciudad";
            this.colCiu.Name = "colCiu";
            this.colCiu.ReadOnly = true;
            // 
            // colReg
            // 
            this.colReg.HeaderText = "Region";
            this.colReg.Name = "colReg";
            this.colReg.ReadOnly = true;
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Código Postal";
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            // 
            // colPais
            // 
            this.colPais.HeaderText = "País";
            this.colPais.Name = "colPais";
            this.colPais.ReadOnly = true;
            // 
            // colTel
            // 
            this.colTel.HeaderText = "Teléfono";
            this.colTel.Name = "colTel";
            this.colTel.ReadOnly = true;
            // 
            // colFax
            // 
            this.colFax.HeaderText = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.ReadOnly = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(24, 51);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(989, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(24, 293);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 6;
            this.lblPais.Text = "Pais";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(24, 322);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad";
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(77, 290);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(81, 21);
            this.cboPais.TabIndex = 8;
            this.cboPais.SelectedIndexChanged += new System.EventHandler(this.cboPais_SelectedIndexChanged);
            // 
            // cboCiudad
            // 
            this.cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Items.AddRange(new object[] {
            "Id. Cliente",
            "Nombre de Compañia",
            "Nombre de Contacto",
            "Cargo de Contacto",
            "Dirección",
            "Ciudad",
            "Region",
            "Código Postal",
            "País",
            "Teléfono",
            "Fax"});
            this.cboCiudad.Location = new System.Drawing.Point(77, 323);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(81, 21);
            this.cboCiudad.TabIndex = 9;
            this.cboCiudad.SelectedIndexChanged += new System.EventHandler(this.cboCiudad_SelectedIndexChanged);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1097, 385);
            this.Controls.Add(this.cboCiudad);
            this.Controls.Add(this.cboPais);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblCon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEPTUNO - Datos";
            this.Load += new System.EventHandler(this.frmDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDire;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFax;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.ComboBox cboCiudad;
    }
}