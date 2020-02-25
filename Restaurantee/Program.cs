using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantee
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fase 1

            float cantidad;
            int can, B500, B200, B100, B50, B20, B10, B5, M1;
            B500 = 0;
            B200 = 0;
            B100 = 0;
            B50 = 0;
            B20 = 0;
            B10 = 0;
            B5 = 0;
            M1 = 0;
            can = 0;

            string[] menu = new string[5];
            int[] preciototal = new int[5];
            int masComida;
            bool comidaExiste = false;
            bool keepdoing = true;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<String> lista  = new List<string>();

            // FASE 2

            for (int i = 0; i < menu.Length; i++)
            {

                Console.Write("Introduce un plato:");
                menu[i] = Console.ReadLine();

                Console.Write("Introduce el precio:");
                preciototal[i] = int.Parse(Console.ReadLine());


            }

            Console.WriteLine("el menu es el siguiente");

            for (int i = 0; i < menu.Length; i++)
            {
               
                Console.Write(menu[i] + " " + preciototal[i] + "€;" + "\n");
            }
            


            while (keepdoing)
            {
                Console.WriteLine("Escribe lo que quieres comer");
                lista.Add(Console.ReadLine());
                Console.Write("Quieres pedir mÃ¡s comida? (1:Si / 0:No): ");
                masComida = int.Parse(Console.ReadLine());

                if (masComida == 0)
                {
                    keepdoing = false;
                }
            }

            //FASE 3

            foreach (var item in lista)
            {
                for (int i = 0; i < menu.Length; i++) 
                {
                    if (item == menu[i]) 
                    {
                        can += preciototal[i];
                        comidaExiste = true;
                        

                    }
                    

                }


                if (!comidaExiste)
                {
                    Console.WriteLine("No tenemos este plato: " + item);
                }
                comidaExiste = false;


            }
            // FASE4
            string myString = can.ToString();
            cantidad = float.Parse(myString);
            Console.WriteLine("El precio total de tu comida es de: " + cantidad);

            if ((cantidad >= 100))
            {
                B100 = ((int)cantidad / 100);
                cantidad = cantidad - (B100 * 100);
            }
            if ((cantidad >= 50))
            {
                B50 = ((int)cantidad / 50);
                cantidad = cantidad - (B50 * 50);
            }
            if ((cantidad >= 20))
            {
                B20 = ((int)cantidad / 20);
                cantidad = cantidad - (B20 * 20);
            }
            if ((B10 >= 10))
            {
                B10 = ((int)cantidad / 10);
                cantidad = cantidad - (B10 * 10);
            }
            if ((cantidad >= 5))
            {
                B5 = ((int)cantidad / 5);
                cantidad = cantidad - (B5 * 5);
            }
            if ((cantidad >= 1))
            {
                M1 = ((int)cantidad / 1);
                cantidad = cantidad - (M1 * 1);
            }

            Console.WriteLine("Billetes de 100: " + B100);
            Console.WriteLine("Billetes de 50 : " + B50);
            Console.WriteLine("Billetes de 20 : " + B20);
            Console.WriteLine("Billetes de 10 : " + B10);
            Console.WriteLine("Billetes de 5 : " + B5);
            Console.WriteLine("Monedas de 1 : " + M1);


            Console.Read();

        }
    }
    
}
