using System.Collections.Generic;

public class PlayerStat
{
    public PlayerStat()
    {
        Hp = 100;
        MaxHp = 100;
        Speed = 5;
        skillList = new List<Skill>();
        Skill st = new SwordStrike();
        st.Init();
        skillList.Add(st);
    }
    public void GameUpdate()
    {
        foreach(var sk in skillList)
        {
            sk.GameUpdate();
        }
    }
    public float MaxHp;
    public float Hp;
    public float Speed;
    public List<Skill> skillList;
}