using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP3OOP
{
    public class Set
    {
        public string[] Elements { get; set; } 
        public static int Count { get; set; } = 0; //счетчик множеств
        public Set(int count, params string[] args) //конструктор 
        {
            Count++;
            Elements = new string[count];
            for (int i = 0; i < count; i++)
            {
                Elements[i] = args[i];
            }
        }
        public Set() : this(0, "")
        { }
        public static void CountInfo() //статический метод 
        {
            Console.WriteLine($"Количество множеств: {Count}");
       
        }

        public static Set operator >>(Set s1, int itemToDelete) //удалить элемент из множества
        {
            List<string> temp = s1.Elements.ToList();
            temp.RemoveAt(itemToDelete);
            
                Console.WriteLine($"Элемент с индексом {itemToDelete} успешно удален");
                s1.Elements = temp.ToArray();
            
            return s1;
        }

        public static Set operator <<(Set s1, int position) //добавить элемент в множество
        {
            Console.WriteLine("Введите добавляемый элемент");
            string elementToInsert = Console.ReadLine();
            if (position > s1.Elements.Length) { Console.WriteLine("Превышено значение индекса"); }
            else
            {
                List<string> temp = s1.Elements.ToList();
                temp.Insert(position, elementToInsert);
                s1.Elements = temp.ToArray();
            }
            return s1;
        }
        public static string[] operator %(Set s1, Set s2) //перегружаем оператор % для пересечения множеств
        {
            List<string> tempS1 = s1.Elements.ToList();
            List<string> tempS2 = s2.Elements.ToList();
            var s3 = tempS1.Intersect(tempS2);
            string[] a = s3.ToArray();
            return a;
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
           public DateTime date { get; set; } = new DateTime(2018,10,7);
     
        }
    }
    public static class MathOperation
    {
        public static int SearchMax(Set s1)
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

        public static int SearchMin(Set s1)
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

        public static int CountOfElements(Set s1)
        {
            int countOfElements = 0;
            for (int i = 0; i < s1.Elements.Length; i++)
            {
                countOfElements++;
            }
            return countOfElements;
        }

        public static bool isItem(this Set s1, string a)
        {
            for (int index = 0; index < s1.Elements.Length; index++)
                if (s1.Elements[index] == a) return true;
            return false;
        }
    }
    public static class SetExtention
    {
       public static string GetShortest(this Set s1)
        {
            string shortest="";
            int min = s1.Elements[0].Length;
            for (int i = 1; i < s1.Elements.Length; i++)
            {
                if (min > s1.Elements[i].Length)
                {
                    min = s1.Elements[i].Length;
                    shortest = s1.Elements[i];
                }
            }
            return shortest ;
        }
        public static Set DeleteLast(this Set s1)
        {
            List<string> temp = s1.Elements.ToList();
          
            temp.RemoveAt(Set.Count);

            Console.WriteLine($"Последний элемент успешно удален");
            s1.Elements = temp.ToArray();

            return s1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Set set1 = new Set(4,"!!","gggggggggg","sddf","we"); //1-ое множество
            Set set2 = new Set(3, "hello","world" ,"!!"); //2-ое множество
            Set set3 = new Set(3, "my", "name", "is"); //3-е множество
            Console.Write("Элементы 1-ого множества: ");
            for (int i = 0; i < set1.Elements.Length; i++)
            {
                Console.Write(set1.Elements[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Элементы 2-ого множества: ");
            for (int i = 0; i < set2.Elements.Length; i++)
            {
                Console.Write(set2.Elements[i] + " ");
            }
            Console.WriteLine();

            Set.CountInfo(); //выводим количество множеств

            Console.WriteLine("Пересечение множеств:");
            string[] v = set1 % set2; //выполняем пересечение двух множеств
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Удаление элемента из множества:");
            set1 = set1 >> 2; //удаляем элемент множества со значением 4
            for (int i = 0; i < set1.Elements.Length; i++)
            {
                Console.Write(set1.Elements[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Добавление элемента в множество:");
            set2 = set2 << 1;
            for (int i = 0; i < set2.Elements.Length; i++)
            {
                Console.Write(set2.Elements[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(set2 == set3);

            Set.Owner owner = new Set.Owner(151199, "Alesia", "Belstu");
            Console.WriteLine(owner.ID);

            Set.Date dateOfCreation = new Set.Date();
            Console.WriteLine($"Класс создан: {dateOfCreation.date}");
            Console.WriteLine("Максимальная длина элемента в 1 множестве: {0}", MathOperation.SearchMax(set1));
            Console.WriteLine("Минимальная длина элемента в 1 множестве: {0}", MathOperation.SearchMin(set1));
            Console.WriteLine("Количество элементов в 1 множестве: {0}", MathOperation.CountOfElements(set1));
            Console.WriteLine(set1.isItem("is"));
        }
    }
}



