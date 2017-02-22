using Microsoft.Xna.Framework.Graphics;

namespace Engine
{
    public interface IGame
    {
        T Load<T>(string resourceName);
        GraphicsDevice Graphics { get; }
    }
}
