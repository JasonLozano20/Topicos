namespace MyLibrary
{
    partial class BtnColor
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnColors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColors
            // 
            this.btnColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColors.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColors.Location = new System.Drawing.Point(0, 0);
            this.btnColors.Name = "btnColors";
            this.btnColors.Size = new System.Drawing.Size(103, 86);
            this.btnColors.TabIndex = 0;
            this.btnColors.Text = "Aceptar";
            this.btnColors.UseVisualStyleBackColor = true;
            this.btnColors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnColors_MouseDown);
            this.btnColors.MouseEnter += new System.EventHandler(this.btnColors_MouseEnter);
            this.btnColors.MouseLeave += new System.EventHandler(this.btnColors_MouseLeave);
            // 
            // BtnColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnColors);
            this.Name = "BtnColor";
            this.Size = new System.Drawing.Size(103, 86);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColors;
    }
}
