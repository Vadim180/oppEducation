using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    //*  створити клас бугалтерія
    //*  клас повинен мати поля
    //*      Загальний розхід по зарплатам
    //*      Розхід по купівлям авто
    //*      Загальний дохід від продаж
    //*      чистий заробіток від продаж авто

    // реалізувати метод який підраховуватиме зарпалати по кожній посаді

    //* реалізувати методи для ініціалізації кожного поля тобто
    //*      метод що підрахує загальний розхід по зп
    //*      метод що підрахує розхід по купівлям авто
    //*      метод що підрахує загальний дохід від продаж
    //*      метод що підрахує чистий заробіток від продаж авто

    //* перезагрузити метод ту стрінг де вивести ці дані

    //* додати цей клас до класу магазин як поле
    public class Bygalteria
    {
        private double rozhid_zp {  get; set; }
        private double rozhid_avto {  get; set; }
        private double dohid_zahalnyi {  get; set; }
        private double dohid_cistyi_zarobitok {  get; set; }
        private Dictionary<Posada, double> zp_po_posadah {  get; set; }
        
        public Bygalteria()
        {
            zp_po_posadah = new Dictionary<Posada, double>
            {
                { Posada.derektor, 0 },
                { Posada.bygalter, 0 },
                { Posada.ohorona, 0 },
                { Posada.prodavets, 0 },
                { Posada.stajer, 0 },
                { Posada.manager, 0 }
            };
        }

        public void Perevirka(Posada pos, double dengi)
        {
            zp_po_posadah[pos] += dengi;
        }

        public void rozhid_zarplata(double a)
        {
            rozhid_zp += a;
        }
        public void dohid(double a)
        {
            dohid_zahalnyi += a;
        }
        public void rozhid_zakypivi(double a)
        {
            rozhid_avto += a;
        }
        public void cisty_zarobitok(double a)
        {            
            dohid_cistyi_zarobitok = (dohid_cistyi_zarobitok + a);
        }

        public void vivod_zp_vsih_posadu()
        {
            foreach(KeyValuePair<Posada,double> vivod_posadam in zp_po_posadah)     //KeyValuePair<Posada,double> можна вказати як просто var
            {
                Console.WriteLine("На посадi " + vivod_posadam.Key + " \t" + vivod_posadam.Value + " зарплат");
            }
        }

        public override string ToString()
        {
            return "Магазин закупив авто на суму " + rozhid_avto + " З яких отримав " + dohid_zahalnyi + " з них " +
                (dohid_cistyi_zarobitok - rozhid_zp) + " чистого заробітку.\n Tа виплатив зарплати на суму " + rozhid_zp;
        }
    }
    
}
