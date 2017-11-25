/* terrain_gen.cs | Roman S. Collins | 11-23-17



*/

using System;

namespace Main {
    public partial class TerrainGen {
        public double seed;

        public int chunk_size;
        public int view_distance; // In number of chunks away from the player
        public int world_size;
        public Graph world;

        /* Graph g = new Graph(world_size); */

        public TerrainGen(int chunk_size, int view_distance, int world_size) {
            this.chunk_size = chunk_size;
            this.view_distance = view_distance;
            this.world_size = world_size;

            this.world = new Graph(world_size);
        }

    }

    class Tests {
        static void Main(string[] args) {
            TerrainGen terrain = new TerrainGen(10, 10, 500);
            Console.WriteLine(terrain.world.getString());
        }
    }
}
