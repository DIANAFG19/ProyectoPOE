namespace Proyecto
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.pbDulces = new System.Windows.Forms.PictureBox();
            this.pbSalas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDulces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDulces
            // 
            this.pbDulces.BackColor = System.Drawing.Color.Transparent;
            this.pbDulces.Image = ((System.Drawing.Image)(resources.GetObject("pbDulces.Image")));
            this.pbDulces.Location = new System.Drawing.Point(25, 31);
            this.pbDulces.Name = "pbDulces";
            this.pbDulces.Size = new System.Drawing.Size(141, 105);
            this.pbDulces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDulces.TabIndex = 0;
            this.pbDulces.TabStop = false;
            this.pbDulces.Click += new System.EventHandler(this.pbDulces_Click);
            // 
            // pbSalas
            // 
            this.pbSalas.Image = ((System.Drawing.Image)(resources.GetObject("pbSalas.Image")));
            this.pbSalas.Location = new System.Drawing.Point(215, 31);
            this.pbSalas.Name = "pbSalas";
            this.pbSalas.Size = new System.Drawing.Size(138, 90);
            this.pbSalas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalas.TabIndex = 1;
            this.pbSalas.TabStop = false;
            this.pbSalas.Click += new System.EventHandler(this.pbSalas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AR CENA", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dulcería";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("AR CENA", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(258, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salas";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Silver;
            this.btnSalir.Font = new System.Drawing.Font("AR CENA", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(153, 184);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 42);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(380, 260);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSalas);
            this.Controls.Add(this.pbDulces);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pbDulces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDulces;
        private System.Windows.Forms.PictureBox pbSalas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}