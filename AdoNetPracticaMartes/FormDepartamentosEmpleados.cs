using AdoNetPracticaMartes.Models;
using AdoNetPracticaMartes.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetPracticaMartes
{
    public partial class FormDepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repo;
        public FormDepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.LoadDepartamentos();
        }

        private async void LoadDepartamentos()
        {
            List<string> departamentos = await this.repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (string nombre in departamentos)
            {
                this.cmbDepartamentos.Items.Add(nombre);
            }
        }

        private async void LoadEmpleados(string nombreDepartamento)
        {
            DatosDepartamento datos = await this.repo.GetDatosDepartamentoAsync(nombreDepartamento);
            this.lstEmpleados.Items.Clear();
            foreach (string apellido in datos.Empleados)
            {
                this.lstEmpleados.Items.Add(apellido);
            }
            this.txtId.Text = datos.DeptNo.ToString();
            this.txtNombre.Text = datos.NombreDepartamento.ToString();
            this.txtLocalidad.Text = datos.Localidad.ToString();
        }

        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDepartamento = this.cmbDepartamentos.SelectedItem.ToString();
            this.LoadEmpleados(nombreDepartamento);
        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string apellido = this.lstEmpleados.SelectedItem.ToString();
            DatosEmpleado empleado = await this.repo.GetDatosEmpleadoAsync(apellido);
            this.txtApellido.Text = empleado.Apellido.ToString();
            this.txtOficio.Text = empleado.Oficio.ToString();
            this.txtSalario.Text = empleado.Salario.ToString();
        }

        private async void btnNuevoDepartamento_Click(object sender, EventArgs e)
        {
            this.cmbDepartamentos.Items.Clear();
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            int registros = await this.repo.InsertarDepartamentoAsync(id, nombre, localidad);
            MessageBox.Show("Departamentos insertados: " + registros);
            this.LoadDepartamentos();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string nombreDepartamento = this.cmbDepartamentos.SelectedItem.ToString();
            string apellido = this.lstEmpleados.SelectedItem.ToString();
            this.lstEmpleados.Items.Clear();
            string nuevoApellido = this.txtApellido.Text;
            string oficio = this.txtOficio.Text;
            int salario = int.Parse(this.txtSalario.Text);
            int registros = await this.repo.UpdateEmpleadoAsync(apellido, nuevoApellido, oficio, salario);
            MessageBox.Show("Empleados modificados: " + registros);
            this.LoadEmpleados(nombreDepartamento);
        }
    }
}
