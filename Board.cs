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
        public Board() { }

        public static Board Instance { get; } = new Board();
        private static readonly List<List<Button>> board = new List<List<Button>>();

        public static List<List<Button>> GetBoard() => board;
        public static void SetBoard(int n, int m)
        {
            var y = 1;
            for (var i = 0; i < n; i++)
            {
                List<Button> row = new List<Button>();
                var x = 1;
                for (var j = 0; j < m; j++)
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

        public static void ShowBoard(Panel panel, int n, int m)
        {
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
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


    }
}
