using System;

namespace CollatzConsole
{
    public class Program
    {
        private static Collatz m_oCollatzImplementation = new Collatz();

        public static void Main(string[] args)
        {
            int nStartNumber = 0;

            Console.WriteLine("Bitte gebe deine Startzahl an");
            nStartNumber = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            List<uint> vnNumbers = m_oCollatzImplementation.CalcNumbers((uint)nStartNumber);

            foreach (uint nNumber in vnNumbers) {
                Console.WriteLine(nNumber);
            }
        }
    }
}