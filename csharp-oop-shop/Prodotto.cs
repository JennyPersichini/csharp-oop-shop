using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private int Codice;
        private string Nome;
        private string Descrizione;
        private double Prezzo;
        private double Iva;

        public Prodotto(string Nome, string Descrizione, double Prezzo, double Iva)
        {
            Codice = CreaProdotto();

            this.Nome = Nome;
            this.Descrizione = Descrizione;
            this.Prezzo = Prezzo;
            this.Iva = Iva;
        }

        //Alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
        //Il codice prodotto sia accessibile solo in lettura
        //Gli altri attributi siano accessibili sia in lettura che in scrittura
        //Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
        //Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome

        private int CreaProdotto()
        {
            Random NumeroRandom = new Random();
            return NumeroRandom.Next();
        }
        
        public string getNome()
        {
            return Nome;
        }
        
        public string getDescrizione()
        {
            return Descrizione;
        }
        
        public double getPrezzo()
        {
            return Prezzo;
        }
        
        public double getPrezzoConIva()
        {
            return Prezzo + (Prezzo / 100 * Iva);
        }
        
        public string getNomeEsteso()
        {
            return Codice.ToString() + " " + Nome;
        }
    }
}
