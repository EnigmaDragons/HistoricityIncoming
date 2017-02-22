using Engine;
using Microsoft.Xna.Framework.Media;

namespace Sound
{
    public class LoadedSong
    {
        private readonly string songName;
        private const string SongFolder = "Music/";

        public LoadedSong(string songName)
        {
            this.songName = songName;
        }

        public Song Get()
        {
            return new GameInstance().Load<Song>(SongFolder + songName);
        }
    }
}
