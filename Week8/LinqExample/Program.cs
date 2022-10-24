namespace LinqExample
{
    internal class MainProgram
    {
        public static void Main(string[] args)
        {
            string s = "PHAM VU THU NGUYET 30/06/2001";

            IEnumerable<char> stringQuery =
                from ch in s
                where Char.IsDigit(ch)
                select ch;


            var enumerable = stringQuery.ToList();
            foreach (char c in enumerable)
                Console.Write(c + " ");
        }
    }
}