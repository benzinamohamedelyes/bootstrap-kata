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
            if ( !string.IsNullOrEmpty(StringNumber) && int.TryParse(StringNumber, out int output))
                return output;
            else
                return 0;
        }
    }
}
