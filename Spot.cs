using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public class Spot
    {
        public int        I         = 0;
        public int        J         = 0;
        public double     F         = 0;
        public double     G         = 0;
        public double     H         = 0;
        public List<Spot> Neighbors = new List<Spot>();
        public Spot       Previous  = null;
        public bool       IsFilled  = false;
        public Button     Btn       = new Button();

        public void AddNeighbors(List<List<Spot>> grid, int rows, int cols)
        {
            if (I < cols - 1) Neighbors?.Add(grid[I + 1][J]);
            if (I > 0) Neighbors?.Add(grid[I        - 1][J]);
            if (J < rows - 1) Neighbors?.Add(grid[I][J + 1]);
            if (J > 0) Neighbors?.Add(grid[I][J        - 1]);
        }
    }
}
