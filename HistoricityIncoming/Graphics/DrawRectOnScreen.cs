using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Graphics
{
    public class DrawRectOnScreen
    {
        private readonly Texture2D texture;
        private readonly Vector2 location;
        private readonly int width;
        private readonly int height;

        public DrawRectOnScreen(Texture2D texture, Vector2 screenLocation, int width, int height)
        {
            this.texture = texture;
            this.location = screenLocation;
            this.width = width;
            this.height = height;
        }

        public void Go()
        {
            new SpritesBatchInstance().Draw(texture, new Rectangle((int)location.X, (int)location.Y, width, height));
        }
    }
}
