namespace PracticandoOUTyREF
{
    internal class Program
    {
        static int variableGlobal = 2;
        static void Main(string[] args)
        {
            int miVariable = 5;
            Console.WriteLine($"La variable tiene un valor de {miVariable}");
            Incrementar(miVariable);

            //aqui vamos a observar si el valor de la variable "miVariable" incrementa a 6...
            Console.WriteLine($"la variable ahora tiene un valor de {miVariable}");
            //podemos observar que vuelve a imprimir 5, ya que el metodo no afecta ala variable porque
            //la variable esta definida en este bloque... no es variable global..
            //aparte los tipos de datos basicos, int, double, string, etc, son de tipo de valor y no de referencia
            //esto quiere decir que cuando pasamos miVariable al metodo incrementar, en realidad le estamos pasando una copia de la variable..
            //es por eso que cuando incrementamos la variable en el metodo Incrementar, en realidad incrementa la copia, pero la variable original no...
            //por eso nos vuelve a imprimir el mismo valor.


            //Esta es una forma si queremos cambiar el valor original de la variable...
            //Declaramos la variable de forma global, es decir, declaramos la variable como propiedad de la clase..
            //para que este al alcance de todos los metodos..
            Console.WriteLine($"\nValor de la variable global {variableGlobal}");
            Incremento();
            //podemos observar que si incremento el valor porque le pasamos la variable original y no una copia
            Console.WriteLine($"Valor de la variable global despues del incremento {variableGlobal}");

            //palabra clave REF....
            //Si queremos por asi decirlo pasar la variable original y no la copia sin tener que hacer la variable global
            //podemos usar la palabra clave ref...
            //Esto lo que hara es pasar la referencia, el apuntado a la memoria de la variable al metodo
            //pasando asi la variable original y no la copia..
            //OJO ES NECESARIO QUE LA VARIABLE ESTE INICIALIZADA CON ALGUN VALOR

            int variable1 = 1;
            Console.WriteLine($"\nValor de la variable 'variable1': {variable1}");
            IncrementoPorReferencia(ref variable1);
            Console.WriteLine($"Valor de la variable 'variable1' despues del incremento por referencia: {variable1}");

            //SIN INCIALIZAR NOS DARA ERROR POR ESTA COMENTADO.
            //podemos observar que aqui nos dara error porque la variable no esta inicializada..
            //para la palabra clave ref es obligatorio que la variable este inicializada.....
            //int variable01;
            //Console.WriteLine($"\nValor de la variable 'variable01': no esta inicializada, no tiene valor.");
            //IncrementoPorReferencia(ref variable01);
            //Console.WriteLine($"Valor de la variable 'variable01' despues del incremento por referencia: {variable1}");

            //palabra clave OUT...
            //a diferencia de ref, no necesitamos tener la variable inicializada...
            int resultado;
            //ya que el metodo es el que inicializara la variable con algun valor
            //OJO OJO pero igual si queremos podemos incializarla en cero o con algun otro valor que desees.
            //ejemplo de una multiplicacion..
            Multiplicacion(2, 2, out resultado);
            Console.WriteLine("\nla variable 'resultado' antes no tenia valor...");
            Console.WriteLine($"Ahora tiene un valor de {resultado} ya que la pasamos por el metodo de Multiplicacion con la palabra clave out");

            //Ahora inicializando la variable. podemos ver que igual funciona..
            int result = 0;
            Console.WriteLine($"\nla variable 'result' tiene un valor de {result}");
            Multiplicacion(5,5, out result);
            Console.WriteLine($"Ahora tiene un valor de {resultado} ya que la pasamos por el metodo de Multiplicacion con la palabra clave out");



        }
        static void Incrementar(int valor)
        {
            valor++;
        }

        static void Incremento()
        {
            //Esto nos dara error porque la variable "miVariable" no es de alcance global, esta declarada en un bloque de codigo, es decir en el metodo main, no en la clase program
            //miVariable++;

            //Esto no nos dara error porque la variable si es de alcance global, ya que esta declarada en la clase program y no en el metodo main
            variableGlobal++;
        }

        static void IncrementoPorReferencia(ref int valor)
        {
            valor++;
        }

        static void Multiplicacion(int n1, int n2, out int total)
        {
            total = n1 * n2;
        }


    }
}
