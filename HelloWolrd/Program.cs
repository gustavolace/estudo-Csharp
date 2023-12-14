using System;

namespace HelloWolrd
{
    internal class Program
    {

        static string myname = "Gustavo Lacerda";
                                
        enum cores {
        Azul, Verde, Preto, Laranja
        }
        enum opcoes { 
        C = 1,
        R,
        U,
        D,
        }

        static void Main(string[] args)
        {
            while (true)
            {
            Exibir();
            }

            int[] numbers = { 1, 2, 3, 4, 5 };
            Array.ForEach(numbers, x =>
            {
                Console.WriteLine(x * 2); 
            });
            foreach (int x in numbers)
            {

            }



            string hello = "Hello World";
            dynamic world = "World";
            if (!string.IsNullOrEmpty(hello))
            {
                hello = "3";
            }

            Console.WriteLine(hello);
            int nome = int.Parse(Console.ReadLine());
            Console.WriteLine(hello + nome);

            string[] array = new string[5] {
            "", "", "", "", ""
            };

            int[] valores = {
                1,
                2,
            };

            switch (array[1]) {
                case "":
                    Console.WriteLine("");
                    break;
                default: Console.WriteLine(""); break;
            }


            cores valor = cores.Azul;
            Console.WriteLine((int)valor);
            Console.WriteLine((cores)2);

            while (true)
            {
            int preco = Math.Abs(int.Parse(Console.ReadLine())); 
            var valorFinal = GerarProco(preco);
                Console.WriteLine(valorFinal);
            }



            Console.ReadLine();
        }

        static void Exibir()
        { 
            Console.WriteLine("Selectione uma das opções: " );
            Console.WriteLine("1- Create\n2- Read\n3- Update\n4- Delete");
            int index = int.Parse(Console.ReadLine());
            switch ((opcoes)index)
            {
                case opcoes.C:
                    Console.WriteLine("Você selecionou: " + (opcoes)1);
                    break;
                case opcoes.R:
                    Console.WriteLine("Você selecionou: " + (opcoes)2);
                    break;
                case opcoes.U:
                    Console.WriteLine("Você selecionou: " + (opcoes)3);
                    break;
                case opcoes.D:
                    Console.WriteLine("Você selecionou: " + (opcoes)4);
                    break;
                default:
                    Console.WriteLine("Selecione um número válido");
                    break;
            }

        }

        static float GerarProco(float preco)
        {
            float valorFinal = preco + (0.2f * preco);

            return valorFinal;
        }
    }
}
