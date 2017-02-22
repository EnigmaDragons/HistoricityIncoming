using Graphics;
using HistoricityIncoming.Scene;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HistoricityIncoming.Views
{
    public sealed class MainMenuView
    {
        private Texture2D _backdrop;

        public void LoadContent()
        {
            _backdrop = new BackdropTexture("cityscape").Get();
        }

        public void UnloadContent()
        {
            _backdrop?.Dispose();
        }

        public void Update(GameTime deltaTime)
        {
        }

        public void Draw()
        {
            new ViewBackgroundColor(Color.Black).Draw();
            new DrawOnScreen(_backdrop, new Vector2(0, 0)).Go();
        }
    }
}
