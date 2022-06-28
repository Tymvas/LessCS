using System;
using static System.Console;

namespace LessCS
{
    //Task1
    /*class Money
    {
        private int _money = 0;
        private int _cents = 0;

        public Money() { }
        public Money(String line) : this()
        {
            _money = int.Parse(line.Split('.')[0]);
            _cents = int.Parse(line.Split('.')[1]);
        }

        public static Money operator +(Money m, String line)
        {
            m._money += int.Parse(line.Split('.')[0]);
            m._cents += int.Parse(line.Split('.')[1]);
            return m;
        }

        public static Money operator -(Money m, String line)
        {
            m._money -= int.Parse(line.Split('.')[0]);
            m._cents -= int.Parse(line.Split('.')[1]);
            if (m._cents < 0) { m._money -= 1; m._cents *= -1; }
            return m;
        }

        public void Minus(String money)
        {
            _money -= int.Parse(money.Split('.')[0]);
            _cents -= int.Parse(money.Split('.')[1]);
            if (_cents < 0) { _money -= 1; _cents *= -1; }
        }

        public override string ToString()
        {
            return $"{_money}.{_cents}";
        }
    }

    class Product : Money
    {
        public String Name { get; set; }

        public Product(String Name, String money) : base(money)
        {
            this.Name = Name;
        }

        public void DoSale(String money) { Minus(money); }

        public override string ToString()
        {
            return $"Name: {Name}\n" + base.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Pepsi", "23.25");
            WriteLine(product.ToString() + '\n');
            product.DoSale("13.10");
            WriteLine(product.ToString());
        }
    }*/


    //Task2

    /*class Device
    {
        protected String _name;
        protected String _description;

        public Device(String name, String description)
        {
            _description = description;
            _name = name;
        }

        public virtual void Sound()
        {
            WriteLine("Beep!");
        }

        public virtual void Show()
        {
            WriteLine("Name!");
        }

        public virtual void Desc()
        {
            WriteLine("Desc!");
        }
    }

    class Teapot : Device
    {
        public Teapot(String name, String description) : base(name, description) { }

        public new void Sound()
        {
            WriteLine("Fiiiii!");
        }

        public new void Show()
        {
            WriteLine($"Name: {base._name}");
        }

        public new void Desc()
        {
            WriteLine($"Description: {base._description}");
        }
    }

    class Microwave : Device
    {
        public Microwave(String name, String description) : base(name, description) { }
        public new void Sound()
        {
            WriteLine("Viiiiii!");
        }

        public new void Show()
        {
            WriteLine($"Name: {base._name}");
        }

        public new void Desc()
        {
            WriteLine($"Description: {base._description}");
        }
    }

    class Car : Device
    {
        public Car(String name, String description) : base(name, description) { }
        public new void Sound()
        {
            WriteLine("Biiiip!");
        }

        public new void Show()
        {
            WriteLine($"Name: {base._name}");
        }

        public new void Desc()
        {
            WriteLine($"Description: {base._description}");
        }
    }

    class Steamship : Device
    {
        public Steamship(String name, String description) : base(name, description) { }
        public new void Sound()
        {
            WriteLine("Tuuuuu!");
        }
        public new void Show()
        {
            WriteLine($"Name: {base._name}");
        }

        public new void Desc()
        {
            WriteLine($"Description: {base._description}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Saft", "Cool car");
            car.Desc();
            Steamship steamship = new Steamship("BlacPerl", "Legendary pirate ship");
            steamship.Desc();
            Teapot teapot = new Teapot("Hot", "Nice tea");
            teapot.Sound();
            Microwave microwave = new Microwave("Dax", "Ultrawaves");
            microwave.Show();
        }
    }*/

    //Task3
    /*class MusicInstrument
    {
        protected String _name;
        protected String _description;
        protected String _history;

        public MusicInstrument(String name, String description, String history)
        {
            _description = description;
            _name = name;
            _history = history;
        }

        public virtual void Sound()
        {
            WriteLine("Beep!");
        }

        public virtual void Show()
        {
            WriteLine("Name!");
        }

        public virtual void Desc()
        {
            WriteLine("Desc!");
        }

        public virtual void History()
        {
            WriteLine("History!");
        }
    }

    class Violin : MusicInstrument
    {
        public Violin(String name, String description, String history ) : base(name, description, history) { }

        public new void Sound()
        {
            WriteLine("Fiiiii!");
        }

        public new void Show()
        {
            WriteLine($"Name: {base._name}");
        }

        public new void Desc()
        {
            WriteLine($"Description: {base._description}");
        }

        public new void History()
        {
            WriteLine($"History: {base._history}");
        }
    }

    class Trombone : MusicInstrument
    {
        public Trombone(String name, String description, String history) : base(name, description, history) { }
        public new void Sound()
        {
            WriteLine("Viiiiii!");
        }

        public new void Show()
        {
            WriteLine($"Name: {base._name}");
        }

        public new void Desc()
        {
            WriteLine($"Description: {base._description}");
        }

        public new void History()
        {
            WriteLine($"History: {base._history}");
        }
    }

    class Uke : MusicInstrument
    {
        public Uke(String name, String description, String history) : base(name, description, history) { }
        public new void Sound()
        {
            WriteLine("Biiiip!");
        }

        public new void Show()
        {
            WriteLine($"Name: {base._name}");
        }

        public new void Desc()
        {
            WriteLine($"Description: {base._description}");
        }

        public new void History()
        {
            WriteLine($"History: {base._history}");
        }
    }

    class Violoncello : MusicInstrument
    {
        public Violoncello(String name, String description, String history) : base(name, description, history) { }
        public new void Sound()
        {
            WriteLine("Tuuuuu!");
        }
        public new void Show()
        {
            WriteLine($"Name: {base._name}");
        }

        public new void Desc()
        {
            WriteLine($"Description: {base._description}");
        }

        public new void History()
        {
            WriteLine($"History: {base._history}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Violin violin = new Violin("Saft", "Cool car", "Romania");
            violin.Desc();
            Trombone trombone = new Trombone("BlacPerl", "Legendary pirate ship","Grese");
            trombone.History();
            Uke uke = new Uke("Hot", "Nice tea","Australia");
            uke.Sound();
            Violoncello violoncello = new Violoncello("Dax", "Ultrawaves","USA");
            violoncello.Show();
        }
    }*/

    //Task4

    abstract class Worker
    {
        protected String name;
        protected int salary;

        public Worker(String name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public abstract void Print();
    }

    class President : Worker
    {
        public President(String name, int salary) : base(name, salary) { }

        public override void Print()
        {
            WriteLine($"President\nName: {base.name}\nSalary: {base.salary}");
        }
    }

    class Security : Worker
    {
        public Security(String name, int salary) : base(name, salary) { }
        public override void Print()
        {
            WriteLine($"Security\nName: {base.name}\nSalary: {base.salary}");
        }
    }

    class Manager : Worker
    {
        public Manager(String name, int salary) : base(name, salary) { }
        public override void Print()
        {
            WriteLine($"Manager\nName: {base.name}\nSalary: {base.salary}");
        }
    }

    class Engineer : Worker
    {
        public Engineer(String name, int salary) : base(name, salary) { }
        public override void Print()
        {
            WriteLine($"Engineer\nName: {base.name}\nSalary: {base.salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            President president = new President("Zelenskyi", 200000);
            president.Print();
            Security security = new Security("Bob", 30000);
            security.Print();
            Manager manager = new Manager("Tim", 25000);
            manager.Print();
            Engineer engineer = new Engineer("Jhon", 15000);
            engineer.Print();
        }
    }
}
