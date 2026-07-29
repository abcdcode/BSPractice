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
        TmpTimer += Time.deltaTime;
        if(TmpTimer > 1)
        {
            skeleton.BuildMonster(player.Position + new Vector3(10,10));
            TmpTimer = 0;
        }
        CurState.GameUpdate();
    }
    public float TmpTimer;
    public Player player;
    public EnemyData skeleton;
    public GameState CurState{get;private set;}
}