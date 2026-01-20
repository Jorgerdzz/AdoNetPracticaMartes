namespace AdoNetPracticaMartes
{
    partial class FormHospitales
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
            label1 = new Label();
            cmbHospitales = new ComboBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtSuma = new TextBox();
            label4 = new Label();
            txtMedia = new TextBox();
            label5 = new Label();
            txtPersonas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 31);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(57, 60);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(147, 23);
            cmbHospitales.TabIndex = 1;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 26);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados hospital";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(327, 62);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(203, 259);
            lstEmpleados.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 171);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Suma salarial";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(57, 199);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(147, 23);
            txtSuma.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 251);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 6;
            label4.Text = "Media salarial";
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(63, 278);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(141, 23);
            txtMedia.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 327);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "Personas";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(64, 362);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(140, 23);
            txtPersonas.TabIndex = 9;
            // 
            // FormHospitales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPersonas);
            Controls.Add(label5);
            Controls.Add(txtMedia);
            Controls.Add(label4);
            Controls.Add(txtSuma);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Name = "FormHospitales";
            Text = "FormHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospitales;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtSuma;
        private Label label4;
        private TextBox txtMedia;
        private Label label5;
        private TextBox txtPersonas;
    }
}