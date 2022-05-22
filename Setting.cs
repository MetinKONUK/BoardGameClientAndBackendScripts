using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Setting
    {
        public string Username { get; set; }
        public int UserId { get; set; }
        public int       Rows             { get; set; }
        public int       Cols             { get; set; }
        public List<int> Shapes = new List<int>() { 0, 0, 0 };
        public int       DiffLevel { get; set; }
        public List<int> Colors = new List<int>() { 0, 0, 0};
    }
}
