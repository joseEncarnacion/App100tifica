using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class CNusuario
    {
        CDusuario usuario = new CDusuario();

        public bool validarUsuario(UsuarioMant user)
        {
            bool respuesta = true;

            if (user.UsuarioE == string.Empty)
            {
                MessageBox.Show("Usuario Requerido");
                respuesta = false;
            }
            if (user.passE == string.Empty)
            {
                MessageBox.Show("Password Requerido");
                respuesta = false;
            }

            return respuesta;
        }

        public DataTable NEBuscarUsuario(UsuarioMant US)
        {
            return usuario.Datos_Listar(US);
        }
    }
}
