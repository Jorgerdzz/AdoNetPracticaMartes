using AdoNetPracticaMartes.Helpers;
using AdoNetPracticaMartes.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Text;

#region STORED PROCEDURES
//create procedure SP_LOAD_DEPARTAMENTOS
//as
//	select * from DEPT;
//go

//alter procedure SP_LOAD_DATOS_DEPARTAMENTO
//(@nombreDepartamento nvarchar(50),
//    @id int,
//    @nombre nvarchar(50),
//    @localidad nvarchar(50))
//as

//	select @id = DEPT_NO, @nombre = DNOMBRE, @localidad = LOC from DEPT where DNOMBRE = @nombreDepartamento

//	select * from EMP
//	inner join DEPT
//	on EMP.DEPT_NO = DEPT.DEPT_NO 
//	where DEPT.DNOMBRE = @nombreDepartamento

//go

#endregion

namespace AdoNetPracticaMartes.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            IConfigurationRoot configuration = HelperConfiguration.GetConfiguration();
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;

        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SP_LOAD_DEPARTAMENTOS";
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while(await this.reader.ReadAsync())
            {
                string nombreDepartamento = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombreDepartamento);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<DatosDepartamento> GetDatosDepartamentoAsync(string nombreDepartamento)
        {
            string sql = "SP_LOAD_DATOS_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@nombreDepartamento", nombreDepartamento);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatosDepartamento datos = new DatosDepartamento();
            if (await this.reader.ReadAsync())
            {
                datos.DeptNo = int.Parse(this.reader["DEPT_NO"].ToString());
                datos.NombreDepartamento = this.reader["DNOMBRE"].ToString();
                datos.Localidad = this.reader["LOC"].ToString();
            }

            if (await this.reader.NextResultAsync())
            {
                while (await this.reader.ReadAsync())
                {
                    datos.Empleados.Add(this.reader["APELLIDO"].ToString());
                }
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return datos;
        }

        public async Task<DatosEmpleado> GetDatosEmpleadoAsync(string apellido)
        {
            string sql = "SP_LOAD_DATOS_EMPLEADO";
            this.com.Parameters.AddWithValue("@apellido", apellido);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatosEmpleado empleado = new DatosEmpleado();
            while(await this.reader.ReadAsync())
            {
                string ap = this.reader["APELLIDO"].ToString();
                string oficio = this.reader["OFICIO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                empleado.Apellido = ap;
                empleado.Oficio = oficio;
                empleado.Salario = salario;
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return empleado;
        }

        public async Task<int> InsertarDepartamentoAsync(int id, string nombreDepartamento, string loc)
        {
            string sql = "SP_INSERT_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombreDepartamento);
            this.com.Parameters.AddWithValue("@localidad", loc);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

        public async Task<int> UpdateEmpleadoAsync(string apellido, string nuevoApellido, string oficio, int salario)
        {
            string sql = "SP_UPDATE_EMPLEADO";
            this.com.Parameters.Clear();
            this.com.Parameters.AddWithValue("@apellido", apellido);
            this.com.Parameters.AddWithValue("@nuevoApellido", nuevoApellido);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.Parameters.AddWithValue("@salario", salario);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

    }
}
