namespace interfazModernaONG
{
    partial class Form_Organigrama_Personal_Alta
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
            this.panelUniversidad = new System.Windows.Forms.Panel();
            this.labelUniversidadNombre = new System.Windows.Forms.Label();
            this.labelcarrera = new System.Windows.Forms.Label();
            this.labelNumAlumnos = new System.Windows.Forms.Label();
            this.textBoxNomUniversidad = new TextBox3.TextBoxRounded();
            this.textBoxCarrera = new TextBox3.TextBoxRounded();
            this.textBoxAlumnosSer = new TextBox3.TextBoxRounded();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.textBoxAM = new TextBox3.TextBoxRounded();
            this.textBoxAP = new TextBox3.TextBoxRounded();
            this.labelAP = new System.Windows.Forms.Label();
            this.labelAM = new System.Windows.Forms.Label();
            this.comboBoxServicio = new TextBox3.ComboBoxRounded();
            this.comboBoxVoluntario = new TextBox3.ComboBoxRounded();
            this.comboBoxEventual = new TextBox3.ComboBoxRounded();
            this.comboBoxBase = new TextBox3.ComboBoxRounded();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxNombre = new TextBox3.TextBoxRounded();
            this.textBoxCargo = new TextBox3.TextBoxRounded();
            this.checkBoxUniversidad = new System.Windows.Forms.CheckBox();
            this.botonAgregar = new ePOSOne.btnProduct.Button_WOC();
            this.panelCentral.SuspendLayout();
            this.panelUniversidad.SuspendLayout();
            this.panelPersonal.SuspendLayout();
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
            this.panelCentral.Controls.Add(this.panelPersonal);
            this.panelCentral.Controls.Add(this.panelUniversidad);
            this.panelCentral.Controls.Add(this.checkBoxUniversidad);
            this.panelCentral.Controls.Add(this.botonAgregar);
            this.panelCentral.Location = new System.Drawing.Point(161, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(676, 399);
            this.panelCentral.TabIndex = 5;
            // 
            // panelUniversidad
            // 
            this.panelUniversidad.Controls.Add(this.labelUniversidadNombre);
            this.panelUniversidad.Controls.Add(this.labelcarrera);
            this.panelUniversidad.Controls.Add(this.labelNumAlumnos);
            this.panelUniversidad.Controls.Add(this.textBoxNomUniversidad);
            this.panelUniversidad.Controls.Add(this.textBoxCarrera);
            this.panelUniversidad.Controls.Add(this.textBoxAlumnosSer);
            this.panelUniversidad.Location = new System.Drawing.Point(0, 100);
            this.panelUniversidad.Name = "panelUniversidad";
            this.panelUniversidad.Size = new System.Drawing.Size(673, 154);
            this.panelUniversidad.TabIndex = 28;
            // 
            // labelUniversidadNombre
            // 
            this.labelUniversidadNombre.AutoSize = true;
            this.labelUniversidadNombre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUniversidadNombre.Location = new System.Drawing.Point(38, 29);
            this.labelUniversidadNombre.Name = "labelUniversidadNombre";
            this.labelUniversidadNombre.Size = new System.Drawing.Size(203, 19);
            this.labelUniversidadNombre.TabIndex = 0;
            this.labelUniversidadNombre.Text = "Nombre de Universidad:";
            // 
            // labelcarrera
            // 
            this.labelcarrera.AutoSize = true;
            this.labelcarrera.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcarrera.Location = new System.Drawing.Point(73, 59);
            this.labelcarrera.Name = "labelcarrera";
            this.labelcarrera.Size = new System.Drawing.Size(168, 19);
            this.labelcarrera.TabIndex = 1;
            this.labelcarrera.Text = "Carrera de alumnos:";
            // 
            // labelNumAlumnos
            // 
            this.labelNumAlumnos.AutoSize = true;
            this.labelNumAlumnos.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumAlumnos.Location = new System.Drawing.Point(69, 92);
            this.labelNumAlumnos.Name = "labelNumAlumnos";
            this.labelNumAlumnos.Size = new System.Drawing.Size(172, 19);
            this.labelNumAlumnos.TabIndex = 6;
            this.labelNumAlumnos.Text = "Alumnos en servicio:";
            // 
            // textBoxNomUniversidad
            // 
            this.textBoxNomUniversidad.colorBottom = System.Drawing.Color.White;
            this.textBoxNomUniversidad.colorTop = System.Drawing.Color.Silver;
            this.textBoxNomUniversidad.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomUniversidad.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNomUniversidad.Location = new System.Drawing.Point(247, 21);
            this.textBoxNomUniversidad.Name = "textBoxNomUniversidad";
            this.textBoxNomUniversidad.Size = new System.Drawing.Size(272, 27);
            this.textBoxNomUniversidad.TabIndex = 7;
            // 
            // textBoxCarrera
            // 
            this.textBoxCarrera.colorBottom = System.Drawing.Color.White;
            this.textBoxCarrera.colorTop = System.Drawing.Color.Silver;
            this.textBoxCarrera.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarrera.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCarrera.Location = new System.Drawing.Point(247, 51);
            this.textBoxCarrera.Name = "textBoxCarrera";
            this.textBoxCarrera.Size = new System.Drawing.Size(272, 27);
            this.textBoxCarrera.TabIndex = 8;
            // 
            // textBoxAlumnosSer
            // 
            this.textBoxAlumnosSer.colorBottom = System.Drawing.Color.White;
            this.textBoxAlumnosSer.colorTop = System.Drawing.Color.Silver;
            this.textBoxAlumnosSer.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlumnosSer.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAlumnosSer.Location = new System.Drawing.Point(247, 84);
            this.textBoxAlumnosSer.Name = "textBoxAlumnosSer";
            this.textBoxAlumnosSer.Size = new System.Drawing.Size(272, 27);
            this.textBoxAlumnosSer.TabIndex = 9;
            // 
            // panelPersonal
            // 
            this.panelPersonal.Controls.Add(this.textBoxAM);
            this.panelPersonal.Controls.Add(this.textBoxAP);
            this.panelPersonal.Controls.Add(this.labelAP);
            this.panelPersonal.Controls.Add(this.labelAM);
            this.panelPersonal.Controls.Add(this.comboBoxServicio);
            this.panelPersonal.Controls.Add(this.comboBoxVoluntario);
            this.panelPersonal.Controls.Add(this.comboBoxEventual);
            this.panelPersonal.Controls.Add(this.comboBoxBase);
            this.panelPersonal.Controls.Add(this.label2);
            this.panelPersonal.Controls.Add(this.label1);
            this.panelPersonal.Controls.Add(this.labelNombre);
            this.panelPersonal.Controls.Add(this.labelCargo);
            this.panelPersonal.Controls.Add(this.labelEmail);
            this.panelPersonal.Controls.Add(this.labelTel);
            this.panelPersonal.Controls.Add(this.textBoxNombre);
            this.panelPersonal.Controls.Add(this.textBoxCargo);
            this.panelPersonal.Location = new System.Drawing.Point(0, 59);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(673, 237);
            this.panelPersonal.TabIndex = 16;
            // 
            // textBoxAM
            // 
            this.textBoxAM.colorBottom = System.Drawing.Color.White;
            this.textBoxAM.colorTop = System.Drawing.Color.Silver;
            this.textBoxAM.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAM.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAM.Location = new System.Drawing.Point(168, 58);
            this.textBoxAM.Name = "textBoxAM";
            this.textBoxAM.Size = new System.Drawing.Size(367, 27);
            this.textBoxAM.TabIndex = 31;
            // 
            // textBoxAP
            // 
            this.textBoxAP.colorBottom = System.Drawing.Color.White;
            this.textBoxAP.colorTop = System.Drawing.Color.Silver;
            this.textBoxAP.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAP.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAP.Location = new System.Drawing.Point(168, 30);
            this.textBoxAP.Name = "textBoxAP";
            this.textBoxAP.Size = new System.Drawing.Size(367, 27);
            this.textBoxAP.TabIndex = 30;
            // 
            // labelAP
            // 
            this.labelAP.AutoSize = true;
            this.labelAP.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAP.Location = new System.Drawing.Point(6, 38);
            this.labelAP.Name = "labelAP";
            this.labelAP.Size = new System.Drawing.Size(147, 19);
            this.labelAP.TabIndex = 29;
            this.labelAP.Text = "Apellido paterno:";
            // 
            // labelAM
            // 
            this.labelAM.AutoSize = true;
            this.labelAM.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAM.Location = new System.Drawing.Point(1, 66);
            this.labelAM.Name = "labelAM";
            this.labelAM.Size = new System.Drawing.Size(152, 19);
            this.labelAM.TabIndex = 28;
            this.labelAM.Text = "Apellido materno:";
            // 
            // comboBoxServicio
            // 
            this.comboBoxServicio.BorderColor = System.Drawing.Color.DarkOrange;
            this.comboBoxServicio.colorBottom = System.Drawing.Color.White;
            this.comboBoxServicio.colorTop = System.Drawing.Color.Silver;
            this.comboBoxServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServicio.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServicio.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxServicio.FormattingEnabled = true;
            this.comboBoxServicio.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboBoxServicio.Location = new System.Drawing.Point(168, 204);
            this.comboBoxServicio.Name = "comboBoxServicio";
            this.comboBoxServicio.Size = new System.Drawing.Size(125, 24);
            this.comboBoxServicio.TabIndex = 27;
            // 
            // comboBoxVoluntario
            // 
            this.comboBoxVoluntario.BorderColor = System.Drawing.Color.DarkOrange;
            this.comboBoxVoluntario.colorBottom = System.Drawing.Color.White;
            this.comboBoxVoluntario.colorTop = System.Drawing.Color.Silver;
            this.comboBoxVoluntario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoluntario.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVoluntario.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxVoluntario.FormattingEnabled = true;
            this.comboBoxVoluntario.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboBoxVoluntario.Location = new System.Drawing.Point(168, 175);
            this.comboBoxVoluntario.Name = "comboBoxVoluntario";
            this.comboBoxVoluntario.Size = new System.Drawing.Size(125, 24);
            this.comboBoxVoluntario.TabIndex = 26;
            // 
            // comboBoxEventual
            // 
            this.comboBoxEventual.BorderColor = System.Drawing.Color.DarkOrange;
            this.comboBoxEventual.colorBottom = System.Drawing.Color.White;
            this.comboBoxEventual.colorTop = System.Drawing.Color.Silver;
            this.comboBoxEventual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEventual.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEventual.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxEventual.FormattingEnabled = true;
            this.comboBoxEventual.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboBoxEventual.Location = new System.Drawing.Point(168, 146);
            this.comboBoxEventual.Name = "comboBoxEventual";
            this.comboBoxEventual.Size = new System.Drawing.Size(125, 24);
            this.comboBoxEventual.TabIndex = 25;
            // 
            // comboBoxBase
            // 
            this.comboBoxBase.BorderColor = System.Drawing.Color.DarkOrange;
            this.comboBoxBase.colorBottom = System.Drawing.Color.White;
            this.comboBoxBase.colorTop = System.Drawing.Color.Silver;
            this.comboBoxBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBase.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxBase.FormattingEnabled = true;
            this.comboBoxBase.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboBoxBase.Location = new System.Drawing.Point(168, 116);
            this.comboBoxBase.Name = "comboBoxBase";
            this.comboBoxBase.Size = new System.Drawing.Size(125, 24);
            this.comboBoxBase.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Voluntario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Servicio Social:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(73, 11);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(80, 19);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.Location = new System.Drawing.Point(92, 94);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(61, 19);
            this.labelCargo.TabIndex = 1;
            this.labelCargo.Text = "Cargo:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(70, 151);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(83, 19);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Eventual:";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(101, 123);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(52, 19);
            this.labelTel.TabIndex = 6;
            this.labelTel.Text = "Base:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.colorBottom = System.Drawing.Color.White;
            this.textBoxNombre.colorTop = System.Drawing.Color.Silver;
            this.textBoxNombre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNombre.Location = new System.Drawing.Point(168, 3);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(367, 27);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.colorBottom = System.Drawing.Color.White;
            this.textBoxCargo.colorTop = System.Drawing.Color.Silver;
            this.textBoxCargo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCargo.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCargo.Location = new System.Drawing.Point(168, 86);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(367, 27);
            this.textBoxCargo.TabIndex = 8;
            // 
            // checkBoxUniversidad
            // 
            this.checkBoxUniversidad.AutoSize = true;
            this.checkBoxUniversidad.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUniversidad.Location = new System.Drawing.Point(56, 30);
            this.checkBoxUniversidad.Name = "checkBoxUniversidad";
            this.checkBoxUniversidad.Size = new System.Drawing.Size(258, 23);
            this.checkBoxUniversidad.TabIndex = 15;
            this.checkBoxUniversidad.Text = "Universidad en servicio social";
            this.checkBoxUniversidad.UseVisualStyleBackColor = true;
            this.checkBoxUniversidad.CheckedChanged += new System.EventHandler(this.CheckBoxUniversidad_CheckedChanged);
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
            this.botonAgregar.Text = "Dar de alta";
            this.botonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAgregar.TextColor = System.Drawing.Color.White;
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // Form_Organigrama_Personal_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Organigrama_Personal_Alta";
            this.Text = "Form_Organigrama_Personal_Alta";
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.panelUniversidad.ResumeLayout(false);
            this.panelUniversidad.PerformLayout();
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelCentral;
        private ePOSOne.btnProduct.Button_WOC botonAgregar;
        private TextBox3.TextBoxRounded textBoxCargo;
        private TextBox3.TextBoxRounded textBoxNombre;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxUniversidad;
        private TextBox3.ComboBoxRounded comboBoxServicio;
        private TextBox3.ComboBoxRounded comboBoxVoluntario;
        private TextBox3.ComboBoxRounded comboBoxEventual;
        private TextBox3.ComboBoxRounded comboBoxBase;
        private System.Windows.Forms.Panel panelUniversidad;
        private System.Windows.Forms.Label labelUniversidadNombre;
        private System.Windows.Forms.Label labelcarrera;
        private System.Windows.Forms.Label labelNumAlumnos;
        private TextBox3.TextBoxRounded textBoxNomUniversidad;
        private TextBox3.TextBoxRounded textBoxCarrera;
        private TextBox3.TextBoxRounded textBoxAlumnosSer;
        private TextBox3.TextBoxRounded textBoxAM;
        private TextBox3.TextBoxRounded textBoxAP;
        private System.Windows.Forms.Label labelAP;
        private System.Windows.Forms.Label labelAM;
    }
}