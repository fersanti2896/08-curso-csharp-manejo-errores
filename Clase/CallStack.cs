using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoErrores.Clase {
    internal class ClaseA {
        public static void procesarA() {
            ClaseB.procesarB();
        }
    }

    internal class ClaseB {
        public static void procesarB() {
            ClaseC.procesarC();
        }
    }

    internal class ClaseC {
        public static void procesarC() {
            try {
                throw new FileNotFoundException("El archivo no ha sido encontrado");
            } catch (FileNotFoundException ex) {
                Console.WriteLine("Procesando la excepción");
                throw;
            }
        }
    }
}
