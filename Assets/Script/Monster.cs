using UnityEditor.Animations;
using UnityEngine;

public class Monster : EventMono
{
    public void Update()
    {
        ChasePlayer();
    }
    public void ChasePlayer()
    {
        var p = GameManager.Instance.player;
        this.Position = Vector2.MoveTowards(this.Position,p.Position,data.Speed*Time.deltaTime);
        Move();
        if(p.Position.x > this.Position.x)
        {
            this.transform.localScale = new Vector3(1,1);
        } else
        {
            this.transform.localScale = new Vector3(-1,1);
        }
        if(Vector2.Distance(this.Position,p.Position) <= data.Range)
        {
            Attack();
        }
    }
    public void Move()
    {
        animator.SetTrigger("Move");
    }
    public void Attack()
    {
        animator.SetTrigger("Attack");
    }
    public EnemyData data;
    public Animator animator;
}