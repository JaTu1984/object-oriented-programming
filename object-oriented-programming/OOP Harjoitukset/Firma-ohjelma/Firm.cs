using System;
using System.Collections.Generic;
using System.Text;

namespace Firma_ohjelma
{
    class Firm
    {
        public string title;
        public string address;
        public string phone;
        public int outcome;
        public int expense;
        public double winning;

        public Firm()
        {

        }
        public Firm(string title, string address, string phone, int outcome, int expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }

        public void AskData()
        {
            Console.WriteLine("Anna yrityksen nimi?");
            this.title = Console.ReadLine();
            Console.WriteLine("Anna yrityksen osoite?");
            this.address = Console.ReadLine();
            Console.WriteLine("Anna yrityksen puhelinnumero?");
            this.phone = Console.ReadLine();
            Console.WriteLine("Anna yrityksen tulot [€]?");
            this.outcome = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna yrityksen menot [€]?");
            this.expense = int.Parse(Console.ReadLine());
        }

        public string ShowFirmInfo()
        {
            return "Yrityksen nimi on " + this.title +
                    " yrityksen osoite on " + this.address +
                    " yrityksen puhelinnumero on " + this.phone +
                    " yrityksen tulot ovat " + this.outcome +
                    " ja yrityksen menot ovat " + this.expense;
        }
        public Firm(Firm previousFirm)
        {
            title = previousFirm.title;
            address = previousFirm.address;
            phone = previousFirm.phone;
            outcome = previousFirm.outcome;
            expense = previousFirm.expense;
        }
        public string Winning()
        {
            winning = (outcome - expense) / expense * 100;

            if (winning >= 300)
                Console.WriteLine("Hyvä");
            else if (winning >= 200)
                Console.WriteLine("Tyydyttävä");
            else
                Console.WriteLine("Kehno");
            return "";
            
        }
    }
}

