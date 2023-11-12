namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {
                "Efe",
                "Mete",
                "Cosmo",
                "Luna",
                "Bihter"
            };
            // arrays are fixed inside so we can not push an element. that is exactly why we need to work with collections.
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            List<string> list = new List<string>
            {
                "Efe",
                "Mete",
                "Cosmo",
                "Luna",
                "Bihter"
            };
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
            Console.WriteLine(list[3]);
            Console.WriteLine(list[4]);
            list.Add("Hikmets");
            Console.WriteLine(list[5]);
            Console.WriteLine(list[0]);
        }
    }
}