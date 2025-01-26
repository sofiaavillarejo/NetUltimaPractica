using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using NetUltimaPractica.Helpers;
using NetUltimaPractica.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

#region STORED PROCEDURES
    //create procedure SP_EMPLE_DPTO (@nombre nvarchar(50))
    //as
    // declare @idDpto int
    // select @idDpto = DEPT_NO from DEPT where DNOMBRE=@nombre
    // select * from EMP where DEPT_NO=@idDpto
    //go

    //create procedure SP_ADD_DPTO (@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
    //as
    //	insert into DEPT values (@numero, @nombre, @localidad)
    //go

    //create procedure SP_DATAEMP (@apellido nvarchar(50))
    //as
	   // select * from EMP where APELLIDO=@apellido
    //go

#endregion
namespace NetUltimaPractica.Repositories
{
    public class RepositoryCrud
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryCrud()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = " select DNOMBRE from DEPT";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> dataDpto = new List<string>();
            while(await this.reader.ReadAsync())
            {
                string nombreDpto = this.reader["DNOMBRE"].ToString();
                dataDpto.Add(nombreDpto);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return dataDpto;
        }

        public async Task <Departamento> GetDatosDptosAsync(string nombre)
        {
            string sql = "SP_DATA_DPTOS";
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            Departamento dpto = new Departamento();
            while (await this.reader.ReadAsync())
            {
                int idDpto = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombreDpto = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                dpto.DptoNum = idDpto;
                dpto.Nombre = nombreDpto;
                dpto.Localidad = localidad;
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return dpto;
        }

        public async Task <List<Empleado>> GetEmpleadosAsync(string nombre)
        {
            string sql = "SP_EMPLE_DPTO";
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Empleado> empleados = new List<Empleado>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string oficio = this.reader["OFICIO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                Empleado emp = new Empleado();
                emp.Apellido = apellido;
                emp.Oficio = oficio;
                emp.Salario = salario;
                empleados.Add(emp);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task PostDepartamentoAsync(int numero, string nombre, string localidad)
        {
            string sql = "SP_ADD_DPTO";
            this.com.Parameters.AddWithValue("@numero", numero);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task UpdateDataEmpleAsync(string apellidoOriginal, string nuevoApellido, string oficio, int salario)
        {
            string sql = "SP_DATAEMP";
            this.com.Parameters.AddWithValue("@apellidoOriginal", apellidoOriginal);
            this.com.Parameters.AddWithValue("@nuevoApellido", nuevoApellido);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.Parameters.AddWithValue("@salario", salario);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task DeleteEmpleadoAsync(string apellido)
        {
            string sql = "SP_DELETE_EMP";
            this.com.Parameters.AddWithValue("@apellido", apellido);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
