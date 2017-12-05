namespace Proyecto
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNuevoNombre = new System.Windows.Forms.TextBox();
            this.tbNuevaContra = new System.Windows.Forms.TextBox();
            this.tbRNuevaContra = new System.Windows.Forms.TextBox();
            this.cbNRangoUsuario = new System.Windows.Forms.CheckBox();
            this.cbNRangoAdmin = new System.Windows.Forms.CheckBox();
            this.tbNuevoCorreo = new System.Windows.Forms.TextBox();
            this.cbUsuario = new System.Windows.Forms.CheckBox();
            this.cbContra = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCorreo = new System.Windows.Forms.CheckBox();
            this.cbRango = new System.Windows.Forms.CheckBox();
            this.tbMostrar = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AR CENA", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDITAR REGISTROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario a Editar:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(154, 59);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(173, 28);
            this.tbUsuario.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.Font = new System.Drawing.Font("AR CENA", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(353, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 37);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione los Campos a Editar:";
            // 
            // tbNuevoNombre
            // 
            this.tbNuevoNombre.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevoNombre.Location = new System.Drawing.Point(154, 158);
            this.tbNuevoNombre.Name = "tbNuevoNombre";
            this.tbNuevoNombre.Size = new System.Drawing.Size(173, 28);
            this.tbNuevoNombre.TabIndex = 6;
            // 
            // tbNuevaContra
            // 
            this.tbNuevaContra.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevaContra.Location = new System.Drawing.Point(154, 192);
            this.tbNuevaContra.Name = "tbNuevaContra";
            this.tbNuevaContra.PasswordChar = '*';
            this.tbNuevaContra.Size = new System.Drawing.Size(173, 28);
            this.tbNuevaContra.TabIndex = 7;
            // 
            // tbRNuevaContra
            // 
            this.tbRNuevaContra.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRNuevaContra.Location = new System.Drawing.Point(154, 224);
            this.tbRNuevaContra.Name = "tbRNuevaContra";
            this.tbRNuevaContra.PasswordChar = '*';
            this.tbRNuevaContra.Size = new System.Drawing.Size(173, 28);
            this.tbRNuevaContra.TabIndex = 8;
            // 
            // cbNRangoUsuario
            // 
            this.cbNRangoUsuario.AutoSize = true;
            this.cbNRangoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cbNRangoUsuario.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNRangoUsuario.ForeColor = System.Drawing.Color.White;
            this.cbNRangoUsuario.Location = new System.Drawing.Point(154, 295);
            this.cbNRangoUsuario.Name = "cbNRangoUsuario";
            this.cbNRangoUsuario.Size = new System.Drawing.Size(76, 25);
            this.cbNRangoUsuario.TabIndex = 9;
            this.cbNRangoUsuario.Text = "Usuario";
            this.cbNRangoUsuario.UseVisualStyleBackColor = false;
            // 
            // cbNRangoAdmin
            // 
            this.cbNRangoAdmin.AutoSize = true;
            this.cbNRangoAdmin.BackColor = System.Drawing.Color.Transparent;
            this.cbNRangoAdmin.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNRangoAdmin.ForeColor = System.Drawing.Color.White;
            this.cbNRangoAdmin.Location = new System.Drawing.Point(236, 295);
            this.cbNRangoAdmin.Name = "cbNRangoAdmin";
            this.cbNRangoAdmin.Size = new System.Drawing.Size(115, 25);
            this.cbNRangoAdmin.TabIndex = 10;
            this.cbNRangoAdmin.Text = "Administrador";
            this.cbNRangoAdmin.UseVisualStyleBackColor = false;
            // 
            // tbNuevoCorreo
            // 
            this.tbNuevoCorreo.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevoCorreo.Location = new System.Drawing.Point(154, 258);
            this.tbNuevoCorreo.Name = "tbNuevoCorreo";
            this.tbNuevoCorreo.Size = new System.Drawing.Size(173, 28);
            this.tbNuevoCorreo.TabIndex = 11;
            // 
            // cbUsuario
            // 
            this.cbUsuario.AutoSize = true;
            this.cbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cbUsuario.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuario.ForeColor = System.Drawing.Color.White;
            this.cbUsuario.Location = new System.Drawing.Point(28, 161);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(80, 25);
            this.cbUsuario.TabIndex = 12;
            this.cbUsuario.Text = "Usuario:";
            this.cbUsuario.UseVisualStyleBackColor = false;
            this.cbUsuario.CheckedChanged += new System.EventHandler(this.Editar_Load);
            // 
            // cbContra
            // 
            this.cbContra.AutoSize = true;
            this.cbContra.BackColor = System.Drawing.Color.Transparent;
            this.cbContra.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContra.ForeColor = System.Drawing.Color.White;
            this.cbContra.Location = new System.Drawing.Point(28, 199);
            this.cbContra.Name = "cbContra";
            this.cbContra.Size = new System.Drawing.Size(102, 25);
            this.cbContra.TabIndex = 13;
            this.cbContra.Text = "Contraseña:";
            this.cbContra.UseVisualStyleBackColor = false;
            this.cbContra.CheckedChanged += new System.EventHandler(this.Editar_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Repetir Contraseña:";
            // 
            // cbCorreo
            // 
            this.cbCorreo.AutoSize = true;
            this.cbCorreo.BackColor = System.Drawing.Color.Transparent;
            this.cbCorreo.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCorreo.ForeColor = System.Drawing.Color.White;
            this.cbCorreo.Location = new System.Drawing.Point(28, 264);
            this.cbCorreo.Name = "cbCorreo";
            this.cbCorreo.Size = new System.Drawing.Size(74, 25);
            this.cbCorreo.TabIndex = 15;
            this.cbCorreo.Text = "Correo:";
            this.cbCorreo.UseVisualStyleBackColor = false;
            this.cbCorreo.CheckedChanged += new System.EventHandler(this.Editar_Load);
            // 
            // cbRango
            // 
            this.cbRango.AutoSize = true;
            this.cbRango.BackColor = System.Drawing.Color.Transparent;
            this.cbRango.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRango.ForeColor = System.Drawing.Color.White;
            this.cbRango.Location = new System.Drawing.Point(28, 295);
            this.cbRango.Name = "cbRango";
            this.cbRango.Size = new System.Drawing.Size(69, 25);
            this.cbRango.TabIndex = 16;
            this.cbRango.Text = "Rango:";
            this.cbRango.UseVisualStyleBackColor = false;
            this.cbRango.CheckedChanged += new System.EventHandler(this.Editar_Load);
            // 
            // tbMostrar
            // 
            this.tbMostrar.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMostrar.Location = new System.Drawing.Point(32, 326);
            this.tbMostrar.Multiline = true;
            this.tbMostrar.Name = "tbMostrar";
            this.tbMostrar.ReadOnly = true;
            this.tbMostrar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMostrar.Size = new System.Drawing.Size(295, 118);
            this.tbMostrar.TabIndex = 17;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Silver;
            this.btnActualizar.Font = new System.Drawing.Font("AR CENA", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(343, 232);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(94, 37);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.Font = new System.Drawing.Font("AR CENA", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(345, 349);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 36);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("AR CENA", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(344, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 40);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Escriba el ID que aparece abajo: ";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("AR CENA", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(236, 100);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(91, 28);
            this.tbId.TabIndex = 22;
            // 
            // Editar
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(449, 454);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tbMostrar);
            this.Controls.Add(this.cbRango);
            this.Controls.Add(this.cbCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbContra);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.tbNuevoCorreo);
            this.Controls.Add(this.cbNRangoAdmin);
            this.Controls.Add(this.cbNRangoUsuario);
            this.Controls.Add(this.tbRNuevaContra);
            this.Controls.Add(this.tbNuevaContra);
            this.Controls.Add(this.tbNuevoNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNuevoNombre;
        private System.Windows.Forms.TextBox tbNuevaContra;
        private System.Windows.Forms.TextBox tbRNuevaContra;
        private System.Windows.Forms.CheckBox cbNRangoUsuario;
        private System.Windows.Forms.CheckBox cbNRangoAdmin;
        private System.Windows.Forms.TextBox tbNuevoCorreo;
        private System.Windows.Forms.CheckBox cbUsuario;
        private System.Windows.Forms.CheckBox cbContra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbCorreo;
        private System.Windows.Forms.CheckBox cbRango;
        private System.Windows.Forms.TextBox tbMostrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbId;
    }
}