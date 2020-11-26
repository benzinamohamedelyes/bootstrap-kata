using System;
using System.Text;

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
                from += "//".Length;
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
                StringBuilder negativeNumbers = new StringBuilder();
                foreach (var element in intTab)
                {
                    if (int.TryParse(element, out int output))
                        if (output < 0)
                            if (negativeNumbers.Length > 0)
                                negativeNumbers.Append("," + output);
                            else
                                negativeNumbers.Append(output);
                        else
                            result += output;
                    else
                        return 0;
                }
                if (negativeNumbers.Length > 0)
                    throw new InvalidOperationException("negatives not allowed: " + negativeNumbers.ToString());
                else
                    return result;
            }

        }
    }
}
