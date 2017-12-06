using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace vnyi.Utility
{
    public class clsCreditCardValidator
    {
        public enum CCType
        {
            None, //Không phải trong các loại thẻ
            VISA, 
            MC //Master Card
        }

        public static CCType ProcessValidation(string cardNumber)
        {
            cardNumber = cardNumber.Replace(" ", "").Replace("-", "");

            bool passRegEx = false;
            bool passIssuer = false;
            bool passLuhn = false;
            bool IsValid = false;
            CCType CardType = CCType.None;

            do
            {
                // Reg Ex check //
                Regex RegExNumber = new Regex(@"(?<firsttwo>(?<firstone>\d)\d)\d{11,14}");
                Match m = RegExNumber.Match(cardNumber);
                passRegEx = m.Success;
                if (!passRegEx) break;
                string number = m.Groups[0].Value; // only digits //
                string firstNum = m.Groups["firstone"].Value;
                int firstTwoNum = int.Parse(  m.Groups["firsttwo"].Value );
                passIssuer = (firstNum == "4") || ((firstTwoNum >= 51) && (firstTwoNum <= 55));
                if (!passIssuer) break;
                if (firstNum == "4") CardType = CCType.VISA;
                if ((firstTwoNum >= 51) && (firstTwoNum <= 55)) CardType = CCType.MC;
                // Now make Luhn check //
                passLuhn = LuhnCheck(number);
                if (!passLuhn) break;
                //
                IsValid = true;
            } while (false);

            if (!IsValid) return CardType = CCType.None;

            return CardType;
        } 


        /// <summary>
        /// Performs mod 10 check
        /// </summary>
        /// <param name="cardNumber">Card Number with only numbers</param>
        /// <returns></returns>
        private static bool LuhnCheck(string cardNumber)
        {

            int sum = 0;
            int digit = 0;
            int addend = 0;
            bool timesTwo = false; 


            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                digit = int.Parse(cardNumber.Substring(i, 1));
                if (timesTwo)
                {
                    addend = digit * 2;
                    if (addend > 9)
                    {
                        addend -= 9;
                    }
                }
                else
                {
                    addend = digit;
                }
                sum += addend;
                timesTwo = !timesTwo;
            } 


            int modulus = sum % 10;
            return (modulus == 0);
        }
    }
}
