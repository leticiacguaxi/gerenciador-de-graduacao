using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void cbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbDisciplina_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUnidade_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void tbAula_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void btCriarPastas_Click(object sender, EventArgs e)
        {
            string semestre = cbSemestre.Text;
            string disciplina = tbDisciplina.Text;
            string unidade = tbUnidade.Text;
            string aula = tbAula.Text;


            string location = @"C:\\Users\\letic\\OneDrive\\Área de Trabalho\\Faculdade";
            string path = System.IO.Path.Combine(location, semestre, disciplina, unidade, aula);

            System.IO.Directory.CreateDirectory(path);

            MessageBox.Show("Criado com sucesso.");
        }
    }
}
