namespace Componentes
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnLetras = new System.Windows.Forms.Button();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.btnRFC = new System.Windows.Forms.Button();
            this.txtLetters = new System.Windows.Forms.TextBox();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.btnColor1 = new MyLibrary.BtnColor();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Practica 3. Componentes y librerias";
            // 
            // btnLetras
            // 
            this.btnLetras.BackColor = System.Drawing.Color.IndianRed;
            this.btnLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetras.Location = new System.Drawing.Point(446, 77);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(106, 33);
            this.btnLetras.TabIndex = 1;
            this.btnLetras.Text = "Validar";
            this.btnLetras.UseVisualStyleBackColor = false;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // btnNumeros
            // 
            this.btnNumeros.BackColor = System.Drawing.Color.Tomato;
            this.btnNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeros.Location = new System.Drawing.Point(446, 131);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(106, 38);
            this.btnNumeros.TabIndex = 2;
            this.btnNumeros.Text = "Validar";
            this.btnNumeros.UseVisualStyleBackColor = false;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // btnRFC
            // 
            this.btnRFC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRFC.Location = new System.Drawing.Point(446, 186);
            this.btnRFC.Name = "btnRFC";
            this.btnRFC.Size = new System.Drawing.Size(106, 42);
            this.btnRFC.TabIndex = 3;
            this.btnRFC.Text = "Aceptar";
            this.btnRFC.UseVisualStyleBackColor = false;
            this.btnRFC.Click += new System.EventHandler(this.btnRFC_Click);
            // 
            // txtLetters
            // 
            this.txtLetters.Location = new System.Drawing.Point(245, 88);
            this.txtLetters.Name = "txtLetters";
            this.txtLetters.Size = new System.Drawing.Size(143, 22);
            this.txtLetters.TabIndex = 4;
            this.txtLetters.TextChanged += new System.EventHandler(this.txtLetters_TextChanged);
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(245, 141);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(143, 22);
            this.txtNumbers.TabIndex = 5;
            this.txtNumbers.TextChanged += new System.EventHandler(this.txtNumbers_TextChanged);
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(245, 192);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(143, 22);
            this.txtRFC.TabIndex = 6;
            this.txtRFC.TextChanged += new System.EventHandler(this.txtRFC_TextChanged);
            // 
            // btnColor1
            // 
            this.btnColor1.Location = new System.Drawing.Point(598, 77);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(103, 86);
            this.btnColor1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingresa solo letras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingresa solo numeros:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingresa tu RFC: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnColor1);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.txtLetters);
            this.Controls.Add(this.btnRFC);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Button btnRFC;
        private System.Windows.Forms.TextBox txtLetters;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.TextBox txtRFC;
        private MyLibrary.BtnColor btnColor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

