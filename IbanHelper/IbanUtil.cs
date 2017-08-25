using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace IbanHelper
{
    public static class IbanUtil
    {
        private static string GetRegexPattern(bool limitToIran = false)
        {
            return limitToIran ? @"^IR([0-9]\s?){24}$" : @"^[A-Z0-9]";
        }
        //
        public static bool ValidateIBAN(string iban, bool limitToIran = true)
        {
            var regexPattern = GetRegexPattern(limitToIran);           
            if (String.IsNullOrWhiteSpace(iban))
                return false;
            iban = iban.ToUpper();
            iban = iban.Replace(" ", String.Empty);
            if (!Regex.IsMatch(iban, regexPattern))
            {
                return false;
            }    
            StringBuilder bankCode = GetBankCode(iban);
            string checkSumString = bankCode.ToString();
            int checksum = int.Parse(checkSumString.Substring(0, 1));
            for (int i = 1; i < checkSumString.Length; i++)
            {
                int v = int.Parse(checkSumString.Substring(i, 1));
                checksum *= 10;
                checksum += v;
                checksum %= 97;
            }
            return checksum == 1;
        }

        private static StringBuilder GetBankCode(string iban)
        {
            const int ASCII_SHIFT = 55;
            const int FOUR = 4;
            string bank = iban.Substring(FOUR, iban.Length - FOUR) + iban.Substring(0, FOUR);
            StringBuilder stringBuilderBank = new StringBuilder();
            foreach (char c in bank)
            {
                int value;
                if (Char.IsLetter(c))
                {
                    value = c - ASCII_SHIFT;
                }
                else
                {
                    value = int.Parse(c.ToString());
                }
                stringBuilderBank.Append(value);
            }
            return stringBuilderBank;
        }     
    }
}
