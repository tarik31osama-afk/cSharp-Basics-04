using System.Text;

namespace session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st q
            string title = "clean code";
            string uppetTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(uppetTitle);

            #endregion

            #region  2nd q
            string first = "Clean Code";
            string second = "Clean Code";
            Console.WriteLine(ReferenceEquals(first, second));
            #endregion

            #region 3rd q
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Book List");
            stringBuilder.Append("-Updated");
            Console.WriteLine(stringBuilder);

            #endregion

            #region 4th q
            stringBuilder.Replace("Book List", "library");
            Console.WriteLine(stringBuilder);

            #endregion

            #region 5th q
            string title2 = "Clean Code";
            int pages = 464;
            string sentence = "Book: " + title2 + "," + "pages: " + pages;
            Console.WriteLine(sentence);

            #endregion

            #region 6th q
            string Sentence = $"Book: {title2} ,pages: {pages}";
            Console.WriteLine(Sentence);

            #endregion

            #region 7th q
            int Pages = 464;
            if(Pages>300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("short book");
            }

            #endregion

            #region 8th q
            bool isAvailable=true;
            if (pages > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }

            #endregion

            #region 9th q

            string Title = "Refactoring";
            switch (Title)
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
            #endregion

            #region 10th q
            string sizeLabel = pages > 300 ? "long book" : "short book ";
            Console.WriteLine(sizeLabel);

            #endregion

            #region 11th q

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(i + 1 + "." + books[i]);
               
            }
            #endregion

            #region 12th q

            int x = 0;
            while (x < books.Length)
            {
                Console.WriteLine(books[x]);
                x++;
            }

            #endregion

            #region 13th q

            int j = 0;
            do
            {
                Console.WriteLine("Checking book...");
                j++;
            }
            while (j< 3);

            #endregion

            #region 14th q

            foreach (string i in books)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region 15th q

            for (int i = 0; i < books.Length; i++)
            {

                if (books[i] == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(books[i]);
            }
            #endregion\

            #region 16th q

            for (int i = 0; i < books.Length; i++)
            {

                if (books[i] == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(books[i]);
            }

            #endregion

            #region 17th q
            static void PrintFirstBook(string[] books)
            {

                if (books.Length == 0)
                {
                    return;
                }
                Console.WriteLine(books[0]);
            }
            PrintFirstBook(books);

            #endregion


        }
    }
}
