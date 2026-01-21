namespace AdoNetPracticaMartes
{
    partial class FormDepartamentosEmpleados
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
            cmbDepartamentos = new ComboBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtId = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            txtLocalidad = new TextBox();
            btnNuevoDepartamento = new Button();
            label6 = new Label();
            txtApellido = new TextBox();
            label7 = new Label();
            txtOficio = new TextBox();
            label8 = new Label();
            txtSalario = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 44);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(57, 73);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(143, 23);
            cmbDepartamentos.TabIndex = 1;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 42);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(321, 75);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(197, 214);
            lstEmpleados.TabIndex = 3;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 113);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 4;
            label3.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(57, 131);
            txtId.Name = "txtId";
            txtId.Size = new Size(118, 23);
            txtId.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 167);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(57, 185);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 224);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(57, 252);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(118, 23);
            txtLocalidad.TabIndex = 9;
            // 
            // btnNuevoDepartamento
            // 
            btnNuevoDepartamento.Location = new Point(55, 303);
            btnNuevoDepartamento.Name = "btnNuevoDepartamento";
            btnNuevoDepartamento.Size = new Size(120, 54);
            btnNuevoDepartamento.TabIndex = 10;
            btnNuevoDepartamento.Text = "Insertar departamento";
            btnNuevoDepartamento.UseVisualStyleBackColor = true;
            btnNuevoDepartamento.Click += btnNuevoDepartamento_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(598, 73);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 11;
            label6.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(599, 96);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(598, 131);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(598, 149);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(599, 188);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 15;
            label8.Text = "Salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(598, 216);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 16;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(601, 267);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 23);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormDepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(txtSalario);
            Controls.Add(label8);
            Controls.Add(txtOficio);
            Controls.Add(label7);
            Controls.Add(txtApellido);
            Controls.Add(label6);
            Controls.Add(btnNuevoDepartamento);
            Controls.Add(txtLocalidad);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Name = "FormDepartamentosEmpleados";
            Text = "FormDepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtId;
        private Label label4;
        private TextBox txtNombre;
        private Label label5;
        private TextBox txtLocalidad;
        private Button btnNuevoDepartamento;
        private Label label6;
        private TextBox txtApellido;
        private Label label7;
        private TextBox txtOficio;
        private Label label8;
        private TextBox txtSalario;
        private Button btnUpdate;
    }
}