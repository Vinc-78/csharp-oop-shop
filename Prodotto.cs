using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {

        private readonly string codice;
        private string nome;
        private string descrizione ;
        private double prezzo;
        

        private double iva;


        
        public double Prezzo
        {
            get { return prezzo; }
            set { prezzo = value; }
        }
        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        public Prodotto(string nome, string descrizione, double prezzo, double iva) 
        
        {
            this.codice = GeneraCodice();
            this.nome = SetNome(nome);
            this.descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;

        
        }

        //genera un codice intero di 9 cifre e lo converte in stringa
        public string GeneraCodice()
        {
            Random random = new Random();

            int codice = random.Next(0, 99999999);

            string sCodice = Convert.ToString(codice);

            return sCodice;
        }

        public string SetNome(string nome) 
        {
            if ((nome != null))
            {
               return this.nome = nome;
            }
            else {
                Console.WriteLine("Devi inserire un nome");
                    
                    return null;
                  }
            
        }

        public string GetNome() { return this.nome; }

        public void PrezzoBaseIva() 
        {

            double prezzoIva = this.prezzo + ((this.prezzo * (this.iva)/100));

            Console.WriteLine("Il prezzo base è {0}", this.prezzo);
            Console.WriteLine("Il prezzo con Iva è {0}", prezzoIva);

        }

        public string NomeCompleto()
        {
            string codiceNome = this.codice + this.nome;

            return codiceNome;
           
        }
        //Metodo Bonus
        public void codicePad()
        {
            int delta = 9 - this.codice.Length;

            Console.Write("il codicePAd è: ");

            for (int i = 0; i < delta; i++) { Console.Write("0"); }

            Console.Write(this.codice);
        }


    }
}
