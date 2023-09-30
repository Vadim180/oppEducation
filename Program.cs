using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Magazin magaz = new Magazin();


            Rab raboci = new Rab("Vasil", "Kopitchak", Posada.manager, 80, 10);
            magaz.add_rab(raboci);
            Rab raboci2 = new Rab("Vasiiil", "Kopiiitchak", Posada.manager, 80, 10);
            magaz.add_rab(raboci2);

            magaz.vivod_pratcivnuk();

            Auto auto = new Auto(new BMW("bmw_725"), 1999, 20000, color.red, 1);
            Auto to1 = new Auto(new BMW("x_5"), 2005, 20000, color.blue, 3);

            Auto to = new Auto(new BMW("bmw_725"), 2005, 20000, color.blue, 2);
            Auto to2 = new Auto(new BMW("bmw_725"), 2005, 20000, color.blue, 5);
            Auto to3 = new Auto(new BMW("bmw_725"), 2003, 20000, color.blue, 1);
            Auto to4 = new Auto(new BMW("bmw_725"), 2005, 20000, color.blue, 2);



            magaz.add_avto(auto);
            magaz.add_avto(to);
            magaz.add_avto(to1);
            magaz.add_avto(to2);
            magaz.add_avto(to3);
            magaz.add_avto(to4);

            magaz.Sell_avto(to3, raboci);
            magaz.Sell_avto(to4, raboci);

            magaz.vivod_avto();

            magaz.vivod_bygalteri();

        }
    }

    
}
