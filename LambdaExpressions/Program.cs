
using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //args => expression
            // () => ...
            // x => ...
            // (x, y, z,) => ...
            //number => number * number;
            //Func<int, int> square = Square;
            Func<int, int> square = number => number * number;

            Console.WriteLine(square(7));
            Console.WriteLine(Square(5));

            const int factor = 5;

            Func<int, int> multiplyer = n => n * factor;

            var result = multiplyer(10);
            Console.WriteLine(result);


            var books = new BookRepository().GetBooks();

            Console.WriteLine("Books less than $10:");

            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine();
            Console.WriteLine("Books more than $10:");

            var expensiveBooks = books.FindAll(b => b.Price > 10);

            foreach (var book in expensiveBooks)
            {
                Console.WriteLine(book.Title);
            }

        }

        static int Square(int number)
        {
            return number * number;
        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
        
    }
}
