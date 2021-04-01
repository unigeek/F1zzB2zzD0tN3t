using System;

namespace F1zzB2zzCsh4rp
{
    class Program
    {
        static void Main(string[] args)
        {
            FbRenderer fbr = new FbRenderer();
            for(int i=1; i<=100; i++)
            {
                Console.WriteLine(string.Format("{0:D1}, {1}", i, fbr.render(i)));
            }
        }
    }
}
