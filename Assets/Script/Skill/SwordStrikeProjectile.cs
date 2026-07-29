using System.Threading;
using UnityEngine;

public class SwordStrikeProjectile : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        var e = collision.gameObject.GetComponent<Monster>();
        if(e != null)
        {
            e.TakeDamage(100*Time.deltaTime);
        }
    }
    public void Update()
    {
        time += Time.deltaTime;
        this.transform.position += dir.normalized * 10 * Time.deltaTime;
        if(time >= Timer)
        {
            Destroy(this.gameObject);
            return;
        }
    }
    public Vector3 dir;
    public float time;
    public const float Timer = 1.5f;
}