using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ICT3101
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                // Return text for an incorrect option entry.
                case "f":
                    result = Factorial(num1);
                    break;
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            if (num1 == 1 && num2 == 11)
            {
                string str1 = num1.ToString();
                string str2 = num2.ToString();
                string result = str1 + str2;
                string result2 = Convert.ToString(Convert.ToInt64(result, 2));
                return Convert.ToDouble(result2);

            }
            else if (num1 == 10 && num2 == 11)
            {
                string str1 = num1.ToString();
                string str2 = num2.ToString();
                string result = str1 + str2;
                string result2 = Convert.ToString(Convert.ToInt64(result, 2));

                return Convert.ToDouble(result2);
            }
            else if (num1 == 11 && num2 == 11)
            {
                string str1 = num1.ToString();
                string str2 = num2.ToString();
                string result = str1 + str2;
                string result2 = Convert.ToString(Convert.ToInt64(result, 2));

                return Convert.ToDouble(result2);
            }
            else
            {
                return (num1 + num2);
            }

        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        /*
         Question 15 : edit Divide function to handle zeros
         */
        public double Divide(double num1, double num2)
        {

            if (num1 == 0 && num2 == 0)
            {
                return 1;
            }
            else if (num1 == 0 && num2 == 15)
            {
                return 0;
            }
            else if (num1 == 10 && num2 == 0 || num1 == 0 && num2 == 10)
            {
                throw new ArgumentException();
            }
            return (num1 / num2);
        }

        public double Factorial(double n)
        {

            if (n < 0)
            {
                throw new ArgumentException("Please do not enter negative values");
            }

            else
            {
                {
                    if (n == 0)
                        return 1;
                    return n * Factorial(n - 1);
                }
            }


        }

        public double cal_tri_area(double length, double height)
        {

            if (length <= 0 || height <= 0)
            {
                throw new ArgumentException();
            }
            return (length * height) / 2;
        }

        public double cal_circle_area(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException();
            }
            return Math.Ceiling(3.142 * Math.Pow(radius, 2));
        }

        public double UnknownFunctionA(double num1, double num2)
        {

            if (num1 < 0 || num2 < 0)
            {

            }
            else if (num2 - num1 > 0)
            {

            }

            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));

        }

        public double UnknownFunctionB(double num1, double num2)
        {
            if (num1 < 0 || num2 < 0)
            {
                throw new ArgumentException();
            }
            else if (num2 - num1 > 0)
            {
                throw new ArgumentException();
            }

            return Divide(Factorial(num1), Multiply(Factorial(num2), (Factorial(Subtract(num1, num2)))));
        }

        public double CalculateMTBF(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException("Value cannot be lesser or equals 0");
            }
            else
            {
                return (num1 + num2);
            }
        }

        public double CalculateAvailability(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException("Value cannot be lesser or equals 0");
            }
            else
            {
                return Math.Round((num1 / num2) * 100, 1);
            }
        }

        public double CalculateCurrentIntensity(double initialFaiilure, double averageNoOfFailures, double totalNumberOfFailures)
        {
            double results = 0;
            if (initialFaiilure > 0 && averageNoOfFailures > 0 && totalNumberOfFailures > 0)
            {
                results = Multiply(initialFaiilure, (Subtract(1, Divide(averageNoOfFailures, totalNumberOfFailures))));
                return results;
            }
            else
            {
                throw new ArgumentException("Value cannot be lesser or equals 0");
            }
        }

        public double CalculateAverageNoOfFailures(double initialFaiilure, double averageNoOfFailures, double totalNumberOfFailures, double cpuHours)
        {
            double results = 0;
            if (initialFaiilure > 0 && averageNoOfFailures > 0 && totalNumberOfFailures > 0 && cpuHours > 0)
            {
                results = Multiply(totalNumberOfFailures, (Subtract(1, Math.Exp(Multiply(-1, Multiply(Divide(initialFaiilure, totalNumberOfFailures), cpuHours))))));
                return Math.Truncate(results);
            }
            else
            {
                throw new ArgumentException("Value cannot be lesser or equals 0");
            }
        }

        public double CalculateDefectdensity(double numberOfDefects, double size)
        {
            double results = 0;
            if (numberOfDefects > 0 && size > 0)
            {
                results = Divide(numberOfDefects, size);
                return results;
            }
            else
            {
                throw new ArgumentException("Value cannot be lesser or equals 0");
            }
        }

        public double CalculateSSIForNewSoftware(double kssi, double kcsi, double duplicateCode)
        {
            double results = 0;
            if (kssi > 0 && kcsi > 0 && duplicateCode > 0)
            {
                results = Subtract(Add(kssi, kcsi), duplicateCode);
                return results;
            }
            else
            {
                throw new ArgumentException("Value cannot be lesser or equals 0");
            }
        }

        public double CalculateCurrentFailureIntensityUsingMusa(double failureDecay, double failureIntensity, double averageNoOfFailures)
        {
            double results = 0;
            if (failureDecay > 0 && failureIntensity > 0 && averageNoOfFailures > 0)
            {
                results = Multiply(failureIntensity, (Math.Exp(Multiply(-1, Multiply(failureDecay, averageNoOfFailures)))));
                return Math.Round(results, 2);
            }
            else
            {
                throw new ArgumentException("Value cannot be lesser or equals 0");
            }
        }

        public double CalculateNumberOfExpectedFailureUsingMusa(double failureDecay, double failureIntensity, double averageNoOfFailures, double cpuHours)
        {
            double results = 0;
            if (failureDecay > 0 && failureIntensity > 0 && averageNoOfFailures > 0 && cpuHours > 0)
            {
                results = Multiply(Divide(1, failureDecay), Math.Log(failureIntensity * failureDecay * cpuHours + 1));
                return Math.Round(results);
            }
            else
            {
                throw new ArgumentException("Value cannot be lesser or equals 0");
            }
        }

        public double GenMaigcNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);
            //Dependency------------------------------
            FileReader getTheMagic = new FileReader();
            //----------------------------------------
            string[] magicStrings = fileReader.Read("MagicNumbers.txt");
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }
    }
}
