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
using RegistroEstudiantes10_9.BLL;
using RegistroEstudiantes10_9.DAL;

namespace RegistroEstudiantes10_9.UI.Registros
{
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();
           
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Inscripciones inscripcion = InscripcionesBLL.Buscar((int)InscripcionIDnumericUpDown.Value);
            return (inscripcion != null);
        }

        

        private Inscripciones LlenaClase()
        {
            
            Inscripciones inscripcion = new Inscripciones();
            inscripcion.IncripcioId = Convert.ToInt32(InscripcionIDnumericUpDown.Value);
            inscripcion.Fecha = FechadateTimePicker.Value;
            inscripcion.EstudianteId =Convert.ToInt32(EstudianteIdnumericUpDown.Value);
            inscripcion.Comentario = ComentariotextBox.Text;
            inscripcion.Monto = Convert.ToInt32(Montonumeric.Value);
            inscripcion.Deposito = Convert.ToInt32(Depositonumeric.Value);
            inscripcion.Balance = Convert.ToInt32(BalancetextBox.Text);

            return inscripcion;
        }

        private void CalcularBalance()
        {
            int monto = 0;
            int deposito = 0;
            monto = Convert.ToInt32(Montonumeric.Value);
            deposito = Convert.ToInt32(Depositonumeric.Value);

            BalancetextBox.Text = InscripcionesBLL.CBalance(monto, deposito).ToString();
        }

        public void LlenaCampo(Inscripciones inscripcion)
        {
            InscripcionIDnumericUpDown.Value = inscripcion.IncripcioId;
            FechadateTimePicker.Value = inscripcion.Fecha ;
            EstudianteIdnumericUpDown.Value = inscripcion.EstudianteId;
            ComentariotextBox.Text = inscripcion.Comentario;
            Montonumeric.Value = Convert.ToInt32(inscripcion.Monto);
            Depositonumeric.Value = Convert.ToInt32(inscripcion.Deposito);
            int total = inscripcion.Monto - inscripcion.Deposito;
            BalancetextBox.Text = Convert.ToString(total);
            

        }
        public void Limpiar()
        {            
            InscripcionIDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            EstudianteIdnumericUpDown.Value = 0;
            ComentariotextBox.Text = string.Empty;
            Montonumeric.Value = 0;
            Depositonumeric.Value = 0;
            BalancetextBox.Text = string.Empty;
            MyerrorProvider.Clear();

        }
        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (Depositonumeric.Value == 0)
            {
               
                Depositonumeric.Focus();
                paso = false;
            }


            return paso;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Inscripciones inscripcion;
            bool paso = false;

            if (!Validar())
                return;

            inscripcion = LlenaClase();

            if (InscripcionIDnumericUpDown.Value == 0)
                paso = InscripcionesBLL.Guardar(inscripcion);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar una Inscripcion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = InscripcionesBLL.Modificar(inscripcion);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            MyerrorProvider.Clear();

            int id;
            id = Convert.ToInt32(InscripcionIDnumericUpDown.Value);

            Limpiar();

            if (InscripcionesBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyerrorProvider.SetError(InscripcionIDnumericUpDown, "No se puede eliminar una persona que no existe");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Inscripciones estudiante = new Inscripciones();
            id = Convert.ToInt32(InscripcionIDnumericUpDown.Value);

            Limpiar();
            estudiante = InscripcionesBLL.Buscar(id);

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

        private void Depositonumeric_ValueChanged(object sender, EventArgs e)
        {
            if (Montonumeric.Value != 0)
                CalcularBalance();
            
        }
    }
}
