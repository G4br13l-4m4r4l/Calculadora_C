using System;

namespace Calc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            
            Console.WriteLine("---------------------------------\n\tWelcome_tr4v3l3r\n---------------------------------\n");

            while (continuar)
            {
                double x = 0;
                double y = 0;
                double result = 0;
                int resp = 0;

                while (resp == 0)
                {
                    Console.WriteLine("Selecione o tipo de operação que deseja fazer:");
                    Console.WriteLine("(1-soma/2-subtração/3-multiplicação/4-divisão)");
                    resp = Convert.ToInt32(Console.ReadLine());
                    switch (resp)
                    {
                            case 1:
                                Console.Write("Digite o primeiro número: ");
                                x = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Digite o segundo número: ");
                                y = Convert.ToDouble(Console.ReadLine());

                                result = soma(x, y);
                                Console.WriteLine("Resultado: " + result + "\n");

                                break;
                            case 2:
                                Console.Write("Digite o primeiro número: ");
                                x = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Digite o segundo número: ");
                                y = Convert.ToDouble(Console.ReadLine());
                                
                                result = sub(x, y);
                                Console.WriteLine("Resultado: " + result + "\n");

                                break;
                            case 3:
                                Console.Write("Digite o primeiro número: ");
                                x = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Digite o segundo número: ");
                                y = Convert.ToDouble(Console.ReadLine());
                                
                                result = mult(x, y);
                                Console.WriteLine("Resultado: " + result + "\n");

                                break;
                            case 4:
                                Console.Write("Digite o primeiro número: ");
                                x = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Digite o segundo número: ");
                                y = Convert.ToDouble(Console.ReadLine());

                                result = div(x, y);
                                Console.WriteLine("Resultado: " + result + "\n");

                                break;
                            default:
                                Console.WriteLine("Comando não identificado! Tente novamente...");
                                break;
                    }
                    Console.WriteLine("Deseja continuar? (s/n)");
                    String sair = Console.ReadLine();
                    if(sair != "s")
                    {
                        Console.WriteLine("___EXITING___");
                        continuar = false;
                    }
                    else
                    {
                        resp = 0;
                    }
                }
            }

            Console.Beep();
            Console.ReadKey();
        }
        static double soma(double x, double y)
        {
            Console.WriteLine("\n---------------------------------\n\tSOMA\n---------------------------------\n");
            return x + y;
        }
        static double sub(double x, double y)
        {
            Console.WriteLine("\n---------------------------------\n\tSUBTRAÇÃO\n---------------------------------\n");
            return x - y;
        }
        static double div(double x, double y)
        {
            if(x%y == 0)
            {
                Console.WriteLine("\n---------------------------------\n\tDIVISÃO\n---------------------------------\n");
                return x / y;
            }
            else
            {
                return 0;
            }
        }
        static double mult(double x, double y)
        {
            Console.WriteLine("\n---------------------------------\n\tMULTIPLICAÇÃO\n---------------------------------\n");
            return x * y;
        }
    }
}