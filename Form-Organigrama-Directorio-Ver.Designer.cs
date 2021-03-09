namespace interfazModernaONG
{
    partial class Form_Organigrama_Directorio_Ver
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
            this.comboBoxFiltro = new TextBox3.ComboBoxRounded();
            this.textBoxCargo = new TextBox3.TextBoxRounded();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.dataGridVer = new Proyecto_de_Pruebas.DataGridViewGradient();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBorrar = new ePOSOne.btnProduct.Button_WOC();
            this.panelTop.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonBorrar);
            this.panelTop.Controls.Add(this.botonFiltrar);
            this.panelTop.Controls.Add(this.comboBoxFiltro);
            this.panelTop.Controls.Add(this.textBoxCargo);
            this.panelTop.Controls.Add(this.labelFiltro);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(837, 100);
            this.panelTop.TabIndex = 40;
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
            this.botonFiltrar.Location = new System.Drawing.Point(736, 3);
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
            "Cargo"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(105, 48);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(247, 24);
            this.comboBoxFiltro.TabIndex = 39;
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.colorBottom = System.Drawing.Color.White;
            this.textBoxCargo.colorTop = System.Drawing.Color.Silver;
            this.textBoxCargo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCargo.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCargo.Location = new System.Drawing.Point(367, 45);
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
            this.panelCentral.TabIndex = 41;
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
            this.Telefono,
            this.Email});
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
            this.dataGridVer.TabIndex = 38;
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
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBorrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBorrar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBorrar.FlatAppearance.BorderSize = 0;
            this.buttonBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(731, 48);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBorrar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBorrar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(131)))));
            this.buttonBorrar.Size = new System.Drawing.Size(103, 33);
            this.buttonBorrar.TabIndex = 40;
            this.buttonBorrar.Text = "Quitar filtros";
            this.buttonBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBorrar.TextColor = System.Drawing.Color.White;
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.ButtonBorrar_Click);
            // 
            // Form_Organigrama_Directorio_Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Organigrama_Directorio_Ver";
            this.Text = "Form_Organigrama_Directorio_Ver";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox3.ComboBoxRounded comboBoxFiltro;
        private System.Windows.Forms.Panel panelTop;
        private ePOSOne.btnProduct.Button_WOC botonFiltrar;
        private TextBox3.TextBoxRounded textBoxCargo;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Panel panelCentral;
        private Proyecto_de_Pruebas.DataGridViewGradient dataGridVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private ePOSOne.btnProduct.Button_WOC buttonBorrar;
    }
}