using UnityEngine;

public class EnemyData : TData
{
    public float Hp;
    public float Exp;
    public float Speed;
    public float Range;
    public float Power;
    public GameObject prefab;
    public Monster BuildMonster(Vector2 pos)
    {
        var result = Instantiate(prefab).GetComponent<Monster>();
        result.data = this;
        result.Position = pos;
        return result;
    }
}