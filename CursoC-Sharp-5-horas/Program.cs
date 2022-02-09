using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CursoC_Sharp_5_horas
{
    internal class Program
    {
        //criação de um Enum

        enum Carros 
        { 
            Porshe = 02,
            Ferrari = 04,
            Masserati = 06,
            Lamborguini = 08,
            Audi = 10,
            Mercedes_Benz = 12,
            BMW = 14,
            McLaren = 16,
            Aston_Martin = 18 
        }
        static void Main(string[] args)
        {
            Carros[] naFormula1 = new Carros[] { Carros.Ferrari, Carros.Mercedes_Benz, Carros.McLaren, Carros.Aston_Martin };
            WriteLine("Qual carro você mais gosta: \n1"+(Carros)02 +"\n2"+(Carros)04+"\n3"+(Carros)06+"\n4"
                +(Carros)08+"\n5"+(Carros)10+"\n6"+(Carros)12+"\n7"+(Carros)14+"\n8"+(Carros)16+"\n9"+(Carros)18);
            int index = int.Parse(ReadLine());
            switch (index)
            {
                case 1:
                    WriteLine(Carros.Porshe);
                    break;
                case 2:
                    WriteLine(Carros.Ferrari);
                    break;
                case 3:
                    WriteLine(Carros.Masserati);
                    break;
                case 4:
                    WriteLine(Carros.Lamborguini);
                    break;
                case 5:
                    WriteLine(Carros.Audi);
                    break;
                case 6:
                    WriteLine(Carros.Mercedes_Benz);
                    break;
                case 7:
                    WriteLine(Carros.BMW);
                    break;
                case 8:
                    WriteLine(Carros.McLaren);
                    break;
                default:
                    WriteLine(Carros.Aston_Martin);
                    break;
            }
            WriteLine(naFormula1[0] +"  "+ naFormula1[1] + "  " + naFormula1[2] + "  " + naFormula1[3]);
            WriteLine((int)naFormula1[0] + "  " + (int)naFormula1[1] + "  " + (int)naFormula1[2] + "  " + (int)naFormula1[3]);
            WriteLine((int)naFormula1[0] + (int)naFormula1[1] + (int)naFormula1[2] + (int)naFormula1[3]);

            int velocidade=0;
            bool boxes=true;
            SwitchCase();
            string [] familia = new string[] { " rubens", " iara", " lili", " chicao", " antonio", " dinda" };
            WriteLine(familia[0] + familia[1]+familia[2]+familia[3]+familia[4]+familia[5]);
            string fim = (Condicional(velocidade, boxes));
            WriteLine(fim);
            ReadLine();
        }
        static string Condicional (int velocidade, bool boxes)
        {   
            string condicao;
            string fim = "\n Fim";
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
            return fim;
        }
        static void SwitchCase()
        {
            int nota;
            Write("Qual a sua nota final: ");
            nota = int.Parse(ReadLine());
            switch (nota)
            {
                case int n when (n <= 40):
                    WriteLine("Muito burro");
                    break;
                case int n when (n> 40 && n <= 50):
                    WriteLine("burro");
                    break;                
                case int n when (n> 50 && n <= 59):
                    WriteLine("Faltou estudar um pouco");
                    break;
                case int n when (n == 60):
                    WriteLine("Ajudado pelo professor, certeza!");
                    break;
                case int n when (n> 60 && n <= 69):
                    WriteLine("Passou por pouco");
                    break;
                case int n when (n> 69 && n <= 79):
                    WriteLine("Não fez mais que a obrigação");
                    break;
                case int n when (n> 79 && n <= 89):
                    WriteLine("Mandou bem, Parabéns");
                    break;
                case int n when (n> 89 && n <= 99):
                    WriteLine("Olha o geninho ai...");
                    break;
                case int n when (n == 100):
                    WriteLine("CDF não tem como negar!");
                    break;

            }
                
        }
    }
}
