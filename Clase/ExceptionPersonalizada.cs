using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoErrores.Clase {
    internal class ExceptionPersonalizada : Exception {
        public ExceptionPersonalizada(TipoError tipoError): base("Esta es una excepción personalizada") {
            TipoError = tipoError;
        }

        public ExceptionPersonalizada(TipoError tipoError, string? msg): base(msg) {
            TipoError = tipoError;
        }

        public TipoError TipoError { get; }
    }

    internal enum TipoError { 
        ErrorCliente,
        ErrorServidor,
        ErrorNoEncontrado
    }
}
