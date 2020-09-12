namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.btnBinario = new System.Windows.Forms.Button();
            this.Operar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBinario
            // 
            this.btnBinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBinario.Location = new System.Drawing.Point(55, 354);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(351, 70);
            this.btnBinario.TabIndex = 1;
            this.btnBinario.Text = "Convertir a Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnConvertirABinario_click);
            // 
            // Operar
            // 
            this.Operar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Operar.Location = new System.Drawing.Point(55, 279);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(229, 48);
            this.Operar.TabIndex = 3;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = true;
            this.Operar.Click += new System.EventHandler(this.btnOperar);
            // 
            // cerrar
            // 
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Location = new System.Drawing.Point(549, 279);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(229, 48);
            this.cerrar.TabIndex = 8;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // limpiar
            // 
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar.Location = new System.Drawing.Point(301, 279);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(229, 48);
            this.limpiar.TabIndex = 9;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.Location = new System.Drawing.Point(427, 354);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(351, 70);
            this.btnDecimal.TabIndex = 10;
            this.btnDecimal.Text = "Convertir a Decimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(346, 179);
            this.comboBox1.Name = "cmbOperador";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
           
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(65, 179);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(219, 20);
            this.txtNumero1.TabIndex = 12;
         
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(549, 179);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(219, 20);
            this.txtNumero2.TabIndex = 13;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.Operar);
            this.Controls.Add(this.btnBinario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Juan Pablo Dos Santos 2°A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
    }
}

