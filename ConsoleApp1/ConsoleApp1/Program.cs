using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        Random rand = new Random();
        static void Main(string[] args)
        {
            var rand = new Random();

            //завдання 3

            Console.WriteLine("Введіть число монет");
            int money = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть чи є зілля ( true / false )");
            bool poison = bool.Parse(Console.ReadLine());
            bool hasSword = false;
            if (money >= 10 && !hasSword)
            {
                money -= 10;
                hasSword = true;
            }
            else if (poison && !hasSword)
            {
               poison = false;
               hasSword = true;
            }
            else
            {
                Console.WriteLine("Вибачай Лінк,я не даю кредиту , Приходь іншим разом , коли ти станеш трохи м-м-м багатшим");
            }

        }
    }
}
