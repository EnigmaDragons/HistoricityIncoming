
namespace Engine
{
    public interface IGameView
    {
        void LoadContent();
        void UnloadContent();
        void Update(long deltaMillis);
        void Draw();
    }
}
