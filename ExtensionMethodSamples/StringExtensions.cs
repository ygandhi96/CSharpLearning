using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodSamples.Extensions
{
    public static class StringExtensions
    {
        //because of this keyword compiler understands it is extension to String class
        public static string GetWithSize(this string str)  //this string str meaning string class will pass the str to this method GetWithSize
        {
            return $"Size is {str.Length},text:{str}";    
        }
    }
}
