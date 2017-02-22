using Microsoft.Xna.Framework;

namespace Engine
{
    public interface IGameObject
    {
        void LoadContent();
        void UnloadContent();
        void Update(long deltaMillis);
        void Draw(Vector2 offset);
    }
}
