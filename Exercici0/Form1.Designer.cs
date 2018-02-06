namespace P02_Interfícies_d_usuari
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
            this.label1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(38, 63);
            this.num1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(112, 26);
            this.num1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(214, 63);
            this.num2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(112, 26);
            this.num2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(375, 63);
            this.result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(116, 26);
            this.result.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "CALCULA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 247);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button button1;
    }
}

