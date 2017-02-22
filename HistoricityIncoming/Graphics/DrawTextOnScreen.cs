﻿using Engine;
using Microsoft.Xna.Framework;

namespace Graphics
{
    public class DrawTextOnScreen
    {
        private readonly string text;
        private readonly Vector2 location;
        private readonly Color color = Color.Black;

        public DrawTextOnScreen(string text, Vector2 screenLocation)
        {
            this.text = text;
            this.location = screenLocation;
        }

        public void Go()
        {
            new SpritesBatchInstance().DrawText(text, location, color);
        }
    }
}
