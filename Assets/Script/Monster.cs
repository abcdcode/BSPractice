using UnityEditor.Animations;
using UnityEngine;

public class Monster : EventMono
{
    public void Init(EnemyData d)
    {
        data = d;
        Hp = data.Hp;
    }
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
    /*
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter");
        var p = collision.gameObject.GetComponent<Player>();
        if(p != null)
        {
            p.TakeDamage(data.Power*Time.deltaTime);
        }
    }
    */
    public void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Stay");
        var p = collision.gameObject.GetComponent<Player>();
        if(p != null)
        {
            Debug.Log("Stay DMG");
            p.TakeDamage(data.Power*Time.deltaTime);
        }
    }
    public void Move()
    {
        animator.SetFloat("Move",1);
    }
    public void Attack()
    {
        animator.SetTrigger("Attack");
    }
    public float Hp;
    public EnemyData data;
    public Animator animator;
}