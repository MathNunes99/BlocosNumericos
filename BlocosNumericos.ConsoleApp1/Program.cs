using System;

namespace BlocosNumericos.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 = 568   0,1,2,3 ok
            //2 = 945   4,5,6,7
            //3 = 946   8,9,10,11
            //4 = 787   12,13,14,15
            //5 = 947   16,17,18,19
            //6 = 1038  20,21,22,23
            //7 = 694   24,25,26,27
            //8 = 1130  28,29,30,31
            //9 = 1039  32,33,34,35
            //0 = 1004  36,37,38,39
            
            string texto = "     __  __      __  __ __   __  __  __ \n" +
                           "  |  __| __||__||__ |__   | |__||__||  |\n" +
                           "  | |__  __|   | __||__|  | |__| __||__|\n"; ;
            string texto2 = "     __  __      __  __  __  __  __  __ \n" +
                            "  |  __| __||__||__ |__ |__ |__||__||__|\n" +
                            "  | |__  __|   | __||__||__||__| __| __|\n"; ;


            System.IO.StringReader leitor = new System.IO.StringReader(texto2);
            string primeiralinha = leitor.ReadLine();
            char[] primeirachar = primeiralinha.ToCharArray();
            string segundalinha = leitor.ReadLine();  
            char[] segundachar = segundalinha.ToCharArray();
            string terceiralinha = leitor.ReadLine();
            char[] terceirachar = terceiralinha.ToCharArray();

            int leitor1 = 0;
            int leitor2 = 0;
            int leitor3 = 0;
            int leitorfinal = 0;
            int repete = 0;
            for (int i = 0; i <= 39; i++)
            {
                
                if(i <= 39)
                {
                    leitor1 = leitor1 + Convert.ToInt32(primeirachar[i]);                    
                    leitor2 = leitor2 + Convert.ToInt32(segundachar[i]);
                    if (Convert.ToInt32(segundachar[i]) == 124 && i % 2 == 0)
                    {
                        leitor2 = leitor2 + 1;
                    }
                    leitor3 = leitor3 + Convert.ToInt32(terceirachar[i]);
                    if (Convert.ToInt32(terceirachar[i]) == 124 && i % 2 == 0)
                    {
                        leitor3 = leitor3 - 1;
                    }
                    leitorfinal = leitor1 + leitor2 + leitor3;
                    repete = repete + 1;
                }

                if (repete == 4)
                {                    
                    if (leitorfinal == 568)
                        Console.Write("1");
                    if (leitorfinal == 945)
                        Console.Write("2");
                    if (leitorfinal == 946)
                        Console.Write("3");
                    if (leitorfinal == 787)
                        Console.Write("4");
                    if (leitorfinal == 947)
                        Console.Write("5");
                    if (leitorfinal == 1038)
                        Console.Write("6");
                    if (leitorfinal == 694)
                        Console.Write("7");
                    if (leitorfinal == 1130)
                        Console.Write("8");
                    if (leitorfinal == 1039)
                        Console.Write("9");
                    if (leitorfinal == 1004)
                        Console.Write("0");


                    leitorfinal = 0;
                    repete = 0;
                    leitor1 = 0;
                    leitor2 = 0;
                    leitor3 = 0;
                }

            }
            Console.ReadLine();
        }
    }
}
