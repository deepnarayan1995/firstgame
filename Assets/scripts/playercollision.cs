using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement pmv;
    
    void OnCollisionEnter(Collision Info)
    {
        if(Info.collider.tag == "obs")
        {
            pmv.enabled = false;
            FindObjectOfType<gamemanager>().gameover();
        }
    }
    
}
