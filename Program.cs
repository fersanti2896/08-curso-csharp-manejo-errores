

using ManejoErrores.Clase;
using ManejoErrores.Debug;
using System.Diagnostics;

Console.WriteLine("¡DEBUGGING Y MANEJO DE ERRORES!");

var msgConsola = new TextWriterTraceListener(System.Console.Out);
var msgPersonalizado = new TextWriterTraceListener(new DebugPersonalizado());
Trace.Listeners.Add(msgConsola);    
Trace.Listeners.Add(msgPersonalizado);

Debug.WriteLine("Mensaje de debug");

sumar(4, 2);

int sumar(int a, int b) { 
    int c = a + b;
    c++;
    return c;
}

procesar(25, "Fer Santi");

/* Valores de Variables Locales */
void procesar(int a, string nombre) {
    var tupla = (a, nombre);
    a = 3;
    int b = a + 23;
    b -= 5;
    int[] num = { 1, 2, 3 };
}

/* Ventana Call Stack */
ClaseA.procesarA();