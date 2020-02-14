using UnityEngine;

public class followcamera : MonoBehaviour
{
    public Transform player;
    public Vector3 Tppoffset;
    public Vector3 FppOffset;


    void Update()
    {
        transform.position = player.position + Tppoffset;
    }
}
