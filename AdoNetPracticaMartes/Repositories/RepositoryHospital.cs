using AdoNetPracticaMartes.Helpers;
using AdoNetPracticaMartes.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection;
using System.Text;

#region STORED PROCEDURES
//alter procedure SP_EMPLEADOS_HOSPITAL_OUT
//(@nombreHospital nvarchar(50),
//    @suma int OUT,
//    @media int OUT,
//    @personas int OUT)
//as

//	select  @suma = isnull(SUM(PLANTILLA.SALARIO + DOCTOR.SALARIO),0), @media = isnull(AVG(PLANTILLA.SALARIO + DOCTOR.SALARIO), 0), @personas = COUNT(PLANTILLA.APELLIDO + DOCTOR.APELLIDO) from PLANTILLA
//	inner join DOCTOR
//	on PLANTILLA.HOSPITAL_COD = DOCTOR.HOSPITAL_COD
//	where PLANTILLA.HOSPITAL_COD = (
//	select HOSPITAL_COD from HOSPITAL where NOMBRE=@nombreHospital)
//	print @suma;
//print @media;
//print @personas;

//select APELLIDO, ESPECIALIDAD, SALARIO 
//	from DOCTOR where HOSPITAL_COD=(select HOSPITAL_COD from HOSPITAL where NOMBRE=@nombreHospital)
//	union
//	select APELLIDO, FUNCION, SALARIO 
//	from PLANTILLA where HOSPITAL_COD=(select HOSPITAL_COD from HOSPITAL where NOMBRE=@nombreHospital)

//go
#endregion

namespace AdoNetPracticaMartes.Repositories
{
    public class RepositoryHospital
    {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryHospital()
        {
            IConfigurationRoot configuration = HelperConfiguration.GetConfiguration();
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetHospitalesAsync()
        {
            string sql = "SP_HOSPITALES";
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> hospitales = new List<string>();
            while(await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                hospitales.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }

        public async Task<ModelEmpleados> GetEmpleadosHospitalAsync(string nombreHospital)
        {
            string sql = "SP_EMPLEADOS_HOSPITAL_OUT";
            this.com.Parameters.AddWithValue("@nombreHospital", nombreHospital);
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamSuma.Value = 0;
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@media";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            ModelEmpleados empleado = new ModelEmpleados();
            while(await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string especialidad = this.reader["ESPECIALIDAD"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                empleado.Apellido.Add(apellido);
                empleado.Especialidad.Add(especialidad);
                empleado.Salario.Add(salario);
            }
            await this.reader.CloseAsync();
            empleado.SumaSalarial = int.Parse(pamSuma.Value.ToString());
            empleado.MediaSalarial = int.Parse(pamMedia.Value.ToString());
            empleado.Personas = int.Parse(pamPersonas.Value.ToString());
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleado;
        }

    }
}
