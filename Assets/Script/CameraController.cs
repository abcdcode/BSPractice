using UnityEngine;

public class CameraController : MonoBehaviour
{
    public void LateUpdate()
    {
        this.transform.position = Player.transform.position + new Vector3(0,0,-10);
    }
    public GameObject Player;
}