using UnityEngine;

public class EnemyData : ScriptableObject
{
    public float Hp;
    public float Exp;
    public GameObject prefab;
    public Monster BuildMonster(Vector2 pos)
    {
        var result = Instantiate(prefab).GetComponent<Monster>();
        result.Position = pos;
        return result;
    }
}