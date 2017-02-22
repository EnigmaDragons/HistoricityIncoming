using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Engine;
using Graphics;
using HistoricityIncoming.Messages;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HistoricityIncoming.UI
{
    public class ChatBox : IGameObject
    {
        private Texture2D textBox;
        private List<Message> messages = new List<Message>();
        private Message currentMessage;
        private int index;

        private string currentContent = "";
        private long totalMessageTime = 0;

        public void LoadContent()
        {
            textBox = new LoadedTexture("UI/textbox2").Get();
        }

        public void UnloadContent()
        {
            textBox.Dispose();
        }

        public void Update(long deltaMillis)
        {
            totalMessageTime += deltaMillis;
            //currentContent = currentMessage.Content.Substring(0, Math.Min(currentMessage.Content.Length - 1, totalMessageTime / 100));
        }

        public void Draw(Vector2 offset)
        {
            ShowBox();
            ShowName();
            ShowMessage();
        }

        public void AppendMessage(Message message)
        {
            messages.Add(message);
            //temp
            currentMessage = message;
        }

        private void ShowBox()
        {
            new SpritesBatchInstance().Draw(textBox, GetBoxPosition(),
                messages[index].Side == Side.Left ? SpriteEffects.None : SpriteEffects.FlipHorizontally);
        }

        private void ShowName()
        {
            new SpritesBatchInstance().DrawText(currentMessage.Name, GetNameLocation(), Color.White);
        }

        private void ShowMessage()
        {
            new SpritesBatchInstance().DrawWrappingText(currentContent, new Vector2(50, GetBoxPosition().Y + 50), Color.White, GetBoxPosition().Width - 100);
        }

        private Vector2 GetNameLocation()
        {
            var nameSizeAdjustment = currentMessage.Side == Side.Left ? -currentMessage.Name.Length*6 : +currentMessage.Name.Length*6;
            var offset = 200 + nameSizeAdjustment;
            return new Vector2(currentMessage.Side == Side.Left ? 0 + offset : GetBoxPosition().Width - offset, GetBoxPosition().Y + 20);
        }

        private Rectangle GetBoxPosition()
        {
            var graphicsDevice = new GraphicsDeviceInstance();
            var width = graphicsDevice.Get().Viewport.Width;
            var scale = (double) width/(double) textBox.Width;
            var height = (int)(textBox.Height * scale);
            var x = 0;
            var y = graphicsDevice.Get().Viewport.Height - height;
            return new Rectangle(x, y, width, height);
        }
    }
}
