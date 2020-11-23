using System;

namespace Array
{
    class Program
    {
        public static void array(int [] a, int[] b)
        {
            for (int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]+ " "+ b[i]);

            }
        }

        public static void printMin(int [] a)
        {
            int min = a[0];
            for (int i=1; i<a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            Console.Write("The minimum of array :");
            for (int j=0; j<a.Length; j++) {
                Console.Write(a[j]+"  ");
            }
            Console.Write("is "+min);
            Console.WriteLine();
        }
        public static void printMax(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.Write("The maximum of array :");
            for (int j = 0; j < a.Length; j++)
            {
                Console.Write(a[j] + "  ");
            }
            Console.Write("is " + max);
            Console.WriteLine();
        }
        public static void twoD(int [,] d)
        {
            for (int i=0; i<3;i++)
            {
                for (int j=0;j<3;j++)
                {
                    Console.Write(d[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        public static void jaggedArray(int[][]w)
        {
            for (int i=0;i<w.Length;i++)
            {
                for (int j=0;j<w[i].Length;j++)
                {
                    Console.Write(w[i][j]+ " ");
                }
                Console.WriteLine();

            }

        }

        public void params1(params object[] items)
        {
            for (int i=0;i<items.Length;i++)
            {
                Console.WriteLine(items[i]);
            }
        }


        static void Main(string[] args)
        {
            int[] arr= { 0,1,0,2};
            /*for (int i=0;i<4;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }*/

            for (int j=0;j<4;j++)
            {
                Console.WriteLine(arr[j]);
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Array passing to function ");
            int[] a = { 16, 13, 14, 15 };
            int[] b = { 5, 3, 2, 5 };

            //Program p = new Program();
            //p.array(a,b);
            array(a,b);
            printMin(b);
            printMin(a);
            printMax(a);
            printMax(b);
            Console.WriteLine("2D Array passing to function ");
            int[,] s = new int[3, 3] { { 1,2,3},{ 4,5,6},{ 7,8,9} };
            /*s[0, 0] = 12;
            s[0, 1] = 11;
            s[0, 2] = 10;
            s[1, 0] = 12;
            s[1, 1] = 9;
            s[1, 2] = 1;
            s[2, 0] = 12;
            s[2, 1] = 12;
            s[2, 2] = 12;
            */
            twoD(s);
            Console.WriteLine("Jagged Array");

            int[][] w = new int[3][];
            w[0] = new int[] {12,11,22,33 };
            w[1] = new int[] {1,2,3,1,3};
            w[2] = new int[] {4,5,6,7,8};
            jaggedArray(w);
            Console.WriteLine();
            Console.WriteLine("PARAMS ");
            Program p = new Program();
            p.params1("Khubaib","Khalid", 22, 1998, 14.07);

        }
    }
}
