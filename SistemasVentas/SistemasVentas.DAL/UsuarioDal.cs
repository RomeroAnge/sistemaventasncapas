using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDal
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "SELECT    USUARIO.IDUSUARIO, (PERSONA.NOMBRE+' '+PERSONA.APELLIDO)NOMBRECOMPLETO, USUARIO.NOMBREUSER, USUARIO.CONTRASEÑA, USUARIO.FECHAREG " +
                                "FROM         USUARIO INNER JOIN" +
                                "                      PERSONA ON USUARIO.IDPERSONA = PERSONA.IDPERSONA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable UsuarioDatosDal()
        {
            string consulta = "SELECT    USUARIO.IDUSUARIO, (PERSONA.NOMBRE+' '+PERSONA.APELLIDO)NOMBRECOMPLETO, USUARIO.NOMBREUSER, ROL.NOMBRE AS NOMBREROL, USUARIOROL.FECHAASIGNA\r\nFROM         PERSONA INNER JOIN\r\n                      USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA INNER JOIN\r\n                      USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN\r\n                      ROL ON USUARIOROL.IDROL = ROL.IDROL";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public string LoginUsuariosDal(string user, string contraseña)
        {
            string consulta = "SELECT    (USUARIOROL.ESTADO)ESTADO\r\nFROM         USUARIO INNER JOIN\r\n                      USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO\r\nwhere nombreuser = '"+user+"' and contraseña = '"+contraseña+"'";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            if (lista.Rows.Count>0)
            {
                return (lista.Rows[0]["estado"]).ToString(); ;
            }
            return "0";
        }
        public int ObtenerUsuarioIdPorNombreDal(string nombre)
        {
            string consulta = "SELECT idusuario FROM USUARIO where NOMBREUSER = '"+nombre+"'";
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");

                return   Convert.ToInt32(tabla.Rows[0]["idusuario"]);

        }
        public int InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into usuario values (" + usuario.IdPersona + ",'"
                                                          + usuario.NombreUser +"','"
                                                          + usuario.Contraseña +"','"
                                                          + usuario.FechaReg + "')";
            conexion.Ejecutar(consulta);
            string consulta2 = "select max(idusuario) from usuario";
            return conexion.EjecutarEscalar(consulta2);
        }
        Usuario p = new Usuario();
        public Usuario ObtenerUsuarioIdDal(int id)
        {
            string consulta = "select * from usuario where idusuario=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                p.NombreUser = tabla.Rows[0]["nombreuser"].ToString();
                p.Contraseña = tabla.Rows[0]["contraseña"].ToString();
                p.FechaReg = Convert.ToDateTime(tabla.Rows[0]["fechareg"]);
            }
            return p;
        }
        public void EditarUsuarioDal(Usuario p)
        {
            string consulta = "update usuario set nombreuser='" + p.NombreUser + "'," +
                                                        "contraseña='" + p.Contraseña+ "'," +
                                                        "fechareg='" + p.FechaReg + "' " +
                                                "where idusuario=" + p.IdUsuario;
            conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioDal(int id)
        {
            string consulta = "delete from usuario where idusuario=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
