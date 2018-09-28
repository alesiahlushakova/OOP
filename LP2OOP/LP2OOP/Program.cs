using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LP2OOP
{
     partial class SuperString
    {
        const int MAX_SIZE= 20;
        public static int counter = 1;
        private string last;
        private string first;
        public static string student { get; set; } = "Student: ";
        public static void getStudent() { Console.WriteLine(student); }
        readonly int id ;
        private bool isInitialized;
        public string lastName
        {
            set
            {
                    last = value;
            }
            get
            {
                return last;
            }

        }
        public string firstName
        {
            set
            {
                    first = value;
            }
            get
            {
                return first;
            }

        }

        public SuperString()//по умолчанию
        {
           last = null;
           first = null;
            counter++;
        }
        public SuperString(string lastName ="unknown")//по умолчанию
        {
            last = lastName;
            id = 0;
            counter++;
        }
        public SuperString(string lastName, string firstName)
        { 
            last = lastName;
            first = firstName;
           
            id = lastName.GetHashCode();
            counter++;
           
        }
        static SuperString()
        {
            Console.WriteLine("Создан первый экземпляр SuperString! ");
        }
        private SuperString( bool isInitialized)  //невозможно будет создть экземпляр,исп-ся при ????
        {
            this.isInitialized = isInitialized;
        }
        
        
      public  int OuputStringLength( string str, out int c)
        {
            Console.WriteLine($"Длина строки: {str.Length}");
            c = str.Length;
            return c;
        }
       public bool CheckSymbol ( string str)
        {
            Console.WriteLine("Введите символ для поиска в строке: ");
           string symbol= Console.ReadLine();
            if(str.Contains(symbol))
            {
                Console.WriteLine("Символ есть в строке");
                return true;
            }
            Console.WriteLine("Символa нет в строке");
            return false;
        }
       public string ReplaceSymbol ( string str )//
        {
            Console.WriteLine("Введите символ,который хотите заменить");
            string symb1 = Console.ReadLine();
            Console.WriteLine("Введите символ, на который хотите заменить");
            string symb2 = Console.ReadLine();
            Console.WriteLine(str.Replace(symb1, symb2));
            return str;
           
        }

        public static void OutputClassInfo()
        {
            Console.WriteLine($"Количество созданных объектов класса равно {counter}");
        }
        public virtual Boolean Equals (SuperString obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            SuperString superstr = (SuperString)obj;
            return (this.lastName == superstr.lastName && this.firstName == superstr.firstName);
        }
        public override int GetHashCode()
        {
            int hash = 269;
            hash = string.IsNullOrEmpty(lastName) ? 0 : lastName.GetHashCode();
            hash = (hash * 47) + firstName.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            return ("Фамилия " + lastName + " Имя " + firstName);
        }
    }
    partial class SuperString
    {

    }
    class MainClass
    {
        static void Main()
        {
            SuperString.getStudent();
  
            SuperString str1 = new SuperString();
            str1.lastName = "Zabelin";
            str1.firstName = "Max";
            SuperString str2 = new SuperString();
            SuperString.OutputClassInfo();
            str2.lastName = "Hlushakova";
            str2.firstName = "Alesia";
            str2.CheckSymbol( str2.lastName);
            str2.OuputStringLength(str2.firstName);
            str2.ReplaceSymbol(str2.lastName);
            
          
            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.GetHashCode());
            var someType = new { lastNAme = "Duben", firstName="Polina" };
            Console.WriteLine($"Анонимный тип {someType}");
            SuperString[] Node = new SuperString[4];
            for (int count=0;count<4;count++)
            {
                Node[count] = new SuperString();
                Console.WriteLine("Введите фамилию студента ");
                Node[count].lastName = Console.ReadLine();
                Console.WriteLine("Введите имя студента ");
                Node[count].firstName = Console.ReadLine();

            }
            Console.WriteLine("Введите длину строк");
            List<string> strings = new List<string>();
            int quantity = int.Parse(Console.ReadLine());
            for (int count = 0; count < 4; count++)
            {
               
              if(  Node[count].lastName.Length==quantity)
                {
                    strings.Add(Node[count].lastName);
                }
         
              if (Node[count].firstName.Length==quantity)
                {
                    strings.Add(Node[count].firstName);
                }

            }
            Console.WriteLine("Строки с заданной длиной ");
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Введите заданное слово");
            List<string> superstrings = new List<string>();
           string word = Console.ReadLine();
            for (int count = 0; count < 4; count++)
            {

                if (Node[count].lastName.Contains(word))
                {
                    superstrings.Add(Node[count].lastName);
                }

                if (Node[count].firstName.Contains(word))
                {
                    superstrings.Add(Node[count].firstName);
                }

            }
            Console.WriteLine("Строки, которые содержат данное слово ");
            foreach (string str in superstrings)
            {
                Console.WriteLine(str);
            }
        }

    }
}
