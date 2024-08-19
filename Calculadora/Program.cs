namespace Calculadora
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a el sistema de calculo");
            Console.WriteLine();

            Console.WriteLine("ingrese el primer numero a utilizar");
            double N1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seleccione la opcion qeu desea");
            Console.WriteLine();
            Console.WriteLine("1. Multiplicar");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("3. Dividir");
            Console.WriteLine("4. Restar");
            int Operador = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine();

            Console.WriteLine("ingrese el segundo numero");
            double N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine() ;

            double Total;

            if (Operador == 1)
            {
                double Multiplicacion = (N1 * N2);
                Console.WriteLine($"La Multiplicacion de {N1} y {N2} es : {Multiplicacion}");
            }
            if (Operador == 2)
            {
                double Suma = (N1 + N2);
                Console.WriteLine($"La Suma de {N1} y {N2} es : {Suma}");
            }
            if (Operador == 3)
            {
                if (N1 == 0)           
                {
                    Console.WriteLine("No es posible dividir entre cero");
                }
                else {
                    double Divicion = (N1 / N2);
                    Console.WriteLine($"La Divicion de {N1} y {N2} es : {Divicion}");
                }
            }
            if (Operador == 4)
            {
               
                double Resta = (N1 - N2);
                Console.WriteLine($"La Resta de {N1} y {N2} es : {Resta}");
            }

            Console.ReadKey();
        }
    }
} 