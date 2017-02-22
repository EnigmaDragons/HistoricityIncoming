using System.Text;
using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Engine
{
    public class SpritesBatchInstance
    {
        private static SpriteBatch spritesInstance;

        public void SetSpritesBatch(SpriteBatch sprites)
        {
            spritesInstance = sprites;
        }

        public void Draw(Texture2D texture, Vector2 pixelPosition)
        {
            spritesInstance.Draw(texture, pixelPosition);
        }

        public void Draw(Texture2D texture, Rectangle rectPostion)
        {
            spritesInstance.Draw(texture, rectPostion, Color.White);
        }

        public void DrawText(string text, Vector2 pixelPosition, Color color)
        {
            spritesInstance.DrawString(DefaultFont.Font, text, pixelPosition, color);
        }

        public void DrawWrappingText(string text, Vector2 pixelPosition, Color color, float maxWidth)
        {
            DrawText(WrapText(DefaultFont.Font, text, maxWidth), pixelPosition, color);
        }

        public void Draw(Texture2D texture, Rectangle rectPosition, SpriteEffects effect)
        {
            spritesInstance.Draw(texture, rectPosition, null, Color.White, 0, Vector2.Zero, effect, 0);
        }

        private string WrapText(SpriteFont spriteFont, string text, float maxLineWidth)
        {
            var words = text.Split(' ');
            var sb = new StringBuilder();
            var lineWidth = 0f;
            var spaceWidth = spriteFont.MeasureString(" ").X;
            foreach (var word in words)
            {
                var size = spriteFont.MeasureString(word);
                if (lineWidth + size.X < maxLineWidth)
                {
                    sb.Append(word + " ");
                    lineWidth += size.X + spaceWidth;
                }
                else
                {
                    sb.Append("\n" + word + " ");
                    lineWidth = size.X + spaceWidth;
                }
            }
            return sb.ToString();
        }
    }
}
