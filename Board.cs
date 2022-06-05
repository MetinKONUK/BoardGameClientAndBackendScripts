using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
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

        private static          int              _n          = 0;
        private static          int              _m          = 0;
        private static readonly List<List<Spot>> BoardMatrix = new List<List<Spot>>();
        private static          Spot             _home       = null;
        private static          Spot             _target     = null;
        public static           Board            Instance { get; } = new Board();
        public static           int              UserScore = 0;
        public static int ButtonSize = 20;
        public static void SetRowCol()
        {
            var userSettings = UserBase.GetSettings()[UserBase.GetCurrentUser()];
            var row          = userSettings.Rows;
            var col          = userSettings.Cols;
            var diffLevel    = userSettings.DiffLevel;
            switch (diffLevel)
            {
                case 0:
                    _n = 15;
                    _m = 15;
                    ButtonSize = 20;
                    break;
                case 1:
                    _n = 9;
                    _m = 9;
                    ButtonSize = 35;
                    break;
                case 2:
                    _n = 6;
                    _m = 6;
                    ButtonSize = 40;
                    break;
                case 3:
                    _n = row;
                    _m = col;
                    if(_n*_m < 200)
                    {
                        ButtonSize = 30;
                    } 
                    else
                    {
                        ButtonSize = 18;
                    }
                    break;
                default:
                    _n = 9;
                    _m = 9;
                    ButtonSize = 35;
                    break;
            }
        } //end func

        public static int CalculateEmptySpotCount()
        {
            return BoardMatrix.SelectMany(row => row).Count(spot => spot.IsFilled);
        } //end func

        public static bool IsGameEnd()
        {
            return CalculateEmptySpotCount() > (_n * _m - 3);
        } //end func

        public static Spot SetSelectedSpot(Button btn)
        {
            foreach (var row in BoardMatrix)
            {
                for (var b = 0; b < row.Count; b++)
                {
                    if (row[b].Btn == btn)
                    {
                        if (_home == null)
                        {
                            _home = row[b];
                        }
                        else
                        {
                            _target = row[b];
                        }

                        return row[b];
                    }
                }
            }

            return null;
        } //end func


        public static void UpdateBestScore()
        {
            Label label = MainGameForm.MainGameFormInstance.BestScoreLabel;

            label.Text = UserBase.GetUsers()[UserBase.GetCurrentUser()].BestScore.ToString();
        }

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
            while (counter < (ms / 100))
            {
                Application.DoEvents();
                Thread.Sleep(100);
                ++counter;
            }
        } //end func

        public static void SwapSpots(Spot a, Spot b)
        {
            //Sound.Play(Sound.ShapeMoved);
            b.ShapeType                 = a.ShapeType;
            a.ShapeType                 = null;
            b.Btn.BackgroundImage       = a.Btn.BackgroundImage;
            b.Btn.BackgroundImageLayout = ImageLayout.Stretch;
            a.Btn.BackgroundImage       = null;
        } //end func

        public static void LoseFocus()
        {
            MainGameForm.MainGameFormInstance.MainGameWindowGamePanel.Focus();
        }

        public static void ClearSpotsAfterSuccess(int n, int m, int type)
        {
            if (type == 0)
            {
                for (var i = m; i < m + 5; i++)
                {
                    BoardMatrix[n][i].ShapeType           = null;
                    BoardMatrix[n][i].Btn.BackgroundImage = null;
                    BoardMatrix[n][i].IsFilled            = false;
                }
            }
            else
            {
                for (var i = n; i < n + 5; i++)
                {
                    BoardMatrix[i][m].ShapeType           = null;
                    BoardMatrix[i][m].Btn.BackgroundImage = null;
                    BoardMatrix[i][m].IsFilled            = false;
                }
            }
        }

        public static bool CoWise(int n, int m)
        {
            var array     = BoardMatrix.Select(row => row[m]).ToList();
            var sameCount = 0;

            //TO UP
            var border = Math.Min(n + 5, array.Count);
            for (var i = n + 1; i < border; i++)
            {
                if (array[i].ShapeType != null && array[i].ShapeType == array[n].ShapeType)
                {
                    sameCount += 1;
                    if (sameCount == 4) return true;
                }
                else
                    break;
            }

            //TO DOWN
            border = Math.Max(n - 5, 0);
            for (var i = n - 1; i > border - 1; i--)
            {
                if (array[i].ShapeType != null && array[i].ShapeType == array[n].ShapeType)
                {
                    sameCount += 1;
                    if (sameCount == 4) return true;
                }
                else
                    break;
            }

            return false;
        }

        public static bool RoWise(int n, int m)
        {
            var array   = BoardMatrix[n];
            var toRight = 0;
            var toLeft  = 0;

            //TO RIGHT
            var border = Math.Min(m + 5, array.Count);
            for (var i = m + 1; i < border; i++)
            {
                if (array[i].ShapeType != null && array[i].ShapeType == array[m].ShapeType)
                {
                    toRight += 1;
                    if (toRight == 4) return true;
                }
                else
                    break;

                ;
            }

            //TO LEFT
            border = Math.Max(m - 5, 0);
            for (var i = m - 1; i > border - 1; i--)
            {
                if (array[i].ShapeType != null && array[i].ShapeType == array[m].ShapeType)
                {
                    toLeft += 1;
                    if ((toRight + toLeft) == 4) return true;
                }
                else
                    break;
            }

            return false;
        }

        public static int Judge()
        {
            var userSettings = UserBase.GetSettings()[UserBase.GetCurrentUser()];
            var diffLevel    = userSettings.DiffLevel;
            switch (diffLevel)
            {
                case 0:
                    return 1;                    
                case 1:
                    return 3;
                case 2:
                    return 5;
                case 3:
                    return 2;
                default:
                    return 0;
            }
        }

        public static void CheckForPoints()
        {
            var point = Judge();
            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _m; j++)
                {
                    if (RoWise(i, j))
                    {
                        Sound.Play(Sound.PointsEarned);
                        UserScore += point;
                        ClearSpotsAfterSuccess(i, j, 0);
                    }

                    if (CoWise(i, j))
                    {
                        Sound.Play(Sound.PointsEarned);
                        UserScore += point;
                        ClearSpotsAfterSuccess(i, j, 1);
                    }
                }
            }
        }

        public static void HandleUserBestScore()
        {
            var user = UserBase.GetUsers()[UserBase.GetCurrentUser()];

            Console.WriteLine($"UserScore: {UserScore}, Previous Score: {user.BestScore}");
            if(user.BestScore < UserScore)
            {
                UserBase.UpdateUserBestScore(UserScore, user.Username);
                UserBase.GetUsers()[UserBase.GetCurrentUser()].BestScore = UserScore;
                UpdateBestScore();
            }
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
                    _home   = null;
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
                _home.IsFilled = false;

                _target.IsFilled = true;
                _home            = null;
                _target          = null;

                PlaceShapes();
                if (IsGameEnd())
                {
                    MessageBox.Show(@"Game End!");
                    MessageBox.Show($"Score: {UserScore}");
                    HandleUserBestScore();
                    return;
                }

                CheckForPoints();

                //MessageBox.Show(RoWise(4, 4).ToString());
                //MessageBox.Show(CoWise(4, 4).ToString());
            }
        } //end func

        public static void SetBoard()
        {
            ClearBoard();
            SetRowCol();
            var panel = MainGameForm.MainGameFormInstance.MainGameWindowGamePanel;
            var PanelWidth = panel.Width;
            var PanelHeight = panel.Height;
            int y = ((PanelHeight) - (_m * ButtonSize)) / 2;
            //MessageBox.Show(y.ToString());
            for (var i = 0; i < _n; i++)
            {
                var row = new List<Spot>();
                int x = ((PanelWidth) - (_n * ButtonSize)) / 2;
                for (var j = 0; j < _m; j++)
                {
                    var spot = new Spot {I = i, J = j};
                    var btn = new Button
                              {
                                  Name      = @"{n}{m}",
                                  Size      = new Size(ButtonSize, ButtonSize),
                                  Location  = new Point(x, y),
                                  BackColor = Color.AntiqueWhite,
                                  TabStop = false,
                              };
                    btn.Click += (s, e) => OnCellClick(btn);
                    spot.Btn  =  btn;
                    row.Add(spot);
                    x += ButtonSize;
                }

                y += ButtonSize;
                BoardMatrix.Add(row);
            }

            SetNeighbors();
            PlaceShapes();
        } //end func

        public static void PlaceShapes()
        {
            for (var i = 0; i < 3; i++)
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
            var shape  = possibleShapes[random.Next(0, possibleShapes.Count())];
            var color  = possibleColors[random.Next(0, possibleColors.Count())];
            var path   = $"../../shapes/{shape}{color}.png";

            return path;
        } //end func

        public static List<int> SpecifyShapeLocation()
        {
            while (true)
            {
                var random = new Random();

                var locationRow   = random.Next(0, _n);
                var locationCol   = random.Next(0, _m);
                var alreadyExists = BoardMatrix[locationRow][locationCol].IsFilled;
                if (alreadyExists) continue;
                return new List<int>() {locationRow, locationCol};
            }
        } //end func

        public static void SetCellShape()
        {
            var coordinates = SpecifyShapeLocation();
            var n           = coordinates[0];
            var m           = coordinates[1];
            var fileName    = SpecifyShape();
            BoardMatrix[n][m].Btn.BackgroundImage       = Image.FromFile(@fileName);
            BoardMatrix[n][m].ShapeType                 = fileName;
            BoardMatrix[n][m].Btn.BackgroundImageLayout = ImageLayout.Stretch;
            BoardMatrix[n][m].IsFilled                  = true;
        } //end func
    }     //class end
}         //namespace end