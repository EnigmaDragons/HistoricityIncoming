
namespace Engine
{
    public interface IGameView
    {
        void SetNavigaton(INavigation navigation);
        void LoadContent();
        void UnloadContent();
        void Update(long deltaMillis);
        void Draw();
    }
}
