using UnityEngine;

public class GameState
{
    public GameState()
    {
        PStat = new PlayerStat();
        GameTime = 0;
    }
    public void GameUpdate()
    {
        GameTime += Time.deltaTime;
    }
    public PlayerStat PStat{get;private set;} 
    public float GameTime;
}