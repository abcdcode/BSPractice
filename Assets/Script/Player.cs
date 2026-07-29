using UnityEngine;

public class Player : EventMono
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var movePos = new Vector2();
        if(Input.GetKey(KeyCode.A))
        {
            movePos += new Vector2(-1,0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            movePos += new Vector2(1,0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            movePos += new Vector2(0,-1);
        }
        if(Input.GetKey(KeyCode.W))
        {
            movePos += new Vector2(0,1);
        }
        if(movePos.x != 0 || movePos.y != 0)
        {
            animator.SetFloat("Move",1);
        }
        else
        {
            animator.SetFloat("Move",0);
        }
        if(movePos.x != 0)
        {
            this.transform.localScale = new Vector3(movePos.x == -1 ? -1 : 1,1);
        }
        this.transform.Translate(movePos.normalized * Speed * Time.deltaTime);
    }
    public void TakeDamage(float value)
    {
        Debug.Log($"Stay DMG Value : {value}");
        GameManager.Instance.CurState.PStat.Hp -= value;
    }
    public float Speed => GameManager.Instance.CurState.PStat.Speed;
    public Animator animator;
    public const float DefaultSpeed = 5;
}
