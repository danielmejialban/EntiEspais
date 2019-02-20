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
    public partial class Form1 : System.Windows.Forms.Form
    {
        // Atributs per a moure la finestra
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private String nom = "Nom";
        private String email = "Email";
        private String contrassenya = "Contrassenya";
        private String repetirContrassenya = "Repetir contrassenya";

        public Form1()
        {
            InitializeComponent();

            // Para quitar el fondo de los textBox
            textBoxNom.BackColor = this.BackColor;
            textBoxEmail.BackColor = this.BackColor;
            textBoxContrassenya.BackColor = this.BackColor;
            textBoxRepetirContrasenya.BackColor = this.BackColor;

            // Asignamos los textos por defecto de los textBox
            textBoxNom.Text = nom;
            textBoxEmail.Text = email;
            textBoxContrassenya.Text = contrassenya;
            textBoxRepetirContrasenya.Text = repetirContrassenya;
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            // Botó per a tancar l'aplicació
            Application.Exit();

            // Botó per a tancar només la finestra (Comentar el métode d'adalt)
            //this.Close();
        }

        private void buttonMinimizeApp_Click(object sender, EventArgs e)
        {
            // Botó per a minimitzar la finestra
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Sirve para mover la ventana (1 - Cuándo haces clic y mantienes) 
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Sirve para mover la ventana (2 - Cuándo arrastras el ratón)
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Sirve para mover la ventana (3 - Cuando sueltas el botón de clik)
            dragging = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Dibuja los rectangulos en los textbox. 
            // TextBox nom
            textBoxNom.BorderStyle = BorderStyle.None;
            Pen p = new Pen(Color.White);
            p.Width = 2.0F;
            Graphics g = e.Graphics;
            int variance = 8;
            Rectangle rectTextBoxNom = new Rectangle(textBoxNom.Location.X - variance/2, textBoxNom.Location.Y - variance/2, textBoxNom.Width + variance, textBoxNom.Height + variance);
            g.DrawRectangle(p, rectTextBoxNom);

            // TextBox email
            textBoxEmail.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxEmail = new Rectangle(textBoxEmail.Location.X - variance/2, textBoxEmail.Location.Y - variance/2, textBoxEmail.Width + variance, textBoxEmail.Height + variance);
            g.DrawRectangle(p, rectTextBoxEmail);

            // Textbox Contrassenya
            textBoxContrassenya.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxContrassenya = new Rectangle(textBoxContrassenya.Location.X - variance/2, textBoxContrassenya.Location.Y - variance/2, textBoxContrassenya.Width + variance, textBoxContrassenya.Height + variance);
            g.DrawRectangle(p, rectTextBoxContrassenya);

            // TextBox Repetir Contrassenya
            textBoxRepetirContrasenya.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxRepetirContrassenya = new Rectangle(textBoxRepetirContrasenya.Location.X - variance/2, textBoxRepetirContrasenya.Location.Y - variance/2, textBoxRepetirContrasenya.Width + variance, textBoxRepetirContrasenya.Height + variance);
            g.DrawRectangle(p, rectTextBoxRepetirContrassenya);
        }

        private void textBoxNom_Click(object sender, EventArgs e)
        {
            // Cuando hacemos click en el textBoxNom y está el valor por defecto, se borra el texto por defecto
            if (textBoxNom.Text == nom)
            {
                textBoxNom.Text = "";
            }
        }

        private void textBoxNom_Leave(object sender, EventArgs e)
        {
            // Cuando no está el focus en el textboxNom, si no se ha añadido ningún texto vuelve al texto por defecto
            if(textBoxNom.Text == "")
            {
                textBoxNom.Text = nom;
            }
        }

        private void textBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuando hacemos click en el textBoxEmail y está el valor por defecto, se borra el texto por defecto
            if (textBoxEmail.Text == email)
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            // Cuando no está el focus en el textboxEmail, si no se ha añadido ningún texto vuelve al texto por defecto
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = email;
            }
        }

        private void textBoxContrassenya_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuando hacemos click en el textBoxContrassenya y está el valor por defecto, se borra el texto por defecto
            if (textBoxContrassenya.Text == contrassenya)
            {
                textBoxContrassenya.Text = "";
            }
        }

        private void textBoxContrassenya_Leave(object sender, EventArgs e)
        {
            // Cuando no está el focus en el textBoxContrassenya, si no se ha añadido ningún texto vuelve al texto por defecto
            if (textBoxContrassenya.Text == "")
            {
                textBoxContrassenya.Text = contrassenya;
            }
        }

        private void textBoxRepetirContrasenya_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuando hacemos click en el textBoxRepetirContrasenya y está el valor por defecto, se borra el texto por defecto
            if (textBoxRepetirContrasenya.Text == repetirContrassenya)
            {
                textBoxRepetirContrasenya.Text = "";
            }
        }

        private void textBoxRepetirContrasenya_Leave(object sender, EventArgs e)
        {
            // Cuando no está el focus en el textBoxContrassenya, si no se ha añadido ningún texto vuelve al texto por defecto
            if (textBoxRepetirContrasenya.Text == "")
            {
                textBoxRepetirContrasenya.Text = repetirContrassenya;
            }
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            // Comprobamos que el textBox Nom no está con el texto por defecto o null (por si acaso)
            if(textBoxNom.Text != nom && textBoxNom.Text != "")
            {
                // Comprobamos que el textBox email no está con el texto por defecto o null (por si acaso)
                if (textBoxEmail.Text != email && textBoxEmail.Text != "")
                {
                    // Comprobamos que el email es válido
                    if (textBoxEmail.Text.Contains("@") && textBoxEmail.Text.Contains("."))
                    {
                        // Comprobamos que el textBox contrassenya no está con el texto por defecto o null (por si acaso)
                        if (textBoxContrassenya.Text != contrassenya && textBoxContrassenya.Text != "")
                        {
                            // Comprobamos que el textBox contrassenya no está con el texto por defecto o null (por si acaso)
                            if (textBoxRepetirContrasenya.Text != repetirContrassenya && textBoxRepetirContrasenya.Text != "")
                            {
                                // Comprobamos que las dos contraseñas coinciden
                                if(textBoxContrassenya.Text == textBoxRepetirContrasenya.Text)
                                {
                                    /*
                                     * 
                                     * AÑADIR FUNCIÓN PARA ABIR EL SIGUIENTE FORMULARIO
                                     * 
                                     */ 
                                }
                                else
                                {
                                    MessageBox.Show("Les contrassenyes no coincideixen", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBoxContrassenya.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Introdueix una contrassenya vàlida", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxRepetirContrasenya.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Introdueix una contrassenya vàlida", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxContrassenya.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introdueix un email vàlid", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmail.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Introdueix un email", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEmail.Focus();
                }
            }
            else
            {
                MessageBox.Show("Introdueix un nom d'usuari", "Atenció", MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBoxNom.Focus();
            }
        }
    }


}
