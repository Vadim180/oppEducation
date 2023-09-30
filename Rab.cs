using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    //* Створити клас працівник

    //* Клас повинен мати поля 
    //      Прізвище (string)
    //      імя (string)
    //      Розмір зп (decimal)
    //      Посада (Enumki(стажер, охоронець, продавець, бухгалтер, менеджер, Директор))
    //      вироботка годин (int)

    //* Конструктора за замовчуванням не повино бути

    //* Конструкторів повино бути мінімум 2

    //* Перезагрузити метод ToString()
    public class Rab
    {
        public string firsname { get; set; }
        public string lastname { get; set; }
        public Posada posada { get; set; }

        private decimal zarplata { get; set; }
        public List<Auto> sells_auto { get; set; }
        
        private int hodunu { get; set; }


        public Rab(string lastname, string firstname, Posada posada, decimal zp_Hod, int hodunu)
        {
            this.lastname = lastname;
            firsname = firstname;
            this.posada = posada;
            zarplata = zp_Hod;
            this.hodunu = hodunu;
            sells_auto = new List<Auto>();
        }

        public Rab(string lastname, string firsname)
        {
            zarplata = 0;
            hodunu = 6;
            this.lastname = lastname;
            this.firsname = firsname;
            posada = Posada.stajer;
            sells_auto = new List<Auto>();
        }

        //підраховуємо зарплату по формулі зп в годину помножити на робочі години
        public int rah()
        {
            return hodunu * (int)zarplata;
        }

        public override string ToString()
        {
            return "Працівник " + firsname + " " + lastname + " На посадi " + posada;
        }
    }
}
