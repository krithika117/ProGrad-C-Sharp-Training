using System.IO;
using System.Text;

namespace file_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File
            //File.WriteAllText("C:\\Users\\HP\\source\\repos\\day-5-hands-on\\files-created\\filedemoplain.txt", "This is Krithika");

            // File Writer
            //string s = "Hello!";
            //Console.WriteLine("Inside File handling");
            //FileStream fs = new FileStream("C:\\Users\\HP\\source\\repos\\day-5-hands-on\\files-created\\filename.txt", FileMode.OpenOrCreate);
            //byte[] content = Encoding.UTF8.GetBytes(s);
            //fs.Write(content, 0, content.Length);
            //fs.Close();

            // Stream Writer
            // FileStream fs1 = new FileStream("C:\\Users\\HP\\source\\repos\\day-5-hands-on\\files-created\\textwriter.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //Stream stream = new MemoryStream();
            //StreamWriter writer = new StreamWriter(fs1);
            //writer.WriteLine("StreamWriter Demo");
            //Console.WriteLine("Written");
            //writer.Close();

            //StreamReader reader = new StreamReader(fs1);
            //string c = reader.ReadToEnd();
            //Console.WriteLine(c);
            //fs1.Close();

            const string path = "C:\\Users\\HP\\source\\repos\\day-5-hands-on\\files-created\\textwriter.txt";

            using (TextWriter textWriter = File.CreateText(path))
            {
                char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
                textWriter.WriteLine(charArray);
            }

            using (TextReader textReader = File.OpenText(path))
            {
                Console.WriteLine(textReader.Read());
            }



        }
    }
}