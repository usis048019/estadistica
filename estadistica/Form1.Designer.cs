namespace estadistica
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
            this.lblserie = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.btbmediaaritmetica = new System.Windows.Forms.Button();
            this.lblrespuesta_serie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(55, 33);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(39, 13);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "SERIE";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(111, 30);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(100, 20);
            this.txtserie.TabIndex = 1;
            // 
            // btbmediaaritmetica
            // 
            this.btbmediaaritmetica.Location = new System.Drawing.Point(111, 105);
            this.btbmediaaritmetica.Name = "btbmediaaritmetica";
            this.btbmediaaritmetica.Size = new System.Drawing.Size(75, 23);
            this.btbmediaaritmetica.TabIndex = 2;
            this.btbmediaaritmetica.Text = "Calcular X";
            this.btbmediaaritmetica.UseVisualStyleBackColor = true;
            this.btbmediaaritmetica.Click += new System.EventHandler(this.btbmediaaritmetica_Click);
            // 
            // lblrespuesta_serie
            // 
            this.lblrespuesta_serie.AutoSize = true;
            this.lblrespuesta_serie.Location = new System.Drawing.Point(55, 68);
            this.lblrespuesta_serie.Name = "lblrespuesta_serie";
            this.lblrespuesta_serie.Size = new System.Drawing.Size(14, 13);
            this.lblrespuesta_serie.TabIndex = 3;
            this.lblrespuesta_serie.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblrespuesta_serie);
            this.Controls.Add(this.btbmediaaritmetica);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblserie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Button btbmediaaritmetica;
        private System.Windows.Forms.Label lblrespuesta_serie;
    }
}

