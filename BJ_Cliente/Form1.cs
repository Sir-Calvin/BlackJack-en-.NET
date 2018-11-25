using BlackJack.Properties;
using Cliente_Servidor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJ_Cliente
{
    public partial class Form1 : Form
    {
        Servidor server;
        Cliente cliente;
        Login ventanaLogin;
		Juego juego = new Juego(15);

		//Para las posiciones de las Cartas
		int x = 100;
		int y = 150;
		int i = 1;
		List<PictureBox> cartas = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            cliente = new Cliente();
            ventanaLogin = new Login();
            ventanaLogin.Show();
            ventanaLogin.enterPresionado += new Login.ElegirNombre(SetNombre);
            server = new Servidor();
            server.objetoRecibido += new Servidor.Recibido(ObjetoRecibido);
            server.Start(6666);
            timerListen.Start();
        }

        private void ObjetoRecibido(Respuesta respuesta)
        {
            if (txtCartaRecibida.InvokeRequired)
            {
                txtCartaRecibida.Invoke(new MethodInvoker(delegate { txtCartaRecibida.Text = respuesta.carta.Nombre; }));
            }

			if (!juego.SumarPuntos(txtCartaRecibida.Text))
				EliminarCartas();
			else
			{
				lblPuntos.Text = juego.Puntos.ToString();
				AgregarCarta();
			}
		}

		#region AgregarCartas
		private void AgregarCarta()
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action(() =>
				{
					PictureBox pictureBox = new PictureBox();

					pictureBox.Location = new System.Drawing.Point(x, y);
					pictureBox.Name = "pictureBox" + i;
					pictureBox.Size = new System.Drawing.Size(100, 150);
					pictureBox.TabIndex = 4;
					pictureBox.BackColor = Color.White;
					pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
					pictureBox.TabStop = false;

					CambiarImagen(txtCartaRecibida.Text, pictureBox);
					this.Controls.Add(pictureBox);
					pictureBox.BringToFront();
					cartas.Add(pictureBox);
					x += 25;
				}));
			}
		}
		
        private void CambiarImagen(string nombre, PictureBox picture)
		{
			if (Char.IsDigit(nombre[0])){
				nombre = " " + nombre;
			}
			nombre=nombre.Replace(' ', '_');
			object O = Resources.ResourceManager.GetObject(nombre);
			picture.Image = O as Image;
		}
		#endregion

		private void EliminarCartas()
		{
			foreach (PictureBox carta in cartas)
			{
				carta.Dispose();
			}
		}



		private void SetNombre(string n)
        {
            cliente.SetearClase(true,n);
            ventanaLogin.Close();
            this.Show();
        }

        private void btnOtra_Click(object sender, EventArgs e)
        {
            cliente.SetearClase(true);
            cliente.Start(5555);
        }

        private void btnPlantarse_Click(object sender, EventArgs e)
        {
            cliente.SetearClase(false);
            cliente.Start(5555);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timerListen_Tick(object sender, EventArgs e)
        {
            server.EsperarRespuesta();
        }
    }
}
