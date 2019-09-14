using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroEstudiantes10_9.Entidades;
using System.Windows.Forms;
using RegistroEstudiantes10_9.BLL;
using RegistroEstudiantes10_9.UI.Registros;
using RegistroEstudiantes10_9.UI.Consultas;

namespace RegistroEstudiantes10_9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registre = new RegistroEstudiantess();
            registre.Show();

        }

        private void RegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form inscripcion = new Inscripcion();
            inscripcion.Show();
        }

        private void InscripcionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form consulta = new ConsultaInscripcion();
            consulta.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EstudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form consulta = new ConsultaEstudiante();
            consulta.Show();
        }
    }
}
