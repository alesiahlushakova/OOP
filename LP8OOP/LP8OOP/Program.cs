using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP3OOP
{
    public  class Product 
    {
        
        public bool InStock { get; set; }

        public int Price { get; set; }
        public Product( int price, bool instock)
        {
            this.InStock = instock;
            this.Price=price;
        }
      
    }
        public interface IDo<T>
        where T:IEquatable<T>
    {
        CollectionType<T> Add(CollectionType<T> s1, int position, T t);
        CollectionType<T> Delete(CollectionType<T> s1, int itemToDelete);
        void Show();
    }
    public class CollectionType<T>:IDo<T>
        where T : IEquatable<T>
    {
        
       
        public T[] Elements { get; set; }
        public static int Count { get; set; } = 0; //счетчик множеств
        public CollectionType (int count, params T[] args) //конструктор 
        {
            try
            {
                if (count >0)
                {
                    Count++;
                   
                }
                else
                {
                    count = -count;
                    throw new Exception();
                }
            }
            catch(Exception e)
            {
                   
                Console.WriteLine("Параметры не могут быть отрицательными!!");
            }
            finally
            {
                Elements = new T[count];
                for (int i = 0; i < count; i++)
                {
                    Elements[i] = args[i];
                }
            }
           
        }
        public CollectionType() : this(0, default(T))
        { }
        public static void CountInfo() //статический метод 
        {
            Console.WriteLine($"Количество множеств: {Count}");

        }

        public override int GetHashCode()
        {

            int hash = 269;

            hash = (hash * 47) + Elements.GetHashCode();
            return hash;
        }

        public static CollectionType<T> operator >>(CollectionType<T> s1, int itemToDelete) //удалить элемент из множества
        {
            List<T> temp = s1.Elements.ToList();
            temp.RemoveAt(itemToDelete);

            Console.WriteLine($"Элемент с индексом {itemToDelete} успешно удален");
            s1.Elements = temp.ToArray();

            return s1;
        }
        public static bool CheckM<T>(T t, T[] Elements)
        {
            foreach (T v in Elements)

                if (v.Equals(t))
                    return true;
            return false;
        }


   
        public static T[] operator %(CollectionType<T> s1, CollectionType<T> s2) //перегружаем оператор % для пересечения множеств
        {
            List<T> tempS1 = s1.Elements.ToList();
            List<T> tempS2 = s2.Elements.ToList();
            var s3 = tempS1.Intersect(tempS2);
            T[] a = s3.ToArray();
            return a;
        }
        public static bool operator >(CollectionType<T> s1, CollectionType<T> s2) //является ли первое подмножеством второго
        {
            List<T> tempS1 = s1.Elements.ToList();
            List<T> tempS2 = s2.Elements.ToList();
            return !tempS1.Except(tempS2).Any();
        }
        public static bool operator <(CollectionType<T> s2, CollectionType<T> s1) //является ли второе подмножеством первого
        {
            List<T> tempS1 = s1.Elements.ToList();
            List<T> tempS2 = s2.Elements.ToList();
            return !tempS1.Except(tempS2).Any();
        }
        public class Owner
        {
            public int ID { get; set; } = 151199;
            public string Name { get; set; } = "Alesia Hlushkoba";
            public string Organization { get; set; } = "Стдентка БГТУ специальности ПОИТ  5гр.";

            public Owner(int ID, string Name, string Organization) //вложеннный класс
            {
                this.ID = ID;
                this.Name = Name;
                this.Organization = Organization;
            }
        }

        public class Date
        {
            public DateTime date { get; set; } = new DateTime(2018, 10, 7);

        }
        public void Show()
        {
           
                Console.WriteLine("Тип : {0}", typeof(T));
                foreach (T t in Elements)
                {
                    Console.WriteLine("{0}\t", t);

                }
                Console.WriteLine();
            
           
        }
        public CollectionType<T> Add(CollectionType<T> s1,int position, T t)
        {
           
            if (position > s1.Elements.Length) { Console.WriteLine("Превышено значение индекса"); }
            else
            {
                List<T> temp = s1.Elements.ToList();
                temp.Insert(position, t);
                s1.Elements = temp.ToArray();
            }
            return s1;
        }
        public CollectionType<T> Delete(CollectionType<T> s1, int itemToDelete)
        {
            List<T> temp = s1.Elements.ToList();
            temp.RemoveAt(itemToDelete);

            Console.WriteLine($"Элемент с индексом {itemToDelete} успешно удален");
            s1.Elements = temp.ToArray();

            return s1;
        }
    }
    public static class MathOperation//реализация интерфесов статическими классами невозможна
    {
        public static int SearchMax(CollectionType<string> s1)
        {
            int max = s1.Elements[0].Length;
            for (int i = 1; i < s1.Elements.Length; i++)
            {
                if (max < s1.Elements[i].Length)
                {
                    max = s1.Elements[i].Length;
                }
            }
            return max;
        }

        public static int SearchMin(CollectionType<string> s1)
        {
            int min = s1.Elements[0].Length;
            for (int i = 1; i < s1.Elements.Length; i++)
            {
                if (min > s1.Elements[i].Length)
                {
                    min = s1.Elements[i].Length;
                }
            }
            return min;
        }

        public static int CountOfElements(CollectionType<string> s1)
        {
            int countOfElements = 0;
            for (int i = 0; i < s1.Elements.Length; i++)
            {
                countOfElements++;
            }
            return countOfElements;
        }

        public static bool isItem(this CollectionType<string> s1, string a)
        {
            for (int index = 0; index < s1.Elements.Length; index++)
                if (s1.Elements[index] == a) return true;
            return false;
        }
    }
    public static class SetExtention
    {
        public static string GetShortest(this CollectionType<string> s1)
        {
            string shortest = "";
            int min = s1.Elements[0].Length;
            for (int i = 1; i < s1.Elements.Length; i++)
            {
                if (min > s1.Elements[i].Length)
                {
                    min = s1.Elements[i].Length;
                    shortest = s1.Elements[i];
                }
            }
            return shortest;
        }
        public static CollectionType<string> DeleteLast(this CollectionType<string> s1)
        {
            List<string> temp = s1.Elements.ToList();

            temp.RemoveAt(CollectionType<string>.Count);

            Console.WriteLine($"Последний элемент успешно удален");
            s1.Elements = temp.ToArray();

            return s1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
                CollectionType<string> set1 = new CollectionType<string>(4, "!!", "gggggggggg", "sddf", "we"); //1-ое множество
                CollectionType<int> set2 = new CollectionType<int>(-3, 3, 2, 3); //2-ое множество
                CollectionType<string> set3 = new CollectionType<string>(3, "my", "name", "is"); //3-е множество
                                                                         //  Set<Product> set4 = new Set<Product>(400,true); //4-ое множество
                                                                           //Set set5 = new Set(1, "1"); //5-е множество
                Console.Write("Элементы 1-ого множества: ");
                set1.Show();

                Console.Write("Элементы 2-ого множества: ");
                set2.Show();

                CollectionType<string>.CountInfo(); //выводим количество множеств

                Console.WriteLine("Пересечение множеств:");
                string[] v = set1 % set3; //выполняем пересечение двух множеств
                for (int i = 0; i < v.Length; i++)
                {
                    Console.Write(v[i] + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Удаление элемента из множества:");
                set1 = set1 >> 1; //удаляем элемент множества 
                for (int i = 0; i < set1.Elements.Length; i++)
                {
                    Console.Write(set1.Elements[i] + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Добавление элемента в множество:");
                set2 = set2.Add(set2, 1, 567);
                for (int i = 0; i < set2.Elements.Length; i++)
                {
                    Console.Write(set2.Elements[i] + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Является ли множество подмножeством другого");
                Console.WriteLine(set1 > set3);

                CollectionType<string>.Owner owner = new CollectionType<string>.Owner(151199, "Alesia", "Belstu");
                Console.WriteLine(owner.ID);
         //   Set<Product> set4 = new Set<Product>();
                CollectionType<string>.Date dateOfCreation = new CollectionType<string>.Date();
                Console.WriteLine($"Класс создан: {dateOfCreation.date}");
                Console.WriteLine("Максимальная длина элемента в 1 множестве: {0}", MathOperation.SearchMax(set1));
                Console.WriteLine("Минимальная длина элемента в 1 множестве: {0}", MathOperation.SearchMin(set1));
                Console.WriteLine("Количество элементов в 1 множестве: {0}", MathOperation.CountOfElements(set1));
                Console.WriteLine(set1.isItem("is"));

            
            
        }
    }
}



