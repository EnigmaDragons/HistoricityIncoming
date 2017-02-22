using Engine;
using Graphics;
using HistoricityIncoming.Scene;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HistoricityIncoming.Views
{
    public abstract class SceneView : IGameView
    {
        private readonly string _backdropName;

        private Texture2D _backdrop;
        private Character _leftCharacter;
        private Character _rightCharacter;
        
        protected SceneView(string backdropName, Character leftCharacter, Character rightCharacter)
        {
            _backdropName = backdropName;
            _leftCharacter = leftCharacter;
            _rightCharacter = rightCharacter;
        }

        public void LoadContent()
        {
            _backdrop = new BackdropTexture(_backdropName).Get();
            _leftCharacter.LoadContent();
            _rightCharacter.LoadContent();
        }

        public void UnloadContent()
        {
            _backdrop?.Dispose();
            _leftCharacter?.UnloadContent();
            _rightCharacter?.UnloadContent();
        }

        public void Update(float deltaTime)
        {
        }

        public void Draw()
        {
            new ViewBackgroundColor(Color.Black).Draw();
            new DrawOnScreen(_backdrop, new Vector2(0, 0)).Go();
            _leftCharacter.Draw(new Vector2(10, 250));
            _rightCharacter.Draw(new Vector2(740, 250));
        }
    }
}
