using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody RB;

    public float forward;
    public float sideforces;
    void FixedUpdate()
    {
        RB.AddForce(0, 0, forward * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            RB.AddForce(sideforces * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            RB.AddForce(-sideforces * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
