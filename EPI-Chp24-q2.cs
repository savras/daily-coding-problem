using System;

namespace ConsoleApplication1
{
    class Solution
    {
        public static int GetSmallestPositiveInteger(int[] arr)
        {
            var n = arr.Length;
            int i;
            for (i = 0; i < n; i++)
            {

                var val = arr[i];
                while (val != i && val > 0 && val < n)
                {
                    if (val == arr[val])
                    {
                        arr[i] = -1;
                        break;
                    }

                    arr[i] = arr[val];
                    arr[val] = val;
                    val = arr[i];
                }
            }

            var result = 1;
            for (i = 1; i < n; i++)
            {
                if (i != arr[i])
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            var arr = new[] {-1, 2, 5, 5, 1, 5};
            var result = GetSmallestPositiveInteger(arr);
            Console.WriteLine(result);
        }
    }
}