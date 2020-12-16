using System;
using maquinaCafe.classe;

namespace maquinaCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe cafe = new MaquinaCafe();
            cafe.acucarDisponivel = 100;
           

            Console.WriteLine("Qual a quantidade de açucar desejada?");
            cafe.FazerCafe (int.Parse(Console.ReadLine()));

           


            
        }
    }
}
