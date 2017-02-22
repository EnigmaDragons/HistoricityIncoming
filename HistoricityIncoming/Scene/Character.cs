using Engine;
using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HistoricityIncoming.Scene
{
    public class Character : IGameObject
    {
        private readonly string _textureName;

        private Texture2D _border;
        private Texture2D _portrait;
        private Texture2D _listeningOverlay;

        public string Name { get; }

        private bool _iAmTalking = false;

        protected Character(string characterName, string textureName)
        {
            Name = characterName;
            _textureName = textureName;
        }

        public void LoadContent()
        {
            _border = new RectangleTexture(154, 201, Color.Black).Create();
            _portrait = new CharacterTexture(_textureName).Get();
            _listeningOverlay = new RectangleTexture(150, 197, Color.FromNonPremultiplied(0, 0, 0, 120)).Create();
        }

        public void UnloadContent()
        {
            _border?.Dispose();
            _portrait?.Dispose();
            _listeningOverlay?.Dispose();
        }

        public void Update(long deltaMillis)
        {
        }

        public void Draw(Vector2 offset)
        {
            new DrawRectOnScreen(_border, offset - new Vector2(2, 2), 154, 201).Go();
            new DrawRectOnScreen(_portrait, offset, 150, 197).Go();
            if (!_iAmTalking)
                new DrawRectOnScreen(_listeningOverlay, offset, 150, 197).Go();
        }

        public void CharacterIsTalking(string characterName)
        {
            _iAmTalking = characterName.Equals(Name);
        }
    }
}
