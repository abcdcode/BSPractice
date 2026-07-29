public class GameManager : SingletonBehavior<GameManager>
{
    public void Start()
    {
        CurState = new GameState();
    }
    public GameState CurState{get;private set;}
}