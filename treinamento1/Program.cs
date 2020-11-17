using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamento1
{
    class Program
    {
        static float[] numeros = { 0, 0 };

        static void MenuInt()
        {
            Console.WriteLine(
                "#---------------------------#\n" +
                "| Os numeros são inteiros ? |\n" +
                "#---------------------------#\n" +
                "|          1- sim           |\n" +
                "|          2- não           |\n" +
                "#---------------------------#");
        }
        static void MenuCalc()
        {
            Console.WriteLine(
                "#-------------------------------#\n" +
                "|      Escolha uma opção:       |\n" +
                "#-------------------------------#\n" +
                "|       1- soma                 |\n" +
                "|       2- subtração            |\n" +
                "|       3- divisão              |\n" +
                "|       4- multiplicação        |\n" +
                "#-------------------------------#");
        }
        static void Menu()
        {
            Console.WriteLine(
                "#-------------------------------#\n" +
                "|          Calculadora          |\n" +
                "#-------------------------------#\n" +
                "|      1- Contas normais        |\n" +
                "|   2- Comparar dois numeros    |\n" +
                "|         3- Bhaskara           |\n" +
                "#-------------------------------#\n" +
                "|          0 - Sair             |\n" +
                "#-------------------------------#");
        }

        // Fim dos menus

        static void RecolheNum()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Digite o {0:D} numero: ",i+1);
                numeros[i] = float.Parse(Console.ReadLine());
            }
        }

        static void Calculo()
        {
            RecolheNum();
            MenuCalc();

            int resp = int.Parse(Console.ReadLine());
            if (resp == 1)
            {
                Console.WriteLine("Sua soma tem como resultado: {0:F}.\n",numeros[0] + numeros[1]);
            }
            else if (resp == 2)
            {
                Console.WriteLine("Sua subtração tem como resultado: {0:F}.\n", numeros[0] - numeros[1]);
            }
            else if (resp == 3)
            {
                Console.WriteLine("Sua divisão tem como resultado: {0:F}.\n", numeros[0] / numeros[1]);
            }
            else if (resp == 4)
            {
                Console.WriteLine("Sua multiplicação tem como resultado: {0:F}.\n", numeros[0] * numeros[1]);
            }
        }
        static void Compara()
        {
            MenuInt();
            int resp2 = int.Parse(Console.ReadLine());
            RecolheNum();

                // teste de maior numero
                if (numeros[0] > numeros[1])
                {
                    Console.WriteLine("\n{0:F} é maior que {1:F}.",numeros[0],numeros[1]);
                }
                else if (numeros[0] < numeros[1])
                {
                    Console.WriteLine("\n{0:F} é maior que {1:F}.", numeros[1], numeros[0]);
            }
                else if (numeros[0] == numeros[1])
                {
                    Console.WriteLine("\nO seus 2 numeros são iguais.");
                }
            if (resp2 == 1)
            {
                //impar ou par
                bool imparn1 = true, imparn2 = true;

                if (numeros[0] != 2)
                {
                    if ((numeros[0] % 2) == 0)
                    {
                        imparn1 = false;
                    }
                }
                else
                {
                    Console.WriteLine("{0:F} é o unico numero primo que é par !", numeros[0]);
                }

                if (numeros[1] != 2)
                {
                    if ((numeros[1] % 2) == 0)
                    {
                        imparn1 = false;
                    }
                }
                else
                {
                    Console.WriteLine("{0:F} é o unico numero primo que é par !", numeros[1]);
                }
                // numero é primo ou não

                if (imparn1 == true)
                {
                    for (int i = 2; i < numeros[0]; i++)
                    {
                        if ((numeros[0] % i) == 0)
                        {
                            Console.WriteLine("{0:F} não é um numero primo.", numeros[0]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("{0:F} é um numero primo.", numeros[0]);
                            break;
                        }
                    }
                }
                else if (numeros[0] != 2)
                {
                    Console.WriteLine("{0:F} não é um numero primo, pois é par e é maior que 2.", numeros[0]);
                }

                if (numeros[0] == numeros[1])
                {
                    return;
                }
                else
                {
                    if (imparn2 == true)
                    {
                        for (int i = 2; i < numeros[1]; i++)
                        {
                            if ((numeros[1] % i) == 0)
                            {
                                Console.WriteLine("{0:F} é um numero não primo.", numeros[1]);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("{0:F} é um numero primo.", numeros[1]);
                                break;
                            }
                        }
                    }
                    else if(numeros[1] != 2)
                    {
                        Console.WriteLine("{0:F} não é um numero primo, pois é par e é maior que 2.", numeros[1]);
                    }

                }
            }
        }
        static void Bhaskara()
        {
            Console.Write("digite o a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("digite o b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("digite o c: ");
            float c = float.Parse(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);
            double raiz = Math.Sqrt(delta);
            var x1 = ((-(b)) + raiz) / (2 * a);
            var x2 = ((-(b)) - raiz) / (2 * a);

            Console.WriteLine("\nValor de X': {0}", x1);
            Console.WriteLine("Valor de X'': {0}\n", x2);
        }
        
        static void Main(string[] args)
        {
            while(true)
            {
                Menu();

                int escolha = int.Parse(Console.ReadLine());
                if(escolha == 1)
                {
                    Calculo();
                }
                else if (escolha == 2)
                {
                    Compara();
                }
                else if (escolha == 3)
                {
                    Bhaskara();
                }
                else if (escolha == 0)
                {
                    break;
                }
            }
        }
    }
}
