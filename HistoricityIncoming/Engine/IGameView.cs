
namespace Engine
{
    public interface IGameView
    {
        void LoadContent();
        void UnloadContent();
        void Update(float deltaTime);
        void Draw();
    }
}
