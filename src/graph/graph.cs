/* graph.cs | Roman S. Collins | Thu, Nov 2016



*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main {
    public partial class Graph {
        public IDictionary<Tuple<int, int>, List<int>> grid = new Dictionary<Tuple<int, int>, List<int>>();
        public int size;
        public int width;
        public int height;

        // Constructor
        public Graph(int size) {
            this.grid = new Dictionary<Tuple<int, int>, List<int>>();
            this.size = size; this.width = this.size; this.height = this.size;

            for (int y = 0; y < this.height; y++) {
                for (int x = 0; x < this.width; x++) {
                    /* Console.WriteLine(string.Format("{0}, {1}", y, x)); */
                    /* grid.Add(y, "test"); */
                    Tuple<int, int> tup = new Tuple<int, int>(y, x);
                    List<int> nl = new List<int> {0, 0, 0, 0};

                    /* Console.WriteLine(string.Format("{0}", tup)); */
                    grid.Add(tup, nl);
                }
            }

            // DEBUG:
            /* Console.WriteLine(size); */
            /* Console.WriteLine(this.size); */
            /* Console.WriteLine(grid); */
        }

        public string getString() {
            string outstr = "{";

            for (int y = 0; y < this.width; y++) {
                for (int x = 0; x < this.height; x++) {
                    string outoutstr = "[";

                    // Lim to size of list contained in dictionary as values
                    int lim = grid[new Tuple<int, int>(y, x)].Count;

                    for (int i = 0; i < lim; i++) {
                        if (i < lim - 1) {
                            outoutstr = outoutstr + string.Format("{0}, ", grid[new Tuple<int, int>(y, x)][i]);
                        } else {
                            outoutstr = outoutstr + string.Format("{0}", grid[new Tuple<int, int>(y, x)][i]);
                        }
                    }

                    outoutstr = outoutstr + "]";

                    outstr = outstr + string.Format("({0}, {1}): {2}", y, x, outoutstr);

                    if (x < (this.width - 1)) {
                        outstr = outstr + " ";
                    }
                }

                if (y < (this.height - 1)) {
                    outstr = outstr + "\n";
                }
            }

            outstr = outstr + "}";

            return outstr;
        }

        // Get value for z
        public Nullable<int> getZ(int y, int x) {
                int? val;

                if (y > this.height || x > this.width || y < 0 || x < 0) {
                    val = null;
                }

                Tuple<int, int> new_tup = new Tuple<int, int>(y, x);
                val = this.grid[new_tup][0];

                return val;
        }

        // Set value for z
        public void setZ(int y, int x, int val) {
                // Out of bounds
                if (y > this.height || x > this.width || y < 0 || x < 0) {
                    return;
                }

                /* Tuple new_tup = new Tuple<int, int>(y, x); */
                Tuple<int, int> new_tup = new Tuple<int, int>(y, x);
                this.grid[new_tup][0] = val;
        }

        // Get color for coord
        public List<int> getColor(int y, int x) {
            Tuple<int, int> new_tup = new Tuple<int, int>(y, x);
            List<int> outlist = new List<int> {this.grid[new_tup][1], this.grid[new_tup][2], this.grid[new_tup][3]};
            return outlist;
        }

        // Set color for coord
        public void setColor(int y, int x, int r, int g, int b) {
            Tuple<int, int> new_tup = new Tuple<int, int>(y, x);
            this.grid[new_tup][1] = r; this.grid[new_tup][2] = g; this.grid[new_tup][3] = b;
        }
    }

    /* class Graph_Main { */
    /*     static void Main(string[] args) { */
    /*     } */
    /* } */
}

