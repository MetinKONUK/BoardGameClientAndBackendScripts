using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace main
{
    public class Sound
    {
        public static string BaseURL = @"../../SoundEffects/";
        public static string WonTheGame = BaseURL + @"won-the-game.wav";
        public static string LostTheGame = BaseURL + @"lost-the-game.wav";
        public static string ShapeMoved = BaseURL + @"shape-moved.wav";
        public static string PointsEarned = BaseURL + @"points-earned.wav";

        public static void Play(string soundPath)
        {
            var player = new System.Media.SoundPlayer(soundPath);
            player.Play();
        }

    }
}
