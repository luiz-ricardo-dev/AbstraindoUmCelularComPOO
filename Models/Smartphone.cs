using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstraindoUmCelularComPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo{ get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void RecebendoLigacao()
        {
            Console.WriteLine("Recebendo uma ligação..");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}