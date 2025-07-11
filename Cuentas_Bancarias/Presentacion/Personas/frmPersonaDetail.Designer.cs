namespace Cuentas_Bancarias.Presentacion.Personas
{
    partial class frmPersonaDetail
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
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label calificacion_crediticiaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label fecha_nacimientoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label movilLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label calle_principalLabel;
            System.Windows.Forms.Label calle_secundariaLabel;
            System.Windows.Forms.Label codigo_postalLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label referenciaLabel;
            this.grpPersonas = new System.Windows.Forms.GroupBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.calificacion_crediticiaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.movilTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.calle_principalTextBox = new System.Windows.Forms.TextBox();
            this.calle_secundariaTextBox = new System.Windows.Forms.TextBox();
            this.codigo_postalTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.referenciaTextBox = new System.Windows.Forms.TextBox();
            this.grpDireccion = new System.Windows.Forms.GroupBox();
            apellidoLabel = new System.Windows.Forms.Label();
            calificacion_crediticiaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            fecha_nacimientoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            movilLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            calle_principalLabel = new System.Windows.Forms.Label();
            calle_secundariaLabel = new System.Windows.Forms.Label();
            codigo_postalLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            this.grpPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.grpDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonas
            // 
            this.grpPersonas.Controls.Add(this.grpDireccion);
            this.grpPersonas.Controls.Add(apellidoLabel);
            this.grpPersonas.Controls.Add(this.apellidoTextBox);
            this.grpPersonas.Controls.Add(calificacion_crediticiaLabel);
            this.grpPersonas.Controls.Add(this.calificacion_crediticiaTextBox);
            this.grpPersonas.Controls.Add(emailLabel);
            this.grpPersonas.Controls.Add(this.emailTextBox);
            this.grpPersonas.Controls.Add(fecha_nacimientoLabel);
            this.grpPersonas.Controls.Add(this.fecha_nacimientoDateTimePicker);
            this.grpPersonas.Controls.Add(idLabel);
            this.grpPersonas.Controls.Add(this.idTextBox);
            this.grpPersonas.Controls.Add(movilLabel);
            this.grpPersonas.Controls.Add(this.movilTextBox);
            this.grpPersonas.Controls.Add(nombreLabel);
            this.grpPersonas.Controls.Add(this.nombreTextBox);
            this.grpPersonas.Controls.Add(telefonoLabel);
            this.grpPersonas.Controls.Add(this.telefonoTextBox);
            this.grpPersonas.Location = new System.Drawing.Point(12, 12);
            this.grpPersonas.Name = "grpPersonas";
            this.grpPersonas.Size = new System.Drawing.Size(446, 425);
            this.grpPersonas.TabIndex = 0;
            this.grpPersonas.TabStop = false;
            this.grpPersonas.Text = "Detalle de Personas";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.Location = new System.Drawing.Point(291, 443);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 1;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(372, 443);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Cuentas_Bancarias.Dominio.Personas.Persona);
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(64, 51);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 0;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(178, 48);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(245, 20);
            this.apellidoTextBox.TabIndex = 1;
            // 
            // calificacion_crediticiaLabel
            // 
            calificacion_crediticiaLabel.AutoSize = true;
            calificacion_crediticiaLabel.Location = new System.Drawing.Point(64, 212);
            calificacion_crediticiaLabel.Name = "calificacion_crediticiaLabel";
            calificacion_crediticiaLabel.Size = new System.Drawing.Size(108, 13);
            calificacion_crediticiaLabel.TabIndex = 2;
            calificacion_crediticiaLabel.Text = "calificacion crediticia:";
            // 
            // calificacion_crediticiaTextBox
            // 
            this.calificacion_crediticiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "calificacion_crediticia", true));
            this.calificacion_crediticiaTextBox.Location = new System.Drawing.Point(178, 209);
            this.calificacion_crediticiaTextBox.Name = "calificacion_crediticiaTextBox";
            this.calificacion_crediticiaTextBox.Size = new System.Drawing.Size(245, 20);
            this.calificacion_crediticiaTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(64, 103);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(178, 100);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(245, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // fecha_nacimientoLabel
            // 
            fecha_nacimientoLabel.AutoSize = true;
            fecha_nacimientoLabel.Location = new System.Drawing.Point(64, 130);
            fecha_nacimientoLabel.Name = "fecha_nacimientoLabel";
            fecha_nacimientoLabel.Size = new System.Drawing.Size(91, 13);
            fecha_nacimientoLabel.TabIndex = 6;
            fecha_nacimientoLabel.Text = "fecha nacimiento:";
            // 
            // fecha_nacimientoDateTimePicker
            // 
            this.fecha_nacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personaBindingSource, "fecha_nacimiento", true));
            this.fecha_nacimientoDateTimePicker.Location = new System.Drawing.Point(178, 126);
            this.fecha_nacimientoDateTimePicker.Name = "fecha_nacimientoDateTimePicker";
            this.fecha_nacimientoDateTimePicker.Size = new System.Drawing.Size(245, 20);
            this.fecha_nacimientoDateTimePicker.TabIndex = 7;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(64, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 8;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(178, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(245, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // movilLabel
            // 
            movilLabel.AutoSize = true;
            movilLabel.Location = new System.Drawing.Point(64, 156);
            movilLabel.Name = "movilLabel";
            movilLabel.Size = new System.Drawing.Size(35, 13);
            movilLabel.TabIndex = 10;
            movilLabel.Text = "Movil:";
            // 
            // movilTextBox
            // 
            this.movilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Movil", true));
            this.movilTextBox.Location = new System.Drawing.Point(178, 153);
            this.movilTextBox.Name = "movilTextBox";
            this.movilTextBox.Size = new System.Drawing.Size(245, 20);
            this.movilTextBox.TabIndex = 11;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(64, 77);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(178, 74);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(245, 20);
            this.nombreTextBox.TabIndex = 13;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(64, 184);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(178, 181);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(245, 20);
            this.telefonoTextBox.TabIndex = 15;
            // 
            // calle_principalLabel
            // 
            calle_principalLabel.AutoSize = true;
            calle_principalLabel.Location = new System.Drawing.Point(19, 52);
            calle_principalLabel.Name = "calle_principalLabel";
            calle_principalLabel.Size = new System.Drawing.Size(74, 13);
            calle_principalLabel.TabIndex = 16;
            calle_principalLabel.Text = "calle principal:";
            // 
            // calle_principalTextBox
            // 
            this.calle_principalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Direccion.calle_principal", true));
            this.calle_principalTextBox.Location = new System.Drawing.Point(112, 49);
            this.calle_principalTextBox.Name = "calle_principalTextBox";
            this.calle_principalTextBox.Size = new System.Drawing.Size(293, 20);
            this.calle_principalTextBox.TabIndex = 17;
            // 
            // calle_secundariaLabel
            // 
            calle_secundariaLabel.AutoSize = true;
            calle_secundariaLabel.Location = new System.Drawing.Point(19, 78);
            calle_secundariaLabel.Name = "calle_secundariaLabel";
            calle_secundariaLabel.Size = new System.Drawing.Size(87, 13);
            calle_secundariaLabel.TabIndex = 18;
            calle_secundariaLabel.Text = "calle secundaria:";
            // 
            // calle_secundariaTextBox
            // 
            this.calle_secundariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Direccion.calle_secundaria", true));
            this.calle_secundariaTextBox.Location = new System.Drawing.Point(112, 75);
            this.calle_secundariaTextBox.Name = "calle_secundariaTextBox";
            this.calle_secundariaTextBox.Size = new System.Drawing.Size(293, 20);
            this.calle_secundariaTextBox.TabIndex = 19;
            // 
            // codigo_postalLabel
            // 
            codigo_postalLabel.AutoSize = true;
            codigo_postalLabel.Location = new System.Drawing.Point(19, 130);
            codigo_postalLabel.Name = "codigo_postalLabel";
            codigo_postalLabel.Size = new System.Drawing.Size(73, 13);
            codigo_postalLabel.TabIndex = 20;
            codigo_postalLabel.Text = "codigo postal:";
            // 
            // codigo_postalTextBox
            // 
            this.codigo_postalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Direccion.codigo_postal", true));
            this.codigo_postalTextBox.Location = new System.Drawing.Point(112, 127);
            this.codigo_postalTextBox.Name = "codigo_postalTextBox";
            this.codigo_postalTextBox.Size = new System.Drawing.Size(293, 20);
            this.codigo_postalTextBox.TabIndex = 21;
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(19, 26);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(18, 13);
            idLabel1.TabIndex = 22;
            idLabel1.Text = "id:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Direccion.id", true));
            this.idTextBox1.Enabled = false;
            this.idTextBox1.Location = new System.Drawing.Point(112, 23);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.ReadOnly = true;
            this.idTextBox1.Size = new System.Drawing.Size(293, 20);
            this.idTextBox1.TabIndex = 23;
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Location = new System.Drawing.Point(19, 104);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(57, 13);
            referenciaLabel.TabIndex = 24;
            referenciaLabel.Text = "referencia:";
            // 
            // referenciaTextBox
            // 
            this.referenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Direccion.referencia", true));
            this.referenciaTextBox.Location = new System.Drawing.Point(112, 101);
            this.referenciaTextBox.Name = "referenciaTextBox";
            this.referenciaTextBox.Size = new System.Drawing.Size(293, 20);
            this.referenciaTextBox.TabIndex = 25;
            // 
            // grpDireccion
            // 
            this.grpDireccion.Controls.Add(this.idTextBox1);
            this.grpDireccion.Controls.Add(codigo_postalLabel);
            this.grpDireccion.Controls.Add(calle_secundariaLabel);
            this.grpDireccion.Controls.Add(this.codigo_postalTextBox);
            this.grpDireccion.Controls.Add(calle_principalLabel);
            this.grpDireccion.Controls.Add(referenciaLabel);
            this.grpDireccion.Controls.Add(this.calle_secundariaTextBox);
            this.grpDireccion.Controls.Add(this.referenciaTextBox);
            this.grpDireccion.Controls.Add(idLabel1);
            this.grpDireccion.Controls.Add(this.calle_principalTextBox);
            this.grpDireccion.Location = new System.Drawing.Point(18, 244);
            this.grpDireccion.Name = "grpDireccion";
            this.grpDireccion.Size = new System.Drawing.Size(413, 168);
            this.grpDireccion.TabIndex = 26;
            this.grpDireccion.TabStop = false;
            this.grpDireccion.Text = "Dirección";
            // 
            // frmPersonaDetail
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(470, 479);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.grpPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPersonaDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de Personas";
            this.grpPersonas.ResumeLayout(false);
            this.grpPersonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.grpDireccion.ResumeLayout(false);
            this.grpDireccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonas;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grpDireccion;
        private System.Windows.Forms.TextBox calle_principalTextBox;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.TextBox calle_secundariaTextBox;
        private System.Windows.Forms.TextBox codigo_postalTextBox;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox referenciaTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox calificacion_crediticiaTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker fecha_nacimientoDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox movilTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
    }
}