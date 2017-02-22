using Engine;
using Microsoft.Xna.Framework.Audio;

namespace Sound
{
    public class LoadedSoundEffect
    {
        private readonly string soundEffectName;
        private const string SoundEffectFolder = "SoundEffect/";

        public LoadedSoundEffect(string soundEffectName)
        {
            this.soundEffectName = soundEffectName;
        }

        public SoundEffect Get()
        {
            return new GameInstance().Load<SoundEffect>(SoundEffectFolder + soundEffectName);
        }
    }
}
