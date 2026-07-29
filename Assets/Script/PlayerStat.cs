using System.Collections.Generic;

public class PlayerStat
{
    public PlayerStat()
    {
        Hp = 100;
        MaxHp = 100;
        Speed = 5;
        skillList = new List<Skill>();
    }
    public float MaxHp;
    public float Hp;
    public float Speed;
    public List<Skill> skillList;
}