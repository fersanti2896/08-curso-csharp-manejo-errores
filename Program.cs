

using ManejoErrores.Debug;
using System.Diagnostics;

Console.WriteLine("¡DEBUGGING Y MANEJO DE ERRORES!");

var msgConsola = new TextWriterTraceListener(System.Console.Out);
var msgPersonalizado = new TextWriterTraceListener(new DebugPersonalizado());
Trace.Listeners.Add(msgConsola);    
Trace.Listeners.Add(msgPersonalizado);

Debug.WriteLine("Mensaje de debug");
