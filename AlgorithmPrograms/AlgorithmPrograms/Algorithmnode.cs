using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class Algorithmnode
    {
        public class StringPermutation
        {

            /**
            * permutation function
            * @param str string to
            * calculate permutation for
            * @param l starting index
            * @param r end index
            */
            public static void permute(String str, int l, int r)
            {
                if (l == r)
                    Console.WriteLine(str);
                else
                {
                    for (int i = l; i <= r; i++)
                    {
                        str = swap(str, l, i); // str= "BAC"
                        permute(str, l + 1, r);
                    }
                }
            }

            /**
             * Swap Characters at position
             * @param a string value
             * @param i position 1
             * @param j position 2
             * @return swapped string
             */
            public static String swap(String a, int i, int j)
            {
                char temp;
                char[] charArray = a.ToCharArray();   // { 'A','B','C'}
                temp = charArray[i];                  // temp = 'A'
                charArray[i] = charArray[j];          // {'B','B','C'}
                charArray[j] = temp;                  // {'B','A','C'}
                string s = new string(charArray);
                return s;
            }

        }

        public class BinarySearch
        {
            //public static void search()
            //{
            //    string str = "snjv is a boy";
            //    string[] arr = str.Split(' ');
            //    Array.Sort(arr);
            //    foreach (var word in arr)
            //    {
            //        System.Console.WriteLine(word);
            //    }
            //}

            public static int binarySearch(String[] arr, String str)
            {
                int low = 0, high = arr.Length - 1;
                while (low <= high)
                {
                    int middle = (low + high) / 2;

                    int res = str.CompareTo(arr[middle]);
                    // Check if str is present at mid
                    if (res == 0)
                        return middle;

                    // If str greater, ignore left half
                    if (res > 0)
                        low = middle + 1;

                    // If str is smaller, ignore right half
                    else
                        high = middle - 1;
                }

                return -1;
            }

            public static void sortStrings(String[] arr)
            {
                String temp;

                // Sorting strings using bubble sort
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    for (int i = j + 1; i < arr.Length; i++)
                    {
                        if (arr[j].CompareTo(arr[i]) > 0)
                        {
                            temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
            }
        }
    }
}

