using System.Linq;
using Engine;
using Graphics;
using HistoricityIncoming.Scene;
using HistoricityIncoming.Story;
using HistoricityIncoming.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HistoricityIncoming.Views
{
    public abstract class SceneView : IGameView
    {
        private readonly string _backdropName;
        protected readonly ChatBox textBox;
        private readonly Conversation _conversation;
        private readonly Character _leftCharacter;
        private readonly Character _rightCharacter;
        private Texture2D _backdrop;
        private bool _enterKeyPressed = false;
        
        protected SceneView(string backdropName, Conversation converstion, ChatBox chatBox)
        {
            textBox = chatBox;
            _conversation = converstion;
            _backdropName = backdropName;
            _leftCharacter = converstion.Characters[0];
            _rightCharacter = converstion.Characters[1];
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
            var ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.Enter) && !_enterKeyPressed)
            {
                if (textBox.IsPrinting())
                    textBox.FinishPrinting();
                else if (textBox.CanAdvance())
                    textBox.Advance();
                else
                    _conversation.Advance();
            }
            _conversation.Update(deltaMillis);
            _enterKeyPressed = ks.IsKeyDown(Keys.Enter);
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
