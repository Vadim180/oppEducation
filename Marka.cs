using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{ 
    //* створити клас Marka
    //      name (string)
    //      marka (string)

    //* створити класи BMW, Mersedes, Audi, Skoda
    //* всі повинні бути унаслідовані від класу Marka
    //* поле name ініціалізується у конструкторі за назвою класу для BMW - (BMW) і так далі

    // створюємо базовий клас марка
    public class Marka
    {
        public string name {  get; set; }
        public string model { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    //створюємо клас бмв унаслідуємо його від марки
    public class BMW : Marka
    {
        public BMW(string model)
        {
            name = "BMW"; // назва марки дорівнює назві класу 
            this.model = model; // а модель отримуємо в конструкторі
        }
        public override string ToString()
        {
            return name + " - " + model;
        }
    }

    public class Mersedes:Marka
    {
        public Mersedes(string model)
        {
            name = "Mersedes";
            this.model = model;
        }
        public override string ToString()
        {
            return name + " - " + model;
        }
    }
    public class Audi : Marka
    {
        public Audi(string model)
        {
            name = "Audi";
            this.model = model;
        }
        public override string ToString()
        {
            return name + " - " + model;
        }
    }
    public class Skoda : Marka
    {

        public Skoda(string skoda)
        {
            name = "Skoda";
            this.model= skoda;
        }

        public override string ToString()
        {
            return name + " - " + model;
        }

    }


}
