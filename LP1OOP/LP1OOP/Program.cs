using System;//содержит фунд. и базовые классы платформы .Net
using System.Collections.Generic;
using System.Linq;
using System.Text;//описаны типы для обработки строк
using System.Threading.Tasks;

namespace LP1OOP
{
    class Program
    {
       
            struct Myobject
            { public int Val; }
        
        static void Main(string[] args)
        {
            //Определите переменные всех возможных примитивных типов
            // С# и проинициализируйте их
            int i = 0;
            int iNumber=-5_831_995;//32
            double dNumber = -99.9999;//64
            sbyte sbNumber = -20;//8
            short shNumber = -22222;//16
            long lNumber = -44_447_474_747;
            byte bNumber = 15;//8
            ushort ushNumber = 2222;//16
            uint uiNumber = 5_831_995;//32
            ulong ulNumber = 44_447_474_747;//64
            char chLetter = 'A';//16
            bool isTrue = true;//8
            float fNumber = 10.5F;//32
            decimal decNumber = 3784849499393939393;
            string myString = "Alesia";
            object myObj = 666;
            //Выполните 5 операций явного и 5 неявного приведения
            Int32 variableOne = (Int32)bNumber;
            Byte variableTwo = (Byte)ushNumber;
            long variableThree = (long)iNumber;
            ushort variableFour = (ushort)shNumber;
            uint variableFive = (uint)iNumber;
            long i64 = iNumber;
            int i32 = shNumber;
            short i16 = sbNumber;
            double doub64 = fNumber;
            float fl32 = uiNumber ;
            //Выполните упаковку и распаковку значимых типов
            Myobject obj = new Myobject();
            obj.Val = 7777;
            object refType = obj;//упаковка
            Myobject ValType =(Myobject)refType;//распаковка
            double x = 123.123;
            object object2 = x;
            short mShort = (short)(double)object2;
            //Продемонстрируйте работу с неявно типизированной переменной
            var array = new[] { 100, 2.55, 65.789, 321.0, 66666666666 };
            Console.Write($"Тип массива array: {array.GetType()}");
            Console.WriteLine();
            var stringVar = "Hello World";
            Console.Write($"Тип строки Hello World: {stringVar.GetType()}");
            Console.WriteLine();
            //Продемонстрируйте пример работы с Nullable переменной
            int? x1 = null;
            if (x1.HasValue)
            {
                int x2 = (int)x1;
                Console.WriteLine(x2);
            }
            float? val1 = null;
            float? val2 = null;
            Console.WriteLine($"Равны ли 2 null значения?: { val1 == val2}");
            int? z = 15;
            int temporary = z ?? 1;
            Console.WriteLine($"Чему будет равна переменная (15 или 1): { val1 == val2}");
            //Объявите строковые литералы. Сравните их
            char[] charArray = { 'l', 'o','w'};//создание массива симовлов
            string str;
            str = "hello, i am string";
            string str0 = ",and who are you?";
            string str1 = new string(' ', 30);// конструктором
            string str2 = new string(charArray);
          if(String.CompareOrdinal(str,str0)!=0)
            {
                Console.WriteLine("Строки str и str0 не равны");
            }
            if (str.CompareTo("Alesia Hlushakova") != 0)
            {
                Console.WriteLine("Строки str и Alesia Hlushkova не равны");
            }
            string newString = String.Concat(str,str0);
            Console.WriteLine($"Конкатенация двух строк: {str} и {str0}: {newString}");//сцепление
            newString = String.Copy(str2);
            Console.WriteLine($"Копирование строки: {newString}");//копирование
            string[] strings = str.Split(new char[] { ' ',','});//разделение строки на слова
            Console.WriteLine("Разделение строки на слова:");
            foreach (string st in strings)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine($"Добавление символа в строку {str2} : {str2.Insert(0,"s")}");//вставка подстроки в заданную позицию
            Console.WriteLine($"Удаление символа из строки {str2} : {str2.Remove(0,2)}");//удаление подстроки из заданной позиции
            // Создайте пустую и null строку
            string emptyString = "";
            string nullString = null;
            string newStr = emptyString + nullString;//результатом будет пустая строка
            int lengthOfString = emptyString.Length;
            str1 = emptyString.Insert(0,str);
            string tempStr = str + nullString;
            bool boolean = (emptyString == nullString);
            Console.WriteLine(boolean);
            //Создайте строку на основе StringBuilder. Удалите определенные
            //позиции и добавьте новые символы в начало и конец строки.
            StringBuilder strBuilder = new StringBuilder("Rsttstring created with ", 100);
            strBuilder.Remove(0, 4);
            strBuilder.Append(" StringBuilder");
            strBuilder.Insert(0, "A ");
            Console.WriteLine(strBuilder);
            //Массивы
            int[,] newArray = { { 45, 56,123,777 }, { 55, 46,567,2 } };
            for (i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write("{0,4}", newArray[i, j]);
                Console.WriteLine();
            }
            String[] collection = new String[] { "строка 1", "строка 2", "строка 3" };
            Console.WriteLine("Вывод массива строк:");
            foreach (String element in collection)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine( $"Размер массива строк= {collection.Length}");//Создайте одномерный массив строк. Выведите на консоль его
            Console.WriteLine("Введите позицию элемента массива строк:");// содержимое, длину массива. Поменяйте произвольный элемент
            int n = int.Parse(Console.ReadLine());//(пользователь определяет позицию и значение)
            string mString = Console.ReadLine();
            collection[n] = mString;
            Console.WriteLine("Вывод  измененного массива строк:");
            foreach (String element in collection)
            {
                Console.WriteLine(element);
            }
            //Создайте ступечатый (не выровненный) массив вещественных
            // чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов  соответственно
           
            int[][] jaggedArray = { new int[2], new int[3], new int[4]};
            Console.WriteLine("Введите элементы зубчатого массива:");
            for (i=0;  i < 2;i++)
            {
                jaggedArray[0][i] = int.Parse(Console.ReadLine());
               
            }
            for (i=0; i < 3; i++)
            {
                jaggedArray[1][i] = int.Parse(Console.ReadLine());
              
            }
            for (i=0; i < 4; i++)
            {
                jaggedArray[2][i] = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine();
            foreach (int[] row in jaggedArray)
            {
                foreach (int num in row)
                {
                    Console.Write($"{num}\t");
                }
                Console.WriteLine();
            }
            //Кортежи
            (int age, string name, char secondname, string surname, ulong phone) myTuple = (19, "Alesia", 'M', "Hlushakova", 336340558);
            Console.WriteLine("Вывод кортежа полностью:");
            Console.WriteLine($"{myTuple}");
            Console.WriteLine("Вывод кортежа частично:");
            Console.WriteLine($"Возраст: {myTuple.age}\t Отчество: {myTuple.secondname}\t Фамилия: {myTuple.surname}\t  ");
            int ages = myTuple.age;
            string names = myTuple.name;
            char secondnames = myTuple.secondname;
            string surnames = myTuple.surname;
            ulong telephone = myTuple.phone;
            //Локальная функция
            (int, int, string) GetExtremumSumLetter(int[] funcArray, string funcString)
            {
                int max = 0;
                int min = 0;
                for(i=0; i<funcArray.Length;i++)
                {
                    if (funcArray[i]>max)
                    {
                        max = funcArray[i];
                    }
                    if (funcArray[i] <min)
                    {
                        min = funcArray[i];
                    }
                }
                string firstLetter = funcString.Substring(0, 1);
                (int, int, string) funcTuple = (min, max, firstLetter);
                return funcTuple;
            }
           // Console.WriteLine("Вызов локальной функции, возвращающей экстремумы массива и первую бувку строки:");
           // Console.WriteLine("Введите кол-во элементов массива:");
            //int quantity = int.Parse(Console.ReadLine());
            //int[quantity] functionArray;
            //for (i = 0; i <quantity;i++)
          //  {
            //    functionArray[i] = int.Parse(Console.ReadLine());
            //}
                Console.WriteLine($"{GetExtremumSumLetter( new int[] { 11, 33, -4 },"Salam")}");
        }
        
    }
}
    