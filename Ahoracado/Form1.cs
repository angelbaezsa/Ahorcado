using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahoracado
{
    public partial class frmAhorcado : Form
    {
        char[] PalabrasCorrectas;
        char[] PalabraSeleccionada;
        char[] Abecedario;
        string[] Palabras;
        int vidas;

        
        

        public frmAhorcado()
        {
            InitializeComponent();
           
            
        }

        public void IniciarJuego()
        {
            flLetras.Controls.Clear();
            flLetras.Enabled = true;
            picAhorcado.Image = null;
            lblMensaje.Visible = false;
            vidas = 0;
            Palabras = new string[] { "mango", "pera", "manzana", "melocoton", "kiwi", "fresa", "banana", "uva", "cereza", "fresa" };
            Abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            Random random = new Random();
            int IndexPalabraSeleccionada = random.Next(0, Palabras.Length);
            PalabraSeleccionada = Palabras[IndexPalabraSeleccionada].ToUpper().ToCharArray();
            PalabrasCorrectas = PalabraSeleccionada;
           
            foreach(char LetraAbecedario in Abecedario)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = " ";
                btnLetra.Text = LetraAbecedario.ToString();
                btnLetra.Name = LetraAbecedario.ToString();
                flLetras.Controls.Add(btnLetra);
            }
            flPalabra.Controls.Clear();
            for (int i = 0; i < PalabraSeleccionada.Length; i++)
            {
                Button Letra = new Button();
                Letra.Tag = PalabraSeleccionada[i].ToString();
                Letra.Text = "__";
                Letra.Name = "Adivinado" + i.ToString();
                flPalabra.Controls.Add(Letra);
            }
            

        }


        private void Comparacion(object sender, EventArgs e)
        {
            bool encontrado = false;
            Button btn = (Button)sender;
            btn.Enabled = false;

            for (int i = 0; i < PalabrasCorrectas.Length; i++)
            {

                if (PalabrasCorrectas[i] == char.Parse(btn.Text))
                {
                    Button boton = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                    boton.Text = PalabrasCorrectas[i].ToString();
                    PalabrasCorrectas[i] = '_';
                    encontrado = true;
                }
            }

            bool ganador = true;

            for (int i= 0; i<PalabrasCorrectas.Length; i++)
            {
                if (PalabrasCorrectas[i] != '_')
                {
                    ganador = false; 
                }
                
            }

            if(ganador = true)
            {
                MessageBox.Show("Ganaste"); 
               
            }
            if (!encontrado)
            {
                vidas = vidas+1;
                picAhorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ahorcado" + vidas);

            }
            if(vidas == 5)
            {
                flLetras.Enabled = false;
                MessageBox.Show("Perdiste");

            }
        }

        private void frmAhorcado_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        private void picAhorcado_Click(object sender, EventArgs e)
        {
            
        }

        private void flLetras_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
