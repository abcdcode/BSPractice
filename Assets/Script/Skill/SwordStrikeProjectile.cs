using System.Threading;
using UnityEngine;

public class SwordStrikeProjectile : MonoBehaviour
{
    public void OTriggerEnter2D(Collider2D collision)
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
        if(time >= Timer)
        {
            Destroy(this.gameObject);
            return;
        }
    }
    public float time;
    public const float Timer = 1.5f;
}