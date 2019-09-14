namespace RegistroEstudiantes10_9.UI.Registros
{
    partial class RegistroEstudiantess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.ApellidotextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.SexocomboBox = new System.Windows.Forms.ComboBox();
            this.FechaNacimientodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CelularmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CedulamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MatriculamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Sexolabel = new System.Windows.Forms.Label();
            this.Balancelabel = new System.Windows.Forms.Label();
            this.FechaNacimientolabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Celularlabel = new System.Windows.Forms.Label();
            this.Telefonolabel6 = new System.Windows.Forms.Label();
            this.Cedulalabel = new System.Windows.Forms.Label();
            this.Apellidoslabel = new System.Windows.Forms.Label();
            this.Nombreslabel = new System.Windows.Forms.Label();
            this.Matriculalabel = new System.Windows.Forms.Label();
            this.Idlabel = new System.Windows.Forms.Label();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(108, 189);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(156, 20);
            this.EmailtextBox.TabIndex = 97;
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.Location = new System.Drawing.Point(108, 268);
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.ReadOnly = true;
            this.BalancetextBox.Size = new System.Drawing.Size(156, 20);
            this.BalancetextBox.TabIndex = 96;
            // 
            // ApellidotextBox
            // 
            this.ApellidotextBox.Location = new System.Drawing.Point(108, 85);
            this.ApellidotextBox.Name = "ApellidotextBox";
            this.ApellidotextBox.Size = new System.Drawing.Size(156, 20);
            this.ApellidotextBox.TabIndex = 95;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(108, 59);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(156, 20);
            this.NombretextBox.TabIndex = 94;
            // 
            // SexocomboBox
            // 
            this.SexocomboBox.FormattingEnabled = true;
            this.SexocomboBox.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.SexocomboBox.Location = new System.Drawing.Point(108, 241);
            this.SexocomboBox.Name = "SexocomboBox";
            this.SexocomboBox.Size = new System.Drawing.Size(156, 21);
            this.SexocomboBox.TabIndex = 93;
            // 
            // FechaNacimientodateTimePicker
            // 
            this.FechaNacimientodateTimePicker.Location = new System.Drawing.Point(108, 215);
            this.FechaNacimientodateTimePicker.Name = "FechaNacimientodateTimePicker";
            this.FechaNacimientodateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.FechaNacimientodateTimePicker.TabIndex = 92;
            // 
            // CelularmaskedTextBox
            // 
            this.CelularmaskedTextBox.Location = new System.Drawing.Point(108, 163);
            this.CelularmaskedTextBox.Mask = "(999)000-0000";
            this.CelularmaskedTextBox.Name = "CelularmaskedTextBox";
            this.CelularmaskedTextBox.Size = new System.Drawing.Size(156, 20);
            this.CelularmaskedTextBox.TabIndex = 91;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(108, 137);
            this.TelefonomaskedTextBox.Mask = "(999)000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(156, 20);
            this.TelefonomaskedTextBox.TabIndex = 90;
            // 
            // CedulamaskedTextBox
            // 
            this.CedulamaskedTextBox.Location = new System.Drawing.Point(108, 111);
            this.CedulamaskedTextBox.Mask = "000-0000000-0";
            this.CedulamaskedTextBox.Name = "CedulamaskedTextBox";
            this.CedulamaskedTextBox.Size = new System.Drawing.Size(156, 20);
            this.CedulamaskedTextBox.TabIndex = 89;
            // 
            // MatriculamaskedTextBox
            // 
            this.MatriculamaskedTextBox.Location = new System.Drawing.Point(108, 33);
            this.MatriculamaskedTextBox.Mask = "0000-0000";
            this.MatriculamaskedTextBox.Name = "MatriculamaskedTextBox";
            this.MatriculamaskedTextBox.Size = new System.Drawing.Size(156, 20);
            this.MatriculamaskedTextBox.TabIndex = 88;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(108, 9);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.IdnumericUpDown.TabIndex = 87;
            // 
            // Sexolabel
            // 
            this.Sexolabel.AutoSize = true;
            this.Sexolabel.Location = new System.Drawing.Point(5, 241);
            this.Sexolabel.Name = "Sexolabel";
            this.Sexolabel.Size = new System.Drawing.Size(34, 13);
            this.Sexolabel.TabIndex = 86;
            this.Sexolabel.Text = "Sexo:";
            // 
            // Balancelabel
            // 
            this.Balancelabel.AutoSize = true;
            this.Balancelabel.Location = new System.Drawing.Point(5, 268);
            this.Balancelabel.Name = "Balancelabel";
            this.Balancelabel.Size = new System.Drawing.Size(49, 13);
            this.Balancelabel.TabIndex = 85;
            this.Balancelabel.Text = "Balance:";
            // 
            // FechaNacimientolabel
            // 
            this.FechaNacimientolabel.AutoSize = true;
            this.FechaNacimientolabel.Location = new System.Drawing.Point(5, 215);
            this.FechaNacimientolabel.Name = "FechaNacimientolabel";
            this.FechaNacimientolabel.Size = new System.Drawing.Size(96, 13);
            this.FechaNacimientolabel.TabIndex = 84;
            this.FechaNacimientolabel.Text = "Fecha Nacimiento:";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(5, 189);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(38, 13);
            this.Emaillabel.TabIndex = 83;
            this.Emaillabel.Text = "E-mail:";
            // 
            // Celularlabel
            // 
            this.Celularlabel.AutoSize = true;
            this.Celularlabel.Location = new System.Drawing.Point(5, 163);
            this.Celularlabel.Name = "Celularlabel";
            this.Celularlabel.Size = new System.Drawing.Size(42, 13);
            this.Celularlabel.TabIndex = 82;
            this.Celularlabel.Text = "Celular:";
            // 
            // Telefonolabel6
            // 
            this.Telefonolabel6.AutoSize = true;
            this.Telefonolabel6.Location = new System.Drawing.Point(5, 137);
            this.Telefonolabel6.Name = "Telefonolabel6";
            this.Telefonolabel6.Size = new System.Drawing.Size(52, 13);
            this.Telefonolabel6.TabIndex = 81;
            this.Telefonolabel6.Text = "Telefono:";
            // 
            // Cedulalabel
            // 
            this.Cedulalabel.AutoSize = true;
            this.Cedulalabel.Location = new System.Drawing.Point(5, 111);
            this.Cedulalabel.Name = "Cedulalabel";
            this.Cedulalabel.Size = new System.Drawing.Size(43, 13);
            this.Cedulalabel.TabIndex = 80;
            this.Cedulalabel.Text = "Cedula:";
            // 
            // Apellidoslabel
            // 
            this.Apellidoslabel.AutoSize = true;
            this.Apellidoslabel.Location = new System.Drawing.Point(5, 85);
            this.Apellidoslabel.Name = "Apellidoslabel";
            this.Apellidoslabel.Size = new System.Drawing.Size(52, 13);
            this.Apellidoslabel.TabIndex = 79;
            this.Apellidoslabel.Text = "Apellidos:";
            // 
            // Nombreslabel
            // 
            this.Nombreslabel.AutoSize = true;
            this.Nombreslabel.Location = new System.Drawing.Point(5, 59);
            this.Nombreslabel.Name = "Nombreslabel";
            this.Nombreslabel.Size = new System.Drawing.Size(52, 13);
            this.Nombreslabel.TabIndex = 78;
            this.Nombreslabel.Text = "Nombres:";
            // 
            // Matriculalabel
            // 
            this.Matriculalabel.AutoSize = true;
            this.Matriculalabel.Location = new System.Drawing.Point(5, 33);
            this.Matriculalabel.Name = "Matriculalabel";
            this.Matriculalabel.Size = new System.Drawing.Size(53, 13);
            this.Matriculalabel.TabIndex = 77;
            this.Matriculalabel.Text = "Matricula:";
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Location = new System.Drawing.Point(5, 9);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(19, 13);
            this.Idlabel.TabIndex = 76;
            this.Idlabel.Text = "Id:";
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::RegistroEstudiantes10_9.Properties.Resources.icons8_agregar_archivo_32;
            this.Nuevobutton.Location = new System.Drawing.Point(27, 317);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 58);
            this.Nuevobutton.TabIndex = 101;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::RegistroEstudiantes10_9.Properties.Resources.icons8_guardar_30;
            this.Guardarbutton.Location = new System.Drawing.Point(108, 317);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 58);
            this.Guardarbutton.TabIndex = 100;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::RegistroEstudiantes10_9.Properties.Resources.icons8_eliminar_24;
            this.Eliminarbutton.Location = new System.Drawing.Point(189, 317);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 58);
            this.Eliminarbutton.TabIndex = 99;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::RegistroEstudiantes10_9.Properties.Resources.icons8_borrar_búsqueda_24;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(189, 8);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 98;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistroEstudiantess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 382);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.BalancetextBox);
            this.Controls.Add(this.ApellidotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.SexocomboBox);
            this.Controls.Add(this.FechaNacimientodateTimePicker);
            this.Controls.Add(this.CelularmaskedTextBox);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.CedulamaskedTextBox);
            this.Controls.Add(this.MatriculamaskedTextBox);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.Sexolabel);
            this.Controls.Add(this.Balancelabel);
            this.Controls.Add(this.FechaNacimientolabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Celularlabel);
            this.Controls.Add(this.Telefonolabel6);
            this.Controls.Add(this.Cedulalabel);
            this.Controls.Add(this.Apellidoslabel);
            this.Controls.Add(this.Nombreslabel);
            this.Controls.Add(this.Matriculalabel);
            this.Controls.Add(this.Idlabel);
            this.Name = "RegistroEstudiantess";
            this.Text = "Registro Estudiantes";
            this.Load += new System.EventHandler(this.RegistroEstudiantess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.TextBox ApellidotextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.ComboBox SexocomboBox;
        private System.Windows.Forms.DateTimePicker FechaNacimientodateTimePicker;
        private System.Windows.Forms.MaskedTextBox CelularmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CedulamaskedTextBox;
        private System.Windows.Forms.MaskedTextBox MatriculamaskedTextBox;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Label Sexolabel;
        private System.Windows.Forms.Label Balancelabel;
        private System.Windows.Forms.Label FechaNacimientolabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label Celularlabel;
        private System.Windows.Forms.Label Telefonolabel6;
        private System.Windows.Forms.Label Cedulalabel;
        private System.Windows.Forms.Label Apellidoslabel;
        private System.Windows.Forms.Label Nombreslabel;
        private System.Windows.Forms.Label Matriculalabel;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
    }
}