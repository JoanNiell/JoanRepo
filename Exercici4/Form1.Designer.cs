namespace Exercici4
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultat = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.RadioButton();
            this.resta = new System.Windows.Forms.RadioButton();
            this.divisio = new System.Windows.Forms.RadioButton();
            this.multiplicacio = new System.Windows.Forms.RadioButton();
            this.botoCalcula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(70, 161);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(116, 22);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(384, 161);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(113, 22);
            this.num2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(576, 161);
            this.resultat.Name = "resultat";
            this.resultat.ReadOnly = true;
            this.resultat.Size = new System.Drawing.Size(151, 22);
            this.resultat.TabIndex = 3;
            // 
            // suma
            // 
            this.suma.AutoSize = true;
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(215, 120);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(72, 21);
            this.suma.TabIndex = 4;
            this.suma.TabStop = true;
            this.suma.Text = "SUMA";
            this.suma.UseVisualStyleBackColor = true;
            // 
            // resta
            // 
            this.resta.AutoSize = true;
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.Location = new System.Drawing.Point(215, 147);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(80, 21);
            this.resta.TabIndex = 5;
            this.resta.TabStop = true;
            this.resta.Text = "RESTA";
            this.resta.UseVisualStyleBackColor = true;
            // 
            // divisio
            // 
            this.divisio.AutoSize = true;
            this.divisio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisio.Location = new System.Drawing.Point(215, 174);
            this.divisio.Name = "divisio";
            this.divisio.Size = new System.Drawing.Size(84, 21);
            this.divisio.TabIndex = 6;
            this.divisio.TabStop = true;
            this.divisio.Text = "DIVISIÓ";
            this.divisio.UseVisualStyleBackColor = true;
            // 
            // multiplicacio
            // 
            this.multiplicacio.AutoSize = true;
            this.multiplicacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacio.Location = new System.Drawing.Point(215, 201);
            this.multiplicacio.Name = "multiplicacio";
            this.multiplicacio.Size = new System.Drawing.Size(144, 21);
            this.multiplicacio.TabIndex = 7;
            this.multiplicacio.TabStop = true;
            this.multiplicacio.Text = "MULTIPLICACIÓ";
            this.multiplicacio.UseVisualStyleBackColor = true;
            // 
            // botoCalcula
            // 
            this.botoCalcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoCalcula.Location = new System.Drawing.Point(298, 278);
            this.botoCalcula.Name = "botoCalcula";
            this.botoCalcula.Size = new System.Drawing.Size(250, 53);
            this.botoCalcula.TabIndex = 8;
            this.botoCalcula.Text = "Calcula";
            this.botoCalcula.UseVisualStyleBackColor = true;
            this.botoCalcula.Click += new System.EventHandler(this.Calcul);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 424);
            this.Controls.Add(this.botoCalcula);
            this.Controls.Add(this.multiplicacio);
            this.Controls.Add(this.divisio);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultat;
        private System.Windows.Forms.RadioButton suma;
        private System.Windows.Forms.RadioButton resta;
        private System.Windows.Forms.RadioButton divisio;
        private System.Windows.Forms.RadioButton multiplicacio;
        private System.Windows.Forms.Button botoCalcula;
    }
}

