using Graphics;

namespace HistoricityIncoming.Scene
{
    public class BackdropTexture : LoadedTexture
    {
        public BackdropTexture(string backdropName) 
            : base("Backdrop/" + backdropName) { }
    }
}
