using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP9OOP
{
  
    public class Game
    {
        public delegate void Activities();
        public event Activities Attack;
        public event Activities Heal;
      
   
       
        public void AttackEvent()
        {
            if (Attack != null)
                Attack();
        }
        public void HealEvent()
        {
            if (Heal != null)
                Heal();
        }
    }
    class Example 
    {
        public string Player { get; set; }
        public int HP { get; set; }
        public static int Count = 0;
        public Example(string player, int hp)
        {
            this.Player = player;
            this.HP = hp;
            Count++;
        }
        public void Show()
        {
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine($"Игрок {Player} HP {HP}");
            Console.WriteLine("------------------------------------------------------------------------------\n");
        }
        public void AttackWitch()
        {
            if (Player == "Man")
            {
                HP = HP - 100;
                Show();
            }
            if (Player == "Witch")
            {
                Console.WriteLine("Вы не можете атаковать свою же группу");
                Show();
            }
            if (Player == "Vampire")
            {
                HP -= 500;
                Show();
            }
        }
        public void AttackMan()
        {
            if (Player == "Man")
            {
                Console.WriteLine("Вы не можете атаковать свою же группу");
                Show();
            }
            if (Player == "Witch")
            {
                HP -= 800;
                Show();
            }
            if (Player == "Vampire")
            {
                HP -= 1000;
                Show();
            }
        }
        public void AttackVampire()
        {
            if (Player == "Man")
            {
                HP -= 900;
                Show();
            }
            if (Player == "Vampire")
            {
                Console.WriteLine("Вы не можете атаковать свою же группу");
                Show();
            }
            if (Player == "Witch")
            {
                HP -= 200;
                Show();
            }
        }
        public void HealWitch()
        {
            if (Player == "Man")
            {
                Console.WriteLine("Вы не можете лечить не свою  группу");
                Show();
            }
            if (Player == "Witch")
            {
                HP += 1500;
                Show();
            }
            if (Player == "Vampire")
            {
                Console.WriteLine("Вы не можете лечить не свою  группу");
                Show();
            }
            }
        public void HealMan()
        {
            if (Player == "Man")
            {
                HP += 1000;
                Show();
            }
            if (Player == "Witch")
            {
                Console.WriteLine("Вы не можете лечить не свою  группу");
                Show();
            }
            if (Player == "Vampire")
            {
                Console.WriteLine("Вы не можете лечить не свою  группу");
                Show();
            }
            }
        public void HealVampire()
        {
            if (Player == "Man")
            {
                Console.WriteLine("Вы не можете лечить не свою  группу");
            }
            if (Player == "Vampire")
            {

                HP += 2000;
                Show();
            }
            if (Player == "Witch")
            {
                Console.WriteLine("Вы не можете лечить не свою  группу");
                Show();
            }
        }


      

        
    }
    class StringProc
    {
        public static string RemDot(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ElementAt(i) == '.')
                {
                    str = str.Remove(i, 1);
                }
            }
            return str;
        }

        public static string RemSp(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (str.ElementAt(i) == ' ' && str.ElementAt(i - 1) == ' ')
                {
                    str = str.Remove(i, 1);
                }
            }
            return str;
        }

        public static string ToUpp(string str)
        {
            str = str.ToUpper();
            return str;
        }

        public static string AddDot(string str)
        {
            str = str.Insert(str.Length, ".");
            return str;
        }

        public static void show(string str)
        {
            Console.WriteLine(str);
        }
    }
    delegate string Operation(string str);
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Example witch = new Example("Witch",6000);
            Example man = new Example("Man", 2000);
            Example vampire = new Example("Vampire", 8000);
            Console.WriteLine("Начальная информация о игроках");
            witch.Show();
            man.Show();
            vampire.Show();
            Console.WriteLine("\n \n \n");
            game.Attack += witch.AttackMan;
            game.Attack += witch.AttackVampire;
            game.Attack += man.AttackWitch;
            game.Attack += vampire.AttackWitch;
           
            game.Heal += witch.HealMan;
        
            game.Heal += man.HealMan;

            game.AttackEvent();
            game.HealEvent();
              Func<string, string> func;

            string mystr = "one  two  three . four";
            Console.WriteLine(mystr);

            func = StringProc.RemDot;
            mystr = func(mystr);
            Console.WriteLine(mystr);

            func = StringProc.RemSp;
            mystr = func(mystr);
            Console.WriteLine(mystr);

            func = StringProc.ToUpp;
            mystr = func(mystr);
            Console.WriteLine(mystr);

            func = StringProc.AddDot;
            mystr = func(mystr);
            Console.WriteLine(mystr);

            Console.WriteLine();

            Action<string> action=StringProc.show;
            action(mystr);
  

            
        }

     
    }
}
