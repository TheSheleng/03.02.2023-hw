using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03._02._2023_hw
{
    internal class Program
    {
        static void EndErr(int code)
        {
            Console.WriteLine("Error Task " + code);
            Console.ReadKey();
            Environment.Exit(code);
        }
        static void EndIfNotInt(string s, out int o, int code)
        {
            if (!(int.TryParse(s, out o))) EndErr(code);
        }
        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        static void PrintMat(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int y = 0; y < mat.GetLength(1); y++)
                {
                    Console.Write($"{mat[i, y]} ");
                }
                Console.WriteLine();
            }
        }
        static int[,] MatSum(int[,] mat1, int num)
        {
            int[,] res = new int[mat1.GetLength(0), mat1.GetLength(1)];
            for (int i = 0; i < mat1.GetLength(0); i++)
                for (int y = 0; y < mat1.GetLength(1); y++)
                    res[i, y] = mat1[i, y] + num;

            return res;
        }
        static int[,] MatDiv(int[,] mat1, int[,] mat2)
        {
            if (mat1.GetLength(0) != mat2.GetLength(0) ||
                mat1.GetLength(1) != mat2.GetLength(1))
                throw new Exception("Матрицы доожны быть одинаковыми");

            int[,] res = new int[mat1.GetLength(0), mat1.GetLength(1)];
            for (int i = 0; i < mat1.GetLength(0); i++)
                for (int y = 0; y < mat1.GetLength(1); y++)
                    res[i, y] = mat1[i, y] * mat2[i, y];

            return res;
        }
        static int[,] MatSum(int[,] mat1, int[,] mat2)
        {
            if (mat1.GetLength(0) != mat2.GetLength(0) ||
                mat1.GetLength(1) != mat2.GetLength(1))
                throw new Exception("Матрицы доожны быть одинаковыми");

            int[,] res = new int[mat1.GetLength(0), mat1.GetLength(1)];
            for (int i = 0; i < mat1.GetLength(0); i++)
                for (int y = 0; y < mat1.GetLength(1); y++)
                    res[i, y] = mat1[i, y] + mat2[i, y];

            return res;
        }
        static void Main(string[] args)
        {
            #region Task 1
            //Console.WriteLine("Enter array: ");
            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{i + 1}: ");
            //    EndIfNotInt(Console.ReadLine(), out arr[i], 1);
            //    if (arr[i] > 100) EndErr(1);
            //}

            //Random rnd = new Random();
            //int[,] mat = new int[3, 4];
            //for (int i = 0; i < mat.GetLength(0); i++)
            //    for (int y = 0; y < mat.GetLength(1); y++)
            //    {
            //        mat[i, y] = rnd.Next(0, 10);
            //    }

            //Console.Write("Arr: ");
            //PrintArr(arr);
            //Console.WriteLine("Mat: ");
            //PrintMat(mat);

            //int[] common = { };
            //foreach (int a in arr)
            //    foreach (int m in mat)
            //    {
            //        if (a == m && !common.Contains(a))
            //        {
            //            int[] temp = new int[common.Length + 1];
            //            Array.Copy(common, temp, common.Length);
            //            temp[common.Length] = a;
            //            common = temp;
            //        }
            //    }

            //Console.Write("\nCommon: ");
            //PrintArr(common);

            //Console.WriteLine($"Max: {common.Max()}");
            //Console.WriteLine($"Min: {common.Min()}");
            //Console.WriteLine($"Sum: {common.Sum()}");
            //Console.WriteLine();

            //int t = 0;
            //foreach (int a in arr) if (a % 2 == 0) t += a;
            //Console.WriteLine($"Sum A ev: {t}");
            //t = 0;
            //foreach (int a in mat) if (a % 2 == 1) t += a;
            //Console.WriteLine($"Sum B nev: {t}");
            #endregion

            #region Task 2
            //Random rnd = new Random();
            //int[,] mat = new int[5, 5];
            //for (int i = 0; i < mat.GetLength(0); i++)
            //    for (int y = 0; y < mat.GetLength(1); y++)
            //    {
            //        mat[i, y] = rnd.Next(-100, 100);
            //    }
            //PrintMat(mat);

            //int[] arr = new int[25];
            //int t = 0;
            //foreach (int i in mat) arr[t++] = i;

            //int iF = Array.IndexOf(arr, arr.Min());
            //int iL = Array.IndexOf(arr, arr.Max());
            //if (iL < iF) (iL, iF) = (iF, iL);

            //int res = 0;
            //for (int i = iF; i < iL; i++) res += arr[i];
            //Console.WriteLine($"Answ: {res}");
            #endregion

            #region Task 3
            //Console.Write("Enter msg: ");
            //StringBuilder str = new StringBuilder(Console.ReadLine());
            //Console.Write("Enter key: ");
            //EndIfNotInt(Console.ReadLine(), out int key, 3);

            //const char AlfLen = (char)('Z' - 'A' + 1);
            //key %= (int)(AlfLen);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] >= 'A' && str[i] <= 'Z')
            //    {
            //        str[i] += (char)key;
            //        if (str[i] > 'Z') str[i] -= AlfLen;
            //        else if (str[i] < 'A') str[i] += AlfLen;
            //    }
            //    else if (str[i] >= 'a' && str[i] <= 'z')
            //    {
            //        str[i] += (char)key;
            //        if (str[i] > 'z') str[i] -= AlfLen;
            //        else if (str[i] < 'a') str[i] += AlfLen;
            //    }
            //}

            //Console.WriteLine($"Edit: {str}");
            #endregion

            #region Task 4
            //Random rnd = new Random();
            //int[,] mat1 = new int[5, 5];
            //int[,] mat2 = new int[5, 5];
            //for (int i = 0; i < mat1.GetLength(0); i++)
            //    for (int y = 0; y < mat1.GetLength(1); y++)
            //    {
            //        mat1[i, y] = rnd.Next(-100, 100);
            //        mat2[i, y] = rnd.Next(-100, 100);
            //    }

            //Console.WriteLine("\nMat1: ");
            //PrintMat(mat1);
            //Console.WriteLine("\nMat2:");
            //PrintMat(mat2);

            //Console.WriteLine("\nMat1 + 5: ");
            //PrintMat(MatSum(mat1, 5));
            //Console.WriteLine("\nMat1 + Mat2: ");
            //PrintMat(MatSum(mat1, mat2));
            //Console.WriteLine("\nMat1 * Mat2: ");
            //PrintMat(MatDiv(mat1, mat2));
            #endregion

            #region Task 5
            //Console.Write("Write math: ");
            //string str = Console.ReadLine();
            //var nums = new List<int>();
            //var action = new List<char>();
            //foreach (string word in str.Split(new char[] { ' ', '+', '-' }, StringSplitOptions.RemoveEmptyEntries))
            //{
            //    EndIfNotInt(word, out int num, 5);
            //    nums.Add(num);
            //}

            //foreach (char s in str) if (s == '+' || s == '-') action.Add(s);

            //int res = nums[0];
            //for (int i = 0; i < nums.Count - 1; i++)
            //{
            //    if (action[i] == '+') res += nums[i + 1];
            //    else if (action[i] == '-') res -= nums[i + 1];
            //}

            //Console.WriteLine($"Result: {res}");
            #endregion

            #region Task 6
            //Console.Write("Write msg: ");
            //string str = Console.ReadLine();
            //string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //var sb = new List<StringBuilder>();

            //foreach (string word in words)
            //{
            //    if (word.Contains("."))
            //    { 
            //        string[] _words = word.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            //        if (word[0] == '.') sb.Last().Append(".");
            //        foreach (string _word in _words) sb.Add(new StringBuilder(_word + '.'));
            //        if (word[word.Length - 1] != '.') sb.Last().Remove(_words[_words.Length - 1].Length, 1);
            //        continue;
            //    }
            //    sb.Add(new StringBuilder(word));
            //}
            //if (str[str.Length - 1] != '.') sb.Last().Append('.');
            //sb[0][0] = sb[0][0].ToString().ToUpper()[0];
            //for (int i = 0; i < sb.Count - 1; i++)
            //{
            //    if (sb[i].ToString().Contains('.')) sb[i + 1][0] = sb[i + 1][0].ToString().ToUpper()[0];
            //}

            //foreach (StringBuilder w in sb) Console.Write(w.Append(' '));
            #endregion

            #region Task 7
            string[] BanWords = {
                "die",
                //....
            };

            Console.Write("Write msg: ");
            StringBuilder str = new StringBuilder(Console.ReadLine());

            foreach (string word in BanWords) 
            {
                str.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine($"Result: {str.ToString()}");
            #endregion

            Console.ReadKey();
        }
    }
}
