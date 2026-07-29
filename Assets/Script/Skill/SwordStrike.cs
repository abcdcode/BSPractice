using System;
using UnityEngine;

[Serializable]
public class SwordStrike : Skill
{
    public override void Init()
    {
        data = TDataDB.Instance.GetSkillData("SwordStrike");
    }
    public override void GameUpdate()
    {
        base.GameUpdate();
        cool -= Time.deltaTime;
        if(cool <= 0)
        {
            var p = GameManager.Instance.player;
            var b = UnityEngine.Object.Instantiate(data.prefab).GetComponent<SwordStrikeProjectile>();
            var e = EnemyManager.Instance.GetNearestEnemy(p.Position);
            if(e == null)
            {
                cool = data.Cool;
                return;
            }
            b.dir = e.Position - p.Position;
            b.transform.right = b.dir;
            b.transform.position = p.Position;
            cool = data.Cool;
        }
    }
    public float cool;
}