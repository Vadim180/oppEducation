using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    //* створити клас Auto

    //* Клас повинен мати 
    //      рік випуску
    //      ціна
    //      Марка (Bmw, mersedes, audi, skoda)
    //      Колір 
    //      кільксть в наявності
    //      продаж bool (true,false)
    //      Працівник що її продав

    //* перезагрузка методу ToString()

    //* Всі параметри повинні передаватися у конструктор окрім працівника та продаж

    //* Створити метод Продаж який прийматиме працівника та встановить статут продажа також повина змінитися кількість в наявності

    public class Auto
    {
        public Marka marka { get; set; }
        public int rik_vipusk { get; set; }
        public double price { get; set; }
        public color colorAuto { get; set; }


        private int count { get; set; }
        private bool ok { get; set; }
        private Rab rab { get; set; }
        private double zakypka_avto { get; set; }


        public Auto(Marka marka, int rik_vipysk, int zakypka_tsina, color kolir, int kilkist)
        {
            this.marka = marka;
            rik_vipusk = rik_vipysk;
            colorAuto = kolir;
            count = kilkist;
            zakypka_avto = zakypka_tsina;

            price = zakypka_tsina * 1.2;


            ok = true;
        }

        //приймаємо працівника щоб вказати який працівник продав авто
        public void sell(Rab pratsivnyk) 
        {   

            rab = pratsivnyk; // зберішаємо дані працівника що продав авто в поле раб
            // якщо в наявності є авто тоді мінусуємо кількісь авто
            if (count > 0)
            {
                count--;                
            }

            // якщо кількість авто 0 тоді встановлюємо значення в наявності false
            if (count == 0) 
            {
                ok = false;
            }
            else
                ok = true;
        }

        // повертаємо значення наявності авто (можемо використовувати поза класом для перевірки наявності авто)
        public bool v_naiavnosti() 
        {
            return ok;
        }

        // додаємо стару кількість авто і нову кількість
        public void CountCONCAT (Auto auto) 
        {
            count += auto.count;
        }


        // повертаємо кількість авто
        public int GetCount()
        {
            return count;
        }

        public double Get_zakypka()
        {
            return zakypka_avto * count;
        }

        public double Get_cisty_dohid()
        {
            return price - zakypka_avto;
        }

        public override string ToString()
        {
            return marka.ToString() + " " + rik_vipusk+" року, "+ colorAuto + " Кольору за " + price + "$" + "\t - в наявностi " + count;
        }
    }
}
