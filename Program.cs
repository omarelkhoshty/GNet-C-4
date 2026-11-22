using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GNet_C_4
{
    internal class Program
    {
        ////Q01:Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1).

        //static void Main(string[] args)
        //{
        //    double[] prices = { 25.5, 40.0, 33.75 };
        //    Console.WriteLine(prices[1]);
        //}

        //---------------------//

        ////Q02:Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and 
        ////shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0. 

        //static void Main(string[] args)
        //{
        //    int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
        //    Console.WriteLine(shelfCopies[1, 0]);

        //}

        //---------------------//

        ////Q03:Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!". Call it from Main.

        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}
        //static void Main(string[] args)
        //{
        //    PrintWelcomeMessage();
        //}

        //---------------------//

        //Q04:Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code". 

        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine("Book title: " + title);
        //}
        //static void Main(string[] args)
        //{
        //    PrintBookTitle("Clean Code");
        //}

        //---------------------//

        //Q05:Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward.What do you expect to see, and why?

        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        static void Main(string[] args)
        {
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
        }
    }

}
