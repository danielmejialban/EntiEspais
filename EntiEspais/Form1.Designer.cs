namespace EntiEspais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonMinimizeApp = new System.Windows.Forms.Button();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxContrassenya = new System.Windows.Forms.TextBox();
            this.textBoxRepetirContrasenya = new System.Windows.Forms.TextBox();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMinimizeApp
            // 
            this.buttonMinimizeApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMinimizeApp.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimizeApp.Image = global::EntiEspais.Properties.Resources.minus;
            this.buttonMinimizeApp.Location = new System.Drawing.Point(781, 12);
            this.buttonMinimizeApp.Name = "buttonMinimizeApp";
            this.buttonMinimizeApp.Size = new System.Drawing.Size(25, 23);
            this.buttonMinimizeApp.TabIndex = 1;
            this.buttonMinimizeApp.UseVisualStyleBackColor = true;
            this.buttonMinimizeApp.Click += new System.EventHandler(this.buttonMinimizeApp_Click);
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.FlatAppearance.BorderSize = 0;
            this.buttonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseApp.Image = global::EntiEspais.Properties.Resources.multiply;
            this.buttonCloseApp.Location = new System.Drawing.Point(812, 12);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(25, 23);
            this.buttonCloseApp.TabIndex = 0;
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(154, 99);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(514, 33);
            this.textBoxNom.TabIndex = 2;
            this.textBoxNom.Text = "Nom";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(154, 155);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(514, 33);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Text = "Email";
            // 
            // textBoxContrassenya
            // 
            this.textBoxContrassenya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContrassenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrassenya.Location = new System.Drawing.Point(154, 210);
            this.textBoxContrassenya.Name = "textBoxContrassenya";
            this.textBoxContrassenya.Size = new System.Drawing.Size(514, 33);
            this.textBoxContrassenya.TabIndex = 4;
            this.textBoxContrassenya.Text = "Contrasenya";
            // 
            // textBoxRepetirContrasenya
            // 
            this.textBoxRepetirContrasenya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRepetirContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepetirContrasenya.Location = new System.Drawing.Point(154, 267);
            this.textBoxRepetirContrasenya.Name = "textBoxRepetirContrasenya";
            this.textBoxRepetirContrasenya.Size = new System.Drawing.Size(514, 33);
            this.textBoxRepetirContrasenya.TabIndex = 5;
            this.textBoxRepetirContrasenya.Text = "Repetir contrasenya";
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonRegistrarse.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRegistrarse.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.White;
            this.buttonRegistrarse.Location = new System.Drawing.Point(512, 331);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(156, 51);
            this.buttonRegistrarse.TabIndex = 6;
            this.buttonRegistrarse.Text = "Registrar-se";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(849, 507);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.textBoxRepetirContrasenya);
            this.Controls.Add(this.textBoxContrassenya);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonMinimizeApp);
            this.Controls.Add(this.buttonCloseApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar-se";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Button buttonMinimizeApp;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxContrassenya;
        private System.Windows.Forms.TextBox textBoxRepetirContrasenya;
        private System.Windows.Forms.Button buttonRegistrarse;
    }
}

