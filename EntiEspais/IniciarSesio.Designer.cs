namespace EntiEspais
{
    partial class IniciarSesio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesio));
            this.buttonMinimizeApp = new System.Windows.Forms.Button();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.buttonMostrarContrassenya = new System.Windows.Forms.Button();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.buttonIniciarSessio = new System.Windows.Forms.Button();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMinimizeApp
            // 
            this.buttonMinimizeApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMinimizeApp.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimizeApp.Image = global::EntiEspais.Properties.Resources.minus;
            this.buttonMinimizeApp.Location = new System.Drawing.Point(768, 19);
            this.buttonMinimizeApp.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
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
            this.buttonCloseApp.Location = new System.Drawing.Point(806, 19);
            this.buttonCloseApp.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(25, 23);
            this.buttonCloseApp.TabIndex = 2;
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // buttonMostrarContrassenya
            // 
            this.buttonMostrarContrassenya.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMostrarContrassenya.FlatAppearance.BorderSize = 0;
            this.buttonMostrarContrassenya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarContrassenya.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMostrarContrassenya.Image = global::EntiEspais.Properties.Resources.hide;
            this.buttonMostrarContrassenya.Location = new System.Drawing.Point(607, 383);
            this.buttonMostrarContrassenya.Name = "buttonMostrarContrassenya";
            this.buttonMostrarContrassenya.Size = new System.Drawing.Size(52, 33);
            this.buttonMostrarContrassenya.TabIndex = 14;
            this.buttonMostrarContrassenya.UseVisualStyleBackColor = true;
            this.buttonMostrarContrassenya.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMostrarContrassenya_MouseDown);
            this.buttonMostrarContrassenya.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMostrarContrassenya_MouseUp);
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Underline);
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.White;
            this.buttonRegistrarse.Location = new System.Drawing.Point(254, 553);
            this.buttonRegistrarse.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(286, 46);
            this.buttonRegistrarse.TabIndex = 13;
            this.buttonRegistrarse.Text = "Registrar-se";
            this.buttonRegistrarse.UseVisualStyleBackColor = true;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // buttonIniciarSessio
            // 
            this.buttonIniciarSessio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonIniciarSessio.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonIniciarSessio.FlatAppearance.BorderSize = 0;
            this.buttonIniciarSessio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciarSessio.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonIniciarSessio.ForeColor = System.Drawing.Color.White;
            this.buttonIniciarSessio.Location = new System.Drawing.Point(450, 469);
            this.buttonIniciarSessio.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.buttonIniciarSessio.Name = "buttonIniciarSessio";
            this.buttonIniciarSessio.Size = new System.Drawing.Size(209, 51);
            this.buttonIniciarSessio.TabIndex = 12;
            this.buttonIniciarSessio.Text = "Iniciar sessió";
            this.buttonIniciarSessio.UseVisualStyleBackColor = false;
            this.buttonIniciarSessio.Click += new System.EventHandler(this.buttonIniciarSessio_Click);
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasenya.ForeColor = System.Drawing.Color.White;
            this.textBoxContrasenya.Location = new System.Drawing.Point(145, 383);
            this.textBoxContrasenya.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(456, 33);
            this.textBoxContrasenya.TabIndex = 11;
            this.textBoxContrasenya.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxContrasenya_MouseClick);
            this.textBoxContrasenya.TextChanged += new System.EventHandler(this.textBoxContrasenya_TextChanged);
            this.textBoxContrasenya.Leave += new System.EventHandler(this.textBoxContrasenya_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(145, 317);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(514, 33);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEmail_MouseClick);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EntiEspais.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(328, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // IniciarSesio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(850, 644);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMostrarContrassenya);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.buttonIniciarSessio);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonMinimizeApp);
            this.Controls.Add(this.buttonCloseApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IniciarSesio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sessió";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.IniciarSesio_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IniciarSesio_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IniciarSesio_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IniciarSesio_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMinimizeApp;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Button buttonMostrarContrassenya;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Button buttonIniciarSessio;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}