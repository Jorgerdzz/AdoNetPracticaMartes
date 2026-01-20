using AdoNetPracticaMartes.Models;
using AdoNetPracticaMartes.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdoNetPracticaMartes
{
    public partial class FormHospitales : Form
    {
        RepositoryHospital repo;
        public FormHospitales()
        {
            InitializeComponent();
            this.repo = new RepositoryHospital();
            this.LoadHospitales();
        }

        private async Task LoadHospitales()
        {
            List<string> hospitales = await this.repo.GetHospitalesAsync();
            this.cmbHospitales.Items.Clear();
            foreach (string nombre in hospitales)
            {
                this.cmbHospitales.Items.Add(nombre);
            }
        }

        private async void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreHospital = this.cmbHospitales.SelectedItem.ToString();
            ModelEmpleados empleados = await this.repo.GetEmpleadosHospitalAsync(nombreHospital);
            this.lstEmpleados.Items.Clear();
            for (int i = 0; i < empleados.Apellido.Count; i++)

            {
                string apellidos = empleados.Apellido[i];
                string especialidad = empleados.Especialidad[i];
                int salario = empleados.Salario[i];
                this.lstEmpleados.Items.Add(apellidos + " - " + especialidad + " - " + salario);
            }
            this.txtSuma.Text = empleados.SumaSalarial.ToString();
            this.txtMedia.Text = empleados.MediaSalarial.ToString();
            this.txtPersonas.Text = empleados.Personas.ToString();
        }
    }
}
