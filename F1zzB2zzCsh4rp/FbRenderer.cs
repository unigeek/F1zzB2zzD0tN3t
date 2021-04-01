using System;

namespace F1zzB2zzCsh4rp
{
    public class FbRenderer
    {
        public string render(int v)
        {
            String simpleResult = String.Format("{0:D1}", v);
            String complexResult = "";

            if ((v % 3) == 0) complexResult = "Fizz";
            if ((v % 5) == 0) complexResult += "Buzz";
            return ("".Equals(complexResult)) ? simpleResult : complexResult;
        }
    }
}
