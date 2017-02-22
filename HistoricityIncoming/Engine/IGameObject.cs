using Microsoft.Xna.Framework;

namespace Engine
{
    public interface IGameObject
    {
        void LoadContent();
        void UnloadContent();
        void Update(GameTime deltaTime);
        void Draw();
    }
}
