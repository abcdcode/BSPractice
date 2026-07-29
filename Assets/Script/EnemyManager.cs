using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine;

public class EnemyManager : SingletonContainerBehavior<EnemyManager,Enemy>
{
    public Enemy GetNearestEnemy(Vector3 pos)
    {
        return CalcUtil.FindObjective(this.itemList,(a,b) =>Vector3.Distance(a.transform.position,pos) > Vector3.Distance(b.transform.position,pos) ? b : a);
    }
}