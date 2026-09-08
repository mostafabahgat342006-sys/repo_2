
using System.Text;
namespace c__ass2;

internal class Program
{
    static void Main(string[] args)
    {
        string title = "clean code";
        string upperTitle = title.ToUpper();

        Console.WriteLine(title);
        Console.WriteLine(upperTitle);

        Console.WriteLine("--------------------------");

        // interning -> the two point in same object 
        string title1 = "clean code";
        string title2 = "clean code";

        Console.WriteLine(ReferenceEquals(title1,title2));

        Console.WriteLine("--------------------------");

        // stringBuilder -> modify in the same string 
        StringBuilder text = new StringBuilder();

        text.Append("Book List");
        text.Append(" - Updated");

        Console.WriteLine(text.ToString());












    }
}
