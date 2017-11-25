/* map_test.cs | Roman S. Collins | 11-24-2017



*/

using System;

namespace Main {
    class Map_Test {
        static void Main(string[] args) {
            Console.WriteLine("DEBUG: map_test.cs ... ");

            Console.WriteLine("DEBUG: Creating map class ... ");

            int render_distance = 10;
            int chunk_size = 10;
            int world_limit = 1000;

            Map map = new Map(render_distance, chunk_size, world_limit);

            System.Environment.Exit(1);
        }
    }
}
