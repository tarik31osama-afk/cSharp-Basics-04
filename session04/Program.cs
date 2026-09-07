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
            Console.WriteLine(ReferenceEquals(first,second));
            #endregion
        }
    }
}
