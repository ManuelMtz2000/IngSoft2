namespace interfazModernaONG
{
    partial class Form_Finanzas_Ingresos_Ver
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
            this.labelFiltro = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.dataGridVer = new Proyecto_de_Pruebas.DataGridViewGradient();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vermas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonFiltrar = new ePOSOne.btnProduct.Button_WOC();
            this.comboBoxFiltro = new TextBox3.ComboBoxRounded();
            this.textBoxCargo = new TextBox3.TextBoxRounded();
            this.panelTop.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.botonFiltrar);
            this.panelTop.Controls.Add(this.comboBoxFiltro);
            this.panelTop.Controls.Add(this.textBoxCargo);
            this.panelTop.Controls.Add(this.labelFiltro);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(837, 100);
            this.panelTop.TabIndex = 51;
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
            this.panelCentral.TabIndex = 52;
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
            this.Folio,
            this.Fecha,
            this.TipoIn,
            this.NumCan,
            this.Observaciones,
            this.Vermas});
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
            this.dataGridVer.TabIndex = 49;
            // 
            // Folio
            // 
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de Alta";
            this.Fecha.Name = "Fecha";
            // 
            // TipoIn
            // 
            this.TipoIn.HeaderText = "Tipo de Ingreso";
            this.TipoIn.Name = "TipoIn";
            // 
            // NumCan
            // 
            this.NumCan.HeaderText = "Cantidad Recibida";
            this.NumCan.Name = "NumCan";
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            // 
            // Vermas
            // 
            this.Vermas.HeaderText = "Ver más información";
            this.Vermas.Name = "Vermas";
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
            this.botonFiltrar.Location = new System.Drawing.Point(731, 34);
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
            this.botonFiltrar.Click += new System.EventHandler(this.BotonFiltrar_Click);
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
            "Folio",
            "Fecha de alta",
            "Tipo de Ingreso",
            "Cantidad Recibida"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(114, 43);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(247, 24);
            this.comboBoxFiltro.TabIndex = 49;
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
            // Form_Finanzas_Ingresos_Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Finanzas_Ingresos_Ver";
            this.Text = "Form_Finanzas_Ingresos_Ver";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private ePOSOne.btnProduct.Button_WOC botonFiltrar;
        private TextBox3.ComboBoxRounded comboBoxFiltro;
        private TextBox3.TextBoxRounded textBoxCargo;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Panel panelCentral;
        private Proyecto_de_Pruebas.DataGridViewGradient dataGridVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vermas;
    }
}