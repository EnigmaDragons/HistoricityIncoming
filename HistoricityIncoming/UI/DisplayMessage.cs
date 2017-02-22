using System.Collections.Generic;
using System.Text;
using Graphics;
using HistoricityIncoming.Scene;
using Microsoft.Xna.Framework.Graphics;

namespace HistoricityIncoming.UI
{
    public class DisplayMessage
    {
        public string Name { get; }
        public Side Side { get; }
        private List<string> _content;
        public int _index = 0;

        public DisplayMessage(string name, string content, Side side, int maxWidth)
        {
            Name = name;
            Side = side;
            initContent(content, maxWidth);
        }

        public string GetCurrentContent()
        {
            return _content[_index];
        }

        public bool CanAdvance()
        {
            return _index != _content.Count - 1;
        }

        public void Advance()
        {
            _index++;
        }

        private void initContent(string content, int maxWidth)
        {
            _content = new List<string>();
            var wrappedContent = WrapText(DefaultFont.Font, content, maxWidth);
            var str = "";
            for (var i = 0; i < wrappedContent.Split('\n').Length; i++)
            {
                if (i % 2 == 0 && str != "")
                {
                    _content.Add(str);
                    str = "";
                }
                str += wrappedContent.Split('\n')[i] + '\n';
            }
            if (str != "")
                _content.Add(str);
        }

        private string WrapText(SpriteFont spriteFont, string text, float maxLineWidth)
        {
            var words = text.Split(' ');
            var sb = new StringBuilder();
            var lineWidth = 0f;
            var spaceWidth = spriteFont.MeasureString(" ").X;
            foreach (var word in words)
            {
                var size = spriteFont.MeasureString(word);
                if (lineWidth + size.X < maxLineWidth)
                {
                    sb.Append(word + " ");
                    lineWidth += size.X + spaceWidth;
                }
                else
                {
                    sb.Append("\n" + word + " ");
                    lineWidth = size.X + spaceWidth;
                }
            }
            return sb.ToString();
        }
    }
}
