using System;

class Aula22
{

    static void Main(string[] args)
    {


        int[] var = new int[3] { 11, 22, 33 };
        /*for (int i = 0; i < var.Length; i++)
        {
            Console.WriteLine(var[i]);
        }
        */
            foreach (int n in var)
        {Console.WriteLine(n);

        }
    }
}
