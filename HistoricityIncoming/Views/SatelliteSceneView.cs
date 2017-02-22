using HistoricityIncoming.Scene;

namespace HistoricityIncoming.Views
{
    public sealed class SatelliteSceneView : SceneView
    {
        public SatelliteSceneView() 
            : base("satellite", new Hacker("Joe"), new Scientist("Bormann")) { }
    }
}
