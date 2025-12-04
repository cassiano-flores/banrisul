using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string nome = Console.ReadLine();
            Console.WriteLine("Nome: " + nome);

            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome vazio");
            }
            else
            {
                ShowMsg("Nome preenchido");
            }

            Console.ReadLine();
        }

        static void ShowMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}