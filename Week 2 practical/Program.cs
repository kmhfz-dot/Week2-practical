class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");

        string text = Console.ReadLine() ?? "";

        int words = CountWords(text);

        Console.WriteLine("Number of words: " + words);
    } 
    static void PrintMenu()
    {
        Console.WriteLine("Please select a language:");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("1 - French");
        Console.WriteLine("2 - Portuguese");
        Console.WriteLine("3 - German");
        Console.WriteLine("4 - Italian");
    }

    static int InputOption()
    {
        try
        {
            Console.Write("Enter your option: ");

            int option = Convert.ToInt32(Console.ReadLine());

            return option;
        }
        catch
        {
            Console.WriteLine("Invalid input. Please enter a number.");

            return -1;
        }
    }

    static string GetMessage(int language)
    {
        switch (language)
        {
            case 0:
                return "Goodbye";

            case 1:
                return "Bonjour";

            case 2:
                return "Ola";

            case 3:
                return "Hallo";

            case 4:
                return "Ciao";

            default:
                return "Please enter a valid option";
        }
    }
    static int CountWords(string text)
    {
        int count = 0;

        foreach (char letter in text)
        {
            if (char.IsUpper(letter))
            {
                count++;
            }
        }

        return count;
    }
}
