using System;
using static System.Console;

namespace CursoC_Sharp_5_horas
{
    internal class Program
    {
        //criação de um Enum
        enum Carros { Porshe=02, Ferrari=04, Masserati=06, Lamborguini=08, Audi=10, Mercedes=12, BMW=14, McLaren=16, Aston_Martin=18 }
        static void Main(string[] args)
        {
            int index;
            int n = 1;
            int c = 0;
            Carros[] carros = new Carros[] {(Carros)02, (Carros)04, (Carros)06, (Carros)08, (Carros)10, (Carros)12, (Carros)14, (Carros)16, (Carros)18 };
            do
            {
                WriteLine(" Escolha um carro:");

                foreach (Carros carro in carros)
                {
                    Write("\n 0" + n + " " + carro);
                    n++;
                }
                Write("\n 00 Sair \n Sua Escolha: 0");
                index = int.Parse(ReadLine());
                switch (index)
                {
                    case 1: WriteLine("\n Escolheu: " + Carros.Porshe + "\n"); break;
                    case 2: WriteLine("\n Escolheu: " + Carros.Ferrari + "\n"); break;
                    case 3: WriteLine("\n Escolheu: " + Carros.Masserati + "\n"); break;
                    case 4: WriteLine("\n Escolheu: " + Carros.Lamborguini + "\n"); break;
                    case 5: WriteLine("\n Escolheu: " + Carros.Audi + "\n"); break;
                    case 6: WriteLine("\n Escolheu: " + Carros.Mercedes + "\n"); break;
                    case 7: WriteLine("\n Escolheu: " + Carros.BMW + "\n"); break;
                    case 8: WriteLine("\n Escolheu: " + Carros.McLaren + "\n"); break;
                    case 9: WriteLine("\n Escolheu: " + Carros.Aston_Martin + "\n"); break;
                    case 0: WriteLine("\n FIM \n"); break;
                }
                    c++;
            } while (index != 0);
            WriteLine(" Foram escolhidos " + --c + " carro(s)");

            Carros[] naFormula1 = new Carros[] { Carros.Ferrari, Carros.Mercedes, Carros.McLaren, Carros.Aston_Martin };
            foreach (Carros formula in naFormula1)
            {
                Write(" " + formula);
                WriteLine(" Id : " + (int)formula);
            }
            c = 0;
            for (int i = 0; i < naFormula1.Length; ++i)
            {
                c = c+(int)naFormula1[i];
            }
            WriteLine(" Somatório dos Ids: "+c);

            int velocidade=0;
            bool boxes=true;
            string fim = (Condicional(velocidade, boxes));
            WriteLine(fim);
            ReadLine();
        }
        static string Condicional (int velocidade, bool boxes)
        {   
            string condicao;
            string fim = "\n ";
            while (fim != "fim")
            {
                WriteLine("\n Pergunta: ");
                Write(" Um carro de formula 1 pode chegar aos (km/h): ");
                velocidade = Math.Abs(int.Parse(ReadLine()));
                if (velocidade < 60 || velocidade > 400) { boxes = false; }
                else { Write(" O carro está nos Boxes(true/false): "); boxes = bool.Parse(ReadLine()); }
                if (velocidade != 60 && velocidade < 400 && !boxes == true) { condicao = " pode sim"; }
                else if (velocidade == 60 && boxes == false) { condicao = " pode sim"; }
                else if (velocidade != 60 && velocidade <= 400 && boxes == true) { condicao = " pode sim, mas fora dos Boxes"; }
                else if ((velocidade == 60 && boxes == true) || (velocidade == 400 && boxes == false))
                { condicao = " pode sim, esté um dos limites que podem ser atingidos: \n 60km/h nos Boxes \n 400km/h em qualquer outra situação"; }
                else { condicao = " não pode"; }
                Write(condicao);
                WriteLine("");
                Write("Deseja saber mais alguma velocidade? (s - sim/ n - não)");
                fim = ReadLine();
                if (fim == "s" || fim == "S" || fim == "sim" || fim =="SIM") { fim = "sim"; continue; }
                else if (fim == "n" || fim == "N" || fim == "nao" || fim == "NAO" || fim == "não" || fim == "NÃO") { fim = "fim"; };
            }
            return fim;
        }
    }
}
