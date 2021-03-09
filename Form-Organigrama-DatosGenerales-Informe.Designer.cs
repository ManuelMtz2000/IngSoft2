namespace interfazModernaONG
{
    partial class Form_Organigrama_DatosGenerales_Informe
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
            this.botonBuscar = new ePOSOne.btnProduct.Button_WOC();
            this.textBoxNombre = new TextBox3.TextBoxRounded();
            this.labelPersonaInforme = new System.Windows.Forms.Label();
            this.botonInforme = new ePOSOne.btnProduct.Button_WOC();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(80, 399);
            this.panelIzquierdo.TabIndex = 1;
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCentral.Controls.Add(this.botonInforme);
            this.panelCentral.Controls.Add(this.botonBuscar);
            this.panelCentral.Controls.Add(this.textBoxNombre);
            this.panelCentral.Controls.Add(this.labelPersonaInforme);
            this.panelCentral.Location = new System.Drawing.Point(80, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(757, 399);
            this.panelCentral.TabIndex = 2;
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
            this.botonBuscar.Location = new System.Drawing.Point(336, 143);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonBuscar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonBuscar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(131)))));
            this.botonBuscar.Size = new System.Drawing.Size(85, 33);
            this.botonBuscar.TabIndex = 18;
            this.botonBuscar.Text = "   Buscar";
            this.botonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonBuscar.TextColor = System.Drawing.Color.White;
            this.botonBuscar.UseVisualStyleBackColor = false;
            this.botonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.colorBottom = System.Drawing.Color.White;
            this.textBoxNombre.colorTop = System.Drawing.Color.Silver;
            this.textBoxNombre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNombre.Location = new System.Drawing.Point(268, 76);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(367, 27);
            this.textBoxNombre.TabIndex = 17;
            // 
            // labelPersonaInforme
            // 
            this.labelPersonaInforme.AutoSize = true;
            this.labelPersonaInforme.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonaInforme.Location = new System.Drawing.Point(6, 84);
            this.labelPersonaInforme.Name = "labelPersonaInforme";
            this.labelPersonaInforme.Size = new System.Drawing.Size(256, 19);
            this.labelPersonaInforme.TabIndex = 16;
            this.labelPersonaInforme.Text = "Persona que genera el informe:";
            // 
            // botonInforme
            // 
            this.botonInforme.BackColor = System.Drawing.Color.Transparent;
            this.botonInforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonInforme.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonInforme.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonInforme.FlatAppearance.BorderSize = 0;
            this.botonInforme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonInforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonInforme.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInforme.Location = new System.Drawing.Point(309, 282);
            this.botonInforme.Name = "botonInforme";
            this.botonInforme.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonInforme.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonInforme.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(131)))));
            this.botonInforme.Size = new System.Drawing.Size(140, 33);
            this.botonInforme.TabIndex = 19;
            this.botonInforme.Text = " Generar Informe";
            this.botonInforme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonInforme.TextColor = System.Drawing.Color.White;
            this.botonInforme.UseVisualStyleBackColor = false;
            this.botonInforme.Click += new System.EventHandler(this.BotonInforme_Click);
            // 
            // Form_Organigrama_DatosGenerales_Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Organigrama_DatosGenerales_Informe";
            this.Text = "Form_Organigrama_DatosGenerales_Informe";
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelCentral;
        private ePOSOne.btnProduct.Button_WOC botonBuscar;
        private TextBox3.TextBoxRounded textBoxNombre;
        private System.Windows.Forms.Label labelPersonaInforme;
        private ePOSOne.btnProduct.Button_WOC botonInforme;
    }
}