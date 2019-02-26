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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxContrassenya = new System.Windows.Forms.TextBox();
            this.textBoxRepetirContrasenya = new System.Windows.Forms.TextBox();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.buttonIniciarSessio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMinimizeApp = new System.Windows.Forms.Button();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.textBoxNom.ForeColor = System.Drawing.Color.White;
            this.textBoxNom.Location = new System.Drawing.Point(158, 272);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(90, 30, 90, 3);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(514, 33);
            this.textBoxNom.TabIndex = 1;
            this.textBoxNom.Click += new System.EventHandler(this.textBoxNom_Click);
            this.textBoxNom.Leave += new System.EventHandler(this.textBoxNom_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(158, 338);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(514, 33);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEmail_MouseClick);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxContrassenya
            // 
            this.textBoxContrassenya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContrassenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrassenya.ForeColor = System.Drawing.Color.White;
            this.textBoxContrassenya.Location = new System.Drawing.Point(158, 404);
            this.textBoxContrassenya.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBoxContrassenya.Name = "textBoxContrassenya";
            this.textBoxContrassenya.Size = new System.Drawing.Size(514, 33);
            this.textBoxContrassenya.TabIndex = 3;
            this.textBoxContrassenya.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxContrassenya_MouseClick);
            this.textBoxContrassenya.Leave += new System.EventHandler(this.textBoxContrassenya_Leave);
            // 
            // textBoxRepetirContrasenya
            // 
            this.textBoxRepetirContrasenya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRepetirContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepetirContrasenya.ForeColor = System.Drawing.Color.White;
            this.textBoxRepetirContrasenya.Location = new System.Drawing.Point(158, 470);
            this.textBoxRepetirContrasenya.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBoxRepetirContrasenya.Name = "textBoxRepetirContrasenya";
            this.textBoxRepetirContrasenya.Size = new System.Drawing.Size(514, 33);
            this.textBoxRepetirContrasenya.TabIndex = 4;
            this.textBoxRepetirContrasenya.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRepetirContrasenya_MouseClick);
            this.textBoxRepetirContrasenya.Leave += new System.EventHandler(this.textBoxRepetirContrasenya_Leave);
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonRegistrarse.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRegistrarse.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.White;
            this.buttonRegistrarse.Location = new System.Drawing.Point(463, 556);
            this.buttonRegistrarse.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(209, 51);
            this.buttonRegistrarse.TabIndex = 5;
            this.buttonRegistrarse.Text = "Registrar-se";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // buttonIniciarSessio
            // 
            this.buttonIniciarSessio.FlatAppearance.BorderSize = 0;
            this.buttonIniciarSessio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciarSessio.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Underline);
            this.buttonIniciarSessio.ForeColor = System.Drawing.Color.White;
            this.buttonIniciarSessio.Location = new System.Drawing.Point(267, 640);
            this.buttonIniciarSessio.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.buttonIniciarSessio.Name = "buttonIniciarSessio";
            this.buttonIniciarSessio.Size = new System.Drawing.Size(286, 46);
            this.buttonIniciarSessio.TabIndex = 6;
            this.buttonIniciarSessio.Text = "Iniciar sessió";
            this.buttonIniciarSessio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EntiEspais.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(332, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMinimizeApp
            // 
            this.buttonMinimizeApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMinimizeApp.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimizeApp.Image = global::EntiEspais.Properties.Resources.minus;
            this.buttonMinimizeApp.Location = new System.Drawing.Point(767, 19);
            this.buttonMinimizeApp.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.buttonMinimizeApp.Name = "buttonMinimizeApp";
            this.buttonMinimizeApp.Size = new System.Drawing.Size(25, 23);
            this.buttonMinimizeApp.TabIndex = 0;
            this.buttonMinimizeApp.UseVisualStyleBackColor = true;
            this.buttonMinimizeApp.Click += new System.EventHandler(this.buttonMinimizeApp_Click);
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.FlatAppearance.BorderSize = 0;
            this.buttonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseApp.Image = global::EntiEspais.Properties.Resources.multiply;
            this.buttonCloseApp.Location = new System.Drawing.Point(805, 19);
            this.buttonCloseApp.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(25, 23);
            this.buttonCloseApp.TabIndex = 0;
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(849, 719);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonIniciarSessio);
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
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button buttonIniciarSessio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

