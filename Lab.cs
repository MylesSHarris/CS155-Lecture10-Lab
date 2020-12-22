using System;
namespace Lab
{
    public class Lab
    {
        static void Main(string[] arguments)
        {
            string text1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.";
            string text2 = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            Email email1 = new Email("John Doe", "Bill Nye", "Interesting email title 1", text1);
            Email email2 = new Email("Bill Nye", "Jane Doe", "Interesting email title 2", text2);

            File file1 = new File("testfile1.txt", text1);
            File file2 = new File("testfile2.txt", text2);

            Console.WriteLine("Email 1: " + ContainsKeyword(email1, "consectetur"));
            Console.WriteLine("Email 2: " + ContainsKeyword(email2, "consectetur"));

            Console.WriteLine("File 1: " + ContainsKeyword(file1, "cillum"));
            Console.WriteLine("File 2: " + ContainsKeyword(file2, "cillum"));
        }

        public static bool ContainsKeyword(Document docObject, string keyword)
        {
            if (docObject.ToString().IndexOf(keyword, 0) >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
