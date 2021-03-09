namespace interfazModernaONG
{
    partial class Form_Organigrama_Directorio_Informe
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.botonInforme = new ePOSOne.btnProduct.Button_WOC();
            this.labelHasta = new System.Windows.Forms.Label();
            this.labelDesde = new System.Windows.Forms.Label();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(161, 399);
            this.panelIzquierdo.TabIndex = 8;
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCentral.Controls.Add(this.dateTimePicker1);
            this.panelCentral.Controls.Add(this.dateTimeDesde);
            this.panelCentral.Controls.Add(this.botonInforme);
            this.panelCentral.Controls.Add(this.labelHasta);
            this.panelCentral.Controls.Add(this.labelDesde);
            this.panelCentral.Location = new System.Drawing.Point(161, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(676, 399);
            this.panelCentral.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 21);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.CalendarFont = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDesde.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDesde.Location = new System.Drawing.Point(217, 73);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(248, 21);
            this.dateTimeDesde.TabIndex = 21;
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
            this.botonInforme.Location = new System.Drawing.Point(248, 303);
            this.botonInforme.Name = "botonInforme";
            this.botonInforme.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonInforme.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonInforme.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(131)))));
            this.botonInforme.Size = new System.Drawing.Size(140, 33);
            this.botonInforme.TabIndex = 20;
            this.botonInforme.Text = " Generar Informe";
            this.botonInforme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonInforme.TextColor = System.Drawing.Color.White;
            this.botonInforme.UseVisualStyleBackColor = false;
            this.botonInforme.Click += new System.EventHandler(this.BotonInforme_Click);
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasta.Location = new System.Drawing.Point(70, 181);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(59, 19);
            this.labelHasta.TabIndex = 1;
            this.labelHasta.Text = "Hasta:";
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesde.Location = new System.Drawing.Point(63, 75);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(66, 19);
            this.labelDesde.TabIndex = 0;
            this.labelDesde.Text = "Desde:";
            // 
            // Form_Organigrama_Directorio_Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Organigrama_Directorio_Informe";
            this.Text = "Form_Organigrama_Directorio_Informe";
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.Label labelDesde;
        private ePOSOne.btnProduct.Button_WOC botonInforme;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}