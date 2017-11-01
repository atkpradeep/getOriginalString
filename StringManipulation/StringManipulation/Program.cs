using System;
using System.Text;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new StringBuilder();
            //Take input fro user as a string length 1<=|S|<=10000 
            var input = Console.ReadLine();
            if (1 <= input.Length && input.Length <= 100000)
            {
                var _length = input.Length;
            start: if (_length != 0)
                {
                    //Length is even take left of the two middle char
                    if (_length % 2 == 0)
                    {
                        var evenChar = input.Substring((_length - 1) / 2, 1);
                        input = input.Remove((_length - 1) / 2, 1);
                        result.Append(evenChar);//append selected char to the new string 
                        _length -= 1;//reduce original string by 1
                        goto start;
                    }
                    else//Length is odd take middle char
                    {
                        var oddChar = input.Substring(_length / 2, 1);
                        input = input.Remove(_length / 2, 1);
                        result.Append(oddChar);
                        _length -= 1;
                        goto start;
                    }
                }
                var outPut = result.ToString();
                Console.Write("Encoded String:{0}", outPut);
                Console.Write("\nDecoded String:{0}", originalString(outPut));
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Get original string from encoded string  
        /// </summary>
        /// <param name="encodedString">String</param>
        /// <returns>String</returns>
        static string originalString(string encodedString)
        {
            var result = new StringBuilder();
            var input = encodedString;
            var _length = input.Length;

            if (_length != 0)
            {
                var lowerLenght = 0;
                var startIndex = 2;
                while ((_length / 2) > lowerLenght)
                {
                    var charInput = input.Substring(_length - startIndex, 1);
                    input = input.Remove(_length - startIndex, 1);
                    result.Append(charInput);
                    lowerLenght++;
                    startIndex += 2;
                }
                result.Append(input);
            }
            return result.ToString();
        }
    }
}
