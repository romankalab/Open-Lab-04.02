using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string result = "";
            for (var x = 0; x < original.Length; x++)
                result = result + original[x] + original[x];
            return result;
        }
    }
}
