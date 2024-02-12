using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Menu
{
    internal class Ordine
    {
        private string _nomePiatto;
        private decimal _costoPiatto;
        private static List<Ordine> _piattoScelto = new List<Ordine>();
        
        public string NomePiatto
        {
            get { return _nomePiatto; }
            set { _nomePiatto = value;}
        }
        public decimal CostoPiatto
        {
            get { return _costoPiatto; }
            set { _costoPiatto = value; }
        }
        public static List<Ordine> PiattoScelto
        {
            get{ return _piattoScelto; }
            set{  _piattoScelto = value; }
        }
        public Ordine(string nomepiatto, decimal costo)
        {
            this._nomePiatto = nomepiatto;
            this._costoPiatto = costo;
        }

        public static void Scelta()
        {
            Console.WriteLine("==============MENU==============");
            Console.WriteLine("1. Coca Cola 150 ml (€ 2.50)");
            Console.WriteLine("2. Insalata di pollo (€ 5.20)");
            Console.WriteLine("3. Pizza Margherita (€ 10.00)");
            Console.WriteLine("4. Pizza 4 Formaggi (€ 12.50)");
            Console.WriteLine("5. Pz patatine fritte (€ 3.50)");
            Console.WriteLine("6. Insalata di riso (€ 8.00)");
            Console.WriteLine("7. Frutta di stagione (€ 5.00)");
            Console.WriteLine("8. Pizza fritta (€ 5.00)");
            Console.WriteLine("9. Piadina vegetariana (€ 6.00)");
            Console.WriteLine("10. Panino Hamburger (€ 7.90)");
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");
            int resp = Convert.ToInt16(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    Ordine m1 = new Ordine("Coca Cola", (decimal)2.50);
                    Ordine.PiattoScelto.Add(m1);
                    Scelta();
                    break;
                case 2:
                    Ordine m2 = new Ordine("Insalata di pollo", (decimal)5.20);
                    Ordine.PiattoScelto.Add(m2);
                    Scelta();
                    break;
                case 3:
                    Ordine m3 = new Ordine("Pizza Margherita", (decimal)10.00);
                    Ordine.PiattoScelto.Add(m3);
                    Scelta();
                    break;
                case 4:
                    Ordine m4 = new Ordine("Pizza 4 formaggi", (decimal)12.20);
                    Ordine.PiattoScelto.Add(m4);
                    Scelta();
                    break;
                case 5:
                    Ordine m5 = new Ordine("Patatine Fritte", (decimal)3.50);
                    Ordine.PiattoScelto.Add(m5);
                    Scelta();
                    break;
                case 6:
                    Ordine m6 = new Ordine("Insalata di riso", (decimal)8.00);
                    Ordine.PiattoScelto.Add(m6);
                    Scelta();
                    break;
                case 7:
                    Ordine m7 = new Ordine("Frutta di stagione", (decimal)5.00);
                    Ordine.PiattoScelto.Add(m7);
                    Scelta();
                    break;
                case 8:
                    Ordine m8 = new Ordine("Pizza fritta", (decimal)6.50); ;
                    Ordine.PiattoScelto.Add(m8);
                    Scelta();
                    break;
                case 9:
                    Ordine m9 = new Ordine("Piadina vegetariana", (decimal)6.00);
                    Ordine.PiattoScelto.Add(m9);
                    Scelta();
                    break;
                case 10:
                    Ordine m10 = new Ordine("Hamburger", (decimal)7.90);
                    Ordine.PiattoScelto.Add(m10);
                    Scelta();
                    break;
                case 11:
                    Ordine.Conto();
                    break;
                default:
                    Console.WriteLine("Scelta non valida, riprovare");
                    Scelta();
                    break;

            }
        }

        public static void Conto()
        {
            decimal contoFinale = 0;
            decimal servizio = 3;

            Console.WriteLine("Il totale del conto:");
            Console.WriteLine("Piatti Scelti:");
            foreach (Ordine m in Ordine.PiattoScelto)
            {
                Console.WriteLine($"{m.NomePiatto} - € {m.CostoPiatto}");
                contoFinale += m.CostoPiatto;
            }
            Console.WriteLine($"Servizio: {servizio}");
            Console.WriteLine($"Totale Conto: {(contoFinale + servizio)}");
            Console.WriteLine("Grazie per averci scelto!");
            Console.ReadLine();
        }
    }
}
