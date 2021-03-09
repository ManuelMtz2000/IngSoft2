namespace interfazModernaONG
{
    partial class Form_Servicios_Servicios_Agregar
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
            this.panelTerapias = new System.Windows.Forms.Panel();
            this.labelTerapia = new System.Windows.Forms.Label();
            this.labelBene2 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.labelBene1 = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.panelConsultas = new System.Windows.Forms.Panel();
            this.labelConsultas = new System.Windows.Forms.Label();
            this.comboBoxConsultas = new TextBox3.ComboBoxRounded();
            this.comboBoxTerapias = new TextBox3.ComboBoxRounded();
            this.comboBoxTipo = new TextBox3.ComboBoxRounded();
            this.botonAgregar = new ePOSOne.btnProduct.Button_WOC();
            this.textBoxCargo = new TextBox3.TextBoxRounded();
            this.textBoxNombre = new TextBox3.TextBoxRounded();
            this.panelOtros = new System.Windows.Forms.Panel();
            this.labelEsp = new System.Windows.Forms.Label();
            this.textBoxEsquecifique = new TextBox3.TextBoxRounded();
            this.panelCentral.SuspendLayout();
            this.panelTerapias.SuspendLayout();
            this.panelConsultas.SuspendLayout();
            this.panelOtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(161, 399);
            this.panelIzquierdo.TabIndex = 4;
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCentral.Controls.Add(this.panelOtros);
            this.panelCentral.Controls.Add(this.panelConsultas);
            this.panelCentral.Controls.Add(this.panelTerapias);
            this.panelCentral.Controls.Add(this.labelBene2);
            this.panelCentral.Controls.Add(this.labelFecha);
            this.panelCentral.Controls.Add(this.comboBoxTipo);
            this.panelCentral.Controls.Add(this.dateTimeDesde);
            this.panelCentral.Controls.Add(this.botonAgregar);
            this.panelCentral.Controls.Add(this.textBoxCargo);
            this.panelCentral.Controls.Add(this.textBoxNombre);
            this.panelCentral.Controls.Add(this.labelObservaciones);
            this.panelCentral.Controls.Add(this.labelBene1);
            this.panelCentral.Controls.Add(this.labelTipo);
            this.panelCentral.Location = new System.Drawing.Point(161, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(676, 399);
            this.panelCentral.TabIndex = 5;
            // 
            // panelTerapias
            // 
            this.panelTerapias.Controls.Add(this.comboBoxTerapias);
            this.panelTerapias.Controls.Add(this.labelTerapia);
            this.panelTerapias.Location = new System.Drawing.Point(0, 121);
            this.panelTerapias.Name = "panelTerapias";
            this.panelTerapias.Size = new System.Drawing.Size(676, 48);
            this.panelTerapias.TabIndex = 26;
            // 
            // labelTerapia
            // 
            this.labelTerapia.AutoSize = true;
            this.labelTerapia.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerapia.Location = new System.Drawing.Point(20, 13);
            this.labelTerapia.Name = "labelTerapia";
            this.labelTerapia.Size = new System.Drawing.Size(134, 19);
            this.labelTerapia.TabIndex = 27;
            this.labelTerapia.Text = "Tipo de terapia:";
            // 
            // labelBene2
            // 
            this.labelBene2.AutoSize = true;
            this.labelBene2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBene2.Location = new System.Drawing.Point(43, 191);
            this.labelBene2.Name = "labelBene2";
            this.labelBene2.Size = new System.Drawing.Size(115, 19);
            this.labelBene2.TabIndex = 25;
            this.labelBene2.Text = "beneficiarios:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(97, 63);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(62, 19);
            this.labelFecha.TabIndex = 24;
            this.labelFecha.Text = "Fecha:";
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.CalendarFont = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDesde.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDesde.Location = new System.Drawing.Point(164, 61);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(248, 21);
            this.dateTimeDesde.TabIndex = 22;
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservaciones.Location = new System.Drawing.Point(27, 236);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(131, 19);
            this.labelObservaciones.TabIndex = 6;
            this.labelObservaciones.Text = "Observaciones:";
            // 
            // labelBene1
            // 
            this.labelBene1.AutoSize = true;
            this.labelBene1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBene1.Location = new System.Drawing.Point(59, 172);
            this.labelBene1.Name = "labelBene1";
            this.labelBene1.Size = new System.Drawing.Size(99, 19);
            this.labelBene1.TabIndex = 1;
            this.labelBene1.Text = "Número de";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(20, 95);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(138, 19);
            this.labelTipo.TabIndex = 0;
            this.labelTipo.Text = "Tipo de servicio:";
            // 
            // panelConsultas
            // 
            this.panelConsultas.Controls.Add(this.comboBoxConsultas);
            this.panelConsultas.Controls.Add(this.labelConsultas);
            this.panelConsultas.Location = new System.Drawing.Point(0, 121);
            this.panelConsultas.Name = "panelConsultas";
            this.panelConsultas.Size = new System.Drawing.Size(676, 48);
            this.panelConsultas.TabIndex = 28;
            // 
            // labelConsultas
            // 
            this.labelConsultas.AutoSize = true;
            this.labelConsultas.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultas.Location = new System.Drawing.Point(13, 13);
            this.labelConsultas.Name = "labelConsultas";
            this.labelConsultas.Size = new System.Drawing.Size(145, 19);
            this.labelConsultas.TabIndex = 27;
            this.labelConsultas.Text = "Tipo de consulta:";
            // 
            // comboBoxConsultas
            // 
            this.comboBoxConsultas.BorderColor = System.Drawing.Color.DarkOrange;
            this.comboBoxConsultas.colorBottom = System.Drawing.Color.White;
            this.comboBoxConsultas.colorTop = System.Drawing.Color.Silver;
            this.comboBoxConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConsultas.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxConsultas.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxConsultas.FormattingEnabled = true;
            this.comboBoxConsultas.Items.AddRange(new object[] {
            "Alopatía",
            "Homeopatía",
            "Medicina Alternativa",
            "Oftalmología",
            "Odontología"});
            this.comboBoxConsultas.Location = new System.Drawing.Point(164, 8);
            this.comboBoxConsultas.Name = "comboBoxConsultas";
            this.comboBoxConsultas.Size = new System.Drawing.Size(200, 24);
            this.comboBoxConsultas.TabIndex = 27;
            // 
            // comboBoxTerapias
            // 
            this.comboBoxTerapias.BorderColor = System.Drawing.Color.DarkOrange;
            this.comboBoxTerapias.colorBottom = System.Drawing.Color.White;
            this.comboBoxTerapias.colorTop = System.Drawing.Color.Silver;
            this.comboBoxTerapias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTerapias.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTerapias.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxTerapias.FormattingEnabled = true;
            this.comboBoxTerapias.Items.AddRange(new object[] {
            "Física",
            "Psicológica",
            "Lenguaje",
            "Individual",
            "Grupal",
            "Familiar",
            "Pareja"});
            this.comboBoxTerapias.Location = new System.Drawing.Point(164, 8);
            this.comboBoxTerapias.Name = "comboBoxTerapias";
            this.comboBoxTerapias.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTerapias.TabIndex = 27;
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
            this.comboBoxTipo.Location = new System.Drawing.Point(164, 88);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTipo.TabIndex = 23;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTipo_SelectedIndexChanged);
            // 
            // botonAgregar
            // 
            this.botonAgregar.BackColor = System.Drawing.Color.Transparent;
            this.botonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonAgregar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonAgregar.FlatAppearance.BorderSize = 0;
            this.botonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Location = new System.Drawing.Point(272, 302);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonAgregar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonAgregar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(131)))));
            this.botonAgregar.Size = new System.Drawing.Size(89, 33);
            this.botonAgregar.TabIndex = 14;
            this.botonAgregar.Text = "  Agregar";
            this.botonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAgregar.TextColor = System.Drawing.Color.White;
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.colorBottom = System.Drawing.Color.White;
            this.textBoxCargo.colorTop = System.Drawing.Color.Silver;
            this.textBoxCargo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCargo.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCargo.Location = new System.Drawing.Point(164, 236);
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
            this.textBoxNombre.Location = new System.Drawing.Point(164, 183);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 27);
            this.textBoxNombre.TabIndex = 7;
            // 
            // panelOtros
            // 
            this.panelOtros.Controls.Add(this.textBoxEsquecifique);
            this.panelOtros.Controls.Add(this.labelEsp);
            this.panelOtros.Location = new System.Drawing.Point(0, 120);
            this.panelOtros.Name = "panelOtros";
            this.panelOtros.Size = new System.Drawing.Size(676, 48);
            this.panelOtros.TabIndex = 29;
            // 
            // labelEsp
            // 
            this.labelEsp.AutoSize = true;
            this.labelEsp.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEsp.Location = new System.Drawing.Point(51, 13);
            this.labelEsp.Name = "labelEsp";
            this.labelEsp.Size = new System.Drawing.Size(107, 19);
            this.labelEsp.TabIndex = 27;
            this.labelEsp.Text = "Especifique:";
            // 
            // textBoxEsquecifique
            // 
            this.textBoxEsquecifique.colorBottom = System.Drawing.Color.White;
            this.textBoxEsquecifique.colorTop = System.Drawing.Color.Silver;
            this.textBoxEsquecifique.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEsquecifique.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxEsquecifique.Location = new System.Drawing.Point(164, 6);
            this.textBoxEsquecifique.Name = "textBoxEsquecifique";
            this.textBoxEsquecifique.Size = new System.Drawing.Size(396, 27);
            this.textBoxEsquecifique.TabIndex = 30;
            // 
            // Form_Servicios_Servicios_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Servicios_Servicios_Agregar";
            this.Text = "Form_Servicios_Servicios_Agregar";
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.panelTerapias.ResumeLayout(false);
            this.panelTerapias.PerformLayout();
            this.panelConsultas.ResumeLayout(false);
            this.panelConsultas.PerformLayout();
            this.panelOtros.ResumeLayout(false);
            this.panelOtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelCentral;
        private ePOSOne.btnProduct.Button_WOC botonAgregar;
        private TextBox3.TextBoxRounded textBoxCargo;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.Label labelBene1;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private TextBox3.TextBoxRounded textBoxNombre;
        private TextBox3.ComboBoxRounded comboBoxTipo;
        private System.Windows.Forms.Label labelBene2;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Panel panelTerapias;
        private TextBox3.ComboBoxRounded comboBoxTerapias;
        private System.Windows.Forms.Label labelTerapia;
        private System.Windows.Forms.Panel panelConsultas;
        private TextBox3.ComboBoxRounded comboBoxConsultas;
        private System.Windows.Forms.Label labelConsultas;
        private System.Windows.Forms.Panel panelOtros;
        private System.Windows.Forms.Label labelEsp;
        private TextBox3.TextBoxRounded textBoxEsquecifique;
    }
}