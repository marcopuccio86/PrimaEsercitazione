using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaEsercitazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esempio creato solamente utilizzando la classe Dipendente
            Dipendente dipendente = new Dipendente();
            dipendente.Cognome = "Pinco";
            dipendente.Nome = "Pallino";
            dipendente.RuoloRicoperto = "Amministratore Delegato";
            dipendente.Stipendio = 1560.52;
            dipendente.DataOraEntrata = DateTime.Now;

            Console.WriteLine(dipendente.ScriviDatiDipendente());
            dipendente.FirmaEntrata();
            dipendente.FirmaUscita();
            Console.ReadLine();
        }
    }

    public class Dipendente
    {
        //l'esempio utilizza solo proprietà ad archiviazione automatica
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Dipartimento { get; set; }
        public double Stipendio { get; set; }
        public string RuoloRicoperto { get; set; }
        public DateTime DataOraEntrata { get; set; }
        public DateTime DataOraUscita
        {
            get
            {
                return DataOraEntrata.AddHours(8);
            }
        }

        public string ScriviDatiDipendente()
        {
            return $"Il dipendente {Cognome} {Nome}, " +
                              $"ricopre il ruolo di {RuoloRicoperto} " +
                              $"ed ha uno stipendio di {Decimal.Parse(Stipendio.ToString())}.";
        }
        public void FirmaEntrata()
        {
            Console.WriteLine($"Il Dipendente {Nome} {Cognome} ha firmato l'entrata alle ore: {DataOraEntrata}");
        }

        public void FirmaUscita()
        {
            Console.WriteLine($"Il Dipendente {Nome} {Cognome} ha firmato l'uscita alle ore: {DataOraUscita}");
        }
    }

    public class Alteta
    {
        //l'esempio utilizza solo proprietà ad archiviazione automatica
        public string Nominativo { get; set; }
        public string SocietaAppartenenza { get; set; }
        public string NominativoProcuratore { get; set; }
        public double Altezza { get; set; }

        public double Peso { get; set; }

        public DateTime DataNascita { get; set; }
        public int NrCartelloGara { get; set; }
    }

    public class Animale
    {
        //l'esempio utilizza solo proprietà ad archiviazione automatica
        public string TipoAnimale { get; set; }
        public string Razza { get; set; }
        public string Nome { get; set; }
        public string NrMicrochip { get; set; }
        public string ColoreMantello { get; set; }
    }
    public class Veicolo
    {
        //l'esempio utilizza solo proprietà ad archiviazione automatica
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int CavalliFiscali { get; set; }
        public string Colore { get; set; }
        public DateTime AnnoImmatricolazione { get; set; }
        public TipoAlimentazione TipoAlimentazione { get; set; }
    }

    public enum TipoAlimentazione
    {
        Benzina = 0,
        Diesel = 1,
        Hybrid = 2,
        FullElectric = 3
    }
}
