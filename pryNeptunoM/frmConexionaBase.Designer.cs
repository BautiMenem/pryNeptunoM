namespace pryNeptunoM
{
    partial class frmConexionaBase
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
            this.btnElegir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(201, 40);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(75, 23);
            this.btnElegir.TabIndex = 0;
            this.btnElegir.Text = "Elegir Base";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // frmConexionaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 266);
            this.Controls.Add(this.btnElegir);
            this.Name = "frmConexionaBase";
            this.Text = "frmConexionaBase";
            this.Load += new System.EventHandler(this.frmConexionaBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElegir;
    }
}