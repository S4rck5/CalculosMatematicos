namespace CalculosMatematicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            int num1 = 0, num2 = 0;
            while (!salir)
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                //Console.WriteLine("3. Multiplicacion");
                //Console.WriteLine("4. Division");
                Console.WriteLine("3. Salir");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Proporciona el numero 1:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Proporciona el numero 2:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"el resultado de la suma entre {num1} y {num2} es: {calculos.Suma(num1, num2)}");

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Proporciona el numero 1:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Proporciona el numero 2:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"el resultado de la resta entre {num1} y {num2}es: {calculos.Resta(num1, num2)}");

                        break;
                    case 3:
                        Console.WriteLine("Gracias por usar el programa");
                        salir = true;
                        break;
                }
            }
        }
    }
}//agregar dividir y multiplicar y validaciones las mas comunes (validacion de que si se ingresa un string se pueda convertir en numero o no)
