namespace Objects_Mangum_Stephen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a new Computer object with specified brand, model, and power state
            Computer myComputer = new Computer("Apple", "All-in-One", true);

            // Assigns the Computer object to an IBootUp interface reference
            IBootUp myBootUp = myComputer;

            // Compares the Computer object to the IBootUp interface reference (should be true, as they reference the same object)
            Console.WriteLine(myComputer.Equals(myBootUp));

            // Creates another Computer object with the same values as the first
            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);

            // Compares the first Computer object to the second (depends on Equals implementation)
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            // Gets the string representation of the first Computer object
            string myString = myComputer.ToString();

            // Assigns the string to another variable (both reference the same string)
            string myOtherString = myString;

            // Changes myString to a new value ("Hi!"), myOtherString remains unchanged
            myString = "Hi!";

            // Outputs the current values of myString and myOtherString
            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);

            // Compares myString to the string representation of both Computer objects
            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());

            // Outputs the runtime type of myComputer and myBootUp
            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myBootUp.GetType());

            // Toggles the power state of myOtherComputer
            myOtherComputer.PowerOnOff();

            // Compares myString to the updated string representation of myOtherComputer
            Console.WriteLine(myString == myOtherComputer.ToString());

            // Outputs the current values of myString and myOtherComputer's string representation
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            // Checks if myString contains the character 'i'
            Console.WriteLine(myString.Contains('i'));

            // Outputs myString in uppercase
            Console.WriteLine(myString.ToUpper());
        }
    }
}
