using Engine;
using Graphics;
using HistoricityIncoming.Scene;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HistoricityIncoming.UI
{
    public class ChatBox : IGameObject
    {
        private const int MillisToCharacter = 50;

        private Texture2D _textBox;
        private DisplayMessage _currentDisplayMessage;
        private string _currentContent = "";
        private long _totalMessageTime = 0;

        public void LoadContent()
        {
            _textBox = new LoadedTexture("UI/textbox2").Get();
            _currentDisplayMessage = new DisplayMessage("", "Start", Side.Left, 100000);
        }

        public void UnloadContent()
        {
            _textBox.Dispose();
        }

        public void Update(long deltaMillis)
        {
            _totalMessageTime += deltaMillis;
            var length = (int)((double)_totalMessageTime/(double)MillisToCharacter);
            length = _currentDisplayMessage.GetCurrentContent().Length < length ? _currentDisplayMessage.GetCurrentContent().Length : length;
            _currentContent = _currentDisplayMessage.GetCurrentContent().Substring(0, length);
        }

        public void Draw(Vector2 offset)
        {
            ShowBox();
            ShowName();
            ShowMessage();
        }

        public void Show(ScriptLine message, Side side)
        {
            _totalMessageTime = 0;
            _currentDisplayMessage = new DisplayMessage(message.CharacterName, message.Text, side, GetBoxPosition().Width - 100);
        }

        public bool CanAdvance()
        {
            return _currentDisplayMessage.CanAdvance();
        }

        public void Advance()
        {
            _totalMessageTime = 0;
            _currentDisplayMessage.Advance();
        }

        private void ShowBox()
        {
            new SpritesBatchInstance().Draw(_textBox, GetBoxPosition(),
                _currentDisplayMessage.Side == Side.Left ? SpriteEffects.None : SpriteEffects.FlipHorizontally);
        }

        private void ShowName()
        {
            new SpritesBatchInstance().DrawText(_currentDisplayMessage.Name, GetNameLocation(), Color.White);
        }

        private void ShowMessage()
        {
            new SpritesBatchInstance().DrawText(_currentContent, new Vector2(50, GetBoxPosition().Y + 50), Color.White);
        }

        private Vector2 GetNameLocation()
        {
            var nameSizeAdjustment = _currentDisplayMessage.Side == Side.Left ? -_currentDisplayMessage.Name.Length*6 : +_currentDisplayMessage.Name.Length*6;
            var offset = 200 + nameSizeAdjustment;
            return new Vector2(_currentDisplayMessage.Side == Side.Left ? 0 + offset : GetBoxPosition().Width - offset, GetBoxPosition().Y + 20);
        }

        private Rectangle GetBoxPosition()
        {
            var graphicsDevice = new GraphicsDeviceInstance();
            var width = graphicsDevice.Get().Viewport.Width;
            var scale = (double) width/(double) _textBox.Width;
            var height = (int)(_textBox.Height * scale);
            var x = 0;
            var y = graphicsDevice.Get().Viewport.Height - height;
            return new Rectangle(x, y, width, height);
        }
    }
}
