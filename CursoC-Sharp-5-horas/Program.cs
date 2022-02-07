using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CursoC_Sharp_5_horas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velocidade=0;
            bool boxes=true;
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
    }
}
