using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOP5
{
   public class ProductException : Exception
    {
        public ProductException(string message)
            : base(message)
        { }
    }
    public class PrinterException : Exception
    {
        public PrinterException(string message)
            : base(message)
        { }
    }
    class ProductExceptions : ArgumentException
    {
        public string Value { get; }
        public ProductExceptions(string message, string val)
            : base(message)
        {
            Value = val;
        }
    }
    public  enum Obj
    {
        e21vek=1,
        elektrosila,
        e5element,
        koronatechno

    }
    public struct Shops
    {
     
        public int Rating;
        public void ObjectInfo(Obj op)
        {

            switch (op)
            {
                case Obj.e21vek:
                    Console.WriteLine($" Добро пожаловать в 21vek  с рейтингом: {Rating}");
                    break;
                case Obj.elektrosila:
                    Console.WriteLine($"Добро пожаловать в Электросилу с рейтингом: {Rating}");
                    break;
                case Obj.e5element:
                    Console.WriteLine($"Добро пожаловать в 5 Элемент c ретингом^ {Rating}");
                    break;
                case Obj.koronatechno:
                    Console.WriteLine($"Добро пожаловать в Корону Техно с рейтингом: {Rating}");
                    break;
            }
        }
    }
   public interface IWireless
    {
        void Wireless(); //метод, который реализуется в классе с данным интерфейсом 
        bool Wires { get; set; } 
        string SomeMethod();
    }
   public abstract partial class Product
    {
        public int price;
        public bool InStock { get; set; }
     
        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    if (value > 20000)//2000
                    {
                        throw new ProductException("Дороговато!");
                    }
                    else
                    {
                        price = value;
                    }
                }
                else
                {
                    throw new ProductException("Цена не может быть отрицательным значением!");
                }
            }
        }
 
        public virtual void Info() 
        {
            Console.WriteLine("Товар в продаже!");
        }
        public static int counter = 0;
    }
    public abstract class Technique : Product
    {

        public Technique(int price, bool inStock)
        {
            this.Price = price;
            this.InStock = inStock;
        }
        public override void Info()
        {
            Console.WriteLine("Технический товар)");
        }
        public override string ToString()
        {
            return "Техника стоимостью " + Price;
        }
        public abstract string SomeMethod(); //одноименный метод (как абстрактный в классе, и как метод в интерфейсе)
    }
    public partial class Computer : Technique, IWireless
    {
        public string model;

        public string Model //модель процессора
        {
            get { return model; }
            set
            {
                if (value.Length>15)//2
                {
                    throw new ProductExceptions("Слишком длинное название модели", value);
                }
                else
                {
                    model = value;
                }
            }
        }
        public bool Wires { get; set; } //наличие проводов
        public Computer(int price, bool inStock, string model, bool wires) : base(price, inStock) //base + модель  и провода
        {
            this.Model = model;
            this.Wires = wires;
        }
        public override void Info()
        {
            Console.Write("Компьютер модели  {0} ", Model);
            if (InStock) //проверка на наличие
            {
                Console.WriteLine("(в наличии)\n");
            }
            else
            {
                Console.WriteLine("(нет в наличии)\n");
            }
        }
        public void Wireless() //проверяем на наличие проводов
        {
            if (!Wires) { Console.WriteLine("Беспроводной"); }
            else { Console.WriteLine("Проводной"); }
        }
        public override string SomeMethod() //реализуем как абстрактный метод
        {
            return "abstract class\n";
        }
        public override string ToString()
        {
            return "Компьютер модели " + Model;
        }
    }
    public class Printer:Technique, IWireless
    {
        public int speed;

        public int Speed
        { get { return speed; }
            set
            {
                if(value<0)
                {
                    throw new PrinterException("Скорость печати не может быть отрицательной");
                }
            }
                } 
        public bool Wires { get; set; } 
        public Printer(int price, bool inStock, int speed, bool wires) : base(price, inStock) //конструктор от базового класса + скорость печати и провода
        {
            this.Speed = speed;
            this.Wires = wires;
        }
        public override void Info()
        {
            Console.Write("Принтер  печатает со скоростью {0} листов в минуту", Speed);
            if (InStock) 
            {
                Console.WriteLine("(в наличии)\n");
            } else
            { 
                Console.WriteLine("(нет в наличии)\n");
            }
        }
        public void Wireless() 
        {
            if (!Wires) { Console.WriteLine("Беспроводной"); }
            else { Console.WriteLine("Проводной"); }  
        }

        public override string SomeMethod() //реализуем как абстрактный метод
        {
            return "abstract class\n";
        }
        string IWireless.SomeMethod() //реализуем как метод интерфейса
        { 
            return "interface\n";
        }
        public override string ToString()
        {
            return "Принетер cо скоростью печати" + Speed;
        }
    }



    public class Scaner : Technique, IWireless
    {
        public int Dpi { get; set; } 
        public bool Wires { get; set; } 
        public Scaner(int price, bool inStock, int dpi, bool wires) : base(price, inStock) 
        {
            this.Dpi = dpi;
            this.Wires = wires;
        }
        public override void Info()
        {
            Console.Write("Cканер с разрешающей способностью {0} dpi ", Dpi);
            if (InStock)
            {
                Console.WriteLine("(в наличии)\n");
            }
            else
            {
                Console.WriteLine("(нет в наличии)\n");
            }
        }
        public void Wireless() //проверяем на наличие проводов
        {
            if (!Wires) { Console.WriteLine("Беспроводной"); }
            else { Console.WriteLine("Проводной"); }
        }
        public override string SomeMethod() //реализуем как абстрактный метод
        {
            return "abstract class\n";
        }
        public override string ToString()
        {
            return "Сканер c dpi" + Dpi;
        }
    }
    sealed class Tablet : Product //запечатанный класс
    {
        public string Brand { get; set; } 
        public Tablet(int price, bool inStock, string brand) 
        {
            this.Price = price;
            this.InStock = inStock;
            this.Brand = brand;
        }
      
        public override void Info()
        {
            Console.Write("Я планшет {0} ", Brand);
            if (InStock) //проверка на наличие
            {
                Console.WriteLine("(в наличии)\n");
            }
            else
            {
                Console.WriteLine("(нет в наличии)\n");
            }
        }
    }
    public class TaskPrinter //класс с полиморфным методом
    {
        public static string IAmPrinting(Product someobj)
        {
            return someobj.ToString();
        }
    }
    public class LabContainer : ICloneable //класс-контейнер
    {
        public Product[] productArr; //реализуем лабораторию в виде одномерного массива
        public int size = 0;
        public LabContainer()
        {
            productArr = new Product[10];
        }
        public Product this[int index] //индексатор
        {
            get
            {
                return productArr[index];
            }
            set
            {
                productArr[index] = value;
            }
        }
        public void AddProduct(Product abstr) //добавление объекта в лабораторию
        {
            productArr[size++] = abstr;
            Product.counter++;
        }
        public void DeleteProduct(Product abstr) //удаление объекта в лаборатории
        {
            for (int i = 0; i < size; i++)
            {
                try
                {
                    if (productArr[i].Equals(abstr))
                    {
                        productArr[i] = null;
                        //size--;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Техника не найдена");
                    }
                }
                catch (Exception e) { }
            }
        }
        public void OutputProducts() //вывод инфомации о объектах лаборатории
        {
            try
            {
                if (size == 0)
                {
                    Console.WriteLine("Лаборатория пуста");
                }
                if (size <= 2)
                {
                    Console.WriteLine("\nТехника в лаборатории:");
                }
                else if (size > 2)
                {
                    throw new OverflowException();
                }
                for (int i = 0; i < size; i++)
                {
                    if (productArr[i] != null) productArr[i].Info();
                }
            }
            catch (OverflowException ex)

            {
                Console.WriteLine("Слишком много техники в лаборатории");
            }
        }
        public object Clone()
        {
            var Lab = (LabContainer)this.MemberwiseClone();
            return Lab;
        }
    }

    public class LabController
    {
        int countPrinter = 0;
        int countScaner = 0;
        int countComputer = 0;
        int countTablet = 0;
        public LabController() { }
        public void CountOfEach(LabContainer laboratory)
        {
            for (int i = 0; i < Product.counter; i++)
            {
                if (laboratory[i] is Printer)
                {
                    countPrinter++;
                }
                if (laboratory[i] is Computer)
                {
                    countComputer++;
                }
                if (laboratory[i] is Scaner)
                {
                    countScaner++;
                }
                if (laboratory[i] is Tablet)
                {
                    countTablet++;
                }
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Принтеров - {0}", countPrinter);
            Console.WriteLine("Компьютеры - {0}", countComputer);
            Console.WriteLine("Сканеры - {0}", countScaner);
            Console.WriteLine("Планшеты - {0}", countTablet);
        }

        public void OutputSortedProducts(LabContainer laboratory)
        {
            for (int i = 0; i < Product.counter; i++)
                for (int j = Product.counter - 1; j > i; j--)
                {
                    if (laboratory.productArr[j - 1].Price < laboratory.productArr[j].Price)
                    {
                        var temp = laboratory.productArr[j - 1];
                        laboratory.productArr[j - 1] = laboratory.productArr[j];
                        laboratory.productArr[j] = temp;
                    }
                }
            try
            {
                foreach (Product x in laboratory.productArr)
                {
                    x.Info();
                    Console.WriteLine("{0}", x.Price);
                }
            }
            catch (Exception e) { }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double min = Double.MinValue;
                Console.WriteLine(min);
                int[] aa = null;
                Debug.Assert(aa != null, "Values array cannot be null");
                Printer myPrinter = new Printer(4000, true, 40, false); //(стоимость, наличие, характеристика, провода)
                myPrinter.Info();
                //   myPrinter.ObjectInfo(Obj.Printer);
                Computer myComputer = new Computer(1900, false, "Asus", true);
                myComputer.Info();

                Scaner myScaner = new Scaner(2500, true, 600, false);
                myScaner.Info();

                Product myTablet = new Tablet(500, true, "Samsunglllllllllllllllllll");
                Product myTablet2 = new Tablet(500, true, "Samsung");
                Console.WriteLine("Стоимость планшета - {0} рублей", myTablet.Price); //доступна только стоимость,
                                                                                      //т.к. ссылке на объект базового класса присвоен объект производного классa
                Console.Write("\nКомпьютер: ");
                myComputer.Wireless(); //вызывем метод интерфейса
                Console.WriteLine();

                Console.Write(myPrinter.SomeMethod()); //одноименный метод, вызывается реализованный с помощью абстрактного класса
                Console.WriteLine(((IWireless)myPrinter).SomeMethod()); //.., реализованный с помощью интерфейса

                Console.WriteLine("   Переопределенные методы:");
                Console.WriteLine("ToString() - " + myTablet.ToString());
                Console.WriteLine("GetHashCode() - " + myTablet.GetHashCode());
                Console.WriteLine("Equals() - " + myTablet.Equals(myTablet2) + "\n");

                Console.WriteLine(TaskPrinter.IAmPrinting(myComputer));

                //is
                bool check = myPrinter is IWireless;
                bool check2 = myTablet is IWireless;
                Console.WriteLine(check);
                Console.WriteLine(check2 + "\n");

                //as
                Printer p = new Printer(200, true, 20, true);
                Technique b = p as Technique;
                if (b != null) //проверка на успешное преобразование
                {
                    b.Info();
                    Console.WriteLine();
                }

                Product[] ArrayOfObjects = { myPrinter, myScaner, myComputer }; //массив ссылок на разнотипные объекты
                foreach (Product x in ArrayOfObjects)
                {
                    Console.WriteLine(TaskPrinter.IAmPrinting(x)); //вызываем метод IAmPrinting со всеми ссылками в качестве аргументов
                }
                LabContainer lab = new LabContainer();
                lab.AddProduct(myComputer);
                lab.AddProduct(myPrinter);
                lab.AddProduct(myScaner);
                lab.AddProduct(myTablet);
                lab.AddProduct(myTablet2);
                LabController labContr = new LabController();
                labContr.OutputSortedProducts(lab);// вывод цены  в порядке убывания
                LabContainer lab2 = lab;
                lab.DeleteProduct(myTablet2);//удаляем myTablet2
                lab2.OutputProducts();
            }
            catch (ProductException e)
            {
                Console.WriteLine("Ошибка " + e.Message);
            }
            catch (PrinterException e)
            {
                Console.WriteLine("Ошибка " + e.Message);
            }
            catch (ProductExceptions e)
            {
                Console.WriteLine("Ошибка" + e.Message + " Некорректное значение: " + e.Value);
            }
           
            catch (IndexOutOfRangeException ex)

            {
                Console.WriteLine("Индекс выходит за пределы значений значений");
            }
            //catch (FieldAccessException)
            //{
            //    Console.WriteLine("Доступ к недопустимым поля класса");
            //}
            catch (Exception e)
            {
                Console.WriteLine("Ошибка(");
            }
            finally
            {
                Shops shop1;
                shop1.Rating = 5;
                shop1.ObjectInfo(Obj.e21vek);
                Shops shop2;
                shop2.Rating = 8;
                shop2.ObjectInfo(Obj.elektrosila);
            }
        }
    }
}
