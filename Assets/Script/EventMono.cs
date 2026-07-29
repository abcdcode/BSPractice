using System;
using UnityEngine;
[Serializable]
public abstract class EventMono : MonoBehaviour
{
    public virtual void OnMouseDown()
    {
        
    }
    public virtual void OnMouseEnter()
    {
        
    }
    public virtual void OnMouseExit()
    {
    }
    public virtual void GameUpdate()
    {
        
    }
    public string monoId;
    public Vector3 Position
    {
        get
        {
            return transform.position;
        }
        set
        {
            transform.position = value;
        }
    }
}