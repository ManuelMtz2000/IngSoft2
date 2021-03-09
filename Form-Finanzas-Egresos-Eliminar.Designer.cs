namespace interfazModernaONG
{
    partial class Form_Finanzas_Egresos_Eliminar
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
            this.botonBuscar = new ePOSOne.btnProduct.Button_WOC();
            this.textBoxObservaciones = new TextBox3.TextBoxRounded();
            this.labelFolio = new System.Windows.Forms.Label();
            this.dateTimeIngreso = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.botonEliminar = new ePOSOne.btnProduct.Button_WOC();
            this.textBoxCantidad = new TextBox3.TextBoxRounded();
            this.textBoxFolio = new TextBox3.TextBoxRounded();
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
            this.panelIzquierdo.TabIndex = 12;
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCentral.Controls.Add(this.comboBoxTipo);
            this.panelCentral.Controls.Add(this.botonBuscar);
            this.panelCentral.Controls.Add(this.textBoxObservaciones);
            this.panelCentral.Controls.Add(this.labelFolio);
            this.panelCentral.Controls.Add(this.dateTimeIngreso);
            this.panelCentral.Controls.Add(this.labelFecha);
            this.panelCentral.Controls.Add(this.botonEliminar);
            this.panelCentral.Controls.Add(this.textBoxCantidad);
            this.panelCentral.Controls.Add(this.textBoxFolio);
            this.panelCentral.Controls.Add(this.labelObservaciones);
            this.panelCentral.Controls.Add(this.labelCantidad);
            this.panelCentral.Controls.Add(this.labelTipoEgreso);
            this.panelCentral.Location = new System.Drawing.Point(161, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(676, 399);
            this.panelCentral.TabIndex = 13;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.BorderColor = System.Drawing.Color.DarkOrange;
            this.comboBoxTipo.colorBottom = System.Drawing.Color.White;
            this.comboBoxTipo.colorTop = System.Drawing.Color.Silver;
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboBoxTipo.Location = new System.Drawing.Point(191, 148);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTipo.TabIndex = 21;
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
            this.botonBuscar.Location = new System.Drawing.Point(470, 12);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonBuscar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonBuscar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(131)))));
            this.botonBuscar.Size = new System.Drawing.Size(91, 33);
            this.botonBuscar.TabIndex = 20;
            this.botonBuscar.Text = "   Buscar";
            this.botonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonBuscar.TextColor = System.Drawing.Color.White;
            this.botonBuscar.UseVisualStyleBackColor = false;
            this.botonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.colorBottom = System.Drawing.Color.White;
            this.textBoxObservaciones.colorTop = System.Drawing.Color.Silver;
            this.textBoxObservaciones.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservaciones.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxObservaciones.Location = new System.Drawing.Point(191, 224);
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(473, 27);
            this.textBoxObservaciones.TabIndex = 19;
            // 
            // labelFolio
            // 
            this.labelFolio.AutoSize = true;
            this.labelFolio.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolio.Location = new System.Drawing.Point(36, 26);
            this.labelFolio.Name = "labelFolio";
            this.labelFolio.Size = new System.Drawing.Size(135, 19);
            this.labelFolio.TabIndex = 18;
            this.labelFolio.Text = "Folio de egreso:";
            // 
            // dateTimeIngreso
            // 
            this.dateTimeIngreso.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeIngreso.Location = new System.Drawing.Point(191, 108);
            this.dateTimeIngreso.Name = "dateTimeIngreso";
            this.dateTimeIngreso.Size = new System.Drawing.Size(245, 21);
            this.dateTimeIngreso.TabIndex = 16;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(105, 110);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(62, 19);
            this.labelFecha.TabIndex = 15;
            this.labelFecha.Text = "Fecha:";
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
            this.botonEliminar.Location = new System.Drawing.Point(264, 363);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonEliminar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonEliminar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(131)))));
            this.botonEliminar.Size = new System.Drawing.Size(91, 33);
            this.botonEliminar.TabIndex = 14;
            this.botonEliminar.Text = "  Eliminar";
            this.botonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonEliminar.TextColor = System.Drawing.Color.White;
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.colorBottom = System.Drawing.Color.White;
            this.textBoxCantidad.colorTop = System.Drawing.Color.Silver;
            this.textBoxCantidad.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCantidad.Location = new System.Drawing.Point(191, 185);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(473, 27);
            this.textBoxCantidad.TabIndex = 9;
            // 
            // textBoxFolio
            // 
            this.textBoxFolio.colorBottom = System.Drawing.Color.White;
            this.textBoxFolio.colorTop = System.Drawing.Color.Silver;
            this.textBoxFolio.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFolio.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxFolio.Location = new System.Drawing.Point(181, 18);
            this.textBoxFolio.MaxLength = 10;
            this.textBoxFolio.Name = "textBoxFolio";
            this.textBoxFolio.Size = new System.Drawing.Size(210, 27);
            this.textBoxFolio.TabIndex = 8;
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservaciones.Location = new System.Drawing.Point(35, 231);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(131, 19);
            this.labelObservaciones.TabIndex = 6;
            this.labelObservaciones.Text = "Observaciones:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(6, 192);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(180, 19);
            this.labelCantidad.TabIndex = 1;
            this.labelCantidad.Text = "Cantidad Invertida:  $";
            // 
            // labelTipoEgreso
            // 
            this.labelTipoEgreso.AutoSize = true;
            this.labelTipoEgreso.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoEgreso.Location = new System.Drawing.Point(35, 153);
            this.labelTipoEgreso.Name = "labelTipoEgreso";
            this.labelTipoEgreso.Size = new System.Drawing.Size(132, 19);
            this.labelTipoEgreso.TabIndex = 0;
            this.labelTipoEgreso.Text = "Tipo de egreso:";
            // 
            // Form_Finanzas_Egresos_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Finanzas_Egresos_Eliminar";
            this.Text = "Form_Finanzas_Egresos_Eliminar";
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelCentral;
        private ePOSOne.btnProduct.Button_WOC botonBuscar;
        private TextBox3.TextBoxRounded textBoxObservaciones;
        private System.Windows.Forms.Label labelFolio;
        private System.Windows.Forms.DateTimePicker dateTimeIngreso;
        private System.Windows.Forms.Label labelFecha;
        private ePOSOne.btnProduct.Button_WOC botonEliminar;
        private TextBox3.TextBoxRounded textBoxCantidad;
        private TextBox3.TextBoxRounded textBoxFolio;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelTipoEgreso;
        private TextBox3.ComboBoxRounded comboBoxTipo;
    }
}