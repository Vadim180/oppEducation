using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{

    // створити клас magazin

    //*      повинен мати Ліст автомобілів           *
    //*      та Ліст працівників                     *

    //*     додати функціонал найняти працівника
    //*     звільнити працівника

    //*     додати функціонал прийняти автомобілі    *
    //*     продати автомобіль                       *

    //      зробити метод кращий працівник по кількості проданих авто

    //*      ПРИ ДОДАВАННІ урахувати цей факт для рабів
    //*      в магазині повино бути не більше одного директора [0]
    //*      не більше 2 бухгалтерів [1]
    //*      не більше 5 менеджерів [2]
    //*      не більше 10 охоронців [3]
    //*      та не більше 15 продавців [4]
    //*      І НЕ БІЛЬШЕ 5 стажерів [5]


    //*      ПРИ ДОДАВАННІ урахувати цей факт для авто
    //*      якщо ти додаєш авто яке уже є потрібно додати їхню кількість
    //*      перевірку здійснювати за такими параметрами 
    //*      Марка, Модель, Рік, Колір


    public class Magazin
    {

        public List<Auto> avtomobili {get; set;}
        public List<Rab> robotnik { get; set;}
        private int[] mas { get; set;}
        private Bygalteria bygalt { get; set;}

        public Magazin()
        {
            bygalt = new Bygalteria();
            mas = new int[]{ 15, 10, 5, 5, 2, 1 };
            avtomobili = new List<Auto>();
            robotnik = new List<Rab>();
        }

        public void add_avto(Auto avto)
        {
            //перевіряє чи в лісті автомобілів є елементи
            if (avtomobili.Count > 0)
            {
                //перевіряємо чи є в лісті авто яке хочемо додати 
                Auto tmp = avtomobili.SingleOrDefault(a => (a.marka.name == avto.marka.name && avto.marka.model == a.marka.model)&&(a.rik_vipusk == avto.rik_vipusk && a.colorAuto == avto.colorAuto));
                if (tmp == null)
                {
                    //якщо нема то додаємо в ліст нову партію авто
                    avtomobili.Add(avto);
                }
                else
                {
                    // якщо є тоді
                    avtomobili.Remove(tmp); // видаляємо з ліста автомобілі що уже є
                    avto.CountCONCAT(tmp); // додаємо стару кількість авто і нову кількість в авто що додаємо
                    avtomobili.Add(avto); // додаємо авто                
                }
            }
            else
                avtomobili.Add(avto); // якщо елементів у лісті нема тоді просто додаємо новий
            bygalt.rozhid_zakypivi(avto.Get_zakypka());
        }

        public void Sell_avto(Auto auto, Rab rab)
        {
            //перевіряє чи в лісті автомобілів є елементи
            if (avtomobili.Count > 0)
            {
                //robotnik.Find(r => r == rab).sells_auto.Add(auto);
                avtomobili.Find(a => a == auto).sell(rab); //перевіряємо чи в лісті є таке авто і продаємо авто
                bygalt.dohid(auto.price);
                bygalt.cisty_zarobitok(auto.Get_cisty_dohid());
                
                // перевіряємо чи авто ще є в наявності
                if (!auto.v_naiavnosti())
                {
                    avtomobili.Remove(auto); // якщо кількість авто 0 тоді видаляємо зі списку
                }
            }
        }

        private int vilni_posady(Posada pos)
        {
            int count = 0; // тимчасовий лічильник
            // перевіряємо чи в лісті є вільна посада яку хочемо додати
            foreach(Rab rab in robotnik)
            {
                // кожен раз коли знайде працівника з такою посадою збільшує лічильник на один
                if (rab.posada == pos)
                    count++;
            }
            return count;
        }

        private bool BeremoRaba(Rab rab, Posada poss)
        {
            // звіряємо максимальну кількість з наявними
            if (vilni_posady(rab.posada) < mas[(int)poss])
            {
                return true;
            }
            return false;
        }

        public void add_rab(Rab rab)
        {
            // якщо є вільні посади додаємо раба
            if (BeremoRaba(rab, rab.posada))
            { 
                robotnik.Add(rab);
                bygalt.rozhid_zarplata(rab.rah());
                bygalt.Perevirka(rab.posada, rab.rah());
            }
        }

        public void remove_Rab(Rab rab)
        {
            // якщо в лісті є працівники то ми видаляємо отриманого раба
            if (robotnik.Count > 0)
            {
                robotnik.Remove(rab);
                bygalt.rozhid_zarplata(-rab.rah());
                bygalt.Perevirka(rab.posada, -rab.rah());
            }
        }


        public void vivod_avto()
        {
            foreach (var item in avtomobili)
            {
                Console.WriteLine(item);

            }
        }

        public void vivod_pratcivnuk()
        {
            foreach(var i in robotnik)
                Console.WriteLine(i);
            bygalt.vivod_zp_vsih_posadu();
        }

        public void vivod_bygalteri()
        {
            Console.WriteLine(bygalt);
        }
    }
}
