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
            var intTab = StringNumber.Split(new Char[] { ',', '\n' },
                                 StringSplitOptions.RemoveEmptyEntries);
            int result = 0;
            if (string.IsNullOrEmpty(StringNumber))
                return 0;
            else
            {
                foreach(var element in intTab)
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
