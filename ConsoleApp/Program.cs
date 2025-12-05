using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        enum Option { Update = 1, Delete, Create, Read }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //string nome = Console.ReadLine();
            //Console.WriteLine("Nome: " + nome);

            //if (string.IsNullOrEmpty(nome))
            //{
            //    Console.WriteLine("Nome vazio");
            //}
            //else
            //{
            //    ShowMsg("Nome preenchido");
            //}

            Console.WriteLine("Options:");
            Console.WriteLine("1. Update\n2. Delete\n3. Create\n4. Read");
            int option = int.Parse(Console.ReadLine());
            Option toOption = (Option) option;

            Console.WriteLine(toOption);

            Console.ReadLine();
        }

        static void ShowMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}