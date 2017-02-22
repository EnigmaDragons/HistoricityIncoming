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
        private readonly Character _leftCharacter;
        private readonly Character _rightCharacter;
        private Texture2D _backdrop;
        
        protected SceneView(string backdropName, Character leftCharacter, Character rightCharacter)
        {
            _backdropName = backdropName;
            _leftCharacter = leftCharacter;
            _rightCharacter = rightCharacter;
        }

        public void LoadContent()
        {
            textBox.LoadContent();
            _backdrop = new BackdropTexture(_backdropName).Get();
            _leftCharacter.LoadContent();
            _rightCharacter.LoadContent();
        }

        public void UnloadContent()
        {
            textBox.UnloadContent();
            _backdrop?.Dispose();
            _leftCharacter?.UnloadContent();
            _rightCharacter?.UnloadContent();
        }

        public void Update(long deltaMillis)
        {
            textBox.Update(deltaMillis);
        }

        public void Draw()
        {
            new ViewBackgroundColor(Color.Black).Draw();
            new DrawOnScreen(_backdrop, new Vector2(0, 0)).Go();
            _leftCharacter.Draw(new Vector2(10, 265));
            _rightCharacter.Draw(new Vector2(740, 265));
            textBox.Draw(new Vector2(0, 450));
        }
    }
}
