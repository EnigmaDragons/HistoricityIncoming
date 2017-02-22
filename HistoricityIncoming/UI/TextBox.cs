using Engine;
using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HistoricityIncoming.UI
{
    public class TextBox : IGameObject
    {
        private Texture2D textBox;
        private SpriteEffects orientation;

        public void LoadContent()
        {
            textBox = new LoadedTexture("UI/textbox2").Get();
        }

        public void UnloadContent()
        {
            textBox.Dispose();
        }

        public void Update(GameTime deltaTime)
        {
        }

        public void Draw()
        {
            var graphicsDevice = new GraphicsDeviceInstance();
            var width = graphicsDevice.Get().Viewport.Width;
            var scale = (double)width / (double)textBox.Width;
            var height = (int)(textBox.Height * scale);
            var x = 0;
            var y = graphicsDevice.Get().Viewport.Height - height;
            new SpritesBatchInstance().Draw(textBox, new Rectangle(x, y, width, height));
        }

        public void Flip()
        {
            orientation = orientation == SpriteEffects.None ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
        }
    }
}
