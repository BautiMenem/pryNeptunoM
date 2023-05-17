namespace pryNeptunoM
{
    partial class FrmMenu
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNeptuno = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(311, 161);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostarDatosToolStripMenuItem,
            this.filtarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // mostarDatosToolStripMenuItem
            // 
            this.mostarDatosToolStripMenuItem.Name = "mostarDatosToolStripMenuItem";
            this.mostarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostarDatosToolStripMenuItem.Text = "Mostar Datos";
            this.mostarDatosToolStripMenuItem.Click += new System.EventHandler(this.mostarDatosToolStripMenuItem_Click);
            // 
            // filtarClientesToolStripMenuItem
            // 
            this.filtarClientesToolStripMenuItem.Name = "filtarClientesToolStripMenuItem";
            this.filtarClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filtarClientesToolStripMenuItem.Text = "Filtar Clientes";
            this.filtarClientesToolStripMenuItem.Click += new System.EventHandler(this.filtarClientesToolStripMenuItem_Click);
            // 
            // lblNeptuno
            // 
            this.lblNeptuno.AutoSize = true;
            this.lblNeptuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeptuno.Location = new System.Drawing.Point(90, 50);
            this.lblNeptuno.Name = "lblNeptuno";
            this.lblNeptuno.Size = new System.Drawing.Size(229, 33);
            this.lblNeptuno.TabIndex = 5;
            this.lblNeptuno.Text = "NEPTUNO. SRL";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(402, 196);
            this.Controls.Add(this.lblNeptuno);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEPTUNO - Menú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtarClientesToolStripMenuItem;
        private System.Windows.Forms.Label lblNeptuno;
    }
}