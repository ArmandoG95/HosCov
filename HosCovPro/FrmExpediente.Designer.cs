namespace HosCovPro
{
    partial class FrmExpediente
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
            this.tbcExpediente = new System.Windows.Forms.TabControl();
            this.tbpPerfil = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.pnlDonante = new System.Windows.Forms.Panel();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.lblDonante = new System.Windows.Forms.Label();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.pnlOrganos = new System.Windows.Forms.Panel();
            this.chcVenasHuesoCartilago = new System.Windows.Forms.CheckBox();
            this.chcPiel = new System.Windows.Forms.CheckBox();
            this.chcPancreas = new System.Windows.Forms.CheckBox();
            this.chcCorneas = new System.Windows.Forms.CheckBox();
            this.chcRiñones = new System.Windows.Forms.CheckBox();
            this.chcHigado = new System.Windows.Forms.CheckBox();
            this.chcCorazon = new System.Windows.Forms.CheckBox();
            this.chcPulmones = new System.Windows.Forms.CheckBox();
            this.grpEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rdbSoltero = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbDivorciado = new System.Windows.Forms.RadioButton();
            this.rdbViudo = new System.Windows.Forms.RadioButton();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblCuarto = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.pctImagen = new System.Windows.Forms.PictureBox();
            this.tbpAnalisis = new System.Windows.Forms.TabPage();
            this.txtNombreCompletoAnalisis = new System.Windows.Forms.TextBox();
            this.lblNombreCompletoAnalisi = new System.Windows.Forms.Label();
            this.btnActualizarAnalisis = new System.Windows.Forms.Button();
            this.cmbPruebas = new System.Windows.Forms.ComboBox();
            this.tbpAgenda = new System.Windows.Forms.TabPage();
            this.btnActualizarAgenda = new System.Windows.Forms.Button();
            this.grpOtrosProgramados = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtNombreCompletoAgenda = new System.Windows.Forms.TextBox();
            this.lblNombreCompletoAgend = new System.Windows.Forms.Label();
            this.grpAnalisisConsultasProgramadas = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbcExpediente.SuspendLayout();
            this.tbpPerfil.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.pnlDonante.SuspendLayout();
            this.pnlOrganos.SuspendLayout();
            this.grpEstadoCivil.SuspendLayout();
            this.grpSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.tbpAnalisis.SuspendLayout();
            this.tbpAgenda.SuspendLayout();
            this.grpOtrosProgramados.SuspendLayout();
            this.grpAnalisisConsultasProgramadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcExpediente
            // 
            this.tbcExpediente.Controls.Add(this.tbpPerfil);
            this.tbcExpediente.Controls.Add(this.tbpAnalisis);
            this.tbcExpediente.Controls.Add(this.tbpAgenda);
            this.tbcExpediente.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcExpediente.Location = new System.Drawing.Point(12, 12);
            this.tbcExpediente.Name = "tbcExpediente";
            this.tbcExpediente.SelectedIndex = 0;
            this.tbcExpediente.Size = new System.Drawing.Size(836, 599);
            this.tbcExpediente.TabIndex = 1;
            // 
            // tbpPerfil
            // 
            this.tbpPerfil.BackColor = System.Drawing.Color.SteelBlue;
            this.tbpPerfil.Controls.Add(this.btnEditar);
            this.tbpPerfil.Controls.Add(this.grpDatos);
            this.tbpPerfil.Controls.Add(this.pctImagen);
            this.tbpPerfil.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpPerfil.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbpPerfil.Location = new System.Drawing.Point(4, 32);
            this.tbpPerfil.Name = "tbpPerfil";
            this.tbpPerfil.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPerfil.Size = new System.Drawing.Size(828, 563);
            this.tbpPerfil.TabIndex = 0;
            this.tbpPerfil.Text = "Mi Perfil";
            // 
            // btnEditar
            // 
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(22, 173);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(122, 33);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.pnlDonante);
            this.grpDatos.Controls.Add(this.pnlOrganos);
            this.grpDatos.Controls.Add(this.grpEstadoCivil);
            this.grpDatos.Controls.Add(this.grpSexo);
            this.grpDatos.Controls.Add(this.numericUpDown3);
            this.grpDatos.Controls.Add(this.lblEdad);
            this.grpDatos.Controls.Add(this.dateTimePicker1);
            this.grpDatos.Controls.Add(this.lblFechaNacimiento);
            this.grpDatos.Controls.Add(this.numericUpDown2);
            this.grpDatos.Controls.Add(this.lblCuarto);
            this.grpDatos.Controls.Add(this.lblPiso);
            this.grpDatos.Controls.Add(this.numericUpDown1);
            this.grpDatos.Controls.Add(this.txtApellidoMaterno);
            this.grpDatos.Controls.Add(this.txtApellidoPaterno);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.lblApellidoPaterno);
            this.grpDatos.Controls.Add(this.lblApellidoMaterno);
            this.grpDatos.ForeColor = System.Drawing.Color.White;
            this.grpDatos.Location = new System.Drawing.Point(171, 34);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(584, 523);
            this.grpDatos.TabIndex = 7;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos Personales";
            // 
            // pnlDonante
            // 
            this.pnlDonante.Controls.Add(this.rdbSi);
            this.pnlDonante.Controls.Add(this.lblDonante);
            this.pnlDonante.Controls.Add(this.rdbNo);
            this.pnlDonante.Location = new System.Drawing.Point(203, 262);
            this.pnlDonante.Name = "pnlDonante";
            this.pnlDonante.Size = new System.Drawing.Size(353, 43);
            this.pnlDonante.TabIndex = 38;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Checked = true;
            this.rdbSi.Location = new System.Drawing.Point(221, 10);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(46, 27);
            this.rdbSi.TabIndex = 37;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // lblDonante
            // 
            this.lblDonante.AutoSize = true;
            this.lblDonante.Location = new System.Drawing.Point(4, 10);
            this.lblDonante.Name = "lblDonante";
            this.lblDonante.Size = new System.Drawing.Size(170, 23);
            this.lblDonante.TabIndex = 36;
            this.lblDonante.Text = "Donante de Órganos:";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(286, 10);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(54, 27);
            this.rdbNo.TabIndex = 26;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // pnlOrganos
            // 
            this.pnlOrganos.Controls.Add(this.chcVenasHuesoCartilago);
            this.pnlOrganos.Controls.Add(this.chcPiel);
            this.pnlOrganos.Controls.Add(this.chcPancreas);
            this.pnlOrganos.Controls.Add(this.chcCorneas);
            this.pnlOrganos.Controls.Add(this.chcRiñones);
            this.pnlOrganos.Controls.Add(this.chcHigado);
            this.pnlOrganos.Controls.Add(this.chcCorazon);
            this.pnlOrganos.Controls.Add(this.chcPulmones);
            this.pnlOrganos.Location = new System.Drawing.Point(203, 317);
            this.pnlOrganos.Name = "pnlOrganos";
            this.pnlOrganos.Size = new System.Drawing.Size(353, 123);
            this.pnlOrganos.TabIndex = 37;
            // 
            // chcVenasHuesoCartilago
            // 
            this.chcVenasHuesoCartilago.AutoSize = true;
            this.chcVenasHuesoCartilago.Location = new System.Drawing.Point(121, 90);
            this.chcVenasHuesoCartilago.Name = "chcVenasHuesoCartilago";
            this.chcVenasHuesoCartilago.Size = new System.Drawing.Size(219, 27);
            this.chcVenasHuesoCartilago.TabIndex = 35;
            this.chcVenasHuesoCartilago.Text = "Venas, Hueso Cartilagos";
            this.chcVenasHuesoCartilago.UseVisualStyleBackColor = true;
            // 
            // chcPiel
            // 
            this.chcPiel.AutoSize = true;
            this.chcPiel.Location = new System.Drawing.Point(8, 90);
            this.chcPiel.Name = "chcPiel";
            this.chcPiel.Size = new System.Drawing.Size(60, 27);
            this.chcPiel.TabIndex = 34;
            this.chcPiel.Text = "Piel";
            this.chcPiel.UseVisualStyleBackColor = true;
            // 
            // chcPancreas
            // 
            this.chcPancreas.AutoSize = true;
            this.chcPancreas.Checked = true;
            this.chcPancreas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcPancreas.Location = new System.Drawing.Point(121, 57);
            this.chcPancreas.Name = "chcPancreas";
            this.chcPancreas.Size = new System.Drawing.Size(101, 27);
            this.chcPancreas.TabIndex = 33;
            this.chcPancreas.Text = "Páncreas";
            this.chcPancreas.UseVisualStyleBackColor = true;
            // 
            // chcCorneas
            // 
            this.chcCorneas.AutoSize = true;
            this.chcCorneas.Location = new System.Drawing.Point(8, 57);
            this.chcCorneas.Name = "chcCorneas";
            this.chcCorneas.Size = new System.Drawing.Size(95, 27);
            this.chcCorneas.TabIndex = 32;
            this.chcCorneas.Text = "Córneas";
            this.chcCorneas.UseVisualStyleBackColor = true;
            // 
            // chcRiñones
            // 
            this.chcRiñones.AutoSize = true;
            this.chcRiñones.Checked = true;
            this.chcRiñones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcRiñones.Location = new System.Drawing.Point(121, 29);
            this.chcRiñones.Name = "chcRiñones";
            this.chcRiñones.Size = new System.Drawing.Size(93, 27);
            this.chcRiñones.TabIndex = 31;
            this.chcRiñones.Text = "Riñones";
            this.chcRiñones.UseVisualStyleBackColor = true;
            // 
            // chcHigado
            // 
            this.chcHigado.AutoSize = true;
            this.chcHigado.Checked = true;
            this.chcHigado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcHigado.Location = new System.Drawing.Point(8, 29);
            this.chcHigado.Name = "chcHigado";
            this.chcHigado.Size = new System.Drawing.Size(88, 27);
            this.chcHigado.TabIndex = 30;
            this.chcHigado.Text = "Hígado";
            this.chcHigado.UseVisualStyleBackColor = true;
            // 
            // chcCorazon
            // 
            this.chcCorazon.AutoSize = true;
            this.chcCorazon.Location = new System.Drawing.Point(121, 4);
            this.chcCorazon.Name = "chcCorazon";
            this.chcCorazon.Size = new System.Drawing.Size(96, 27);
            this.chcCorazon.TabIndex = 29;
            this.chcCorazon.Text = "Corazón";
            this.chcCorazon.UseVisualStyleBackColor = true;
            // 
            // chcPulmones
            // 
            this.chcPulmones.AutoSize = true;
            this.chcPulmones.Checked = true;
            this.chcPulmones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcPulmones.Location = new System.Drawing.Point(8, 4);
            this.chcPulmones.Name = "chcPulmones";
            this.chcPulmones.Size = new System.Drawing.Size(107, 27);
            this.chcPulmones.TabIndex = 28;
            this.chcPulmones.Text = "Pulmones";
            this.chcPulmones.UseVisualStyleBackColor = true;
            // 
            // grpEstadoCivil
            // 
            this.grpEstadoCivil.Controls.Add(this.rdbSoltero);
            this.grpEstadoCivil.Controls.Add(this.rdbCasado);
            this.grpEstadoCivil.Controls.Add(this.rdbDivorciado);
            this.grpEstadoCivil.Controls.Add(this.rdbViudo);
            this.grpEstadoCivil.ForeColor = System.Drawing.Color.White;
            this.grpEstadoCivil.Location = new System.Drawing.Point(19, 287);
            this.grpEstadoCivil.Name = "grpEstadoCivil";
            this.grpEstadoCivil.Size = new System.Drawing.Size(143, 154);
            this.grpEstadoCivil.TabIndex = 9;
            this.grpEstadoCivil.TabStop = false;
            this.grpEstadoCivil.Text = "Estado Cívil";
            // 
            // rdbSoltero
            // 
            this.rdbSoltero.AutoSize = true;
            this.rdbSoltero.Checked = true;
            this.rdbSoltero.Location = new System.Drawing.Point(6, 29);
            this.rdbSoltero.Name = "rdbSoltero";
            this.rdbSoltero.Size = new System.Drawing.Size(85, 27);
            this.rdbSoltero.TabIndex = 24;
            this.rdbSoltero.TabStop = true;
            this.rdbSoltero.Text = "Soltero";
            this.rdbSoltero.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(6, 55);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(88, 27);
            this.rdbCasado.TabIndex = 23;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbDivorciado
            // 
            this.rdbDivorciado.AutoSize = true;
            this.rdbDivorciado.Location = new System.Drawing.Point(6, 80);
            this.rdbDivorciado.Name = "rdbDivorciado";
            this.rdbDivorciado.Size = new System.Drawing.Size(115, 27);
            this.rdbDivorciado.TabIndex = 22;
            this.rdbDivorciado.Text = "Divorciado";
            this.rdbDivorciado.UseVisualStyleBackColor = true;
            // 
            // rdbViudo
            // 
            this.rdbViudo.AutoSize = true;
            this.rdbViudo.Location = new System.Drawing.Point(6, 104);
            this.rdbViudo.Name = "rdbViudo";
            this.rdbViudo.Size = new System.Drawing.Size(78, 27);
            this.rdbViudo.TabIndex = 21;
            this.rdbViudo.Text = "Viudo";
            this.rdbViudo.UseVisualStyleBackColor = true;
            // 
            // grpSexo
            // 
            this.grpSexo.BackColor = System.Drawing.Color.Transparent;
            this.grpSexo.Controls.Add(this.rdbMasculino);
            this.grpSexo.Controls.Add(this.rdbFemenino);
            this.grpSexo.ForeColor = System.Drawing.Color.White;
            this.grpSexo.Location = new System.Drawing.Point(19, 166);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(143, 98);
            this.grpSexo.TabIndex = 9;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.Location = new System.Drawing.Point(5, 29);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(110, 27);
            this.rdbMasculino.TabIndex = 5;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(5, 62);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(105, 27);
            this.rdbFemenino.TabIndex = 6;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(404, 478);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(98, 30);
            this.numericUpDown3.TabIndex = 19;
            this.numericUpDown3.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.ForeColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(400, 452);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(53, 23);
            this.lblEdad.TabIndex = 18;
            this.lblEdad.Text = "Edad:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 478);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(352, 30);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2002, 4, 6, 1, 31, 0, 0);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(24, 452);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(173, 23);
            this.lblFechaNacimiento.TabIndex = 16;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(209, 209);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(98, 30);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblCuarto
            // 
            this.lblCuarto.AutoSize = true;
            this.lblCuarto.BackColor = System.Drawing.Color.Transparent;
            this.lblCuarto.ForeColor = System.Drawing.Color.White;
            this.lblCuarto.Location = new System.Drawing.Point(344, 176);
            this.lblCuarto.Name = "lblCuarto";
            this.lblCuarto.Size = new System.Drawing.Size(156, 23);
            this.lblCuarto.TabIndex = 14;
            this.lblCuarto.Text = "Número de Cuarto:";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.BackColor = System.Drawing.Color.Transparent;
            this.lblPiso.ForeColor = System.Drawing.Color.White;
            this.lblPiso.Location = new System.Drawing.Point(207, 176);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(46, 23);
            this.lblPiso.TabIndex = 13;
            this.lblPiso.Text = "Piso:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(372, 209);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            830,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            801,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 30);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            817,
            0,
            0,
            0});
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(209, 109);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(347, 30);
            this.txtApellidoMaterno.TabIndex = 10;
            this.txtApellidoMaterno.Text = "Ramírez";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(209, 71);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(347, 30);
            this.txtApellidoPaterno.TabIndex = 9;
            this.txtApellidoPaterno.Text = "Espinosa";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(209, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(347, 30);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Text = "Mario Sebastian";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(61, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre (s):";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoPaterno.ForeColor = System.Drawing.Color.White;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(21, 74);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(141, 23);
            this.lblApellidoPaterno.TabIndex = 2;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoMaterno.ForeColor = System.Drawing.Color.White;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(15, 109);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(147, 23);
            this.lblApellidoMaterno.TabIndex = 3;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // pctImagen
            // 
            this.pctImagen.Image = global::HosCovPro.Properties.Resources.siluetaH;
            this.pctImagen.Location = new System.Drawing.Point(20, 24);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(124, 130);
            this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagen.TabIndex = 0;
            this.pctImagen.TabStop = false;
            // 
            // tbpAnalisis
            // 
            this.tbpAnalisis.BackColor = System.Drawing.Color.SteelBlue;
            this.tbpAnalisis.Controls.Add(this.txtNombreCompletoAnalisis);
            this.tbpAnalisis.Controls.Add(this.lblNombreCompletoAnalisi);
            this.tbpAnalisis.Controls.Add(this.btnActualizarAnalisis);
            this.tbpAnalisis.Controls.Add(this.cmbPruebas);
            this.tbpAnalisis.Location = new System.Drawing.Point(4, 32);
            this.tbpAnalisis.Name = "tbpAnalisis";
            this.tbpAnalisis.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAnalisis.Size = new System.Drawing.Size(828, 563);
            this.tbpAnalisis.TabIndex = 1;
            this.tbpAnalisis.Text = "Mis Análisis";
            // 
            // txtNombreCompletoAnalisis
            // 
            this.txtNombreCompletoAnalisis.Location = new System.Drawing.Point(40, 78);
            this.txtNombreCompletoAnalisis.Name = "txtNombreCompletoAnalisis";
            this.txtNombreCompletoAnalisis.Size = new System.Drawing.Size(643, 30);
            this.txtNombreCompletoAnalisis.TabIndex = 5;
            this.txtNombreCompletoAnalisis.Text = "Mario Sebastian Espinosa Ramírez";
            // 
            // lblNombreCompletoAnalisi
            // 
            this.lblNombreCompletoAnalisi.AutoSize = true;
            this.lblNombreCompletoAnalisi.ForeColor = System.Drawing.Color.White;
            this.lblNombreCompletoAnalisi.Location = new System.Drawing.Point(36, 33);
            this.lblNombreCompletoAnalisi.Name = "lblNombreCompletoAnalisi";
            this.lblNombreCompletoAnalisi.Size = new System.Drawing.Size(171, 23);
            this.lblNombreCompletoAnalisi.TabIndex = 4;
            this.lblNombreCompletoAnalisi.Text = "Nombre del Paciente:";
            // 
            // btnActualizarAnalisis
            // 
            this.btnActualizarAnalisis.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarAnalisis.Location = new System.Drawing.Point(509, 229);
            this.btnActualizarAnalisis.Name = "btnActualizarAnalisis";
            this.btnActualizarAnalisis.Size = new System.Drawing.Size(174, 40);
            this.btnActualizarAnalisis.TabIndex = 3;
            this.btnActualizarAnalisis.Text = "Actualizar";
            this.btnActualizarAnalisis.UseVisualStyleBackColor = true;
            // 
            // cmbPruebas
            // 
            this.cmbPruebas.FormattingEnabled = true;
            this.cmbPruebas.Items.AddRange(new object[] {
            "Análisis de Sangre",
            "Química Sanguinea (24 elementos)",
            "Electrocardiograma",
            "Ultrasonido Abdominal",
            "Perfil lipídico: Colesterol, LDL; HDL; triglicérido",
            "Perfil hepático: Bilirrubina, total y directa, AST, LDH",
            "Perfil triode: TSH, T3, T4",
            "Panel básico metabólico: Electrolitos, glucosa, nitrógeno de urea,creatinina",
            "Resonancia Magnetica",
            "Tomografía"});
            this.cmbPruebas.Location = new System.Drawing.Point(40, 153);
            this.cmbPruebas.Name = "cmbPruebas";
            this.cmbPruebas.Size = new System.Drawing.Size(643, 31);
            this.cmbPruebas.TabIndex = 0;
            this.cmbPruebas.Text = "(Seleccione una de las pruebas para visualizar los resultados)";
            // 
            // tbpAgenda
            // 
            this.tbpAgenda.BackColor = System.Drawing.Color.SteelBlue;
            this.tbpAgenda.Controls.Add(this.btnActualizarAgenda);
            this.tbpAgenda.Controls.Add(this.grpOtrosProgramados);
            this.tbpAgenda.Controls.Add(this.txtNombreCompletoAgenda);
            this.tbpAgenda.Controls.Add(this.lblNombreCompletoAgend);
            this.tbpAgenda.Controls.Add(this.grpAnalisisConsultasProgramadas);
            this.tbpAgenda.Location = new System.Drawing.Point(4, 32);
            this.tbpAgenda.Name = "tbpAgenda";
            this.tbpAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAgenda.Size = new System.Drawing.Size(828, 563);
            this.tbpAgenda.TabIndex = 2;
            this.tbpAgenda.Text = "Mi Agenda";
            // 
            // btnActualizarAgenda
            // 
            this.btnActualizarAgenda.Location = new System.Drawing.Point(630, 500);
            this.btnActualizarAgenda.Name = "btnActualizarAgenda";
            this.btnActualizarAgenda.Size = new System.Drawing.Size(161, 31);
            this.btnActualizarAgenda.TabIndex = 8;
            this.btnActualizarAgenda.Text = "Actualizar";
            this.btnActualizarAgenda.UseVisualStyleBackColor = true;
            // 
            // grpOtrosProgramados
            // 
            this.grpOtrosProgramados.Controls.Add(this.dateTimePicker2);
            this.grpOtrosProgramados.ForeColor = System.Drawing.Color.White;
            this.grpOtrosProgramados.Location = new System.Drawing.Point(410, 139);
            this.grpOtrosProgramados.Name = "grpOtrosProgramados";
            this.grpOtrosProgramados.Size = new System.Drawing.Size(381, 272);
            this.grpOtrosProgramados.TabIndex = 2;
            this.grpOtrosProgramados.TabStop = false;
            this.grpOtrosProgramados.Text = "Otros Programados";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(16, 35);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(337, 30);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // txtNombreCompletoAgenda
            // 
            this.txtNombreCompletoAgenda.Location = new System.Drawing.Point(20, 77);
            this.txtNombreCompletoAgenda.Name = "txtNombreCompletoAgenda";
            this.txtNombreCompletoAgenda.Size = new System.Drawing.Size(771, 30);
            this.txtNombreCompletoAgenda.TabIndex = 7;
            this.txtNombreCompletoAgenda.Text = "Mario Sebastian Espinosa Ramírez";
            // 
            // lblNombreCompletoAgend
            // 
            this.lblNombreCompletoAgend.AutoSize = true;
            this.lblNombreCompletoAgend.ForeColor = System.Drawing.Color.White;
            this.lblNombreCompletoAgend.Location = new System.Drawing.Point(16, 32);
            this.lblNombreCompletoAgend.Name = "lblNombreCompletoAgend";
            this.lblNombreCompletoAgend.Size = new System.Drawing.Size(171, 23);
            this.lblNombreCompletoAgend.TabIndex = 6;
            this.lblNombreCompletoAgend.Text = "Nombre del Paciente:";
            // 
            // grpAnalisisConsultasProgramadas
            // 
            this.grpAnalisisConsultasProgramadas.Controls.Add(this.monthCalendar1);
            this.grpAnalisisConsultasProgramadas.ForeColor = System.Drawing.Color.White;
            this.grpAnalisisConsultasProgramadas.Location = new System.Drawing.Point(20, 139);
            this.grpAnalisisConsultasProgramadas.Name = "grpAnalisisConsultasProgramadas";
            this.grpAnalisisConsultasProgramadas.Size = new System.Drawing.Size(364, 272);
            this.grpAnalisisConsultasProgramadas.TabIndex = 0;
            this.grpAnalisisConsultasProgramadas.TabStop = false;
            this.grpAnalisisConsultasProgramadas.Text = "Análisis y Consultas Programadas";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 35);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(881, 573);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(881, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(174, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Volver al Menú";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbcExpediente);
            this.Name = "FrmExpediente";
            this.Text = "FrmExpediente";
            this.tbcExpediente.ResumeLayout(false);
            this.tbpPerfil.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.pnlDonante.ResumeLayout(false);
            this.pnlDonante.PerformLayout();
            this.pnlOrganos.ResumeLayout(false);
            this.pnlOrganos.PerformLayout();
            this.grpEstadoCivil.ResumeLayout(false);
            this.grpEstadoCivil.PerformLayout();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.tbpAnalisis.ResumeLayout(false);
            this.tbpAnalisis.PerformLayout();
            this.tbpAgenda.ResumeLayout(false);
            this.tbpAgenda.PerformLayout();
            this.grpOtrosProgramados.ResumeLayout(false);
            this.grpAnalisisConsultasProgramadas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcExpediente;
        private System.Windows.Forms.TabPage tbpPerfil;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Panel pnlDonante;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.Label lblDonante;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.Panel pnlOrganos;
        private System.Windows.Forms.CheckBox chcVenasHuesoCartilago;
        private System.Windows.Forms.CheckBox chcPiel;
        private System.Windows.Forms.CheckBox chcPancreas;
        private System.Windows.Forms.CheckBox chcCorneas;
        private System.Windows.Forms.CheckBox chcRiñones;
        private System.Windows.Forms.CheckBox chcHigado;
        private System.Windows.Forms.CheckBox chcCorazon;
        private System.Windows.Forms.CheckBox chcPulmones;
        private System.Windows.Forms.GroupBox grpEstadoCivil;
        private System.Windows.Forms.RadioButton rdbSoltero;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbDivorciado;
        private System.Windows.Forms.RadioButton rdbViudo;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblCuarto;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.PictureBox pctImagen;
        private System.Windows.Forms.TabPage tbpAnalisis;
        private System.Windows.Forms.TextBox txtNombreCompletoAnalisis;
        private System.Windows.Forms.Label lblNombreCompletoAnalisi;
        private System.Windows.Forms.Button btnActualizarAnalisis;
        private System.Windows.Forms.ComboBox cmbPruebas;
        private System.Windows.Forms.TabPage tbpAgenda;
        private System.Windows.Forms.Button btnActualizarAgenda;
        private System.Windows.Forms.GroupBox grpOtrosProgramados;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtNombreCompletoAgenda;
        private System.Windows.Forms.Label lblNombreCompletoAgend;
        private System.Windows.Forms.GroupBox grpAnalisisConsultasProgramadas;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}