using System;
using System.Drawing;

namespace Room
{
    class Program
    {
        static void Main(string[] args)
        {
            Box plot1 = new Box(5, 5, 1, Material.Wooden);
            Box back1 = new Box(6, 5, 1, Material.Wooden);
            Box[] legs = new Box[4];

            for (int i = 0; i < legs.Length; i++)
            {
                Box leg = new Box(5, 2, 2, Material.Wooden);
                legs[i] = leg;
            }

            //Chair chair1 = new Chair(plot1, legs, back1);
            //Console.WriteLine(chair1.c);

            Painter p = new Painter();
            Chair c = new Chair(plot1, legs, back1);
            p.Paint(Color.Beige, c);

            Console.ReadKey();
        }
    }
}
