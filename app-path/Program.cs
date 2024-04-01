using System.Net.Mime;
using System.Text;

namespace app_path
{
    internal class Program
    {

        static void Main()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            Console.WriteLine(projectDirectory);

            string filePath = Path.Combine(projectDirectory, "Report1.rdlc");
            Console.WriteLine(filePath);
        }




    }
}
