
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

        Console.WriteLine("--------------------------");

        // Replace( old name , new name )
        text.Replace("Book List", "Library");

        Console.WriteLine(text.ToString());

        Console.WriteLine("--------------------------");

        string newTitle = "Clean Code";
        int pages = 464;
        Console.WriteLine("Book: " + newTitle + " , " + "pages: " + pages + " .");

        Console.WriteLine("--------------------------");

        Console.WriteLine($"Book: {newTitle} , pages: {pages} .");

        Console.WriteLine("--------------------------");

        string sentence = string.Format(
            "Book: {0}, Pages: {1} .",
                newTitle,
                pages

            );
        Console.WriteLine(sentence);

        Console.WriteLine("--------------------------");

        int nwePages = 464;

        if( nwePages > 300 )
        {
            Console.WriteLine("Long Book");
        }
        else
        {
            Console.WriteLine("Short Book");
        }

        Console.WriteLine("--------------------------");

        bool isAvailable = true;

        if (pages > 300 && isAvailable)
        {
            Console.WriteLine("You can borrow this book");
        }

        Console.WriteLine("--------------------------");

        string refTitle = "Refactoring";

        switch (refTitle)
        {
            case "Clean Code":
                Console.WriteLine("Great choice!");
                break;

            case "Refactoring":
                Console.WriteLine("Nice pick!");
                break;

            default:
                Console.WriteLine("Never heard of it");
                break;
        }

        Console.WriteLine("--------------------------");

        // ternary operator -> if statement is true take follwing symbole "?" directly
        string sizeLabel;

        sizeLabel = pages > 300 ? "Long Book" : "Short Book";

        Console.WriteLine(sizeLabel);

        Console.WriteLine("--------------------------");

        string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

        for (int i = 0; i < Books.Length; i++)
        {
            // (i+1) because index start from 0 but natural numbering start from 1
            Console.WriteLine((i+1) + ": "+ Books[i]);
        }

        Console.WriteLine("--------------------------");

        int index = 0;

        while (index < Books.Length)
        {
            Console.WriteLine(Books[index]);
            index++;
        }

        Console.WriteLine("--------------------------");

        int count = 0;

        do
        {
            Console.WriteLine("Checking book...");
            count++;
        }
        while (count < 3);

        Console.WriteLine("--------------------------");

        foreach (string book in Books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("--------------------------");

        foreach (string book in Books)
        {
            if (book == "Refactoring")
            {
                // break -> stop and exit from loop 
                break;
            }

            Console.WriteLine(book);
        }

        Console.WriteLine("--------------------------");























    }
}
