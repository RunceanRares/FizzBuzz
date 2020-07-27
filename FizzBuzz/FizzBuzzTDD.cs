using System;

namespace FizzBuzz
{
    public class FizzBuzzTDD
    {
        public string Convert(int v)
        {
            if(v%3==0 && v%5==0)
            {
                return "FizzBuzz";
            }
            if(v%3==0)
            {
                return "Fizz";

            }
            if(v%5==0)
            {
                return "Buzz";
            }
            return v.ToString();
        }
    }
}