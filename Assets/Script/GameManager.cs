using UnityEngine;

public class GameManager : SingletonBehavior<GameManager>
{
    public void Start()
    {
        CurState = new GameState();
    }
    public void Awake()
    {
        skeleton.BuildMonster(new Vector2(10,10));
    }
    public void Update()
    {
        CurState.GameUpdate();
    }
    public Player player;
    public EnemyData skeleton;
    public GameState CurState{get;private set;}
}