using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main()
    {

        Random random = new Random();


        int numeroSecreto = random.Next(1, 101);

        int palpite = 0;


        Console.WriteLine("Bem-vindo ao jogo da adivinhação!");
        Console.WriteLine("Deseja jogar? ");
        string resposta = Console.ReadLine()!;
        if (resposta != "sim" && resposta != "s" && resposta != "SIM" && resposta != "Começar" && resposta != "COMEÇAR" && resposta != "go" && resposta != "GO" && resposta != "ir" )
        {
            Console.WriteLine("Uma pena ");
        }
        else
        {
          Console.WriteLine("Digite um número entre 1 e 100 ");


            while (palpite != numeroSecreto)
            {
                Console.Write("Digite seu palpite: ");
                string entrada = Console.ReadLine()!;


                if (int.TryParse(entrada, out palpite))
                {


                    if (palpite < numeroSecreto)
                    {
                        Console.WriteLine("Muito baixo! Tente novamente");
                    }
                    else if (palpite > numeroSecreto)
                    {
                        Console.WriteLine("Muito alto! Tente novamente");
                    }
                    else
                    {
                        Console.WriteLine("Parabéns! Você adivinhou o número!");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido");
                }
            }
        }
    }
}
