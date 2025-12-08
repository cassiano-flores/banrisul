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

            //Console.WriteLine("Options:");
            //Console.WriteLine("1. Update\n2. Delete\n3. Create\n4. Read");
            //int option = int.Parse(Console.ReadLine());
            //Option toOption = (Option) option;

            //Console.WriteLine(toOption);

            int count = 0;
            while (count < 10)
            {
                Console.WriteLine("Count: " + count);
                count = count + 1;
            }

            do
            {
                Console.WriteLine("Count: " + count);
                count += 1;
            }
            while (count < 10);

            string[] words = { "Cassiano", "Luis", "Flores", "Michel" };
            foreach (string word in words)
            {
                Console.WriteLine("Word: " + word);
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("Word: " + words[i]);
            }

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Word: " + words[i]);
            }

            Console.ReadLine();
        }

        static void ShowMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
