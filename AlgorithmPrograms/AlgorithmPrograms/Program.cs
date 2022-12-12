namespace AlgorithmPrograms
{
    internal class Program
    {
        /**
        * permutation function
        * @param str string to
        * calculate permutation for
        * @param l starting index
        * @param r end index
        */
        private static void permute(String str, int l, int r)
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
            char[] charArray = a.ToCharArray(); // { 'A','B','C'}
            temp = charArray[i];// temp = 'A'
            charArray[i] = charArray[j]; // {'B','B','C'}
            charArray[j] = temp; // {'B','A','C'}
            string s = new string(charArray);
            return s;
        }

        // Driver Code
        public static void Main()
        {
            String str = "SAN";
            int n = str.Length;
            permute(str, 0, n - 1);
        }
    }
}