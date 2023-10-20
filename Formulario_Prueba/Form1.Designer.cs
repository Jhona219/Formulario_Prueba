namespace Formulario_Prueba
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
            this.tbNombre = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.Label();
            this.tbEstatura = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Estatura = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.AutoSize = true;
            this.tbNombre.Location = new System.Drawing.Point(50, 51);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(56, 16);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.Text = "Nombre";
            // 
            // tbApellidos
            // 
            this.tbApellidos.AutoSize = true;
            this.tbApellidos.Location = new System.Drawing.Point(50, 92);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(64, 16);
            this.tbApellidos.TabIndex = 1;
            this.tbApellidos.Text = "Apellidos";
            // 
            // tbTelefono
            // 
            this.tbTelefono.AutoSize = true;
            this.tbTelefono.Location = new System.Drawing.Point(50, 127);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(61, 16);
            this.tbTelefono.TabIndex = 2;
            this.tbTelefono.Text = "Telefono";
            // 
            // tbEstatura
            // 
            this.tbEstatura.AutoSize = true;
            this.tbEstatura.Location = new System.Drawing.Point(50, 162);
            this.tbEstatura.Name = "tbEstatura";
            this.tbEstatura.Size = new System.Drawing.Size(56, 16);
            this.tbEstatura.TabIndex = 3;
            this.tbEstatura.Text = "Estatura";
            // 
            // tbEdad
            // 
            this.tbEdad.AutoSize = true;
            this.tbEdad.Location = new System.Drawing.Point(50, 201);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(40, 16);
            this.tbEdad.TabIndex = 4;
            this.tbEdad.Text = "Edad";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(130, 51);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(198, 22);
            this.Nombre.TabIndex = 5;
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(130, 92);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(198, 22);
            this.Apellidos.TabIndex = 6;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(130, 127);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(198, 22);
            this.Telefono.TabIndex = 7;
            // 
            // Estatura
            // 
            this.Estatura.Location = new System.Drawing.Point(130, 162);
            this.Estatura.Name = "Estatura";
            this.Estatura.Size = new System.Drawing.Size(198, 22);
            this.Estatura.TabIndex = 8;
            // 
            // Edad
            // 
            this.Edad.Location = new System.Drawing.Point(130, 201);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(198, 22);
            this.Edad.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMujer);
            this.groupBox1.Controls.Add(this.rbHombre);
            this.groupBox1.Location = new System.Drawing.Point(102, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 86);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(135, 46);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(61, 20);
            this.rbMujer.TabIndex = 1;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(6, 46);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(77, 20);
            this.rbHombre.TabIndex = 0;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(81, 383);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 46);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(228, 383);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 46);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 561);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Estatura);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbEstatura);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tbNombre;
        private System.Windows.Forms.Label tbApellidos;
        private System.Windows.Forms.Label tbTelefono;
        private System.Windows.Forms.Label tbEstatura;
        private System.Windows.Forms.Label tbEdad;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Estatura;
        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

