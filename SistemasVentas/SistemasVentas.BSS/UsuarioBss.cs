using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class UsuarioBss
    {
        UsuarioDal dal = new UsuarioDal();
        public DataTable ListarUsuarioBss()
        {
            return dal.ListarUsuarioDal();
        }
        public string LoginUsuariosBss(string user, string contraseña)
        {
            return dal.LoginUsuariosDal(user, contraseña);
        }
        public int ObtenerUsuarioIdPorNombreBss(string nombre)
        {
            return dal.ObtenerUsuarioIdPorNombreDal(nombre);
        }
        public DataTable UsuarioDatosBss()
        {
            return dal.UsuarioDatosDal();
        }
        public int InsertarUsuarioBss(Usuario usuario)
        {
           return dal.InsertarUsuarioDal(usuario);
        }
        public Usuario ObtenerUsuarioIdBss(int id)
        {
            return dal.ObtenerUsuarioIdDal(id);
        }
        public void EditarUsuarioBss(Usuario p)
        {
            dal.EditarUsuarioDal(p);
        }
        public void EliminarUsuarioBss(int id)
        {
            dal.EliminarUsuarioDal(id);
        }
    }
}
