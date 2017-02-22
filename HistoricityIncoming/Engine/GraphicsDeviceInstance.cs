using Microsoft.Xna.Framework.Graphics;

namespace Engine
{
    public class GraphicsDeviceInstance
    {
        public GraphicsDevice Get()
        {
            return new GameInstance().Graphics;
        }
    }
}
