using Microsoft.Xna.Framework;

namespace Engine
{
    public class ScreenSize
    {
        private readonly int _width;
        private readonly int _height;

        public ScreenSize(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void Apply(GraphicsDeviceManager device)
        {
            device.PreferredBackBufferWidth = _width;
            device.PreferredBackBufferHeight = _height;
        }
    }
}
