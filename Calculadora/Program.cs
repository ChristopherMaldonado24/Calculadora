namespace Calculadora
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a el sistema de calculo");
            Console.WriteLine();

            Console.WriteLine("ingrese el primer numero a utilizar");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el operador (+, -, *, /): ");
            char Operador = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("ingrese el segundo numero");
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine() ;

            double Total;

            switch (Operador)
            {
                case '+':
                    Total = N1 + N2;
                    break;
                case '-':
                    Total = N1 - N2;
                    break;
                case '*':
                    Total = N1 * N2;
                    break;
                case '/':
                    // Manejo de división por cero
                    if (N2 == 0)
                    {
                        Console.WriteLine("Error: División por cero no permitida.");
                        return;
                    }
                    Total = N1 / N2;
                    break;
                default:
                    Console.WriteLine("Operador no válido.");
                    return;
            }
            Console.WriteLine($" El resultado de {N1} {Operador} {N2} es : {Total} ");
            Console.ReadKey();
        }
       
    }

} 