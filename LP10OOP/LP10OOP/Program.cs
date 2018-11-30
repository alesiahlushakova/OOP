using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP10OOP
{
    public partial class Product : IComparable<Product>
    {
        public string Prod { get; set; }
  
        public bool InStock { get; set; }

        public int Price { get; set; }

        public int CompareTo(Product obj)
        {
            if (this.Price > obj.Price) return 1;
            if (this.Price < obj.Price) return -1;
            else return 0;
        }
        public virtual void Info()
        {
            Console.WriteLine("Товар в продаже!");
        }
        public Product(string prod, int price, bool instock)
        {
            this.InStock = instock;
            this.Price = price;
            this.Prod = prod;
        }
        public static int counter = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                arrayList.Add(random.Next(0, 100));
            }
            Console.WriteLine("Первая коллекция рандомных целых чисел ");
            arrayList.Add("Добавили к коллекции строку ");
            arrayList.RemoveAt(2);
            Console.WriteLine("Количество элементов " + arrayList.Count);
            foreach (var element in arrayList)
                Console.Write(element + " ");
            Console.WriteLine();
            Console.WriteLine(arrayList.Contains(0));
            //Dictionary<string, double> dictionary = new Dictionary< string,double>
            //{
            //    ["e"]=2.718 ,
            //    ["pi"] = 3.14,
            //    ["g"] = 9.8,
            //    ["A"]=6.03,
            //};
            //   foreach (var v in dictionary)
            //{
            //    Console.WriteLine(v);
            //}

            SortedSet<double> sortedSet = new SortedSet<double>();
            Console.Write("Введите кол-во элементов: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы: ");
            for (int i = 0; i < size; i++)
            {
                float temp = Convert.ToSingle(Console.ReadLine());
                sortedSet.Add(temp);
            }
            Console.WriteLine();
            Console.WriteLine("Введите кол-во элементов для удаления");
            int toDelete = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < toDelete; i++)
            {
                sortedSet.Remove(sortedSet.Last());
            }
            foreach (float element in sortedSet)
                Console.Write(element + " ");
            Console.WriteLine();

            //for(int i=0; i<del;i++)
            //{
            //    dictionary.Remove(dictionary.Last);
            //}
            //foreach (var v in dictionary)
            //{
            //    Console.WriteLine(v);
            //}

            //dictionary.Add( "V",22.4);
            //dictionary["R"] = 8.31;
            //foreach (var v in dictionary)
            //{
            //    Console.WriteLine(v);
            //}
            Queue<double> queue = new Queue<double>();
            for (int i = 0; i < sortedSet.Count; i++)
            {
                queue.Enqueue(sortedSet.ElementAt(i));
            }
            Console.WriteLine("Вторая коллекция ");
            foreach (float element in queue)
                Console.Write(element + " ");
            Console.WriteLine();
            Console.WriteLine("Введите элемент, которые хотите найти");
            double t = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(queue.Contains(t));
            Console.WriteLine();
            Product printer = new Product("Принтер", 15000, true);
            Product scaner = new Product("Scaner", 100, false);
            Product pc = new Product("ПK", 80000, true);
            SortedSet<Product> product = new SortedSet<Product>();
            product.Add(printer);
            product.Add(scaner);
            product.Add(pc);
            foreach (Product el in product)
                Console.WriteLine(el + " ");
            Console.Write("Введите кол-во элементов для удаления ");
            int Delete = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Delete; i++)
            {
                product.Remove(product.Last());
            }
            foreach (Product element in product)
                Console.WriteLine(element + " ");
            Console.WriteLine();

            Queue<Product> productqueue = new Queue<Product>();
            for(int i=0;i<product.Count;i++)
            {
                productqueue.Enqueue(product.ElementAt(i));
            }
            Console.WriteLine("Вторая коллекция");
            foreach (Product el in productqueue)
                Console.WriteLine(el + " ");
            Console.WriteLine();
            ObservableCollection<Product> observableCollection = new ObservableCollection<Product>();
            observableCollection.CollectionChanged += Notification;
            observableCollection.Add(scaner);
            observableCollection.Remove(scaner);


        }
        static void Notification(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("The collection has been changed");
        }
    }
}