namespace interfazModernaONG
{
    partial class Form_Finanzas_Egresos_Agregar
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
            this.comboBoxTipo = new TextBox3.ComboBoxRounded();
            this.dateTimeEgreso = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.botonAgregar = new ePOSOne.btnProduct.Button_WOC();
            this.textBoxObservaciones = new TextBox3.TextBoxRounded();
            this.textBoxCantidad = new TextBox3.TextBoxRounded();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelTipoEgreso = new System.Windows.Forms.Label();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(161, 399);
            this.panelIzquierdo.TabIndex = 10;
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCentral.Controls.Add(this.comboBoxTipo);
            this.panelCentral.Controls.Add(this.dateTimeEgreso);
            this.panelCentral.Controls.Add(this.labelFecha);
            this.panelCentral.Controls.Add(this.botonAgregar);
            this.panelCentral.Controls.Add(this.textBoxObservaciones);
            this.panelCentral.Controls.Add(this.textBoxCantidad);
            this.panelCentral.Controls.Add(this.labelObservaciones);
            this.panelCentral.Controls.Add(this.labelCantidad);
            this.panelCentral.Controls.Add(this.labelTipoEgreso);
            this.panelCentral.Location = new System.Drawing.Point(161, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(676, 399);
            this.panelCentral.TabIndex = 11;
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
            "Apoyos económicos",
            "Medicinas y prótesis",
            "Despensas",
            "Gastos por evento",
            "Insumos",
            "Gastos de administración",
            "Inversiones",
            "Acreedores diversos"});
            this.comboBoxTipo.Location = new System.Drawing.Point(191, 119);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTipo.TabIndex = 17;
            // 
            // dateTimeEgreso
            // 
            this.dateTimeEgreso.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEgreso.Location = new System.Drawing.Point(191, 69);
            this.dateTimeEgreso.Name = "dateTimeEgreso";
            this.dateTimeEgreso.Size = new System.Drawing.Size(245, 21);
            this.dateTimeEgreso.TabIndex = 16;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(105, 71);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(62, 19);
            this.labelFecha.TabIndex = 15;
            this.labelFecha.Text = "Fecha:";
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
            this.botonAgregar.Location = new System.Drawing.Point(265, 354);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonAgregar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonAgregar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(131)))));
            this.botonAgregar.Size = new System.Drawing.Size(91, 33);
            this.botonAgregar.TabIndex = 14;
            this.botonAgregar.Text = "  Agregar";
            this.botonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAgregar.TextColor = System.Drawing.Color.White;
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.colorBottom = System.Drawing.Color.White;
            this.textBoxObservaciones.colorTop = System.Drawing.Color.Silver;
            this.textBoxObservaciones.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservaciones.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxObservaciones.Location = new System.Drawing.Point(191, 210);
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(473, 27);
            this.textBoxObservaciones.TabIndex = 9;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.colorBottom = System.Drawing.Color.White;
            this.textBoxCantidad.colorTop = System.Drawing.Color.Silver;
            this.textBoxCantidad.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCantidad.Location = new System.Drawing.Point(191, 165);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(200, 27);
            this.textBoxCantidad.TabIndex = 8;
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservaciones.Location = new System.Drawing.Point(36, 218);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(131, 19);
            this.labelObservaciones.TabIndex = 6;
            this.labelObservaciones.Text = "Observaciones:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(6, 168);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(180, 19);
            this.labelCantidad.TabIndex = 1;
            this.labelCantidad.Text = "Cantidad Invertida:  $";
            // 
            // labelTipoEgreso
            // 
            this.labelTipoEgreso.AutoSize = true;
            this.labelTipoEgreso.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoEgreso.Location = new System.Drawing.Point(31, 121);
            this.labelTipoEgreso.Name = "labelTipoEgreso";
            this.labelTipoEgreso.Size = new System.Drawing.Size(132, 19);
            this.labelTipoEgreso.TabIndex = 0;
            this.labelTipoEgreso.Text = "Tipo de egreso:";
            // 
            // Form_Finanzas_Egresos_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Finanzas_Egresos_Agregar";
            this.Text = "Form_Finanzas_Egresos_Agregar";
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelCentral;
        private TextBox3.ComboBoxRounded comboBoxTipo;
        private System.Windows.Forms.DateTimePicker dateTimeEgreso;
        private System.Windows.Forms.Label labelFecha;
        private ePOSOne.btnProduct.Button_WOC botonAgregar;
        private TextBox3.TextBoxRounded textBoxObservaciones;
        private TextBox3.TextBoxRounded textBoxCantidad;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelTipoEgreso;
    }
}