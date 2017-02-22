using Engine;
using Graphics;
using HistoricityIncoming.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HistoricityIncoming.Views
{
    public class ChatView : IGameView
    {
        private TextBox textBox = new TextBox();

        public void LoadContent()
        {
            textBox.LoadContent();
        }

        public void UnloadContent()
        {
            textBox.UnloadContent();
        }

        public void Update(long deltaMillis)
        {
            textBox.Update(deltaMillis);
        }

        public void Draw()
        {
            new ViewBackgroundColor(Color.AliceBlue).Draw();
            textBox.Draw(new Vector2(0, 0));
        }
    }
}
