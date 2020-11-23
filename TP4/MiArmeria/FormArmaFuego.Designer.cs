
namespace MiArmeria
{
    partial class FormArmaFuego
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
            this.nombreArmaFuegoTxt = new System.Windows.Forms.TextBox();
            this.precioArmaFuegoTxt = new System.Windows.Forms.TextBox();
            this.descripcionArmaFuegoTxt = new System.Windows.Forms.TextBox();
            this.LbLNombre = new System.Windows.Forms.Label();
            this.LbLDescripcion = new System.Windows.Forms.Label();
            this.LbLPrecio = new System.Windows.Forms.Label();
            this.capacidadCargadorTxt = new System.Windows.Forms.TextBox();
            this.calibreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreArmaFuegoTxt
            // 
            this.nombreArmaFuegoTxt.AcceptsReturn = true;
            this.nombreArmaFuegoTxt.Location = new System.Drawing.Point(26, 32);
            this.nombreArmaFuegoTxt.Name = "nombreArmaFuegoTxt";
            this.nombreArmaFuegoTxt.Size = new System.Drawing.Size(204, 20);
            this.nombreArmaFuegoTxt.TabIndex = 0;
            // 
            // precioArmaFuegoTxt
            // 
            this.precioArmaFuegoTxt.Location = new System.Drawing.Point(26, 127);
            this.precioArmaFuegoTxt.Name = "precioArmaFuegoTxt";
            this.precioArmaFuegoTxt.Size = new System.Drawing.Size(204, 20);
            this.precioArmaFuegoTxt.TabIndex = 3;
            // 
            // descripcionArmaFuegoTxt
            // 
            this.descripcionArmaFuegoTxt.Location = new System.Drawing.Point(26, 81);
            this.descripcionArmaFuegoTxt.Name = "descripcionArmaFuegoTxt";
            this.descripcionArmaFuegoTxt.Size = new System.Drawing.Size(204, 20);
            this.descripcionArmaFuegoTxt.TabIndex = 4;
            // 
            // LbLNombre
            // 
            this.LbLNombre.AutoSize = true;
            this.LbLNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLNombre.Location = new System.Drawing.Point(22, 9);
            this.LbLNombre.Name = "LbLNombre";
            this.LbLNombre.Size = new System.Drawing.Size(116, 20);
            this.LbLNombre.TabIndex = 5;
            this.LbLNombre.Text = "Nombre arma";
            // 
            // LbLDescripcion
            // 
            this.LbLDescripcion.AutoSize = true;
            this.LbLDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLDescripcion.Location = new System.Drawing.Point(22, 55);
            this.LbLDescripcion.Name = "LbLDescripcion";
            this.LbLDescripcion.Size = new System.Drawing.Size(103, 20);
            this.LbLDescripcion.TabIndex = 6;
            this.LbLDescripcion.Text = "Descripcion";
            // 
            // LbLPrecio
            // 
            this.LbLPrecio.AutoSize = true;
            this.LbLPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLPrecio.Location = new System.Drawing.Point(22, 104);
            this.LbLPrecio.Name = "LbLPrecio";
            this.LbLPrecio.Size = new System.Drawing.Size(59, 20);
            this.LbLPrecio.TabIndex = 7;
            this.LbLPrecio.Text = "Precio";
            // 
            // capacidadCargadorTxt
            // 
            this.capacidadCargadorTxt.Location = new System.Drawing.Point(26, 184);
            this.capacidadCargadorTxt.Name = "capacidadCargadorTxt";
            this.capacidadCargadorTxt.Size = new System.Drawing.Size(204, 20);
            this.capacidadCargadorTxt.TabIndex = 8;
            // 
            // calibreTxt
            // 
            this.calibreTxt.Location = new System.Drawing.Point(26, 230);
            this.calibreTxt.Name = "calibreTxt";
            this.calibreTxt.Size = new System.Drawing.Size(204, 20);
            this.calibreTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Capacidad cargador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Calibre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(134, 256);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 35);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FormArmaFuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 303);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calibreTxt);
            this.Controls.Add(this.capacidadCargadorTxt);
            this.Controls.Add(this.LbLPrecio);
            this.Controls.Add(this.LbLDescripcion);
            this.Controls.Add(this.LbLNombre);
            this.Controls.Add(this.descripcionArmaFuegoTxt);
            this.Controls.Add(this.precioArmaFuegoTxt);
            this.Controls.Add(this.nombreArmaFuegoTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormArmaFuego";
            this.Text = "Agregar arma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreArmaFuegoTxt;
        private System.Windows.Forms.TextBox precioArmaFuegoTxt;
        private System.Windows.Forms.TextBox descripcionArmaFuegoTxt;
        private System.Windows.Forms.Label LbLNombre;
        private System.Windows.Forms.Label LbLDescripcion;
        private System.Windows.Forms.Label LbLPrecio;
        private System.Windows.Forms.TextBox capacidadCargadorTxt;
        private System.Windows.Forms.TextBox calibreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
    }
}