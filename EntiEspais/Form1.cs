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
        public Form1()
        {
            InitializeComponent();

            // Para quitar el fondo de los textBox
            textBoxNom.BackColor = this.BackColor;
            textBoxEmail.BackColor = this.BackColor;
            textBoxContrassenya.BackColor = this.BackColor;
            textBoxRepetirContrasenya.BackColor = this.BackColor;
                        
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
            int variance = 3;
            Rectangle rectTextBoxNom = new Rectangle(textBoxNom.Location.X - variance, textBoxNom.Location.Y - variance, textBoxNom.Width + variance, textBoxNom.Height + variance);
            g.DrawRectangle(p, rectTextBoxNom);

            // TextBox email
            textBoxEmail.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxEmail = new Rectangle(textBoxEmail.Location.X - variance, textBoxEmail.Location.Y - variance, textBoxEmail.Width + variance, textBoxEmail.Height + variance);
            g.DrawRectangle(p, rectTextBoxEmail);

            // Textbox Contrassenya
            textBoxContrassenya.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxContrassenya = new Rectangle(textBoxContrassenya.Location.X - variance, textBoxContrassenya.Location.Y - variance, textBoxContrassenya.Width + variance, textBoxContrassenya.Height + variance);
            g.DrawRectangle(p, rectTextBoxContrassenya);

            // TextBox Repetir Contrassenya
            textBoxRepetirContrasenya.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxRepetirContrassenya = new Rectangle(textBoxRepetirContrasenya.Location.X - variance, textBoxRepetirContrasenya.Location.Y - variance, textBoxRepetirContrasenya.Width + variance, textBoxRepetirContrasenya.Height + variance);
            g.DrawRectangle(p, rectTextBoxRepetirContrassenya);
        }
    }
}
