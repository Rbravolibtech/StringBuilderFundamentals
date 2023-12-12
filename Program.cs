using System;
using System.Text;

namespace StringBuilderFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("HELLO WORLD");
            //builder.Append('-', 10);
            //builder.AppendLine();
            //builder.Append("Header");

            //builder.AppendLine();


            //builder.Append('-', 10);
            //builder.AppendLine();
            //builder.Append("Header");

            //builder.AppendLine();

            //builder.Append('-', 10);
            //builder.AppendLine();
            //builder.Append("Header");

            //builder.Replace('-', '+');

            //builder.Remove(0, 10);

            //builder.Insert(0, new string('-', 10));

            ////THIS CODE BELOW MAKES CODE LOOK WAY CLEANER FROM THE TOP

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("HEADER")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First char: " + builder[0]);
        }
    }
}