﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Graphics
{
    public static class DefaultFont
    {
        public static SpriteFont Font { get; set; }

        public static void Load(ContentManager content)
        {
            Font = content.Load<SpriteFont>("Arial");
        }
    }
}
