namespace Presentacion
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
            this.btnPrueba = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnAltaLibro = new System.Windows.Forms.Button();
            this.btnModificacionLibro = new System.Windows.Forms.Button();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultaLibros = new System.Windows.Forms.Button();
            this.btnConsultaConUnidades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(155, 32);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(137, 43);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Prueba de conexion";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(493, 47);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 13);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "lblResultado";
            this.lblResultado.Visible = false;
            // 
            // btnAltaLibro
            // 
            this.btnAltaLibro.Location = new System.Drawing.Point(155, 100);
            this.btnAltaLibro.Name = "btnAltaLibro";
            this.btnAltaLibro.Size = new System.Drawing.Size(137, 43);
            this.btnAltaLibro.TabIndex = 2;
            this.btnAltaLibro.Text = "Alta de Libro";
            this.btnAltaLibro.UseVisualStyleBackColor = true;
            this.btnAltaLibro.Click += new System.EventHandler(this.btnAltaLibro_Click);
            // 
            // btnModificacionLibro
            // 
            this.btnModificacionLibro.Location = new System.Drawing.Point(315, 32);
            this.btnModificacionLibro.Name = "btnModificacionLibro";
            this.btnModificacionLibro.Size = new System.Drawing.Size(137, 43);
            this.btnModificacionLibro.TabIndex = 3;
            this.btnModificacionLibro.Text = "Modificacion de Libro";
            this.btnModificacionLibro.UseVisualStyleBackColor = true;
            this.btnModificacionLibro.Click += new System.EventHandler(this.btnModificacionLibro_Click);
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Location = new System.Drawing.Point(315, 100);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(137, 43);
            this.btnEliminarLibro.TabIndex = 4;
            this.btnEliminarLibro.Text = "Eliminacion de Libro";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 246);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnConsultaLibros
            // 
            this.btnConsultaLibros.Location = new System.Drawing.Point(639, 32);
            this.btnConsultaLibros.Name = "btnConsultaLibros";
            this.btnConsultaLibros.Size = new System.Drawing.Size(137, 43);
            this.btnConsultaLibros.TabIndex = 6;
            this.btnConsultaLibros.Text = "Consulta de Libros";
            this.btnConsultaLibros.UseVisualStyleBackColor = true;
            this.btnConsultaLibros.Click += new System.EventHandler(this.btnConsultaLibros_Click);
            // 
            // btnConsultaConUnidades
            // 
            this.btnConsultaConUnidades.Location = new System.Drawing.Point(639, 100);
            this.btnConsultaConUnidades.Name = "btnConsultaConUnidades";
            this.btnConsultaConUnidades.Size = new System.Drawing.Size(137, 43);
            this.btnConsultaConUnidades.TabIndex = 7;
            this.btnConsultaConUnidades.Text = "Consulta de Libros con unidades";
            this.btnConsultaConUnidades.UseVisualStyleBackColor = true;
            this.btnConsultaConUnidades.Click += new System.EventHandler(this.btnConsultaConUnidades_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultaConUnidades);
            this.Controls.Add(this.btnConsultaLibros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminarLibro);
            this.Controls.Add(this.btnModificacionLibro);
            this.Controls.Add(this.btnAltaLibro);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAltaLibro;
        private System.Windows.Forms.Button btnModificacionLibro;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultaLibros;
        private System.Windows.Forms.Button btnConsultaConUnidades;
    }
}

