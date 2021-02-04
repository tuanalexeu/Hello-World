using System;

namespace Hello_World {
    internal static class Program {
        private static void Main(string[] args) {
            Calc calc = new Calc();
            int ans = calc.Add(10, 84);
            Console.WriteLine("10 + 84 is {0}", ans);
            Console.ReadLine();
        }
    }

    class Calc {
        public int Add(int x, int y) {
            return x + y;
        }
    }
}