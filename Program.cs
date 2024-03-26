namespace SUS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.Create("sus.txt");
            fs.Close();
            StreamWriter sw = new StreamWriter("sus.txt");
            while (true)
                sw.WriteLine("NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA!\n");
        }
    }
}
