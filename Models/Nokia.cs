using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstraindoUmCelularComPOO.Models
{
    public class Nokia : Smartphone
    {
        public override void InstalarAplicativo(string nome)
        {
           string NomeApp = nome;
            Console.WriteLine("Abrindo a Google Play...");
            Console.WriteLine($"Aplicativo {NomeApp} Instalado.");
        }
    }
}