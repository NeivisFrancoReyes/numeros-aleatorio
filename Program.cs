using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaLINQ
{
    class Program
    {
        static bool lista(int numero)
        {
            return numero!=0;
        }
        static void Main(string[] args)
        {
            

            List<Int32> ListaNumero = new List<Int32> { };
            List<Int32> ListaNumCuadrados = new List<Int32> { };
            List<Int32> ListaNumPrimos = new List<Int32> { };
            List<Int32> ListaNumUnicos = new List<Int32> { };

            Random aleato = new Random();

            
            int suma = 0, cuadrado = 0, promedio = 0, contador = 0, primo = 0,
                mayores =0, pares=0, contador2=0, impares=0, unicos=0, residuo=0, x, y;

            Console.WriteLine("*********LISTA DE NÚMEROS ALEATORIOS*************");
            for (int i = 0; i < 50; i++)
            {
                ListaNumero.Add(aleato.Next(0, 100));
            }
            
            var n = from l in ListaNumero where lista(l) select l;
            var c = from m in ListaNumero where lista(1) select m;

            foreach (var item in n)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("****** NÚMEROS PRIMO DE LA LISTA DE NÚMEROS ALEATORIOS******");
            foreach (var item in n)
            {
                x = 2;
                y = 0;
                while (((x < item) && (y == 0)))
                {
                    residuo = item % x;
                    {
                        if ((residuo == 0))
                        {
                            y = 1;
                        }
                        else
                        {
                            x++;
                        }

                    }
                }
                if ((y == 0))
                {
                   
                    Console.WriteLine(item);
                }
                
            }


            foreach (var item in n)
            {
                suma = ListaNumero.Sum();
            }
            Console.WriteLine("***********SUMA TOTAL DE LA LISTA DE NÚMEROS ALEATORIOS**************");
            Console.WriteLine("LA SUMA ES: "+suma);


            Console.WriteLine("******* LISTA DEL CUADRADO DE CADA NÚMERO ALEATORIO*******");
            foreach (var item in n)
            {
                cuadrado = item * item;
                ListaNumCuadrados.Add(cuadrado);
                Console.WriteLine(cuadrado);
            }

            Console.WriteLine("************NUEVA LISTA DE NÚMEROS PRIMOS*************");
            foreach (var item in n )
            {
                x = 2;
                y = 0;
                while (((x<item)&&(y==0)))
                {
                    residuo = item % x;
                    if ((residuo==0))
                    {
                        y = 1;
                    }
                    else
                    {
                        x++;
                    }

                }
                if ((y==0))
                {
                    ListaNumPrimos.Add(item);
                    Console.WriteLine(item);
                }
               
            }

            foreach (var item in n)
            {
                if (item > 50)
                {
                    mayores = mayores + item;
                    contador++;
                }
            } promedio = mayores / contador;
                Console.WriteLine("********EL PROMEDIO DE TODOS LOS NUMEROS MAYORES A 50***********");
                Console.WriteLine("ES DE: "+promedio);
            

            foreach (var item in n)
            {
                if (item % 2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }
            }
            Console.WriteLine("**********NÚMEROS PARES E IMPARES*******");
            Console.WriteLine("HAY "+ pares+"  NUMEROS PARES EN LA LISTA");
            Console.WriteLine("HAY " + impares +"  NUMEROS IMPARES EN LA LISTA ");

            Console.WriteLine("*******************CANTIDAD DE VECES REPETIDO**********************");

            foreach (var item in n)
            {
                if (item == item)
                {

                    contador2++;
                }
            }
            Console.WriteLine("CONTADOR ES: " + contador2);

            
            Console.WriteLine("*******************LISTA DESCENDENTE**********************");
            (from l in ListaNumero where l > 0 orderby l descending select l).ToList().ForEach(i => Console.WriteLine(i)); ;


            
            Console.WriteLine("*******************NÚMEROS ÚNICOS**********************");
            for (int i = 0; i < ListaNumero.Count; i++)
            {
                if (!(ListaNumUnicos.Contains(ListaNumero[i])))
                {
                    ListaNumUnicos.Add(ListaNumero[i]);
                }
            }
            (from l in ListaNumero where l > 0 orderby l ascending select l).ToList().ForEach(i => Console.WriteLine(i)); ;


            Console.WriteLine("****************SUMA NÚMEROS ÚNICOS*******************");
            for (int i = 0; i < ListaNumero.Count; i++)
            {
                if (!(ListaNumUnicos.Contains(ListaNumero[i])))
                {
                    ListaNumUnicos.Add(ListaNumero[i]);
                }
            }
            foreach (var item in ListaNumUnicos)
            {
                unicos = unicos + item;
            }
            Console.WriteLine("SUMA DE NÚMEROS ÚNICOS ES: " + unicos);
            Console.ReadKey();
        }
       
    }
}
