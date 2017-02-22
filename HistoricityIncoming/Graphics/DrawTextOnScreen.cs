using Engine;
using Microsoft.Xna.Framework;

namespace Graphics
{
    public class DrawTextOnScreen
    {
        private readonly string text;
        private readonly Vector2 location;
        private readonly Color color;

        public DrawTextOnScreen(string text, Vector2 screenLocation)
            : this(text, screenLocation, Color.Black) { }

        public DrawTextOnScreen(string text, Vector2 screenLocation, Color color)
        {
            this.text = text;
            this.location = screenLocation;
            this.color = color;
        }

        public void Go()
        {
            new SpritesBatchInstance().DrawText(text, location, color);
        }
    }
}
