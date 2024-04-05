using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDal
    {

        public DataTable ListarUsuarioRolXDal(string rol, string user)
        {
            string consulta = "SELECT    USUARIO.IDUSUARIO,USUARIOROL.IDUSUARIOROL,PERSONA.NOMBRE, PERSONA.APELLIDO, USUARIO.NOMBREUSER, USUARIO.CONTRASEÑA, USUARIO.FECHAREG, ROL.NOMBRE AS Expr1, ROL.ESTADO, USUARIOROL.FECHAASIGNA\r\nFROM         PERSONA INNER JOIN\r\n                      USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA INNER JOIN\r\n                      USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN\r\n                      ROL ON USUARIOROL.IDROL = ROL.IDROL  WHERE ROL.NOMBRE LIKE '" + rol + "%' AND USUARIO.NOMBREUSER LIKE '" + user + "%'";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "SELECT    USUARIOROL.IDUSUARIOROL, USUARIO.NOMBREUSER, (ROL.NOMBRE)ROL, USUARIOROL.FECHAASIGNA, USUARIOROL.ESTADO " +
                "FROM         USUARIO INNER JOIN                     USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN" +
                "                      ROL ON USUARIOROL.IDROL = ROL.IDROL";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public string UsuariosActivosInactivosDal(string opcion)
        {
            string consulta = "SELECT    count(USUARIO.IDUSUARIO)CANTIDAD\r\nFROM         USUARIO INNER JOIN\r\n                      USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN\r\n                      ROL ON USUARIOROL.IDROL = ROL.IDROL\r\nWHERE USUARIOROL.ESTADO = '"+opcion+"'";
            
            
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                return tabla.Rows[0]["cantidad"].ToString();
            }
            else
            {
                return "0";
            }
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuariorol)
        {
            string consulta = "insert into usuariorol values (" + usuariorol.IdUsuario + ","
                                                          + usuariorol.IdRol + ",' "
                                                          + usuariorol.FechaAsigna + "','Activo')";
            conexion.Ejecutar(consulta);

        }
        UsuarioRol p = new UsuarioRol();
        public UsuarioRol ObtenerUsuarioRolIdDal(int id)
        {
            string consulta = "select * from usuariorol where idusuariorol=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                
                p.IdUsuarioRol = Convert.ToInt32(tabla.Rows[0]["idusuariorol"]);
                p.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                p.IdRol = Convert.ToInt32(tabla.Rows[0]["idrol"]);
                p.FechaAsigna = Convert.ToDateTime(tabla.Rows[0]["fechaasigna"]);
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarUsuarioRolDal(UsuarioRol p)
        {
            string consulta = "update usuariorol set idusuario=" + p.IdUsuario + "," +
                                                        "idrol=" + p.IdRol + "," +
                                                        "fechaasigna='" + p.FechaAsigna + "', " +
                                                        "estado='" + p.Estado + "' " +
                                                "where idusuariorol=" + p.IdUsuarioRol;
            conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioRolDal(int id)
        {
            string consulta = "delete from usuariorol where idusuariorol=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
