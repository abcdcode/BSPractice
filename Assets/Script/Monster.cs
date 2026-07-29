using UnityEditor.Animations;
using UnityEngine;

public class Monster : EventMono
{
    public void Update()
    {
        
    }
    public void ChasePlayer()
    {
        var p = GameManager.Instance.player;
        this.Position = Vector2.MoveTowards(this.Position,p.Position,data.Speed*Time.deltaTime);
        if(p.Position.x > this.Position.x)
        {
            this.transform.localScale = new Vector3(1,1);
        } else
        {
            this.transform.localScale = new Vector3(-1,1);
        }
    }
    public void Attack()
    {
        animator.SetTrigger("Attack");
    }
    public void DoAttack(int v)
    {
        
    }
    public EnemyData data;
    public Animator animator;
}