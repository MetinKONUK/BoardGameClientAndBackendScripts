using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace main
{
    public class MultiplayerBoard
    {
        public static string local = "ws://127.0.0.1:5000";
        public static string glitch = "ws://oop-websocket-server.glitch.me";
        readonly static WebSocket ws = new WebSocket(glitch);

        public static List<List<MultiplayerSpot>> board = new List<List<MultiplayerSpot>>();
        public static bool gameStarted = false;
        public static MultiplayerSpot home = null;
        public static MultiplayerSpot target = null;
        public static List<int> Scores = new List<int>();
        public static string OpponentUsername = "";
        public static Button CurrentUserScoreBox = MultiplayerGameForm.GameFormInstance.CurrentUserScoreBox;
        public static Button OpponentUserScoreBox = MultiplayerGameForm.GameFormInstance.OpponentScoreBox;
        public static Button InfoBox = MultiplayerGameForm.GameFormInstance.InfoBox;

        public static void LoseFocus()
        {
            MultiplayerGameForm.GameFormInstance.Focus();
        }//end-func
        public static void Connect()
        {
            ws.Connect();
            ws.OnMessage += Ws_OnMessage;
            DataToServer dts = new DataToServer();
            dts.Type = "username";
            dts.CurrentUsername = UserBase.CurrentUser;
            ws.Send(DataConvertion.Serialize(dts));
        }
        public static void Disconnect()
        {
            ws.Close();
        }//end-func

        public static void SetOpponent(string OpponentUsername)
        {
            if(OpponentUsername == UserBase.CurrentUser)
            {
                System.Windows.Forms.MessageBox.Show("You cannot match with yourself obviously...");
                return;

            }
            DataToServer dts = new DataToServer();
            dts.Type = "opponent_username";
            dts.OpponentUsername = OpponentUsername;
            ws.Send(DataConvertion.Serialize(dts));
        }//end-func

        private static void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            DataFromServer data = DataConvertion.Deserialize(e.Data);

            if (data.Type == "error-message")
            {
                if (data.ErrorMessage == "this-is-not-your-turn")
                {
                    home = null;
                    target = null;
                    InfoBox.Text = "Wait your turn!!";
                    //System.Windows.Forms.MessageBox.Show("Wait your turn!!");
                    LoseFocus();
                }
            }
            if(data.Type == "opponent-does-not-exist-error")
            {
                System.Windows.Forms.MessageBox.Show("Opponent does not exist!");
            }
            if(data.Type == "opponent-username-data")
            {
                OpponentUsername = data.OpponentUsername;
            }
            if(data.Type == "update-scores-request")
            {
                Scores = data.Scores;
                var currentUserScoreState = $"{UserBase.CurrentUser}: {Scores[0]}";
                var opponentUserScoreState = $"{OpponentUsername}: {Scores[1]}";
                CurrentUserScoreBox.Text = currentUserScoreState;
                OpponentUserScoreBox.Text = opponentUserScoreState;
            }
            if(data.Type == "opponent-disconnected")
            {
                System.Windows.Forms.MessageBox.Show("Opponent disconnected!");
                ClearBoard();
                ClearPanel(MultiplayerGameForm.GameFormInstance.GameFormLowerPanel);
                MultiplayerGameForm.GameFormInstance.Close();

            }
            if (data.Type == "game-started-feedback")
            {
                gameStarted = true;
                MultiplayerBoard.ShowBoard();
                Console.WriteLine("Game started!!");
            }
            if (data.Type == "new-shape-coordinates")
            {
                Console.WriteLine("NEW SHAPE COORDINATES ARRIVED!!");
                List<List<int>> coordinates = data.NewShapeCoordinates;
                List<int> shapeTypes = data.NewShapeTypes;
                PlaceShapes(coordinates, shapeTypes);
            }
            if (data.Type == "home-spot-set-request-feedback")
            {
                Console.Write("HOME DECISION ARRIVED!!");
                bool decision = data.HomeSpotSetRequestFeedback;
                if (decision == false)
                {
                    InfoBox.Text = "CANNOT SELECT EMPTY SPOT FOR HOME!!";
                    //System.Windows.Forms.MessageBox.Show(@"CANNOT SELECT EMPTY SPOT FOR HOME!!");
                    LoseFocus();
                    home = null;
                    target = null;
                }
            }
            if (data.Type == "target-spot-set-request-feedback")
            {
                Console.Write("TARGET DECISION ARRIVED!!");
                bool decision = data.TargetSpotSetRequestFeedback;
                if (decision == false)
                {
                    InfoBox.Text = "TARGET IS NOT VALID!!";
                    //System.Windows.Forms.MessageBox.Show(@"TARGET IS NOT VALID!!");
                    LoseFocus();
                    home = null;
                    target = null;
                }
            }
            if (data.Type == "shape-move-info")
            {
                List<List<int>> path = data.Path;

                InfoBox.Text = "";
                ShapeWalksOnThePath(path);
                if (UserBase.CurrentUser == data.Turn)
                {
                    DataToServer dts = new DataToServer();
                    dts.Type = "place_new_shapes_request";
                    dts.CurrentUsername = UserBase.CurrentUser;
                    ws.Send(DataConvertion.Serialize(dts));
                }
            }
            if (data.Type == "clear-spots-request")
            {
                List<int> csd = data.ClearSpotsData;
                ClearSpotsAfterSuccess(csd[0], csd[1], csd[2]);
            }
            if (data.Type == "game-end-info")
            {
                System.Windows.Forms.MessageBox.Show(data.GameEndInfo);
                ClearBoard();
                ClearPanel(MultiplayerGameForm.GameFormInstance.GameFormLowerPanel);

            }

        }//end-func

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

        public static void ClearSpotsAfterSuccess(int n, int m, int type)
        {
            if (type == 0)
            {
                for (var i = m; i < m + 5; i++)
                {
                    board[n][i].IsFilled = false;
                    board[n][i].Btn.BackgroundImage = null;
                    board[n][i].ShapeType = -1;
                }
            }
            else
            {
                for (var i = n; i < n + 5; i++)
                {
                    board[i][m].IsFilled = false;
                    board[i][m].Btn.BackgroundImage = null;
                    board[i][m].ShapeType = -1;
                }
            }
        }//end-func

        public static void ShapeWalksOnThePath(List<List<int>> path)
        {
            for(var i = 1; i < path.Count; ++i)
            {
                SwapSpots(board[path[i-1][0]][path[i-1][1]], board[path[i][0]][path[i][1]]);
                Sleep(500);
            }
            LoseFocus();
            home = null;
            target = null;
        }

        public static void SwapSpots(MultiplayerSpot a, MultiplayerSpot b)
        {
            b.Btn.BackgroundImage = a.Btn.BackgroundImage;
            b.Btn.BackgroundImageLayout = ImageLayout.Stretch;
            a.Btn.BackgroundImage = null;
        }

        public static MultiplayerSpot SetSelectedSpot(Button btn)
        {
            foreach (var row in board)
            {
                for (var i = 0; i < row.Count; ++i)
                {
                    if (row[i].Btn == btn)
                    {
                        if (home == null) home = row[i];
                        else target = row[i];
                        return row[i];
                    }
                }
            }
            return null;
        }//end-func

        public static void OnCellClick(Button btn)
        {
            Console.WriteLine("Clicked to button!!\n");
            var selectedSpot = SetSelectedSpot(btn);
            var i = selectedSpot.I;
            var j = selectedSpot.J;
            if (home != null && target == null) // TRY TO SET HOME SPOT
            {
                Console.WriteLine("home != null & target == null\n");
                DataToServer dts = new DataToServer();
                dts.Type = "home_spot_coords";
                dts.HomeSpotCoords = new List<int>() { i, j };
                dts.CurrentUsername = UserBase.CurrentUser;
                ws.Send(DataConvertion.Serialize(dts));
            }

            if (home != null && target != null) // TRY TO SET TARGET SPOT
            {
                Console.WriteLine("home != null & target != null");
                DataToServer dts = new DataToServer();
                dts.Type = "target_spot_coords";
                dts.TargetSpotCoords = new List<int> { i, j };
                dts.CurrentUsername = UserBase.CurrentUser;
                ws.Send(DataConvertion.Serialize(dts));
            }

        }//end-func

        public static void SetCellShape(int n, int m, int type)
        {
            var fileName = $"../../shapes/{type}.png";
            board[n][m].Btn.BackgroundImage = Image.FromFile(@fileName);
            board[n][m].Btn.BackgroundImageLayout = ImageLayout.Stretch;
            board[n][m].IsFilled = true;
        }//end-func

        public static void PlaceShapes(List<List<int>> coordinates, List<int> types)
        {
            for (var i = 0; i < 3; ++i)
            {
                SetCellShape(coordinates[i][0], coordinates[i][1], types[i]);
            }
        }//end-func

        public static void SetBoard()
        {
            ClearPanel(MultiplayerGameForm.GameFormInstance.GameFormLowerPanel);
            ClearBoard();
            var panel = MultiplayerGameForm.GameFormInstance.GameFormLowerPanel;
            var PanelWidth = panel.Width;
            var PanelHeight = panel.Height;
            var ButtonSize = 35;
            int y = ((PanelHeight) - (9 * ButtonSize)) / 2;
            for (var i = 0; i < 9; ++i)
            {
                var row = new List<MultiplayerSpot>();
                int x = ((PanelWidth) - (9 * ButtonSize)) / 2;
                for (var j = 0; j < 9; ++j)
                {
                    var spot = new MultiplayerSpot();
                    var btn = new Button
                    {
                        Size = new Size(ButtonSize, ButtonSize),
                        Location = new Point(x, y),
                        BackColor = Color.AliceBlue,
                    };
                    btn.Click += (s, e) => OnCellClick(btn);
                    spot.Btn = btn;
                    spot.I = i;
                    spot.J = j;
                    row.Add(spot);
                    x += ButtonSize;
                }
                y += ButtonSize;
                board.Add(row);
            }
        }//end-func
        public static Task AddButton(Button btn)
        {
            var panel = MultiplayerGameForm.GameFormInstance.GameFormLowerPanel;
            return Task.Run(() =>
            {
                if (panel.InvokeRequired)
                {
                    panel.Invoke((MethodInvoker)delegate ()
                    {
                        panel.Controls.Add(btn);
                    });
                }
            });
        }//end-func
        public static void SetScoreBoxes()
        {
            CurrentUserScoreBox.Text = $"{UserBase.CurrentUser}: 0";
            OpponentUserScoreBox.Text = $"{OpponentUsername}: 0";
        }//end-func
        public static void ShowBoard()
        {
            SetScoreBoxes();
            SetBoard();
            
            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    AddButton(board[i][j].Btn);
                }
            }
        }//end-func
        public static void ClearPanel(Panel panel)
        {
            //panel.Controls.Clear();
        }
        public static void ClearBoard()
        {
            board.Clear();
        }//end-func
    }//end-class
}//end-namespace
