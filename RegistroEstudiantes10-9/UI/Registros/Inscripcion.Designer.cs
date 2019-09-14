namespace RegistroEstudiantes10_9.UI.Registros
{
    partial class Inscripcion
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
            this.ComentariotextBox = new System.Windows.Forms.TextBox();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InscripcionIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Balancelabel = new System.Windows.Forms.Label();
            this.Depositolabel = new System.Windows.Forms.Label();
            this.Montolabel = new System.Windows.Forms.Label();
            this.ComentariosLabel = new System.Windows.Forms.Label();
            this.EstudianteIdlabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.IncripcionIdlabel = new System.Windows.Forms.Label();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Montonumeric = new System.Windows.Forms.NumericUpDown();
            this.Depositonumeric = new System.Windows.Forms.NumericUpDown();
            this.EstudianteIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Montonumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depositonumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ComentariotextBox
            // 
            this.ComentariotextBox.Location = new System.Drawing.Point(98, 104);
            this.ComentariotextBox.Multiline = true;
            this.ComentariotextBox.Name = "ComentariotextBox";
            this.ComentariotextBox.ShortcutsEnabled = false;
            this.ComentariotextBox.Size = new System.Drawing.Size(152, 89);
            this.ComentariotextBox.TabIndex = 35;
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.Location = new System.Drawing.Point(98, 284);
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.ReadOnly = true;
            this.BalancetextBox.Size = new System.Drawing.Size(152, 20);
            this.BalancetextBox.TabIndex = 31;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(98, 69);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.FechadateTimePicker.TabIndex = 28;
            // 
            // InscripcionIDnumericUpDown
            // 
            this.InscripcionIDnumericUpDown.Location = new System.Drawing.Point(98, 6);
            this.InscripcionIDnumericUpDown.Name = "InscripcionIDnumericUpDown";
            this.InscripcionIDnumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.InscripcionIDnumericUpDown.TabIndex = 26;
            // 
            // Balancelabel
            // 
            this.Balancelabel.AutoSize = true;
            this.Balancelabel.Location = new System.Drawing.Point(13, 284);
            this.Balancelabel.Name = "Balancelabel";
            this.Balancelabel.Size = new System.Drawing.Size(49, 13);
            this.Balancelabel.TabIndex = 25;
            this.Balancelabel.Text = "Balance:";
            // 
            // Depositolabel
            // 
            this.Depositolabel.AutoSize = true;
            this.Depositolabel.Location = new System.Drawing.Point(13, 248);
            this.Depositolabel.Name = "Depositolabel";
            this.Depositolabel.Size = new System.Drawing.Size(52, 13);
            this.Depositolabel.TabIndex = 24;
            this.Depositolabel.Text = "Deposito:";
            // 
            // Montolabel
            // 
            this.Montolabel.AutoSize = true;
            this.Montolabel.Location = new System.Drawing.Point(13, 211);
            this.Montolabel.Name = "Montolabel";
            this.Montolabel.Size = new System.Drawing.Size(40, 13);
            this.Montolabel.TabIndex = 23;
            this.Montolabel.Text = "Monto:";
            // 
            // ComentariosLabel
            // 
            this.ComentariosLabel.AutoSize = true;
            this.ComentariosLabel.Location = new System.Drawing.Point(13, 104);
            this.ComentariosLabel.Name = "ComentariosLabel";
            this.ComentariosLabel.Size = new System.Drawing.Size(68, 13);
            this.ComentariosLabel.TabIndex = 22;
            this.ComentariosLabel.Text = "Comentarios:";
            // 
            // EstudianteIdlabel
            // 
            this.EstudianteIdlabel.AutoSize = true;
            this.EstudianteIdlabel.Location = new System.Drawing.Point(14, 38);
            this.EstudianteIdlabel.Name = "EstudianteIdlabel";
            this.EstudianteIdlabel.Size = new System.Drawing.Size(72, 13);
            this.EstudianteIdlabel.TabIndex = 21;
            this.EstudianteIdlabel.Text = "Estudiante Id:";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(14, 69);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(40, 13);
            this.Fechalabel.TabIndex = 20;
            this.Fechalabel.Text = "Fecha:";
            // 
            // IncripcionIdlabel
            // 
            this.IncripcionIdlabel.AutoSize = true;
            this.IncripcionIdlabel.Location = new System.Drawing.Point(13, 6);
            this.IncripcionIdlabel.Name = "IncripcionIdlabel";
            this.IncripcionIdlabel.Size = new System.Drawing.Size(68, 13);
            this.IncripcionIdlabel.TabIndex = 19;
            this.IncripcionIdlabel.Text = "Incripcion Id:";
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::RegistroEstudiantes10_9.Properties.Resources.icons8_borrar_búsqueda_241;
            this.Buscarbutton.Location = new System.Drawing.Point(175, 6);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 52);
            this.Buscarbutton.TabIndex = 36;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::RegistroEstudiantes10_9.Properties.Resources.icons8_eliminar_24;
            this.Eliminarbutton.Location = new System.Drawing.Point(175, 331);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 60);
            this.Eliminarbutton.TabIndex = 34;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::RegistroEstudiantes10_9.Properties.Resources.icons8_agregar_archivo_321;
            this.Nuevobutton.Location = new System.Drawing.Point(17, 331);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(71, 60);
            this.Nuevobutton.TabIndex = 33;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Editarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::RegistroEstudiantes10_9.Properties.Resources.icons8_guardar_30;
            this.Guardarbutton.Location = new System.Drawing.Point(94, 331);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 60);
            this.Guardarbutton.TabIndex = 32;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Montonumeric
            // 
            this.Montonumeric.Location = new System.Drawing.Point(98, 209);
            this.Montonumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Montonumeric.Name = "Montonumeric";
            this.Montonumeric.Size = new System.Drawing.Size(152, 20);
            this.Montonumeric.TabIndex = 37;
            // 
            // Depositonumeric
            // 
            this.Depositonumeric.Location = new System.Drawing.Point(98, 248);
            this.Depositonumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Depositonumeric.Name = "Depositonumeric";
            this.Depositonumeric.Size = new System.Drawing.Size(152, 20);
            this.Depositonumeric.TabIndex = 38;
            this.Depositonumeric.ValueChanged += new System.EventHandler(this.Depositonumeric_ValueChanged);
            // 
            // EstudianteIdnumericUpDown
            // 
            this.EstudianteIdnumericUpDown.Location = new System.Drawing.Point(98, 38);
            this.EstudianteIdnumericUpDown.Name = "EstudianteIdnumericUpDown";
            this.EstudianteIdnumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.EstudianteIdnumericUpDown.TabIndex = 39;
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 397);
            this.Controls.Add(this.EstudianteIdnumericUpDown);
            this.Controls.Add(this.Depositonumeric);
            this.Controls.Add(this.Montonumeric);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.ComentariotextBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.BalancetextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.InscripcionIDnumericUpDown);
            this.Controls.Add(this.Balancelabel);
            this.Controls.Add(this.Depositolabel);
            this.Controls.Add(this.Montolabel);
            this.Controls.Add(this.ComentariosLabel);
            this.Controls.Add(this.EstudianteIdlabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.IncripcionIdlabel);
            this.Name = "Inscripcion";
            this.Text = "Inscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Montonumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depositonumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ComentariotextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.NumericUpDown InscripcionIDnumericUpDown;
        private System.Windows.Forms.Label Balancelabel;
        private System.Windows.Forms.Label Depositolabel;
        private System.Windows.Forms.Label Montolabel;
        private System.Windows.Forms.Label ComentariosLabel;
        private System.Windows.Forms.Label EstudianteIdlabel;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label IncripcionIdlabel;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.NumericUpDown Depositonumeric;
        private System.Windows.Forms.NumericUpDown Montonumeric;
        private System.Windows.Forms.NumericUpDown EstudianteIdnumericUpDown;
    }
}