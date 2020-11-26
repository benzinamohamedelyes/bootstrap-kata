using System;

namespace boostrap_DotnetCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(args[0]));
        }
        public static int Add(string StringNumber)
        {
            int from = StringNumber.IndexOf("//");
            int to = StringNumber.IndexOf("\n");
            string[] intTab = null;
            if (from != -1 && to != -1)
            {
                from = from + 2;
                string customDelimiter = StringNumber.Substring(from, to - from);
                if (customDelimiter.Length == 1)
                {
                    intTab = StringNumber.Substring(to).Split(new Char[] { ',', '\n', customDelimiter[0] },
                                                         StringSplitOptions.RemoveEmptyEntries);
                }
                else
                    return 0;
            }
            else
                intTab = StringNumber.Split(new Char[] { ',', '\n' },
                                    StringSplitOptions.RemoveEmptyEntries);
            int result = 0;
            if (string.IsNullOrEmpty(StringNumber))
                return 0;
            else
            {
                foreach (var element in intTab)
                {
                    if (int.TryParse(element, out int output))
                        result = result + output;
                    else
                        return 0;
                }
                return result;
            }

        }
    }
}
