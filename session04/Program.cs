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

        }
    }
}
