using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroEstudiantes10_9.Entidades;
using RegistroEstudiantes10_9.DAL;
using RegistroEstudiantes10_9.BLL;
using System.Windows.Forms;

namespace RegistroEstudiantes10_9.UI.Consultas
{
    public partial class ConsultaEstudiante : Form
    {
        public ConsultaEstudiante()
        {
            InitializeComponent();
        }

        private void EstBuscarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Estudiantes>();  
            if(EstCriteriotextBox.Text.Trim().Length>0)
            {
                switch (ESTfiltro.SelectedItem)
                {
                    case 0:
                        listado = EstudiantesBLL.GetList(p => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(EstCriteriotextBox.Text);
                        listado = EstudiantesBLL.GetList(p => p.EstudianteId == id);
                        break;
                    case 2:
                        listado = EstudiantesBLL.GetList(p => p.Matricula.Contains(EstCriteriotextBox.Text));
                        break;
                    case 3:
                        listado = EstudiantesBLL.GetList(p => p.Nombres.Contains(EstCriteriotextBox.Text));
                        break;
                    case 4:
                        listado = EstudiantesBLL.GetList(p => p.Apellidos.Contains(EstCriteriotextBox.Text));
                        break;
                }
                listado = listado.Where(c => c.FechaNacimiento.Date >= DesdeTimePicker1.Value.Date && c.FechaNacimiento.Date <= HastadataTimer.Value.Date).ToList();

            }
            else
            {
                listado = EstudiantesBLL.GetList(p => true);
            }

            MydataGridView.DataSource = null;
            MydataGridView.DataSource = listado;
        }

        private void ESTfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EstDesdelabel_Click(object sender, EventArgs e)
        {

        }
    }
    
}
