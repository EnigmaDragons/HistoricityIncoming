using Engine;
using Graphics;
using HistoricityIncoming.Messages;
using Microsoft.Xna.Framework;

namespace HistoricityIncoming.Views
{
    public class LabSceneView : SceneView
    {
        public LabSceneView()
            : base("laboratory")
        {
            textBox.AppendMessage(new Message("Bobsdfeswfefef", "Let's talk!", Side.Right));
        }
    }
}
