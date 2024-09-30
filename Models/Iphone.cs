using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstraindoUmCelularComPOO.Models
{
    public class Iphone : Smartphone
    {
        public override void InstalarAplicativo(string nome)
        {
            string NomeApp = nome;
            Console.WriteLine("Abrindo a Apple Store...");
            Console.WriteLine($"Aplicativo {NomeApp} Instalado.");

        }
    }
}