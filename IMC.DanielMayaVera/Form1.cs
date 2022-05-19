using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IMC.DanielMayaVera
{
    public partial class formCal : Form
    {
       

        public formCal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void formCal_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            lblDate.Text = fecha.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre;
            double peso, estatura, imc;
            string clasificacion = "";

            DateTime fecha = DateTime.Now;

            nombre = txtNombre.Text;
            peso = double.Parse(txtPeso.Text);
            estatura = double.Parse(txtEstatura.Text);

            imc = peso / (Math.Pow(estatura, 2));

            lblIMC.Text = imc.ToString();

            if (imc < 18.5 )
            {
                clasificacion = "Bajo Peso";
                lblClasificacion.Text = clasificacion;
            } 
            else if (imc >= 18.5 && imc < 25)
            {
                clasificacion = "Normal";
                lblClasificacion.Text = clasificacion;
            }
            else if (imc >= 25 && imc < 30)
            {
                clasificacion = "Sobrepeso";
                lblClasificacion.Text = clasificacion;
            }
            else if (imc >= 30)
            {
                clasificacion = "Obesidad";
                lblClasificacion.Text = clasificacion;
            }

            TextWriter Escribir = new StreamWriter("HistorialIMC.txt");
            Escribir.WriteLine(fecha);
            Escribir.WriteLine(nombre);
            Escribir.WriteLine(peso);
            Escribir.WriteLine(imc);
            Escribir.WriteLine(clasificacion);
            Escribir.Close();

        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            rtxHistorial.Visible = true;
            TextReader Leer = new StreamReader("HistorialIMC.txt");
            rtxHistorial.Text = Leer.ReadToEnd();
            Leer.Close();

        }
    }
}
