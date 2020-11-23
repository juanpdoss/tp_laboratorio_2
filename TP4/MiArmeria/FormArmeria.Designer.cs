
namespace MiArmeria
{
    partial class FormArmeria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgArmasDeFuego = new System.Windows.Forms.DataGridView();
            this.btn_CargarArmas = new System.Windows.Forms.Button();
            this.dgArmasBlancas = new System.Windows.Forms.DataGridView();
            this.btn_AgregarArmaBlanca = new System.Windows.Forms.Button();
            this.btn_AgregarArmaFuego = new System.Windows.Forms.Button();
            this.btn_VenderArmaFuego = new System.Windows.Forms.Button();
            this.btn_VenderArmaBlanca = new System.Windows.Forms.Button();
            this.LbLRecaudado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btn_SerializarArmaFuego = new System.Windows.Forms.Button();
            this.btn_SerializarArmaBlanca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgArmasDeFuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArmasBlancas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgArmasDeFuego
            // 
            this.dgArmasDeFuego.AllowUserToAddRows = false;
            this.dgArmasDeFuego.AllowUserToDeleteRows = false;
            this.dgArmasDeFuego.AllowUserToResizeColumns = false;
            this.dgArmasDeFuego.AllowUserToResizeRows = false;
            this.dgArmasDeFuego.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgArmasDeFuego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgArmasDeFuego.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgArmasDeFuego.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgArmasDeFuego.Location = new System.Drawing.Point(12, 27);
            this.dgArmasDeFuego.MultiSelect = false;
            this.dgArmasDeFuego.Name = "dgArmasDeFuego";
            this.dgArmasDeFuego.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgArmasDeFuego.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgArmasDeFuego.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgArmasDeFuego.Size = new System.Drawing.Size(731, 232);
            this.dgArmasDeFuego.TabIndex = 0;
            // 
            // btn_CargarArmas
            // 
            this.btn_CargarArmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CargarArmas.Location = new System.Drawing.Point(771, 27);
            this.btn_CargarArmas.Name = "btn_CargarArmas";
            this.btn_CargarArmas.Size = new System.Drawing.Size(179, 59);
            this.btn_CargarArmas.TabIndex = 3;
            this.btn_CargarArmas.Text = "Cargar armas";
            this.btn_CargarArmas.UseVisualStyleBackColor = true;
            this.btn_CargarArmas.Click += new System.EventHandler(this.btn_CargarArmas_Click);
            // 
            // dgArmasBlancas
            // 
            this.dgArmasBlancas.AllowUserToAddRows = false;
            this.dgArmasBlancas.AllowUserToDeleteRows = false;
            this.dgArmasBlancas.AllowUserToResizeColumns = false;
            this.dgArmasBlancas.AllowUserToResizeRows = false;
            this.dgArmasBlancas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgArmasBlancas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgArmasBlancas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgArmasBlancas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgArmasBlancas.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgArmasBlancas.Location = new System.Drawing.Point(12, 312);
            this.dgArmasBlancas.MultiSelect = false;
            this.dgArmasBlancas.Name = "dgArmasBlancas";
            this.dgArmasBlancas.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgArmasBlancas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgArmasBlancas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgArmasBlancas.Size = new System.Drawing.Size(731, 243);
            this.dgArmasBlancas.TabIndex = 4;
            // 
            // btn_AgregarArmaBlanca
            // 
            this.btn_AgregarArmaBlanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarArmaBlanca.Location = new System.Drawing.Point(956, 104);
            this.btn_AgregarArmaBlanca.Name = "btn_AgregarArmaBlanca";
            this.btn_AgregarArmaBlanca.Size = new System.Drawing.Size(176, 59);
            this.btn_AgregarArmaBlanca.TabIndex = 5;
            this.btn_AgregarArmaBlanca.Text = "Agregar arma blanca";
            this.btn_AgregarArmaBlanca.UseVisualStyleBackColor = true;
            this.btn_AgregarArmaBlanca.Click += new System.EventHandler(this.btn_AgregarArmaBlanca_Click);
            // 
            // btn_AgregarArmaFuego
            // 
            this.btn_AgregarArmaFuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarArmaFuego.Location = new System.Drawing.Point(774, 104);
            this.btn_AgregarArmaFuego.Name = "btn_AgregarArmaFuego";
            this.btn_AgregarArmaFuego.Size = new System.Drawing.Size(176, 59);
            this.btn_AgregarArmaFuego.TabIndex = 6;
            this.btn_AgregarArmaFuego.Text = "Agregar arma de fuego";
            this.btn_AgregarArmaFuego.UseVisualStyleBackColor = true;
            this.btn_AgregarArmaFuego.Click += new System.EventHandler(this.btn_AgregarArmaFuego_Click);
            // 
            // btn_VenderArmaFuego
            // 
            this.btn_VenderArmaFuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VenderArmaFuego.Location = new System.Drawing.Point(774, 186);
            this.btn_VenderArmaFuego.Name = "btn_VenderArmaFuego";
            this.btn_VenderArmaFuego.Size = new System.Drawing.Size(179, 59);
            this.btn_VenderArmaFuego.TabIndex = 7;
            this.btn_VenderArmaFuego.Text = "Vender arma de fuego";
            this.btn_VenderArmaFuego.UseVisualStyleBackColor = true;
            this.btn_VenderArmaFuego.Click += new System.EventHandler(this.btnVenderArma_Click);
            // 
            // btn_VenderArmaBlanca
            // 
            this.btn_VenderArmaBlanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VenderArmaBlanca.Location = new System.Drawing.Point(959, 186);
            this.btn_VenderArmaBlanca.Name = "btn_VenderArmaBlanca";
            this.btn_VenderArmaBlanca.Size = new System.Drawing.Size(179, 59);
            this.btn_VenderArmaBlanca.TabIndex = 8;
            this.btn_VenderArmaBlanca.Text = "Vender arma blanca";
            this.btn_VenderArmaBlanca.UseVisualStyleBackColor = true;
            this.btn_VenderArmaBlanca.Click += new System.EventHandler(this.btn_VenderArmaBlanca_Click);
            // 
            // LbLRecaudado
            // 
            this.LbLRecaudado.AutoSize = true;
            this.LbLRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLRecaudado.Location = new System.Drawing.Point(767, 498);
            this.LbLRecaudado.Name = "LbLRecaudado";
            this.LbLRecaudado.Size = new System.Drawing.Size(231, 42);
            this.LbLRecaudado.TabIndex = 9;
            this.LbLRecaudado.Text = "Recaudado:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(987, 498);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 42);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // btn_SerializarArmaFuego
            // 
            this.btn_SerializarArmaFuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SerializarArmaFuego.Location = new System.Drawing.Point(774, 266);
            this.btn_SerializarArmaFuego.Name = "btn_SerializarArmaFuego";
            this.btn_SerializarArmaFuego.Size = new System.Drawing.Size(179, 59);
            this.btn_SerializarArmaFuego.TabIndex = 11;
            this.btn_SerializarArmaFuego.Text = "Serializar arma de fuego";
            this.btn_SerializarArmaFuego.UseVisualStyleBackColor = true;
            this.btn_SerializarArmaFuego.Click += new System.EventHandler(this.btn_SerializarArma_Click);
            // 
            // btn_SerializarArmaBlanca
            // 
            this.btn_SerializarArmaBlanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SerializarArmaBlanca.Location = new System.Drawing.Point(959, 266);
            this.btn_SerializarArmaBlanca.Name = "btn_SerializarArmaBlanca";
            this.btn_SerializarArmaBlanca.Size = new System.Drawing.Size(179, 59);
            this.btn_SerializarArmaBlanca.TabIndex = 12;
            this.btn_SerializarArmaBlanca.Text = "Serializar arma blanca";
            this.btn_SerializarArmaBlanca.UseVisualStyleBackColor = true;
            this.btn_SerializarArmaBlanca.Click += new System.EventHandler(this.btn_SerializarArmaBlanca_Click);
            // 
            // FormArmeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 610);
            this.Controls.Add(this.btn_SerializarArmaBlanca);
            this.Controls.Add(this.btn_SerializarArmaFuego);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.LbLRecaudado);
            this.Controls.Add(this.btn_VenderArmaBlanca);
            this.Controls.Add(this.btn_VenderArmaFuego);
            this.Controls.Add(this.btn_AgregarArmaFuego);
            this.Controls.Add(this.btn_AgregarArmaBlanca);
            this.Controls.Add(this.dgArmasBlancas);
            this.Controls.Add(this.btn_CargarArmas);
            this.Controls.Add(this.dgArmasDeFuego);
            this.Name = "FormArmeria";
            this.Text = "Armeria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormArmeria_FormClosing);
            this.Load += new System.EventHandler(this.FormArmeria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArmasDeFuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArmasBlancas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgArmasDeFuego;
        private System.Windows.Forms.Button btn_CargarArmas;
        private System.Windows.Forms.DataGridView dgArmasBlancas;
        private System.Windows.Forms.Button btn_AgregarArmaBlanca;
        private System.Windows.Forms.Button btn_AgregarArmaFuego;
        private System.Windows.Forms.Button btn_VenderArmaFuego;
        private System.Windows.Forms.Button btn_VenderArmaBlanca;
        private System.Windows.Forms.Label LbLRecaudado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btn_SerializarArmaFuego;
        private System.Windows.Forms.Button btn_SerializarArmaBlanca;
    }
}

