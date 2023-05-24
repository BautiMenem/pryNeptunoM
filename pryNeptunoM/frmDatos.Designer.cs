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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(260, 9);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(68, 25);
            this.lblCon.TabIndex = 0;
            this.lblCon.Text = "Datos";
            this.lblCon.Click += new System.EventHandler(this.lblConectar_Click);
            // 
            // dgvDatos
            // 
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
            this.dgvDatos.Size = new System.Drawing.Size(542, 200);
            this.dgvDatos.TabIndex = 2;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id. Cliente";
            this.colId.Name = "colId";
            // 
            // colNomCo
            // 
            this.colNomCo.HeaderText = "Nombre de Compañía";
            this.colNomCo.Name = "colNomCo";
            // 
            // colNomCon
            // 
            this.colNomCon.HeaderText = "Nombre de Concatcto";
            this.colNomCon.Name = "colNomCon";
            // 
            // colCarg
            // 
            this.colCarg.HeaderText = "Cargo de Contacto";
            this.colCarg.Name = "colCarg";
            // 
            // colDire
            // 
            this.colDire.HeaderText = "Dirección";
            this.colDire.Name = "colDire";
            // 
            // colCiu
            // 
            this.colCiu.HeaderText = "Ciudad";
            this.colCiu.Name = "colCiu";
            // 
            // colReg
            // 
            this.colReg.HeaderText = "Region";
            this.colReg.Name = "colReg";
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Código Postal";
            this.colCod.Name = "colCod";
            // 
            // colPais
            // 
            this.colPais.HeaderText = "País";
            this.colPais.Name = "colPais";
            // 
            // colTel
            // 
            this.colTel.HeaderText = "Teléfono";
            this.colTel.Name = "colTel";
            // 
            // colFax
            // 
            this.colFax.HeaderText = "Fax";
            this.colFax.Name = "colFax";
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
            this.btnSalir.Location = new System.Drawing.Point(491, 286);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(579, 323);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblCon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d ffod+  sa gas ggas g   ww";
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
    }
}