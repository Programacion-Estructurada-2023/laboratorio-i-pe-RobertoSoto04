using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Mi auto evaluacion es un 8, debido a que no se manejar muy bien la estetica de los terminales e es un poco desordenada la informacion
            //DECLARACION DE VARIABLES TIPO TEXTO


            string? departamento="";
            string? municipio="";
            string? ciudad="";

            string? coloniadondevive="Barrio San Pedro";
            string? colordecasa="Azul";

            //DECLARACION DE VARIABLES TIPO ENTERA

            int aniosderesidencia=0;

            int edadactual=0;

            //DECLARACION DE VARIABLES TIPO DATE TIME

            DateTime fechadenacimiento = new DateTime (2004, 2, 24, 0, 2, 0);

            DateTime fechaactual = DateTime.Now;

             Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("\n------Capturando datos de tipo texto------");
            Console.WriteLine("Ingrese el departamento >> ");
            departamento=Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n-----------\n");
            Console.WriteLine("Ingrese el municipio >> ");
            municipio=Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n-----------\n");
            Console.WriteLine("Ingrese la ciudad >> ");
            ciudad=Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n------Fin de captura de datos de tipo texto-----\n");

            Console.WriteLine("\n------Capturando datos de tipo entero------\n");
            Console.WriteLine("Ingrese cuantos años reside en la residencia >> ");
            aniosderesidencia=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n-----------\n");
            Console.WriteLine("Ingrese cuantos años tiene actualmente >> ");
            edadactual=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n-----------\n");
            Console.WriteLine("\n------Fin de captura de datos de tipo enteros------\n");

            //FUNCIONES

            

            string? colormayuscula=colordecasa.ToUpper();

            string? textocontatenado= "Usted vive en " + ciudad + " en el municipio de " + colormayuscula;

            int longitud1= coloniadondevive.Length;

            int longitud2= colordecasa.Length;

            string fechaformateada= fechadenacimiento.ToString(" dd/MM/yyyy");

            DateTime suma2semanas1= fechadenacimiento.AddDays(14);

            DateTime suma2semanas2= fechaactual.AddDays(14);

            //IMPRESION

            Console.WriteLine("***************************************************************************\n\n");
            Console.WriteLine("\n-----IMPRESION DE DATOS DE TEXTO------");
            Console.WriteLine("\n TEXTO CONCATENADO >> " + textocontatenado + " " + municipio);
            Console.WriteLine("\n LUGAR ESPECIFICO vive en la colonia>> " + coloniadondevive + " " + " en una casa de color " + ">>" + colordecasa);
            Console.WriteLine("\n LA LONGITUD DE LA COLONIA DONDE VIVE ES >> " + longitud1 + " Y LA DEL COLOR DE LA CASA ES " + " >>" + longitud2);
            Console.WriteLine("\n El color de casa en mayusculas" + colormayuscula);
            Console.WriteLine("***************************************************************************\n\n");
            Console.WriteLine("\n-----IMPRESION DE DATOS DE ENTERO------");
            Console.WriteLine("\n LA CANTIDAD DE AÑOS QUE LLEVA RESIDIENDO ES DE >> " + aniosderesidencia);
            Console.WriteLine("\n Y USTED TIENE >> " + edadactual + " AÑOS");
            Console.WriteLine("***************************************************************************\n");


            Console.WriteLine("\n RESULTADO COMPARACION ENTRE LA VARIABLE DEPARTAMENTO(1) Y LA VARIABLE CIUDAD(2) ");
            int resultadoComparacion = string.Compare(departamento, ciudad);

            if (resultadoComparacion < 0)
            {
                Console.WriteLine("La cadena1 es menor que la cadena2.");
            }
            else if (resultadoComparacion > 0)
            {
                Console.WriteLine("La cadena1 es mayor que la cadena2.");
            }
            else
            {
                Console.WriteLine("Las cadenas son iguales. \n");
            }

            Console.WriteLine("***************************************************************************\n");
            Console.WriteLine("***************************************************************************\n\n");
            Console.WriteLine("\n-----IMPRESION DE DATOS DE DATOS DE FECHAS------");
            Console.WriteLine("\n La fecha actual es >> " + fechaactual);
            Console.WriteLine("\n Su fecha de nacimiento es >> " + fechadenacimiento);
            Console.WriteLine("\n Su fecha de nacimiento con una suma de dos semanas es >> " + suma2semanas1);
            Console.WriteLine("\n La fecha actual con una suma de dos semanas es >> " + suma2semanas2);
            Console.WriteLine("\n La fecha formateada es >> " + fechaformateada);
            Console.WriteLine("\n------------A CONTINUACION UNA COMPARACION DE AÑOS ENTRE LA FECHA ACTUAL Y LA FECHA DE NACIMIENTO-----------\n");
            TimeSpan diferencia = fechaactual.Date - fechadenacimiento.Date;

            if (Math.Abs(diferencia.TotalDays) < 1)
            {
                Console.WriteLine("\n Las fechas son iguales (dentro de un margen de 1 día).");
            }
            else if (diferencia.TotalDays < 0)
            {
                Console.WriteLine("\n la fecha actual es anterior a fecha de nacimiento.");
            }
            else
            {
                Console.WriteLine("\n La fecha actual es posterior a la fecha de nacimiento.");
            }

            Console.WriteLine("******************************--FIN--**********************************\n");










        }
    }
}
