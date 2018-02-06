namespace Exercici2
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
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.Calcula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com desitja rebre l\'enviament?";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Location = new System.Drawing.Point(58, 68);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(181, 21);
            this.radio1.TabIndex = 1;
            this.radio1.TabStop = true;
            this.radio1.Text = "Per correu normal (50€)";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(58, 107);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(217, 21);
            this.radio2.TabIndex = 2;
            this.radio2.Text = "Per Paquetaria normal (100€)";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(58, 144);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(217, 21);
            this.radio3.TabIndex = 3;
            this.radio3.Text = "Per Paquetaria Urgent (150€)";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Com desitja ser notificat de l\'enviament? (Marcar totes les desitjades)";
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(58, 230);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(120, 21);
            this.check1.TabIndex = 5;
            this.check1.Text = "Per Email (5€)";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(58, 266);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(142, 21);
            this.check2.TabIndex = 6;
            this.check2.Text = "Per Telefon (15€)";
            this.check2.UseVisualStyleBackColor = true;
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(58, 302);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(116, 21);
            this.check3.TabIndex = 7;
            this.check3.Text = "Per Fax (20€)";
            this.check3.UseVisualStyleBackColor = true;
            // 
            // Calcula
            // 
            this.Calcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcula.Location = new System.Drawing.Point(146, 347);
            this.Calcula.Name = "Calcula";
            this.Calcula.Size = new System.Drawing.Size(352, 35);
            this.Calcula.TabIndex = 8;
            this.Calcula.Text = "Calcular despeses d\'enviament";
            this.Calcula.UseVisualStyleBackColor = true;
            this.Calcula.Click += new System.EventHandler(this.CalculaGastos);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 403);
            this.Controls.Add(this.Calcula);
            this.Controls.Add(this.check3);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.Button Calcula;
    }
}

