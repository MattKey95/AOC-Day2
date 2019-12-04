using System;

namespace AOC_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser("data.txt");
            var program = parser.Parse();
            CPU cpu = new CPU(program);
            cpu.Run();
            Console.WriteLine("program finished");
        }
    }
}
