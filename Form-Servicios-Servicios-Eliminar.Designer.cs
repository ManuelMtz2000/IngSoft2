namespace interfazModernaONG
{
    partial class Form_Servicios_Servicios_Eliminar
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
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.labelBene2 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.comboBoxTipo = new TextBox3.ComboBoxRounded();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.botonEliminar = new ePOSOne.btnProduct.Button_WOC();
            this.textBoxCargo = new TextBox3.TextBoxRounded();
            this.textBoxNombre = new TextBox3.TextBoxRounded();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.labelBene1 = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelFolio = new System.Windows.Forms.Label();
            this.textBoxFolio = new TextBox3.TextBoxRounded();
            this.botonBuscar = new ePOSOne.btnProduct.Button_WOC();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(161, 399);
            this.panelIzquierdo.TabIndex = 6;
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCentral.Controls.Add(this.botonBuscar);
            this.panelCentral.Controls.Add(this.textBoxFolio);
            this.panelCentral.Controls.Add(this.labelFolio);
            this.panelCentral.Controls.Add(this.labelBene2);
            this.panelCentral.Controls.Add(this.labelFecha);
            this.panelCentral.Controls.Add(this.comboBoxTipo);
            this.panelCentral.Controls.Add(this.dateTimeDesde);
            this.panelCentral.Controls.Add(this.botonEliminar);
            this.panelCentral.Controls.Add(this.textBoxCargo);
            this.panelCentral.Controls.Add(this.textBoxNombre);
            this.panelCentral.Controls.Add(this.labelObservaciones);
            this.panelCentral.Controls.Add(this.labelBene1);
            this.panelCentral.Controls.Add(this.labelTipo);
            this.panelCentral.Location = new System.Drawing.Point(161, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(676, 399);
            this.panelCentral.TabIndex = 7;
            // 
            // labelBene2
            // 
            this.labelBene2.AutoSize = true;
            this.labelBene2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBene2.Location = new System.Drawing.Point(40, 243);
            this.labelBene2.Name = "labelBene2";
            this.labelBene2.Size = new System.Drawing.Size(115, 19);
            this.labelBene2.TabIndex = 25;
            this.labelBene2.Text = "beneficiarios:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(94, 115);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(62, 19);
            this.labelFecha.TabIndex = 24;
            this.labelFecha.Text = "Fecha:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.BorderColor = System.Drawing.Color.DarkOrange;
            this.comboBoxTipo.colorBottom = System.Drawing.Color.White;
            this.comboBoxTipo.colorTop = System.Drawing.Color.Silver;
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Casa Hogar",
            "Guarderia",
            "Educación Preescolar",
            "Educación Básica",
            "Educación Especial",
            "Cursos",
            "Talleres",
            "Conferencias",
            "Servicios de Comedor",
            "Apoyos en Especie",
            "Apoyos Económicos",
            "Apoyo Legal",
            "Asesoría",
            "Orientación",
            "Servicios Funerarios",
            "Servicios Paramédicos",
            "Emergencias médicas",
            "Consulta Externa",
            "Hospitalización",
            "Cirugía Menor",
            "Cirugía Mayor",
            "Estudios Médicos Especializados",
            "Análisis Clínicos",
            "Terapias",
            "Otros"});
            this.comboBoxTipo.Location = new System.Drawing.Point(161, 140);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTipo.TabIndex = 23;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.CalendarFont = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDesde.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDesde.Location = new System.Drawing.Point(161, 113);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(248, 21);
            this.dateTimeDesde.TabIndex = 22;
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.botonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonEliminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonEliminar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonEliminar.FlatAppearance.BorderSize = 0;
            this.botonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEliminar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.Location = new System.Drawing.Point(269, 354);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonEliminar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonEliminar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(131)))));
            this.botonEliminar.Size = new System.Drawing.Size(89, 33);
            this.botonEliminar.TabIndex = 14;
            this.botonEliminar.Text = "  Eliminar";
            this.botonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonEliminar.TextColor = System.Drawing.Color.White;
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.colorBottom = System.Drawing.Color.White;
            this.textBoxCargo.colorTop = System.Drawing.Color.Silver;
            this.textBoxCargo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCargo.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCargo.Location = new System.Drawing.Point(161, 288);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(396, 27);
            this.textBoxCargo.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.colorBottom = System.Drawing.Color.White;
            this.textBoxNombre.colorTop = System.Drawing.Color.Silver;
            this.textBoxNombre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNombre.Location = new System.Drawing.Point(161, 235);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 27);
            this.textBoxNombre.TabIndex = 7;
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservaciones.Location = new System.Drawing.Point(24, 288);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(131, 19);
            this.labelObservaciones.TabIndex = 6;
            this.labelObservaciones.Text = "Observaciones:";
            // 
            // labelBene1
            // 
            this.labelBene1.AutoSize = true;
            this.labelBene1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBene1.Location = new System.Drawing.Point(56, 224);
            this.labelBene1.Name = "labelBene1";
            this.labelBene1.Size = new System.Drawing.Size(99, 19);
            this.labelBene1.TabIndex = 1;
            this.labelBene1.Text = "Número de";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(17, 147);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(138, 19);
            this.labelTipo.TabIndex = 0;
            this.labelTipo.Text = "Tipo de servicio:";
            // 
            // labelFolio
            // 
            this.labelFolio.AutoSize = true;
            this.labelFolio.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolio.Location = new System.Drawing.Point(12, 32);
            this.labelFolio.Name = "labelFolio";
            this.labelFolio.Size = new System.Drawing.Size(143, 19);
            this.labelFolio.TabIndex = 26;
            this.labelFolio.Text = "Folio de Servicio:";
            // 
            // textBoxFolio
            // 
            this.textBoxFolio.colorBottom = System.Drawing.Color.White;
            this.textBoxFolio.colorTop = System.Drawing.Color.Silver;
            this.textBoxFolio.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFolio.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxFolio.Location = new System.Drawing.Point(161, 24);
            this.textBoxFolio.Name = "textBoxFolio";
            this.textBoxFolio.Size = new System.Drawing.Size(248, 27);
            this.textBoxFolio.TabIndex = 27;
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackColor = System.Drawing.Color.Transparent;
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonBuscar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonBuscar.FlatAppearance.BorderSize = 0;
            this.botonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBuscar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Location = new System.Drawing.Point(468, 18);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonBuscar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonBuscar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(131)))));
            this.botonBuscar.Size = new System.Drawing.Size(89, 33);
            this.botonBuscar.TabIndex = 28;
            this.botonBuscar.Text = "   Buscar";
            this.botonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonBuscar.TextColor = System.Drawing.Color.White;
            this.botonBuscar.UseVisualStyleBackColor = false;
            this.botonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // Form_Servicios_Servicios_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Servicios_Servicios_Eliminar";
            this.Text = "Form_Servicios_Servicios_Eliminar";
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelCentral;
        private ePOSOne.btnProduct.Button_WOC botonBuscar;
        private TextBox3.TextBoxRounded textBoxFolio;
        private System.Windows.Forms.Label labelFolio;
        private System.Windows.Forms.Label labelBene2;
        private System.Windows.Forms.Label labelFecha;
        private TextBox3.ComboBoxRounded comboBoxTipo;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private ePOSOne.btnProduct.Button_WOC botonEliminar;
        private TextBox3.TextBoxRounded textBoxCargo;
        private TextBox3.TextBoxRounded textBoxNombre;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.Label labelBene1;
        private System.Windows.Forms.Label labelTipo;
    }
}