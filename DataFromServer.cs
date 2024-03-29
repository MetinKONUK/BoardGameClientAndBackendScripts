﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class DataFromServer
    {
        public string Type { get; set; }

        public List<List<int>> NewShapeCoordinates = new List<List<int>>();
        public List<int> NewShapeTypes = new List<int>();
        public bool GameStartedFeedback = false;
        public bool HomeSpotSetRequestFeedback = false;
        public bool TargetSpotSetRequestFeedback = false;
        public List<List<int>> Path = null;
        public string Turn = null;
        public string ErrorMessage = null;
        public List<int> ClearSpotsData = null;
        public string GameEndInfo = null;
        public List<int> Scores = null;
        public string OpponentUsername = null;
    }
}
