namespace SUS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.Create("sus.txt");
            FileInfo fi = new FileInfo("sus.txt");
            fs.Close();
            StreamWriter sw = new StreamWriter("sus.txt");
            int line = 0;
            while (line < 20000000)
            {
                sw.WriteLine("NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA! NIGGA!");
                line++;
            }
                
            Console.WriteLine(fi.Length);
        }
    }
}
