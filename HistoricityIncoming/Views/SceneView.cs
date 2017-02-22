using Engine;
using Graphics;
using HistoricityIncoming.Scene;
using HistoricityIncoming.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HistoricityIncoming.Views
{
    public abstract class SceneView : IGameView
    {
        private readonly string _backdropName;
        private readonly TextBox textBox = new TextBox();
        private Texture2D _backdrop;

        protected SceneView(string backdropName)
        {
            _backdropName = backdropName;
        }

        public void LoadContent()
        {
            textBox.LoadContent();
            _backdrop = new BackdropTexture(_backdropName).Get();
        }

        public void UnloadContent()
        {
            textBox.UnloadContent();
            _backdrop?.Dispose();
        }

        public void Update(GameTime deltaTime)
        {
            textBox.Update(deltaTime);
        }

        public void Draw()
        {
            new ViewBackgroundColor(Color.Black).Draw();
            new DrawOnScreen(_backdrop, new Vector2(0, 0)).Go();
            textBox.Draw();
        }
    }
}
