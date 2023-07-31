using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones
{
    public class UsuarioNoExiste
    {
        public UsuarioNoExiste(String mensaje) : base("El usuario no existe")
        {
            throw new UsuarioNoExistenteException("El usuario no existe");
        }

    }
}
