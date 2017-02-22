using Graphics;

namespace HistoricityIncoming.Scene
{
    public class CharacterTexture : LoadedTexture
    {
        public CharacterTexture(string characterName) 
            : base("Characters/" + characterName) { }
    }
}
