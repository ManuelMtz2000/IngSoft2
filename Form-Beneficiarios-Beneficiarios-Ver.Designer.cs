namespace interfazModernaONG
{
    partial class Form_Beneficiarios_Beneficiarios_Ver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxFiltro = new TextBox3.ComboBoxRounded();
            this.panelTop = new System.Windows.Forms.Panel();
            this.botonFiltrar = new ePOSOne.btnProduct.Button_WOC();
            this.textBoxCargo = new TextBox3.TextBoxRounded();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.dataGridVer = new Proyecto_de_Pruebas.DataGridViewGradient();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamiliarRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomFam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelFamRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonQuitar = new ePOSOne.btnProduct.Button_WOC();
            this.panelTop.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVer)).BeginInit();
            this.SuspendLayout();
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.BorderColor = System.Drawing.Color.DarkOrange;
            this.comboBoxFiltro.colorBottom = System.Drawing.Color.White;
            this.comboBoxFiltro.colorTop = System.Drawing.Color.Silver;
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltro.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Nombre",
            "Edad",
            "Sexo",
            "Tipo",
            "Cuota Mensual"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(114, 43);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(247, 24);
            this.comboBoxFiltro.TabIndex = 44;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonQuitar);
            this.panelTop.Controls.Add(this.botonFiltrar);
            this.panelTop.Controls.Add(this.comboBoxFiltro);
            this.panelTop.Controls.Add(this.textBoxCargo);
            this.panelTop.Controls.Add(this.labelFiltro);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(837, 100);
            this.panelTop.TabIndex = 45;
            // 
            // botonFiltrar
            // 
            this.botonFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.botonFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonFiltrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonFiltrar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonFiltrar.FlatAppearance.BorderSize = 0;
            this.botonFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonFiltrar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonFiltrar.Location = new System.Drawing.Point(736, 12);
            this.botonFiltrar.Name = "botonFiltrar";
            this.botonFiltrar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonFiltrar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonFiltrar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(131)))));
            this.botonFiltrar.Size = new System.Drawing.Size(89, 33);
            this.botonFiltrar.TabIndex = 30;
            this.botonFiltrar.Text = "    Filtrar";
            this.botonFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonFiltrar.TextColor = System.Drawing.Color.White;
            this.botonFiltrar.UseVisualStyleBackColor = false;
            this.botonFiltrar.Click += new System.EventHandler(this.BotonFiltrar_Click_1);
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.colorBottom = System.Drawing.Color.White;
            this.textBoxCargo.colorTop = System.Drawing.Color.Silver;
            this.textBoxCargo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCargo.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCargo.Location = new System.Drawing.Point(367, 40);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(349, 27);
            this.textBoxCargo.TabIndex = 29;
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltro.Location = new System.Drawing.Point(17, 48);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(91, 19);
            this.labelFiltro.TabIndex = 27;
            this.labelFiltro.Text = "Filtrar por:";
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.dataGridVer);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 100);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(837, 299);
            this.panelCentral.TabIndex = 46;
            this.panelCentral.Resize += new System.EventHandler(this.PanelCentral_Resize);
            // 
            // dataGridVer
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            this.dataGridVer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridVer.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridVer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.FechaNac,
            this.Edad,
            this.Sexo,
            this.Tipo,
            this.FamiliarRes,
            this.DomFam,
            this.TelFamRes,
            this.Cuota});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVer.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVer.EnableHeadersVisualStyles = false;
            this.dataGridVer.Location = new System.Drawing.Point(0, 0);
            this.dataGridVer.Name = "dataGridVer";
            this.dataGridVer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridVer.RowHeadersVisible = false;
            this.dataGridVer.Size = new System.Drawing.Size(837, 299);
            this.dataGridVer.TabIndex = 43;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "Fecha de nacimiento";
            this.FechaNac.Name = "FechaNac";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // FamiliarRes
            // 
            this.FamiliarRes.HeaderText = "Familiar Responsable";
            this.FamiliarRes.Name = "FamiliarRes";
            // 
            // DomFam
            // 
            this.DomFam.HeaderText = "Domicilio de Familiar Responsable";
            this.DomFam.Name = "DomFam";
            // 
            // TelFamRes
            // 
            this.TelFamRes.HeaderText = "Teléfono de Familiar Responsable";
            this.TelFamRes.Name = "TelFamRes";
            // 
            // Cuota
            // 
            this.Cuota.HeaderText = "Cuota Mensual";
            this.Cuota.Name = "Cuota";
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonQuitar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonQuitar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonQuitar.FlatAppearance.BorderSize = 0;
            this.buttonQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitar.Location = new System.Drawing.Point(731, 51);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonQuitar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonQuitar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(131)))));
            this.buttonQuitar.Size = new System.Drawing.Size(103, 33);
            this.buttonQuitar.TabIndex = 45;
            this.buttonQuitar.Text = "Quitar filtros";
            this.buttonQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuitar.TextColor = System.Drawing.Color.White;
            this.buttonQuitar.UseVisualStyleBackColor = false;
            this.buttonQuitar.Click += new System.EventHandler(this.ButtonQuitar_Click);
            // 
            // Form_Beneficiarios_Beneficiarios_Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Beneficiarios_Beneficiarios_Ver";
            this.Text = "Form_Beneficiarios_Beneficiarios_Ver";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private TextBox3.ComboBoxRounded comboBoxFiltro;
        private System.Windows.Forms.Panel panelTop;
        private ePOSOne.btnProduct.Button_WOC botonFiltrar;
        private TextBox3.TextBoxRounded textBoxCargo;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Panel panelCentral;
        private Proyecto_de_Pruebas.DataGridViewGradient dataGridVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamiliarRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomFam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelFamRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private ePOSOne.btnProduct.Button_WOC buttonQuitar;
    }
}