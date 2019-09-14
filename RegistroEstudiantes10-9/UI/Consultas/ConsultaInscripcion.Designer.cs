namespace RegistroEstudiantes10_9.UI.Consultas
{
    partial class ConsultaInscripcion
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
            this.DesdedateINSTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ConsultadataINSGridView = new System.Windows.Forms.DataGridView();
            this.HastadateINSTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Desdelabel = new System.Windows.Forms.Label();
            this.Hastalabel = new System.Windows.Forms.Label();
            this.CriterioINStextBox = new System.Windows.Forms.TextBox();
            this.Criteriolabel = new System.Windows.Forms.Label();
            this.FiltroINScomboBox = new System.Windows.Forms.ComboBox();
            this.Filtrolabel = new System.Windows.Forms.Label();
            this.Consultabutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataINSGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DesdedateINSTimePicker
            // 
            this.DesdedateINSTimePicker.Location = new System.Drawing.Point(12, 25);
            this.DesdedateINSTimePicker.Name = "DesdedateINSTimePicker";
            this.DesdedateINSTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DesdedateINSTimePicker.TabIndex = 0;
            this.DesdedateINSTimePicker.ValueChanged += new System.EventHandler(this.DesdedateTimePicker_ValueChanged);
            // 
            // ConsultadataINSGridView
            // 
            this.ConsultadataINSGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataINSGridView.Location = new System.Drawing.Point(12, 51);
            this.ConsultadataINSGridView.Name = "ConsultadataINSGridView";
            this.ConsultadataINSGridView.Size = new System.Drawing.Size(776, 387);
            this.ConsultadataINSGridView.TabIndex = 1;
            this.ConsultadataINSGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsultadataGridView_CellContentClick);
            // 
            // HastadateINSTimePicker
            // 
            this.HastadateINSTimePicker.Location = new System.Drawing.Point(218, 25);
            this.HastadateINSTimePicker.Name = "HastadateINSTimePicker";
            this.HastadateINSTimePicker.Size = new System.Drawing.Size(200, 20);
            this.HastadateINSTimePicker.TabIndex = 2;
            this.HastadateINSTimePicker.ValueChanged += new System.EventHandler(this.HastadateTimePicker_ValueChanged);
            // 
            // Desdelabel
            // 
            this.Desdelabel.AutoSize = true;
            this.Desdelabel.Location = new System.Drawing.Point(12, 9);
            this.Desdelabel.Name = "Desdelabel";
            this.Desdelabel.Size = new System.Drawing.Size(38, 13);
            this.Desdelabel.TabIndex = 3;
            this.Desdelabel.Text = "Desde";
            this.Desdelabel.Click += new System.EventHandler(this.Desdelabel_Click);
            // 
            // Hastalabel
            // 
            this.Hastalabel.AutoSize = true;
            this.Hastalabel.Location = new System.Drawing.Point(215, 9);
            this.Hastalabel.Name = "Hastalabel";
            this.Hastalabel.Size = new System.Drawing.Size(35, 13);
            this.Hastalabel.TabIndex = 4;
            this.Hastalabel.Text = "Hasta";
            this.Hastalabel.Click += new System.EventHandler(this.Hastalabel_Click);
            // 
            // CriterioINStextBox
            // 
            this.CriterioINStextBox.Location = new System.Drawing.Point(551, 25);
            this.CriterioINStextBox.Name = "CriterioINStextBox";
            this.CriterioINStextBox.Size = new System.Drawing.Size(149, 20);
            this.CriterioINStextBox.TabIndex = 6;
            this.CriterioINStextBox.TextChanged += new System.EventHandler(this.CriteriotextBox_TextChanged);
            // 
            // Criteriolabel
            // 
            this.Criteriolabel.AutoSize = true;
            this.Criteriolabel.Location = new System.Drawing.Point(548, 9);
            this.Criteriolabel.Name = "Criteriolabel";
            this.Criteriolabel.Size = new System.Drawing.Size(39, 13);
            this.Criteriolabel.TabIndex = 7;
            this.Criteriolabel.Text = "Criterio";
            this.Criteriolabel.Click += new System.EventHandler(this.Criteriolabel_Click);
            // 
            // FiltroINScomboBox
            // 
            this.FiltroINScomboBox.FormattingEnabled = true;
            this.FiltroINScomboBox.Items.AddRange(new object[] {
            "Todo",
            "ID"});
            this.FiltroINScomboBox.Location = new System.Drawing.Point(424, 24);
            this.FiltroINScomboBox.Name = "FiltroINScomboBox";
            this.FiltroINScomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltroINScomboBox.TabIndex = 8;
            this.FiltroINScomboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrocomboBox_SelectedIndexChanged);
            // 
            // Filtrolabel
            // 
            this.Filtrolabel.AutoSize = true;
            this.Filtrolabel.Location = new System.Drawing.Point(421, 9);
            this.Filtrolabel.Name = "Filtrolabel";
            this.Filtrolabel.Size = new System.Drawing.Size(29, 13);
            this.Filtrolabel.TabIndex = 9;
            this.Filtrolabel.Text = "Filtro";
            this.Filtrolabel.Click += new System.EventHandler(this.Filtrolabel_Click);
            // 
            // Consultabutton
            // 
            this.Consultabutton.Image = global::RegistroEstudiantes10_9.Properties.Resources.icons8_borrar_búsqueda_241;
            this.Consultabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultabutton.Location = new System.Drawing.Point(706, 22);
            this.Consultabutton.Name = "Consultabutton";
            this.Consultabutton.Size = new System.Drawing.Size(82, 23);
            this.Consultabutton.TabIndex = 5;
            this.Consultabutton.Text = "Consulta";
            this.Consultabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultabutton.UseVisualStyleBackColor = true;
            this.Consultabutton.Click += new System.EventHandler(this.Consultabutton_Click);
            // 
            // ConsultaInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Filtrolabel);
            this.Controls.Add(this.FiltroINScomboBox);
            this.Controls.Add(this.Criteriolabel);
            this.Controls.Add(this.CriterioINStextBox);
            this.Controls.Add(this.Consultabutton);
            this.Controls.Add(this.Hastalabel);
            this.Controls.Add(this.Desdelabel);
            this.Controls.Add(this.HastadateINSTimePicker);
            this.Controls.Add(this.ConsultadataINSGridView);
            this.Controls.Add(this.DesdedateINSTimePicker);
            this.Name = "ConsultaInscripcion";
            this.Text = "Consulta Inscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataINSGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DesdedateINSTimePicker;
        private System.Windows.Forms.DataGridView ConsultadataINSGridView;
        private System.Windows.Forms.DateTimePicker HastadateINSTimePicker;
        private System.Windows.Forms.Label Desdelabel;
        private System.Windows.Forms.Label Hastalabel;
        private System.Windows.Forms.Button Consultabutton;
        private System.Windows.Forms.TextBox CriterioINStextBox;
        private System.Windows.Forms.Label Criteriolabel;
        private System.Windows.Forms.ComboBox FiltroINScomboBox;
        private System.Windows.Forms.Label Filtrolabel;
    }
}