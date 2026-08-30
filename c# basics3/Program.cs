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
        }
    }
}
