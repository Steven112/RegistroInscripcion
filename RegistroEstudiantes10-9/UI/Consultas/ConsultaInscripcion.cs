using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroEstudiantes10_9.BLL;
using RegistroEstudiantes10_9.DAL;
using RegistroEstudiantes10_9.Entidades;

namespace RegistroEstudiantes10_9.UI.Consultas
{
    public partial class ConsultaInscripcion : Form
    {
        public ConsultaInscripcion()
        {
            InitializeComponent();
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Inscripciones>();
            if ( CriterioINStextBox.Text.Trim().Length > 0)
            {
                switch (FiltroINScomboBox .SelectedItem)
                {
                    case 0:
                        listado = InscripcionesBLL.GetList(p => true);
                        break;
                    case 1:
                        int Id = Convert.ToInt32(CriterioINStextBox .Text);
                        listado = InscripcionesBLL.GetList(p => p.IncripcioId==Id);
                        break;
                    

                }

                listado = listado.Where(c => c.Fecha.Date >= DesdedateINSTimePicker.Value.Date && c.Fecha.Date <= HastadateINSTimePicker.Value.Date).ToList();

            }
            else
            {
                listado = InscripcionesBLL.GetList(p => true);
            }

            ConsultadataINSGridView.DataSource = null;
            ConsultadataINSGridView.DataSource = listado;
        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Criteriolabel_Click(object sender, EventArgs e)
        {

        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Filtrolabel_Click(object sender, EventArgs e)
        {

        }

        private void Hastalabel_Click(object sender, EventArgs e)
        {

        }

        private void Desdelabel_Click(object sender, EventArgs e)
        {

        }

        private void HastadateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DesdedateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
