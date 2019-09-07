using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nota1txt.Focus();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            double nota1txt2 = double.Parse(nota1txt.Text);
            double nota2txt2 = double.Parse(nota1txt.Text);
            double nota3txt2 = double.Parse(nota1txt.Text);
            double nota4txt2 = double.Parse(nota1txt.Text);
            double nota5txt2 = double.Parse(nota1txt.Text);
            double promedio = (nota1txt2 + nota2txt2 + nota3txt2 + nota4txt2 + nota5txt2) / 5;

            if (promedio <3.5){
                MessageBox.Show("El estudiante no alcanzó el promedio mínimo (3.5), no ha superado la competencia de la materia, su promedio fue de: "+promedio);
            }
            if (promedio >= 3.5){
                MessageBox.Show("El estudiante alcanzó el promedio mínimo (3.5), ha superado la competencia de la materia, su promedio fue de: "+promedio);
            }
            nota1txt.Text = "";
            nota2txt.Text = "";
            nota3txt.Text = "";
            nota4txt.Text = "";
            nota5txt.Text = "";
        }
    }
}
