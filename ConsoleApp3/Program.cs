namespace ClassLibrary1
{
    public class Class1
    {
        static void Main(String[] args)
        {
            while (true)
            {

                Console.Write("PLease Enter Your String: ");
                String input = Console.ReadLine();
                Console.WriteLine("PLease Select an option");
                Console.WriteLine("1. Convert To upper");
                Console.WriteLine("2. Convert To lower");
                Console.WriteLine("3. print the length");
                String selectedOption = Console.ReadLine();
                switch (selectedOption)
                {
                    default:
                        Console.WriteLine("The Value is invalid");
                        break;
                    case "1":
                        Console.WriteLine(input.ToUpper());
                        break;
                    case "2":
                        Console.WriteLine(input.ToLower());
                        break;
                    case "3":
                        Console.WriteLine(input.Length);
                        break;

                }
            }

        }
    }
}
