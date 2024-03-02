using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosMatematicos
{
    internal class calculos
    {
        public static int num1;
        public static int num2;
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("Proporciona el numero 1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Proporciona el numero 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        public static int Suma(int num1,int num2){
            return num1 + num2;
        }
        public static int Resta(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multi(int num1,int num2)
        {
            return num1 * num2;
        }
        public static int Divi(int num1, int num2)
        {
            return num1 / num2;
        }
       public static int validacion(int num2)
        {
            do
            {
                Console.WriteLine("No puede ser cero");
                Console.WriteLine("Proporciona el numero 2:");
                num2 = int.Parse(Console.ReadLine());
            } while (num2 == 0);
            return num2;
        }
        
    }
}
