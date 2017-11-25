/* map.cs | Roman S. Collins | 11-24-17



*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main {
    public partial class Map {
        public IDictionary<Tuple<int, int>, Graph> chunks = new Dictionary<Tuple<int, int>, Graph>();
        public int render_distance;
        public int chunk_size;
        public int world_limit;

        public Map(int render_distance, int chunk_size, int world_limit) {
            this.render_distance = render_distance;
            this.chunk_size = chunk_size;
            this.world_limit = world_limit;

            for (int y = 0; y < this.world_limit; y++) {
                for (int x = 0; x < this.world_limit; x++) {
                    Tuple<int, int> tup = new Tuple<int, int>(y, x);
                    Graph gra = new Graph(chunk_size);
                    chunks.Add(tup, gra);
                }
            }
        }

        public Graph getChunk(int y, int  x) {
            return chunks[new Tuple<int, int>(y, x)];
        }

        // TODO:
        // Methods for rendering chunks to the game

    }
}
