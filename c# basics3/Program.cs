namespace c__basics3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region frist question

            int pages = 464;
            bool isAvailable = true;

            if (pages > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }

            #endregion

            #region second question

            string title = "Refactoring";

            switch (title)
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

            #region Question Three

            int page = 464;

            string sizeLabel = page > 300 ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);

            #endregion

            #region Question Four

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + books[i]);
            }
            #endregion

            #region Question Five
            int ii= 0;

            while (ii < books.Length)
            {
                Console.WriteLine((ii + 1) + ". " + books[ii]);
                ii++;
            }
            #endregion

        }
    }
}
