using System;
using Raylib_cs;

namespace Snake.Game.Casting
{
    public class VideoService
    {
        private int CellSize = 15;
        public VideoService()
        {
        }
        
        public void CreateWindow()
        {

            const int ScreenWidth = 800;
            const int ScreenHeight = 450;

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "Snake");

            Raylib.SetTargetFPS(60);
        }
    }
}