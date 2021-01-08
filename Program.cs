using System;
using AulaPOO_Encapsulamento.classes;

namespace AulaPOO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard mc = new MasterCard();
            
            mc.Parcelas = 12;
            System.Console.WriteLine(mc.Parcelas);
        }
    }
}
