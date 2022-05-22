using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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

        private static readonly List<List<Spot>> BoardMatrix = new List<List<Spot>>();
        
        private static Spot _home = null;
        
        private static Spot _target = null;

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
        } //end func


        public static Spot SetSelectedSpot(Button btn)
        {
            foreach (var t in BoardMatrix)
            {
                for (var b = 0; b < t.Count; b++)
                {
                    if (t[b].Btn == btn)
                    {
                        if (_home == null)
                        {
                            _home = t[b];
                        }
                        else
                        {
                            _target = t[b];
                        }
                        return t[b];
                    }
                }
            }

            return null;
        } //end func


        private static double Heuristic(Spot a, Spot b)
        {
            var distance = Math.Abs(a.I - b.I) + Math.Abs(a.J - b.J);
            return distance;
        } //end func


        private static void ResetPrevious()
        {
            for (var i = 0; i < _m; i++)
            {
                for (var j = 0; j < _m; j++)
                {
                    BoardMatrix[i][j].Previous = null;
                }
            }
        } //end func


        private static void SetNeighbors()
        {
            /* ADD NEIGHBORS */
            for (var i = 0; i < _m; i++)
            {
                for (var j = 0; j < _m; j++)
                {
                    BoardMatrix[i][j].AddNeighbors(BoardMatrix, _n, _m);
                }
            }
        } //end func

        public static List<Spot> PathFinder(Spot start, Spot end)
        {
            var openSet   = new List<Spot>();
            var closedSet = new List<Spot>();
            var path      = new List<Spot>();
            openSet.Add(start);
            while (true)
            {
                if (openSet.Count > 0)
                {
                    var winner = 0;
                    for (var i = 0; i < openSet.Count; i++)
                    {
                        if (openSet[i].F < openSet[winner].F)
                        {
                            winner = i;
                        }
                    } //end for

                    var current = openSet[winner];
                    if (current == end)
                    {
                        var temp = current;
                        path.Add(temp);
                        while (temp.Previous != null)
                        {
                            path.Add(temp.Previous);
                            temp = temp.Previous;
                        }

                        Console.WriteLine(@"DONE!!");
                        break;
                    } //end if

                    openSet.Remove(current);
                    closedSet.Add(current);
                    var neighbors = current.Neighbors;
                    foreach (var neighbor in neighbors)
                    {
                        if (!closedSet.Contains(neighbor) && !neighbor.IsFilled)
                        {
                            var tempG = current.G + 1;
                            if (openSet.Contains(neighbor))
                            {
                                if (tempG < neighbor.G)
                                {
                                    neighbor.G = tempG;
                                }
                            }
                            else
                            {
                                neighbor.G = tempG;
                                openSet.Add(neighbor);
                            }

                            neighbor.H        = Heuristic(neighbor, end);
                            neighbor.F        = neighbor.G + neighbor.H;
                            neighbor.Previous = current;
                        }
                    } //end foreach
                }     //end if
                else
                {
                    return null;
                }
            } //end while

            ResetPrevious();
            return path;
        } //end func


        public static void Sleep(int ms)
        {
            var counter = 0;
            while (counter < (ms/100))
            {
                Application.DoEvents();
                Thread.Sleep(100);
                ++counter;
            }
        } //end func


        public static void SwapSpots(Spot a, Spot b)
        {

            b.Btn.BackgroundImage       = a.Btn.BackgroundImage;
            b.Btn.BackgroundImageLayout = ImageLayout.Stretch;
            a.Btn.BackgroundImage       = null;
        } //end func

        public static void LoseFocus()
        {
            MainGameForm.MainGameFormInstance.MainGameWindowGamePanel.Focus();
        }
        public static void OnCellClick(Button btn)
        {
            var selectedSpot = SetSelectedSpot(btn);
            if (_target == null && selectedSpot.IsFilled == false)
            {
                MessageBox.Show(@"CANNOT SELECT EMPTY SPOT FOR HOME!!");
                LoseFocus();
                _home   = null;
                _target = null;
                return;
            }

            if (_home != null && _target != null)
            {
                if (_target.IsFilled == true)
                {
                    MessageBox.Show(@"TARGET MUST BE EMPTY; SELECT ANOTHER SPOT!!");
                    _home.Btn.Focus();
                    _target = null;
                    return;
                }

                var path = PathFinder(_home, _target);
                if (path == null)
                {
                    MessageBox.Show(@"NO PATH EXISTS!!");
                    LoseFocus();
                    _home = null;
                    _target = null;
                    return;
                }

                path.Reverse();
                var prevSpot = path[0];

                path = path.GetRange(1, path.Count - 1);

                foreach (var spot in path)
                {
                    Sleep(500);
                    SwapSpots(prevSpot, spot);
                    prevSpot = spot;
                }

                LoseFocus();
                _home.IsFilled   = false;
                _target.IsFilled = true;
                _home            = null;
                _target          = null;
                SetCellShape();
            }
        } //end func


        public static void SetBoard()
        {
            ClearBoard();
            SetRowCol();

            var y = 2;
            for (var i = 0; i < _n; i++)
            {
                var row = new List<Spot>();
                var x = 2;
                for (var j = 0; j < _m; j++)
                {
                    var spot = new Spot
                               {
                                   I = i,
                                   J = j
                               };
                    var btn = new Button
                              {
                                  Name = @"{n}{m}",
                                  Size = new Size(40, 40),
                                  Location = new Point(40 * x, 40 * y),
                                  BackColor = Color.AntiqueWhite,
                              };
                    btn.Click += (s, e) => OnCellClick(btn);
                    spot.Btn = btn;
                    row.Add(spot);
                    x++;
                }
                y++;
                BoardMatrix.Add(row);
            }

            SetNeighbors();
            for (var i = 0; i < 3; i++)
            {
                SetCellShape();
            }
        } //end func


        public static void ShowBoard()
        {
            var panel = MainGameForm.MainGameFormInstance.MainGameWindowGamePanel;
            ClearPanel(panel);
            SetRowCol();
            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _m; j++)
                {
                    panel.Controls.Add(BoardMatrix[i][j].Btn);
                }
            }
        } //end func


        public static void ClearPanel(Panel panel)
        {
            panel.Controls.Clear();
        } //end func


        public static void ClearBoard()
        {
            BoardMatrix.Clear();
        } //end func


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
        } //end func

        public static List<int> SpecifyShapeLocation()
        {
            var random = new Random();

            var  locationRow   = random.Next(0, _n);
            var  locationCol   = random.Next(0, _m);
            var alreadyExists = BoardMatrix[locationRow][locationCol].IsFilled == true;
            return alreadyExists ? SpecifyShapeLocation() : new List<int>() { locationRow, locationCol };
        } //end func


        public static void SetCellShape()
        {
            var coordinates = SpecifyShapeLocation();
            var n           = coordinates[0];
            var m           = coordinates[1];
            BoardMatrix[n][m].Btn.BackgroundImage       = Image.FromFile(@SpecifyShape());
            BoardMatrix[n][m].Btn.BackgroundImageLayout = ImageLayout.Stretch;
            BoardMatrix[n][m].IsFilled                  = true;
        } //end func


    } //class end
} //namespace end
