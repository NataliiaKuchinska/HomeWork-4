using System;
using System.Collections;

namespace HW4Lib
{
    public class HW4Tasks
    {
        public static void Swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static int PowerXToExp(int x, int exp)
        {
            int result = 1;
            for (int i = 1; i <= exp; i++)
            {
                result *= x;
            }

            return result;
        }

        public static double PowerXToExp(double x, int exp)
        {
            double result = 1;
            for (int i = 1; i <= exp; i++)
            {
                result *= x;
            }

            return result;
        }

        public static int[] NumbersMultipliedN(int n)
        {
            int sizeofarray = 1000 / n;
            int[] arr = new int[sizeofarray];
            int j = 0;
            for (int i = n; i <= 1000; i += n)
            {
                arr[j] = i;
                ++j;
            }
            return arr;
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i <arr.Length; ++i)
            {
                Console.Write($"{arr[i]}  ");
            }
            Console.WriteLine(" ");
        }

        public static void SquaresToN(int n)
        {
            int i = 1;
            while ((i * i) <= n)
            {
                Console.Write($"{i * i++}  ");
            }

            Console.WriteLine();
        }

        public static int MaxDivider(int n)
        {
            int divider = n;
            do
            {
                divider -= 2;
            } while (n % divider != 0);

            return divider;
        }

        public static int Task5(int a, int b)
        {
            int sum = 0;
            const int step = 7;
            if (a <= b)
            {
                int residue = a % step;
                a += (residue != 0) ? (step - residue) : 0;
                for (; a <= b; a += step)
                {
                    sum += a;
                }

            }

            return sum;
        }

        public static int Fibonacci_recursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            if (n == 0)
            {
                return 0;
            }

            return Fibonacci_recursion(n - 1) + Fibonacci_recursion(n - 2);
        }

        public static int Fibonacci(int n)
        {
            int fi2 = 0;
            int fi1 = 1;
            if (n < 1)
            {
                return fi2;
            }

            int temp;
            for (int i = 1; i < n; ++i)
            {
                temp = fi1;
                fi1 += fi2;
                fi2 = temp;
            }

            return fi1;
        }

        public static int GcdEuclidean_recursion(int a, int b)
        {
            return (b != 0) ? GcdEuclidean_recursion(b, a % b) : a;
        }

        public static int GcdEuclidean(int a, int b)
        {
            while (b != 0)
            {
                a %= b;
                Swap(ref a, ref b);
            }

            return a;
        }

        public static double Bisection(int cube)
        {
            double root = Double.NaN;
            if (cube == 0)
            {
                return 0;
            }

            double a = 1;
            double b = cube;
            double tmp = (a + b) / 2; 
            do
            {                
                if ((PowerXToExp(0, 3) - cube) * (PowerXToExp(tmp, 3) - cube) > 0)
                {
                    a = tmp;
                }
                else
                {
                    b = tmp;
                }

                root = (a + b) / 2;
                tmp = root;
            } while (PowerXToExp(root, 3) != cube);

            return root;
        }

        public static int OddDigitsCount(int n)
        {
            int count = 0;
            while (n > 0)
            {
                if((n % 2) != 0)
                {
                    ++count;
                }

                n /= 10;
            }

            return count;
        }

        public static int NumberReverse(int n)
        {
            int result = 0;
            do
            {
                result = result * 10 + n % 10;
                n /= 10;
            } while (n > 0);

            return result;
        }

        public static void NumbersEvenDigitsSum(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int oddsum = 0;
                int evensum = 0;
                int tmp = i;
                do
                {
                    if (tmp % 2 == 0)
                    {
                        oddsum += tmp % 10;
                    }
                    else
                    {
                        evensum += tmp % 10; ;
                    }

                    tmp /= 10;
                } while (tmp > 0);

                if (oddsum > evensum)
                {
                    Console.Write($"{i}  ");
                }
            }
            Console.WriteLine();
        }

        public static bool Task12(int a, int b)
        {
            bool isDigit = false;
            do
            {
                int tmp1 = b;
                int tmp2 = a % 10;
                while (tmp1 > 0)
                {
                    if (tmp2 == (tmp1 % 10))
                    {
                        isDigit = true;
                        break;
                    }
                    tmp1 /= 10;
                }

                if (isDigit == true)
                {
                    break;
                }

                a /= 10;
            } while (a > 0);

            return isDigit;
        }
    }
}
