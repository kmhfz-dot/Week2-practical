Main();

static void Main()
{
    int option;

    do
    {
        PrintMenu();

        option = InputOption();

        string message = GetMessage(option);

        Console.WriteLine(message);

    } while (option != 0);
    Console.WriteLine("Enter a string:");
    string text = Console.ReadLine();

    int words = CountWords(text);

    Console.WriteLine($"Number of words: {words}");
    Console.WriteLine("Enter text to encrypt:");
    string plainText = Console.ReadLine();

    Console.WriteLine("Enter rotation:");
    int rotation = Convert.ToInt32(Console.ReadLine());

    string encrypted = Encrypt(plainText, rotation);

    Console.WriteLine($"Original: {plainText}");
    Console.WriteLine($"Encrypted: {encrypted}");
    string decrypted = Decrypt(encrypted, rotation);

    Console.WriteLine($"Decrypted: {decrypted}");
    CipherMenu();
    double radius;

    do
    {
        Console.WriteLine("Enter circle radius, or 0 to exit:");

        radius = Convert.ToDouble(Console.ReadLine());

        if (radius != 0)
        {
            double area = CircleArea(radius);

            Console.WriteLine($"Area: {area}");
        }

    } while (radius != 0);
}
static void PrintMenu()
{
    Console.WriteLine("Please select an option:");
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

static string Encrypt(string text, int rotation)
{
    string encryptedText = "";
    foreach (char letter in text)
    {
        if (char.IsUpper(letter))
        {
            char shifted = (char)('A' + (letter - 'A' + rotation) % 26);
            encryptedText += shifted;
        }
        else if (char.IsLower(letter))
        {
            char shifted = (char)('a' + (letter - 'a' + rotation) % 26);
            encryptedText += shifted;
        }
        else
        {
            encryptedText += letter;
        }
    }
    return encryptedText;
}
static string Decrypt(string text, int rotation)
{
    string decryptedText = "";

    foreach (char letter in text)
    {
{
    if (char.IsUpper(letter))
    {
        char shifted = (char)('A' + (letter - 'A' - rotation + 26) % 26);
        decryptedText += shifted;
    }
    else if (char.IsLower(letter))
    {
        char shifted = (char)('a' + (letter - 'a' - rotation + 26) % 26);
        decryptedText += shifted;
    }
    else
    {
        decryptedText += letter;
    }
}
    }

    return decryptedText;
}
static void CipherMenu()
{
    Console.WriteLine("Cipher Menu");
    Console.WriteLine("1 - Encrypt");
    Console.WriteLine("2 - Decrypt");
    Console.WriteLine("0 - Exit");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("Enter text to encrypt:");
        string text = Console.ReadLine();

        Console.WriteLine("Enter rotation:");
        int rotation;

        try
        {
            rotation = Convert.ToInt32(Console.ReadLine());

            if (rotation <= 0 || rotation >= 100)
            {
                Console.WriteLine("Rotation must be between 1 and 99.");
                return;
            }
        }
        catch
        {
            Console.WriteLine("Invalid rotation. Please enter a number.");
            return;
        }

        string encrypted = Encrypt(text, rotation);

        Console.WriteLine($"Encrypted: {encrypted}");
    }
    else if (choice == 2)
    {
        Console.WriteLine("Enter text to decrypt:");
        string text = Console.ReadLine();

        int rotation;

        try
        {
            rotation = Convert.ToInt32(Console.ReadLine());

            if (rotation <= 0 || rotation >= 100)
            {
                Console.WriteLine("Rotation must be between 1 and 99.");
                return;
            }
        }
        catch
        {
            Console.WriteLine("Invalid rotation. Please enter a number.");
            return;
        }

        string decrypted = Decrypt(text, rotation);

        Console.WriteLine($"Decrypted: {decrypted}");
    }
    else if (choice == 0)
    {
        return;
    }
    else
    {
        Console.WriteLine("Invalid option");
    }
}
static double CircleArea(double radius)
{
    double area = Math.PI * Math.Pow(radius, 2);

    return area;
}