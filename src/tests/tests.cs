/* tests.cs | Roman S. Collins | Thu, Nov 2016



*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main {
    // Main program
    class Tests {
        static void Main(string[] args) {
            // Routine:

            Console.WriteLine("DEBUG: Creating Graph class... ");

            int size = 5;
            Graph g = new Graph(size);
            Console.WriteLine(g);
            Console.WriteLine(g.getString());

            // getZ, setZ for (0, 0) and (4, 4)
            int x = 0; int y = 0; int c = 0;

            while (y != 4 && x != 4 || c < 1) {
                Console.WriteLine(string.Format("{0} {1}", "getZ, setZ", g.getZ(y, x)));
                g.setZ(y, x, 2);
                Console.WriteLine(string.Format("{0} {1}", "getZ, setZ", g.getZ(y, x)));

                if (y == 4 ||  x == 4) {
                    c++;
                }

                y = 4; x = 4;
            }

            // Display changes for (0, 0) and (4, 4)
            Console.WriteLine(g.getString());

            // getColor, setColor for (4, 4)
            Console.WriteLine(g.getColor(4, 4));
            g.setColor(4, 4, 255, 255, 255);
            Console.WriteLine(g.getColor(4, 4));

            // Display color changes for (4, 4)
            Console.WriteLine(g.getString());
        }
    }
}
