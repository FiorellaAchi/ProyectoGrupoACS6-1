using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoGrupoA_CS
{
    internal class CredencialesIncorrectasException : Exception
    {
        public CredencialesIncorrectasException(string message) : base(message)
        {
        }
    }

   

    internal class Excepciones
    {
        public Excepciones()
        {

        }

        public void ProblemasLogeo()
        {
            throw new CredencialesIncorrectasException("Usuario o contraseña incorrectos");
        }

        
    }
}
