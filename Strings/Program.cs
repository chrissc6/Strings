using System;

namespace Strings
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Simmutable();
            Scompare();
            Scompare2();
            Slengthindex();
            Subs();
            CaW();
            CharacterMethods();
            EditS();
            JoinSplit();

            Console.ReadKey();
        }
        

        static void Simmutable()
        {
            string s1 = "Chris";
            Console.WriteLine(s1);

            s1.ToUpper();
            Console.WriteLine(s1);

            string s2 = s1.ToUpper();   //used for user menu input
            Console.WriteLine(s2);

            string s3 = s1.ToLower();
            Console.WriteLine(s3);

            Console.WriteLine(s1);

        }

        static void Scompare()
        {
            string s1 = "Hello";
            string s2 = "hello";

            if (s1 == s2)
                Console.WriteLine("Equal");
            else
            {
                Console.WriteLine("Not equal");
            }

            if (s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Case yes");
            }
            else
                Console.WriteLine("Case no");
        }

        static void Scompare2()
        {
            string s1 = "Hello";
            string s2 = "hello";

            if (s1 != s2)
                Console.WriteLine("Not equal");
            else
            {
                Console.WriteLine("Equal");
            }

            if (s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Case yes");
            }
            else
                Console.WriteLine("Case no");
        }

        static void Slengthindex()
        {
            string name = "Chris";
            Console.WriteLine("Letter 0: {0}", name[0]);

            for (int i = name.Length -1; i >= 0; i--)
            {
                Console.Write("{0}", name[i]); //write so on single line
            }
            Console.WriteLine(); //just for new line
        }

        static void Subs()
        {
            string Name = "Chris";

            Console.WriteLine("Everything at or after position 1: {0}", Name.Substring(1));
            Console.WriteLine("Last 3 characters: {0}", Name.Substring(Name.Length - 3, 3));
        }

        static void CaW()
        {
            string s1 = " ";
            string s2 = "";

            Console.WriteLine("Null or empty? {0}", string.IsNullOrEmpty(s1)); //have data?

            Console.WriteLine("Null or whitespace? {0}", string.IsNullOrWhiteSpace(s2));
        }

        static void CharacterMethods()
        {
            char c1 = 'c';

            Console.WriteLine("Character: {0}", c1);
            Console.WriteLine("IsDigit: {0}", char.IsDigit(c1));
            Console.WriteLine("IsLetter: {0}", char.IsLetter(c1));
            Console.WriteLine("IsLoD: {0}", char.IsLetterOrDigit(c1));
            Console.WriteLine("IsPunctuation: {0}", char.IsPunctuation(c1));
            Console.WriteLine("IsWS: {0}", char.IsWhiteSpace(c1));
            Console.WriteLine("IsLower: {0}", char.IsLower(c1));
            Console.WriteLine("IsUpper: {0}", char.IsUpper(c1));
        }

        static void EditS()
        {
            string s1 = "  String with extra spaces  ";

            Console.WriteLine(s1);
            s1 = s1.Trim();
            Console.WriteLine(s1);

            s1 = s1.Replace("extra", "some");
            Console.WriteLine(s1);

        }

        static void JoinSplit()
        {
            string s1 = "Words on the screen";
            Console.WriteLine(s1);

            string[] words = s1.Split(' ');
            foreach (var s in words)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(s1);

            string s2 = string.Join("+", words);
            Console.WriteLine(s2);
        }
    }
}
