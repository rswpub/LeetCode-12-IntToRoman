namespace LeetCode_12_IntToRoman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = new Solution().IntToRoman(1);
        }
    }

    public class Solution
    {
        public string IntToRoman(int num)
        {
            // Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
            // 
            // Symbol       Value
            // I             1
            // V             5
            // X             10
            // L             50
            // C             100
            // D             500
            // M             1000
            // For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
            // 
            // Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
            // 
            // I can be placed before V (5) and X (10) to make 4 and 9. 
            // X can be placed before L (50) and C (100) to make 40 and 90. 
            // C can be placed before D (500) and M (1000) to make 400 and 900.
            // Given an integer, convert it to a roman numeral.


            // First check constraints
            CheckConstraints(num);

            string romanStr = string.Empty;

            // Convert the integer to a string so we can process it more easily, digit by digit, starting from
            // the most significant (largest) digit at the left.
            string numStr = num.ToString();
            int tensPosition = 1;

            for (int i = numStr.Length - 1; i >= 0; i--, tensPosition++)
            {
                string romanDigit = IntToRomanDigit(numStr[i], tensPosition);
                romanStr = romanDigit + romanStr;
            }

            return romanStr;
        }

        private string IntToRomanDigit(char digit, int tensPosition)
        {
            switch (digit)
            {
                case '0':
                    return "";
                case '1':
                    {
                        switch (tensPosition)
                        {
                            case 1:
                                return "I";
                            case 2:
                                return "X";
                            case 3:
                                return "C";
                            case 4:
                                return "M";
                            default:
                                throw new Exception($"Error - unexpected {nameof(tensPosition)} value ({tensPosition}) (202207201834)");
                        }
                    }
                case '2':
                    {
                        switch (tensPosition)
                        {
                            case 1:
                                return "II";
                            case 2:
                                return "XX";
                            case 3:
                                return "CC";
                            case 4:
                                return "MM";
                            default:
                                throw new Exception($"Error - unexpected {nameof(tensPosition)} value ({tensPosition}) (202207201834)");
                        }
                    }
                case '3':
                    {
                        switch (tensPosition)
                        {
                            case 1:
                                return "III";
                            case 2:
                                return "XXX";
                            case 3:
                                return "CCC";
                            case 4:
                                return "MMM";
                            default:
                                throw new Exception($"Error - unexpected {nameof(tensPosition)} value ({tensPosition}) (202207201834)");
                        }
                    }
                case '4':
                    {
                        switch (tensPosition)
                        {
                            case 1:
                                return "IV";
                            case 2:
                                return "XL";
                            case 3:
                                return "CD";
                            default:
                                throw new Exception($"Error - unexpected {nameof(tensPosition)} value ({tensPosition}) (202207201834)");
                        }
                    }
                case '5':
                    {
                        switch (tensPosition)
                        {
                            case 1:
                                return "V";
                            case 2:
                                return "L";
                            case 3:
                                return "D";
                            default:
                                throw new Exception($"Error - unexpected {nameof(tensPosition)} value ({tensPosition}) (202207201834)");
                        }
                    }
                case '6':
                    switch (tensPosition)
                    {
                        case 1:
                            return "VI";
                        case 2:
                            return "LX";
                        case 3:
                            return "DC";
                        default:
                            throw new Exception($"Error - unexpected {nameof(tensPosition)} value ({tensPosition}) (202207201834)");
                    }
                case '7':
                    switch (tensPosition)
                    {
                        case 1:
                            return "VII";
                        case 2:
                            return "LXX";
                        case 3:
                            return "DCC";
                        default:
                            throw new Exception($"Error - unexpected {nameof(tensPosition)} value ({tensPosition}) (202207201834)");
                    }
                case '8':
                    switch (tensPosition)
                    {
                        case 1:
                            return "VIII";
                        case 2:
                            return "LXXX";
                        case 3:
                            return "DCCC";
                        default:
                            throw new Exception($"Error - unexpected {nameof(tensPosition)} value ({tensPosition}) (202207201834)");
                    }
                case '9':
                    switch (tensPosition)
                    {
                        case 1:
                            return "IX";
                        case 2:
                            return "XC";
                        case 3:
                            return "CM";
                        default:
                            throw new Exception($"Error - unexpected {nameof(tensPosition)} value ({tensPosition}) (202207201834)");
                    }
                default:
                    throw new Exception($"Error - unexpected character ({digit}) (202207141224)");
            }
        }

        private void CheckConstraints(int num)
        {
            // Constraints:
            //
            // 1 <= num <= 3999

            if ((num <= 0) || (num >= 4000))
            {
                throw new ConstraintViolationException();
            }
        }
    }

    public class ConstraintViolationException : Exception { }
}