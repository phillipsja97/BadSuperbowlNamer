using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer
{
    public class Translator
    {
        public string Translate(int number)
        {

            var romanNumeral = "";
            while (number > 0)
            {
                while (number >= 1000)
                {
                    romanNumeral += "M";
                    number -= 1000;
                }
                while (number >= 900)
                {
                    romanNumeral += "CM";
                    number -= 900;
                }
                while (number >= 500)
                {
                    romanNumeral += "D";
                    number -= 500;
                }
                while (number >= 100)
                {
                    romanNumeral += "C";
                    number -= 100;
                }
                while (number >= 90)
                {
                    romanNumeral += "XC";
                    number -= 90;
                }
                while (number >= 50)
                {
                    romanNumeral += "L";
                    number -= 50;
                }
                while (number >= 40)
                {
                    romanNumeral += "XL";
                    number -= 40;
                }
                while (number >= 10)
                {
                    romanNumeral += "X";
                    number -= 10;
                }
                if (number >= 9)
                {
                    romanNumeral += "IX";
                    number -= 9;
                }
                else if (number >= 5)
                {
                    romanNumeral += "V";
                    number -= 5;
                }
                else if (number == 4)
                {
                    romanNumeral += "IV";
                    number -= 4;
                }
                else if (number >= 1)
                {
                    romanNumeral += "I";
                    number -= 1;
                }
            }
            return romanNumeral;
           
        }
    }
}
