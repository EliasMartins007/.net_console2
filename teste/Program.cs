using System;
using System.Globalization;
using teste;

namespace MyApp
{
    class Program
    {
    
        private static void Main(string[] args)
        {


            //Pessoa PrimeiraPessoa = new Pessoa();
            //Pessoa SegundaPessoa = new Pessoa();

            //Console.WriteLine("Dados Da primeira pessoa:");
            //Console.Write("Nome:");
            //PrimeiraPessoa.Nome = Console.ReadLine();
            //Console.Write("idade:");
            //PrimeiraPessoa.Idade = int.Parse(Console.ReadLine()) ;

            //Console.WriteLine("Dados Da Segunda pessoa:");
            //Console.Write("Nome:");
            //SegundaPessoa.Nome = Console.ReadLine();
            //Console.Write("idade:");
            //SegundaPessoa.Idade = int.Parse(Console.ReadLine());

            //if (PrimeiraPessoa.Idade > SegundaPessoa.Idade)
            //{
            //    Console.WriteLine($"primeira pessoa maior {PrimeiraPessoa.Nome}");
            //}
            //else
            //    Console.WriteLine($"segunda pessoa maior {SegundaPessoa.Nome}");





            Triangulo x = new Triangulo();  
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do trinagulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do trinagulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine($"Area de X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");
        }


    }          
}

