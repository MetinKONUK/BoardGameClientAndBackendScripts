using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public sealed class Board
    {
        public Board()
        {
            UserBase.SetSettings();
        }

        private static int _n = 0;
        private static int _m = 0;
        public static Board Instance { get; } = new Board();
        private static readonly List<List<Button>> BoardMatrix = new List<List<Button>>();
        private static readonly List<List<int>> CrowdedPoints = new List<List<int>>(2);
        public static List<List<Button>> GetBoard() => BoardMatrix;

        public static void SetRowCol()
        {
            var diffLevel = UserBase.GetSettings()[UserBase.GetCurrentUser()].DifficultyLevel;
            switch (diffLevel)
            {
                case 0:
                    _n = 6;
                    _m = 6;
                    break;
                case 1:
                    _n = 9;
                    _m = 9;
                    break;
                default:
                    _n = 12;
                    _m = 12;
                    break;
            }
        }
        public static void SetBoard()
        {
            ClearBoard();
            SetRowCol();
            var y = 2;
            for (var i = 0; i < _n; i++)
            {
                var row = new List<Button>();
                var x = 2;
                for (var j = 0; j < _m; j++)
                {
                    var btn = new Button
                    {
                        Name = @"{n}{m}",
                        Size = new Size(40, 40),
                        Location = new Point(40 * x, 40 * y)
                    };
                    ;
                    x++;
                    row.Add(btn);
                }
                BoardMatrix.Add(row);
                y++;
            }

            for (int i = 0; i < 3; i++)
            {
                SetCellShape();
            }
        }

        public static void ShowBoard()
        {
            var panel = MainGameForm.MainGameFormInstance.MainGameWindowGamePanel;
            ClearPanel(panel);
            SetRowCol();
            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _m; j++)
                {
                    panel.Controls.Add(BoardMatrix[i][j]);
                }
            }
        }

        public static void ClearPanel(Panel panel)
        {
            panel.Controls.Clear();
        }

        public static void ClearBoard()
        {
            BoardMatrix.Clear();
        }

        public static List<int> SpecifyShapeLocation()
        {
            var random = new Random();

            var locationRow = random.Next(0, _n);
            var locationCol = random.Next(0, _m);

            return new List<int>(){locationRow, locationCol};
        }

        public static string SpecifyShape()
        {
            var selectedShapes = UserBase.GetSettings()[UserBase.GetCurrentUser()].Shapes;
            var possibleShapes = new List<int>();
            for (var i = 0; i < 3; i++)
            {
                if (selectedShapes[i] == 1)
                {
                    possibleShapes.Add(i);
                }
            }

            var selectedColors = UserBase.GetSettings()[UserBase.GetCurrentUser()].Colors;
            var possibleColors = new List<int>();
            for (var i = 0; i < 3; i++)
            {
                if (selectedColors[i] == 1)
                {
                    possibleColors.Add(i);
                }
            }

            var random = new Random();
            var shape = possibleShapes[random.Next(0, possibleShapes.Count())];
            var color = possibleColors[random.Next(0, possibleColors.Count())];
            var path = $"../../shapes/{shape}{color}.png";

            return path;
        }

        public static void SetCellShape()
        {

            var coordinates = SpecifyShapeLocation();
            var n = coordinates[0];
            var m = coordinates[1];
            var alreadyExists = CrowdedPoints.Any(x => x[0] == n && x[1] == m);

            if (alreadyExists)
            {
                //MessageBox.Show("Contain");
                SetCellShape();
            }
            else
            {
                BoardMatrix[n][m].BackgroundImage       = Image.FromFile(@SpecifyShape());
                BoardMatrix[n][m].BackgroundImageLayout = ImageLayout.Stretch;
                CrowdedPoints.Add(new List<int>(){n, m});
            }
        }
    }
}
