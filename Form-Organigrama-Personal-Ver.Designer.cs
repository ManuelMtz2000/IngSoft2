namespace interfazModernaONG
{
    partial class Form_Organigrama_Personal_Ver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.botonFiltrar = new ePOSOne.btnProduct.Button_WOC();
            this.textBoxCargo = new TextBox3.TextBoxRounded();
            this.comboBoxFiltro = new TextBox3.ComboBoxRounded();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.dataGridVer = new Proyecto_de_Pruebas.DataGridViewGradient();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eventual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voluntario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicioSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonQuitar = new ePOSOne.btnProduct.Button_WOC();
            this.panelTop.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonQuitar);
            this.panelTop.Controls.Add(this.botonFiltrar);
            this.panelTop.Controls.Add(this.textBoxCargo);
            this.panelTop.Controls.Add(this.comboBoxFiltro);
            this.panelTop.Controls.Add(this.labelFiltro);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(837, 100);
            this.panelTop.TabIndex = 13;
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
            "Cargo",
            "Base",
            "Eventual",
            "Voluntario",
            "Servicio Social",
            "Servicio Social (Universidad)"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(114, 43);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(247, 24);
            this.comboBoxFiltro.TabIndex = 28;
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
            this.panelCentral.BackColor = System.Drawing.Color.White;
            this.panelCentral.Controls.Add(this.dataGridVer);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 100);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(837, 299);
            this.panelCentral.TabIndex = 14;
            this.panelCentral.Resize += new System.EventHandler(this.PanelCentral_Resize);
            // 
            // dataGridVer
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.dataGridVer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridVer.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridVer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cargo,
            this.Base,
            this.Eventual,
            this.Voluntario,
            this.ServicioSocial});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVer.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVer.EnableHeadersVisualStyles = false;
            this.dataGridVer.Location = new System.Drawing.Point(0, 0);
            this.dataGridVer.Name = "dataGridVer";
            this.dataGridVer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridVer.RowHeadersVisible = false;
            this.dataGridVer.Size = new System.Drawing.Size(837, 299);
            this.dataGridVer.TabIndex = 14;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "  Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // Base
            // 
            this.Base.HeaderText = "Base";
            this.Base.Name = "Base";
            // 
            // Eventual
            // 
            this.Eventual.HeaderText = "Eventual";
            this.Eventual.Name = "Eventual";
            // 
            // Voluntario
            // 
            this.Voluntario.HeaderText = "Voluntario";
            this.Voluntario.Name = "Voluntario";
            // 
            // ServicioSocial
            // 
            this.ServicioSocial.HeaderText = "Servicio Social";
            this.ServicioSocial.Name = "ServicioSocial";
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
            this.buttonQuitar.TabIndex = 31;
            this.buttonQuitar.Text = "Quitar filtros";
            this.buttonQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuitar.TextColor = System.Drawing.Color.White;
            this.buttonQuitar.UseVisualStyleBackColor = false;
            this.buttonQuitar.Click += new System.EventHandler(this.ButtonQuitar_Click);
            // 
            // Form_Organigrama_Personal_Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Organigrama_Personal_Ver";
            this.Text = "Form_Organigrama_Personal_Ver";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private ePOSOne.btnProduct.Button_WOC botonFiltrar;
        private TextBox3.TextBoxRounded textBoxCargo;
        private TextBox3.ComboBoxRounded comboBoxFiltro;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Panel panelCentral;
        private Proyecto_de_Pruebas.DataGridViewGradient dataGridVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eventual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voluntario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicioSocial;
        private ePOSOne.btnProduct.Button_WOC buttonQuitar;
    }
}