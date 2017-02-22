using HistoricityIncoming.Story;
using HistoricityIncoming.UI;

namespace HistoricityIncoming.Views
{
    public class CityScapeSceneView : SceneView
    {
        public CityScapeSceneView() : this(new ChatBox()) {}

        public CityScapeSceneView(ChatBox chatBox) : base("cityscape", new BackstoryConversation(chatBox), chatBox)
        {
        }
    }
}
