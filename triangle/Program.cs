using System;
public class DrawTriangle
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int width = Convert.ToInt32(Console.ReadLine());
        int height = width;

        for (int row = 0; row < height; row++)
        {
            for ( int column = 0; column < width; column++)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            width--;
        }
    }
}



