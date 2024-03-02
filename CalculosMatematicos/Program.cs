using System.Drawing;

namespace CalculosMatematicos
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool salir = false, esNumero = true;
           
            int op;
            do
            {
                
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Salir");
                string n = Console.ReadLine();
                esNumero = int.TryParse(n, out op);
                   if(esNumero == false)
                {
                    Console.WriteLine("numero no valido");
                }
                    
                switch (op)
                {
                    case 1:
                        calculos.menu();
                        Console.WriteLine($"el resultado de la suma entre {calculos.num1} y {calculos.num2} es: {calculos.Suma(calculos.num1, calculos.num2)}");
                        
                        break;
                    case 2:
                        calculos.menu();
                        Console.WriteLine($"el resultado de la resta entre {calculos.num1} y {calculos.num2}es: {calculos.Resta(calculos.num1,calculos.num2)}");
                        
                        break;
                    case 3:
                        calculos.menu();
                        Console.WriteLine($"el resultado de la multiplicacion entre {calculos.num1} y {calculos.num2}es: {calculos.Multi(calculos.num1,calculos.num2)}");
                        
                        break;
                    case 4:
                        calculos.menu();
                        if (calculos.num2 == 0)
                        {
                            calculos.num2 = calculos.validacion(calculos.num2);
                        }
                        Console.WriteLine($"el resultado de la division entre {calculos.num1} y {calculos.num2} es: {calculos.Divi(calculos.num1,calculos.num2)}");
                        
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar el programa");
                        salir = true;
                        break;
                }
            } while (!salir);
        }
    }
}