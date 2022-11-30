using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoErrores.Clase {
    internal class ExceptionPersonalizada : Exception {
        public ExceptionPersonalizada(): base("Esta es una excepción personalizada") {

        }

        public ExceptionPersonalizada(string? msg): base(msg) {

        }
    }
}
