
namespace MiArmeria
{
    partial class FormArmaBlanca
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
            this.nombreArmaBlancaTxt = new System.Windows.Forms.TextBox();
            this.precioArmaBlancaTxt = new System.Windows.Forms.TextBox();
            this.descripcionArmaBlancaTxt = new System.Windows.Forms.TextBox();
            this.LbLNombre = new System.Windows.Forms.Label();
            this.LbLDescripcion = new System.Windows.Forms.Label();
            this.LbLPrecio = new System.Windows.Forms.Label();
            this.materialArmaBlancaTxt = new System.Windows.Forms.TextBox();
            this.longitudArmaBlancaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreArmaBlancaTxt
            // 
            this.nombreArmaBlancaTxt.Location = new System.Drawing.Point(32, 37);
            this.nombreArmaBlancaTxt.Name = "nombreArmaBlancaTxt";
            this.nombreArmaBlancaTxt.Size = new System.Drawing.Size(204, 20);
            this.nombreArmaBlancaTxt.TabIndex = 0;
            // 
            // precioArmaBlancaTxt
            // 
            this.precioArmaBlancaTxt.Location = new System.Drawing.Point(32, 134);
            this.precioArmaBlancaTxt.Name = "precioArmaBlancaTxt";
            this.precioArmaBlancaTxt.Size = new System.Drawing.Size(204, 20);
            this.precioArmaBlancaTxt.TabIndex = 3;
            // 
            // descripcionArmaBlancaTxt
            // 
            this.descripcionArmaBlancaTxt.Location = new System.Drawing.Point(32, 81);
            this.descripcionArmaBlancaTxt.Name = "descripcionArmaBlancaTxt";
            this.descripcionArmaBlancaTxt.Size = new System.Drawing.Size(204, 20);
            this.descripcionArmaBlancaTxt.TabIndex = 4;
            // 
            // LbLNombre
            // 
            this.LbLNombre.AutoSize = true;
            this.LbLNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLNombre.Location = new System.Drawing.Point(28, 9);
            this.LbLNombre.Name = "LbLNombre";
            this.LbLNombre.Size = new System.Drawing.Size(116, 20);
            this.LbLNombre.TabIndex = 5;
            this.LbLNombre.Text = "Nombre arma";
            // 
            // LbLDescripcion
            // 
            this.LbLDescripcion.AutoSize = true;
            this.LbLDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLDescripcion.Location = new System.Drawing.Point(28, 60);
            this.LbLDescripcion.Name = "LbLDescripcion";
            this.LbLDescripcion.Size = new System.Drawing.Size(103, 20);
            this.LbLDescripcion.TabIndex = 6;
            this.LbLDescripcion.Text = "Descripcion";
            // 
            // LbLPrecio
            // 
            this.LbLPrecio.AutoSize = true;
            this.LbLPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLPrecio.Location = new System.Drawing.Point(28, 111);
            this.LbLPrecio.Name = "LbLPrecio";
            this.LbLPrecio.Size = new System.Drawing.Size(59, 20);
            this.LbLPrecio.TabIndex = 7;
            this.LbLPrecio.Text = "Precio";
            // 
            // materialArmaBlancaTxt
            // 
            this.materialArmaBlancaTxt.Location = new System.Drawing.Point(31, 180);
            this.materialArmaBlancaTxt.Name = "materialArmaBlancaTxt";
            this.materialArmaBlancaTxt.Size = new System.Drawing.Size(204, 20);
            this.materialArmaBlancaTxt.TabIndex = 8;
            // 
            // longitudArmaBlancaTxt
            // 
            this.longitudArmaBlancaTxt.Location = new System.Drawing.Point(32, 226);
            this.longitudArmaBlancaTxt.Name = "longitudArmaBlancaTxt";
            this.longitudArmaBlancaTxt.Size = new System.Drawing.Size(204, 20);
            this.longitudArmaBlancaTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Material ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Longitud";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(140, 252);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 35);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FormArmaBlanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 299);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.longitudArmaBlancaTxt);
            this.Controls.Add(this.materialArmaBlancaTxt);
            this.Controls.Add(this.LbLPrecio);
            this.Controls.Add(this.LbLDescripcion);
            this.Controls.Add(this.LbLNombre);
            this.Controls.Add(this.descripcionArmaBlancaTxt);
            this.Controls.Add(this.precioArmaBlancaTxt);
            this.Controls.Add(this.nombreArmaBlancaTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormArmaBlanca";
            this.Text = "Agregar arma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreArmaBlancaTxt;
        private System.Windows.Forms.TextBox precioArmaBlancaTxt;
        private System.Windows.Forms.TextBox descripcionArmaBlancaTxt;
        private System.Windows.Forms.Label LbLNombre;
        private System.Windows.Forms.Label LbLDescripcion;
        private System.Windows.Forms.Label LbLPrecio;
        private System.Windows.Forms.TextBox materialArmaBlancaTxt;
        private System.Windows.Forms.TextBox longitudArmaBlancaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
    }
}