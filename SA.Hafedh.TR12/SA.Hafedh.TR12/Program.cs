using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.Hafedh.TR12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" How many Square Romms do u have in your house ?"  );
            
            int squareRoomsNumber = Console.Read();


            Console.WriteLine(" How many Rectangle Romms do u have in your house ?");

            int rectangleRoomsNumber = Console.Read();

            Rectangle[] rectangleRooms = new Rectangle[rectangleRoomsNumber];

            Square[] squareRooms = new Square[squareRoomsNumber];

            for (int i = 0; i < squareRooms.Length; i++ )
            {
                Console.WriteLine("Length of + " + i + " the square room please");
                squareRooms[i] = new Square( Console.Read());
            }

            for (int i = 0; i < squareRooms.Length; i++)
            {
                Console.WriteLine("X, Y  of + " + i + " the rectangle room please");
                rectangleRooms[i] = new Rectangle(Console.Read(), Console.Read());
            }

            float surface=0;

            foreach (var squareRoom in squareRooms)
            {
                surface += squareRoom.GetArea();
            }

            foreach (var rectRoom in rectangleRooms)
            {
                surface += rectRoom.GetArea();
            }

            Console.WriteLine(" the area of the house is "+ surface);

            Console.Read();

        }
    }
}
