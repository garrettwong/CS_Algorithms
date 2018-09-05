using System;

namespace csharpAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[] { "Hello", "World"};
            
            var arrayEnumerator = new ArrayEnumerator<string>(arr);
            
            while (arrayEnumerator.MoveNext() ) {
                Console.WriteLine(arrayEnumerator.Current);
            }
        }
    }
}
