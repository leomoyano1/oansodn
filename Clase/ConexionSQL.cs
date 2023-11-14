using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Agm_Tools
{
    class ConexionSQL
    {
        string StringConnection = "Data Source=DESKTOP-9PINCOE;Initial Catalog = DB_SISTEMA_IMPRENTA; Integrated Security = True; TrustServerCertificate=true";
        public bool Login(string usuario, string contraseña)
        {
            using (SqlConnection conexion = new SqlConnection(StringConnection))
            {
                string consulta = @"select count (*) FROM USUARIO WHERE NombreUs = @Usuario and Password = @Password";
                //int ROL = 0;
                string consultaRol = string.Empty;

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Password", contraseña);


                try
                {
                    conexion.Open();
                    int resultado = Convert.ToInt32(comando.ExecuteScalar());
                    if (resultado > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());  /*error en problema con la conexion*/
                }
                return false;
            }
        }

        public DataTable CargasTodos()
        {
            DataTable data = new DataTable();
            using (SqlConnection conexion = new SqlConnection(StringConnection))
            {
                string consulta = $"select Cuit, Apellido, Nombre, TipoConsumidor as 'Tipo consumidor', Direccion as 'Dirección', Telefono1 as 'Teléfono 1', Telefono2 as 'Teléfono 2', Estado from cliente;";
                SqlDataAdapter query = new SqlDataAdapter(consulta, conexion);

                try
                {
                    conexion.Open();
                    query.Fill(data);
                    return data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());  /*error en problema con la conexion*/
                }
                return null;

            }

        }
        
        public void Actualizar(string txtCuit, string txtApellido, string txtNOmbre, string txtTipocons, string txtdirec, string txtTel, string txtTel2, string txtEmail)
        {
            using (SqlConnection conexion = new SqlConnection(StringConnection))
            {
                string update = "update cliente set TipoConsumidor = @TipoCons, Direccion = @Direccion, Telefono1 = @Tel1, Telefono2 = @Tel2, Email = @email where Cuit = @Cuit;";

                SqlCommand updateCommand = new SqlCommand(update, conexion);

                updateCommand.Parameters.AddWithValue("@Cuit", txtCuit);
                updateCommand.Parameters.AddWithValue("@TipoCons", txtTipocons);
                updateCommand.Parameters.AddWithValue("@Direccion", txtdirec);
                updateCommand.Parameters.AddWithValue("@Tel1", txtTel);
                updateCommand.Parameters.AddWithValue("@Tel2", txtTel2);
                updateCommand.Parameters.AddWithValue("@email", txtEmail);

                try
                {
                    conexion.Open();
                    updateCommand.ExecuteNonQuery();
                }catch(SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        public DataTable Buscar(string Cuit)
        {
            DataTable data = new DataTable();
            using (SqlConnection conexion = new SqlConnection(StringConnection))
            {                
                  string consulta = $"select Cuit, Apellido, Nombre, TipoConsumidor as 'Tipo consumidor', Direccion as 'Dirección', Telefono1 as 'Teléfono 1', Telefono2 as 'Teléfono 2', Estado from cliente where Cuit = {Cuit}";
                SqlDataAdapter query = new SqlDataAdapter(consulta, conexion);

                try
                {
                    conexion.Open();
                    query.Fill(data);
                    return data;                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());  /*error en problema con la conexion*/
                }
                return null;
            }
        }    
        
        public void Registrar(string txtCuit, string txtApellido, string txtNOmbre, string txtTipocons, string txtdirec, string txtTel, string txtTel2, string txtEmail)
        {
            using (SqlConnection conexion = new SqlConnection(StringConnection))
            {
                string datos = @"insert into CLIENTE(Cuit, Apellido, Nombre, TipoConsumidor, Direccion, Telefono1, Telefono2, Email, Estado) values(@Cuit, @Apellido, @Nombre, @Tipo, @Dire, @Tel, @Tel2, @Email, 1)";
                SqlCommand insert = new SqlCommand(datos, conexion);

                insert.Parameters.AddWithValue("@Cuit", txtCuit);
                insert.Parameters.AddWithValue("@Apellido", txtApellido);
                insert.Parameters.AddWithValue("@Nombre", txtNOmbre);
                insert.Parameters.AddWithValue("@Tipo", txtTipocons);
                insert.Parameters.AddWithValue("@dire", txtdirec);
                insert.Parameters.AddWithValue("@Tel", txtTel);
                insert.Parameters.AddWithValue("@Tel2", txtTel2);
                insert.Parameters.AddWithValue("@Email", txtEmail); 

                try
                {
                    conexion.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Registro correcto.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());  /*error en problema con la conexion*/
                }
            }
        }

        public void Eliminar(string cuit)
        {
            using (SqlConnection conexion = new SqlConnection(StringConnection))
            {
                string insert = @"update cliente set estado = 0 where cuit = @Cuit";
                SqlCommand query = new SqlCommand(insert, conexion);
                query.Parameters.AddWithValue("@Cuit", cuit);
                
                try
                {
                    conexion.Open();
                    query.ExecuteNonQuery();
                    MessageBox.Show("Cliente ha sido eliminado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());  /*error en problema con la conexion*/
                }
            }
        }

    }

}
