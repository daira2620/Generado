using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace Generado
{
    public class Lenguaje : Sintaxis
    {
        public Lenguaje()
        {
        }
        public Lenguaje(string nombre) : base(nombre)
        {
        }
        public void Printf()
        {
            match("printf");
            match("(");
            match("cadena");
            match(")");
            match(";");
        }
        public void A()
        {
            match("a");
            match("b");
            Printf();
        }
    }
}
