using HistoricityIncoming.Messages;
﻿using HistoricityIncoming.Scene;

namespace HistoricityIncoming.Views
{
    public class LabSceneView : SceneView
    {
        public LabSceneView() : base("laboratory", new Hacker("Ang3l0R0X"), new Scientist("Bormann"))
        {
            textBox.AppendMessage(new Message("Bobsdfeswfefef", "Let's talk!", Side.Right));
        }
    }
}
