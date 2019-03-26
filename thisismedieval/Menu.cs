using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thisismedieval
{
    class Menu
    {
        private static int numButtonElemMenu = 5;
        public static int NumButtonElemMenu
        {
            get { return numButtonElemMenu; }
            set { numButtonElemMenu = value; }
        }
        public static void buttonElem(Texture2D rectangleBlock, SpriteBatch spriteBatch, int x, int y, int width, int height )
        {
            spriteBatch.Begin();
            Point position = new Point(x, y); // position 
            Point size = new Point(width, height); // size 
            Rectangle rectangle = new Rectangle(position, size);
            Color color = new Color(255, 255, 0);// color yellow 
            spriteBatch.Draw(rectangleBlock, rectangle, color);
            spriteBatch.End();
        }

    }
}
