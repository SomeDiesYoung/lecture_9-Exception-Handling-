using System.ComponentModel.DataAnnotations;
namespace Validation_Methods
{
    internal partial class Program
    {
        //radgan .NET 6 ar aris INumber<T> gadavwyvite ase gameketebina (ufro kargi gzac mipovnia)
        public static class Ensure
        {


            //Method IsPositive
            public static void IsPositive(int number)
            {
                if (number <= 0)
                    throw new ValidationException("The number must be positive.");
                else
                {
                    Console.WriteLine("its okay");
                }
            }

            public static void IsPositive(double number)
            {
                if (number <= 0.0)
                    throw new ValidationException("The number must be positive.");
            }

            public static void IsPositive(short number)
            {
                if (number <= 0)
                    throw new ValidationException("The number must be positive.");
            }

            public static void IsPositive(long number)
            {
                if (number <= 0)
                    throw new ValidationException("The number must be positive.");
            }

            public static void IsPositive(decimal number)
            {
                if (number <= 0.0m)
                    throw new ValidationException("The number must be positive.");
            }
            public static void IsPositive(float number)
            {
                if (number <= 0.0f)
                    throw new ValidationException("The number must be positive.");
            }

            //Method IsNegative

            public static void IsNegative(int number)
            {
                if (number >= 0)
                    throw new ValidationException("The number must be Negative.");
                else
                {
                    Console.WriteLine("its okay");
                }
            }

            public static void IsNegative(double number)
            {
                if (number >= 0.0)
                    throw new ValidationException("The number must be Negative.");
            }

            public static void IsNegative(short number)
            {
                if (number >= 0)
                    throw new ValidationException("The number must be Negative.");
            }

            public static void IsNegative(long number)
            {
                if (number >= 0)
                    throw new ValidationException("The number must be Negative.");
            }

            public static void IsNegative(decimal number)
            {
                if (number >= 0.0m)
                    throw new ValidationException("The number must be Negative.");
            }
            public static void IsNegative(float number)
            {
                if (number >= 0.0f)
                    throw new ValidationException("The number must be Negative.");
            }


            // Method IsNonPositive
            public static void IsNonPositive(int number)
            {
                if (number >= 0)
                    throw new ValidationException("The number mustnot be Positive.");
                else
                {
                    Console.WriteLine("its okay");
                }
            }

            public static void IsNonPositive(double number)
            {
                if (number >= 0.0)
                    throw new ValidationException("The number mustnot be Positive.");
            }

            public static void IsNonPositive(short number)
            {
                if (number >= 0)
                    throw new ValidationException("The number mustnot be Positive.");
            }

            public static void IsNonPositive(long number)
            {
                if (number >= 0)
                    throw new ValidationException("The number mustnot be Positive.");
            }

            public static void IsNonPositive(decimal number)
            {
                if (number >= 0.0m)
                    throw new ValidationException("The number mustnot be Positive.");
            }
            public static void IsNonPositive(float number)
            {
                if (number >= 0.0f)
                    throw new ValidationException("The number mustnot be Positive.");
            }

            //Method IsNonNegative 
            public static void IsNonNegative(int number)
            {
                if (number <= 0)
                    throw new ValidationException("The number must be Negative .");
                else
                {
                    Console.WriteLine("its okay");
                }
            }

            public static void IsNonNegative(double number)
            {
                if (number <= 0.0)
                    throw new ValidationException("The number must be Negative.");
            }

            public static void IsNonNegative(short number)
            {
                if (number <= 0)
                    throw new ValidationException("The number must be Negative.");
            }

            public static void IsNonNegative(long number)
            {
                if (number <= 0)
                    throw new ValidationException("The number must be Negative.");
            }

            public static void IsNonNegative(decimal number)
            {
                if (number <= 0.0m)
                    throw new ValidationException("The number must be Negative.");
            }
            public static void IsNonNegative(float number)
            {
                if (number <= 0.0f)
                    throw new ValidationException("The number must be Negative.");
            }

            // Method IsGreaterThan 

            public static void IsGreaterThan(int number1, int number2)
            {
                if (number1 < number2)
                    throw new ValidationException($"The first number ({number1}) must be greater than the second number or equal ({number2}).");
            }
            public static void IsGreaterThan(short number1, short number2)
            {
                if (number1 < number2)
                    throw new ValidationException($"The first number ({number1}) must be greater than the second number or equal ({number2}).");
            }
            public static void IsGreaterThan(long number1, long number2)
            {
                if (number1 < number2)
                    throw new ValidationException($"The first number ({number1}) must be greater than the second number ({number2}).");
            }
            public static void IsGreaterThan(float number1, float number2)
            {
                if (number1 < number2)
                    throw new ValidationException($"The first number ({number1}) must be greater than the second number  ({number2}).");
            }
            public static void IsGreaterThan(double number1, double number2)
            {
                if (number1 < number2)
                    throw new ValidationException($"The first number ({number1}) must be greater than the second number ({number2}).");
            }
            public static void IsGreaterThan(decimal number1, decimal number2)
            {
                if (number1 < number2)
                    throw new ValidationException($"The first number ({number1}) must be greater than the second number  ({number2}).");
            }

            public static void IsGreaterThanOrEqual(int number1, int number2)
            {
                if (number1 <= number2)
                    throw new ValidationException($"The first number ({number1}) must be greater than the second number or equal ({number2}).");
            }
            public static void IsGreaterThanOrEqual(short number1, short number2)
            {
                if (number1 <= number2)
                    throw new ValidationException($"The first number ({number1}) must be greater than the second number or equal ({number2}).");
            }
            public static void IsGreaterThanOrEqual(long number1, long number2)
            {
                if (number1 <= number2)
                    throw new ValidationException($"The first number ({number1}) must be greater than the second number or equal ({number2}).");
            }
            public static void IsGreaterThanOrEqual(float number1, float number2)
            {
                if (number1 <= number2)
                    throw new ValidationException($"The first number ({number1}) must be greater than the second number or equal ({number2}).");
            }
            public static void IsGreaterThanOrEqual(double number1, double number2)
            {
                if (number1 <= number2)
                    throw new ValidationException($"The first number ({number1}) must be greater than the second number or equal ({number2}).");
            }
            public static void IsGreaterThanOrEqual(decimal number1, decimal number2)
            {
                if (number1 <= number2)
                    throw new ValidationException($"The first number ({number1}) must be greater than the second number or equal ({number2}).");
            }

        }


    }

}

