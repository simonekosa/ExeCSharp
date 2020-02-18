using System;

namespace CalculaMediaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            double al1;
            double al2;
            double al3;
            double al4;
            double al5;

            //CABECALHO DO PROGRAMA
            Console.WriteLine("***PROGRAMA PARA CALCULO DE MEDIA - ALUNOS***");
            Console.ReadLine();

            //ARMAZENAMENTO DE DADOS 
            Console.Write("Informe a idade do Aluno 1:  ");
            al1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a idade do Aluno 2:  ");
            al2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a idade do Aluno 3:  ");
            al3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a idade do Aluno 4:  ");
            al4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a idade do Aluno 5:  ");
            al5 = Convert.ToDouble(Console.ReadLine());

            //LOGICA DE CALCULO DA MEDIA
            media = (al1 + al2 + al3 + al4 + al5) / 5;

            //RESULTADO DO CALCULO
            Console.WriteLine("Media é igual a:" + media);
            Console.ReadLine();





        }
    }
}
