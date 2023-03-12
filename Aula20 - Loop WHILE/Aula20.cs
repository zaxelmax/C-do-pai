using System;

class Aula19
{

    static void Main()
    {
        int i = 1;
        while (i < 26)
        {
            Console.Write(i + "\t");
            
            if (i % 5 == 0)
            {
                Console.WriteLine("");
            }
            i++;
        }

    }

}
