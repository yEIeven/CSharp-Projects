using System;

namespace migsplaygroud
{



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha outro número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha uma operação: 1 para soma; 2 para subtração; 3 para divisão; 4 para multiplicação. ");
            string operação = Console.ReadLine()!;


            switch (operação)
            {
                case "1":
                    Console.WriteLine("A soma dos seus números é: " + (numero1 + numero2));
                    break;

                case "2":
                    Console.WriteLine("A subtração dos seus números é: " + (numero1 - numero2));
                    break;
                case "3":
                    {
                        if (numero2 <= 0)
                        {
                            Console.WriteLine("Divisão por 0 não existe.");
                            break;


                        }
                        else
                        {

                            Console.WriteLine("A divisão dos seus números é: " + (numero1 / numero2));
                            break;
                        }
                    }

                case "4":
                    Console.WriteLine("A multiplicação dos seus números é: " + (numero1 * numero2));
                    break;

                  
            }


        }
    }
}

