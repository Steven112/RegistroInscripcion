using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroEstudiantes10_9.Entidades;
using RegistroEstudiantes10_9.DAL;
using RegistroEstudiantes10_9.BLL;
using RegistroEstudiantes10_9.UI;

namespace RegistroEstudiantes10_9.UI.Registros
{
    public partial class RegistroEstudiantess : Form
    {
        public RegistroEstudiantess()
        {
            InitializeComponent();


        }
        public void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            MatriculamaskedTextBox.Text = string.Empty;
            NombretextBox.Text = string.Empty;
            ApellidotextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            CelularmaskedTextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            FechaNacimientodateTimePicker.Value = DateTime.Now;
            SexocomboBox.Text = string.Empty;
            BalancetextBox.Text = string.Empty;
            MyerrorProvider.Clear();

        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Estudiantes estudiante = EstudiantesBLL.Buscar((int)IdnumericUpDown.Value);
            return (estudiante != null);
        }


        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = Convert.ToInt32(IdnumericUpDown.Value);
            estudiante.Matricula = MatriculamaskedTextBox.Text;
            estudiante.Nombres = NombretextBox.Text;
            estudiante.Apellidos = ApellidotextBox.Text;
            estudiante.Cedula = CedulamaskedTextBox.Text;
            estudiante.Telefono = TelefonomaskedTextBox.Text;
            estudiante.Celular = CelularmaskedTextBox.Text;
            estudiante.Email = EmailtextBox.Text;
            estudiante.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            estudiante.Sexo = SexocomboBox.Text;
           // estudiante.Balance = Convert.ToInt32(BalancetextBox.Text);

            return estudiante;
        }

        public void LlenaCampo(Estudiantes estudiante)
        {
            IdnumericUpDown.Value = estudiante.EstudianteId;
            MatriculamaskedTextBox.Text = estudiante.Matricula;
            NombretextBox.Text = estudiante.Nombres;
            ApellidotextBox.Text = estudiante.Apellidos;
            CedulamaskedTextBox.Text = estudiante.Cedula;
            TelefonomaskedTextBox.Text = estudiante.Telefono;
            CelularmaskedTextBox.Text = estudiante.Celular;
            EmailtextBox.Text = estudiante.Email;
            FechaNacimientodateTimePicker.Value = estudiante.FechaNacimiento;
            SexocomboBox.Text = estudiante.Sexo;
            BalancetextBox.Text = estudiante.Balance.ToString();
        }
        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (NombretextBox.Text == string.Empty)
            {
                MyerrorProvider.SetError(NombretextBox, "El campo Nombre no puede estar vacio");
                NombretextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrEmpty(CedulamaskedTextBox.Text.Replace("-","")))
            {
                MyerrorProvider.SetError(CedulamaskedTextBox, "El campo Cedula no puede estar vacio");
                CedulamaskedTextBox.Focus();
                paso = false;
            }

            return paso;
        }


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante;
            bool paso = false;

            if (!Validar())
                return;

            estudiante = LlenaClase();

            if (IdnumericUpDown.Value == 0)
                paso = EstudiantesBLL.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar a una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = EstudiantesBLL.Modificar(estudiante);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Estudiantes estudiante = new Estudiantes();
            id = Convert.ToInt32(IdnumericUpDown.Value);

            Limpiar();
            estudiante = EstudiantesBLL.Buscar(id);

            if (estudiante != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenaCampo(estudiante);
            }
            else
            {
                MessageBox.Show("Persona no Encontrada");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            MyerrorProvider.Clear();

            int id;
            id = Convert.ToInt32(IdnumericUpDown.Value);

            Limpiar();

            if (EstudiantesBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyerrorProvider.SetError(IdnumericUpDown, "No se puede eliminar una persona que no existe");
            }
               
        }

        private void RegistroEstudiantess_Load(object sender, EventArgs e)
        {

        }
    }
}
