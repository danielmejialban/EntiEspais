using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntiEspais
{
    public partial class IniciarSesio : Form
    {
        // Atributs per a moure la finestra
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // Texts dels textboxs
        private String email = "Adreça electrònica";
        private String contrasenya = "Contrasenya";

        public IniciarSesio()
        {
            InitializeComponent();

            // Treiem el color de fons del textbox
            this.textBoxEmail.BackColor = this.BackColor;
            this.textBoxContrasenya.BackColor = this.BackColor;

            // Assignem els noms als textboxs
            textBoxEmail.Text = email;
            textBoxContrasenya.Text = contrasenya;
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimizeApp_Click(object sender, EventArgs e)
        {
            // Botó per a minimitzar la finestra
            this.WindowState = FormWindowState.Minimized;
        }

        private void IniciarSesio_MouseDown(object sender, MouseEventArgs e)
        {
            // Sirve para mover la ventana (1 - Cuándo haces clic y mantienes) 
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void IniciarSesio_MouseMove(object sender, MouseEventArgs e)
        {
            // Sirve para mover la ventana (2 - Cuándo arrastras el ratón)
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void IniciarSesio_MouseUp(object sender, MouseEventArgs e)
        {
            // Sirve para mover la ventana (3 - Cuando sueltas el botón de clik)
            dragging = false;
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            Registre f = new Registre();

            f.Show();

            this.Hide();
        }

        private void IniciarSesio_Paint(object sender, PaintEventArgs e)
        {
            // Dibuja los rectangulos en los textbox. 
            // Seleccionamos como pintar los rectangulos (Boli blanco, 2F de ancho);
            Pen p = new Pen(Color.White);
            p.Width = 2.0F;
            Graphics g = e.Graphics;
            int variance = 8;

            // TextBox email
            textBoxEmail.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxEmail = new Rectangle(textBoxEmail.Location.X - variance / 2, textBoxEmail.Location.Y - variance / 2, textBoxEmail.Width + variance, textBoxEmail.Height + variance);
            g.DrawRectangle(p, rectTextBoxEmail);

            // TextBox passwd
            textBoxContrasenya.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxContrassenya = new Rectangle(textBoxContrasenya.Location.X - variance / 2, textBoxContrasenya.Location.Y - variance / 2, textBoxEmail.Width + variance, textBoxEmail.Height + variance);
            g.DrawRectangle(p, rectTextBoxContrassenya);
        }
        


        private void buttonMostrarContrassenya_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxContrasenya.Text != contrasenya)
            {
                textBoxContrasenya.UseSystemPasswordChar = false;
            }
        }

        private void buttonMostrarContrassenya_MouseUp(object sender, MouseEventArgs e)
        {
            // Si se hace clik en mostrar pw, se muestra la pw
            if (textBoxContrasenya.Text != contrasenya)
            {
                textBoxContrasenya.UseSystemPasswordChar = true;
            }
        }

        private void textBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if(textBoxEmail.Text == email)
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            // Cuándo no está el focus en el email y no se ha puesto texto se pone el texto por defecto
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = email;
            }
        }

        private void textBoxContrasenya_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBoxContrasenya.Text == contrasenya)
            {
                textBoxContrasenya.Text = "";
            }
        }

        private void textBoxContrasenya_Leave(object sender, EventArgs e)
        {
            if(textBoxContrasenya.Text == "")
            {
                textBoxContrasenya.Text = contrasenya; 
            }
        }

        private void textBoxContrasenya_TextChanged(object sender, EventArgs e)
        {
            // Si cambia el texto del textbox contrasenya se muestra como carácteres "Seguros"
            if ((textBoxContrasenya.Text != contrasenya) && (textBoxContrasenya.Text != null))
            {
                textBoxContrasenya.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxContrasenya.UseSystemPasswordChar = false;
            }
        }

        private void buttonIniciarSessio_Click(object sender, EventArgs e)
        {
             if(textBoxEmail.Text != email && textBoxEmail.Text != "")
            {
                if (textBoxEmail.Text.Contains("@") && textBoxEmail.Text.Contains("."))
                {
                    if(textBoxContrasenya.Text != contrasenya && textBoxContrasenya.Text != "")
                    {
                        // if(textBoxContrassenya.Text == BASE DE DATOS && textBoxEmail.Text == BASE DE DATOS)
                        // Entrar a la app

                        // else
                        // MessageBox usuari o pw no vàlids
                    }
                    else
                    {
                        MessageBox.Show("Introdueix una contrasenya", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxContrasenya.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Introdueix una adreça electrònica vàlida", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEmail.Focus();
                }
            }
            else
            {
                MessageBox.Show("Introdueix una adreça electrònica", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Focus();
            }
        }
    }
}
