using System;
using System.Collections.Generic;
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
        private static readonly List<List<Button>> board = new List<List<Button>>();

        public static List<List<Button>> GetBoard() => board;

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
                board.Add(row);
                y++;
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
                    panel.Controls.Add(board[i][j]);
                }
            }
        }

        public static void SetCellShape(int n, int m, int shape)
        {
            board[n][m].BackgroundImage = Image.FromFile($@"../../shapes/{shape}.png");
            board[n][m].BackgroundImageLayout = ImageLayout.Stretch;
        }

        public static void ClearPanel(Panel panel)
        {
            panel.Controls.Clear();
        }

        public static void ClearBoard()
        {
            board.Clear();
        }


    }
}
