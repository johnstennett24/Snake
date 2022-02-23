using System;
using Raylib_cs;

namespace Snake.Game.Casting
{
    public class KeyboardServices
    {
       
       private int CellSize = 15;

        public KeyboardServices()
        {
        }

        public void GetDirection(int CellSize)
        {
            int Xposition = 0;
            int Yposition = 0;

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                  Xposition += 1;
                }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    Xposition -= 1;
                }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    Yposition -= 1;
                }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    Yposition += 1;
                }
        }
    }
}
