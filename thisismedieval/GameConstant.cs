using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thisismedieval
{
    class GameConstant
    {
        private int screenWidth;            //Ширина игрового окна
        private int screenHeight;           //Высота игрового окна

        public int ScreenWidth
        {
            get { return screenWidth; }
            set { screenWidth = value; }
        }
        public int ScreenHeight
        {
            get { return screenHeight; }
            set { screenHeight = value; }
        }

        public GameConstant(int screenWidth, int screenHeight)
        {
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
        }

    }
}
