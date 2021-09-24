using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

#region spagetyCode
namespace BackToCsharp
{
    class Program
    {
        //MyPrint myPrint = new MyPrint();
        static void Main(string[] args)
        {
            setup();
            Intro();
            Cal();
        }

        #region Intro
        static void setup()
        {
            Console.Title = "Time Converter";

        }
        static void Intro()
        {
            MyPrint.Welcome2();
            string name = Name();
            Console.ReadLine();
            Console.Clear();
        }
        static string Name()
        {
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            if (name != ""){
                Console.WriteLine($"Hello {name}!");
            }
            else
            {
                Console.WriteLine($"LOL - Who want know your name anyway :D");
            }
            return name;
        }
        #endregion

        static void Cal(string jednotka = "hodin")
        {
            while (true) {
                Console.WriteLine($"Zadej počet {jednotka}: ");
                Regex regex = new Regex(@"^\d+$"); //redex syntax je pain 
                string number;
                while (true)
                {
                    number = Console.ReadLine();
                    if (regex.IsMatch(number)) { break; }
                    else
                    {
                        Console.WriteLine("Nezdal jsi celé číslo!");
                    }
                }
                int num = Convert.ToInt32(number);

                Console.Clear();
                MyPrint.Logo();
                if (jednotka == "hodin")
                {
                    int sec = num * 3600;
                    int min = num * 60;
                    int h = num * 1;
                    Console.WriteLine($"{number} {jednotka} je: {sec} sekund nebo {min} minut"); // fix sklonovani - "1 hodin="
                }
                //else if (jednotka == "minuta"){}
                else
                {
                    var rand = new Random();
                    int random = rand.Next(1, 100);
                    if (random > 50) {Console.WriteLine($"Something went wrong :/");}
                    else { Console.WriteLine($"Spagety code go BRRRRRRR"); }
                }

                Console.WriteLine("\n\nChcete opakovat akci? \n [y] - yes | [n] - no");
                string next = Console.ReadLine();
                next = next.ToLower();

                if (next == "y") { Console.Clear(); } //|| "yes" || "jo"
                else { break; }
            }


        }
    }
}
#endregion 
