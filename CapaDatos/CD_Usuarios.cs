using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;    
using System.Data;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<Usuario> Listar() { 
            List<Usuario> lista = new List<Usuario>();
          
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    string query = "select IdUsuario,Nombre,Apellido,Correo,Contraseña,Restablecer, TipoUsuario,FechaRegistro,Activo from Usuarios";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Contraseña = dr["Contraseña"].ToString(),
                                Restablecer = dr["Restablecer"].ToString(),
                                TipoUsuario = dr["TipoUsuario"].ToString(),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                                Activo = Convert.ToBoolean(dr["Activo"])
                            }); 
                        }
                    }   

                }
               
            }
            catch 
            {
                lista = new List<Usuario>();
            }
            return lista;
        }
    }
}
