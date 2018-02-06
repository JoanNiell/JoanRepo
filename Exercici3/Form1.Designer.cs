namespace Exercici3
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
            this.llista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parcials = new System.Windows.Forms.CheckBox();
            this.repeticions = new System.Windows.Forms.TextBox();
            this.boto_iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // llista
            // 
            this.llista.FormattingEnabled = true;
            this.llista.ItemHeight = 16;
            this.llista.Location = new System.Drawing.Point(72, 163);
            this.llista.Name = "llista";
            this.llista.Size = new System.Drawing.Size(438, 260);
            this.llista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calcuar suma desde 1 fins :";
            // 
            // parcials
            // 
            this.parcials.AutoSize = true;
            this.parcials.Location = new System.Drawing.Point(72, 99);
            this.parcials.Name = "parcials";
            this.parcials.Size = new System.Drawing.Size(179, 21);
            this.parcials.TabIndex = 2;
            this.parcials.Text = "Veure resultats parcials";
            this.parcials.UseVisualStyleBackColor = true;
            // 
            // repeticions
            // 
            this.repeticions.Location = new System.Drawing.Point(331, 41);
            this.repeticions.Name = "repeticions";
            this.repeticions.Size = new System.Drawing.Size(67, 22);
            this.repeticions.TabIndex = 3;
            // 
            // boto_iniciar
            // 
            this.boto_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boto_iniciar.Location = new System.Drawing.Point(187, 464);
            this.boto_iniciar.Name = "boto_iniciar";
            this.boto_iniciar.Size = new System.Drawing.Size(210, 47);
            this.boto_iniciar.TabIndex = 4;
            this.boto_iniciar.Text = "INICIAR";
            this.boto_iniciar.UseVisualStyleBackColor = true;
            this.boto_iniciar.Click += new System.EventHandler(this.iniciar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 540);
            this.Controls.Add(this.boto_iniciar);
            this.Controls.Add(this.repeticions);
            this.Controls.Add(this.parcials);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox llista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox parcials;
        private System.Windows.Forms.TextBox repeticions;
        private System.Windows.Forms.Button boto_iniciar;
    }
}

