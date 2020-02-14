using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody RB;

    public float forward;
    public float sideforces;
    public float breakForce;

    //public Joystick joystick;

    private Transform camtransform;

    public VirtualJoystick moveJoystick;

    public void Start()
    {
        camtransform = Camera.main.transform;
    }    

    void FixedUpdate()
    {
        RB.AddForce(0, 0, forward * Time.deltaTime);

        Vector3 newDir = camtransform.TransformDirection(moveJoystick.InputDirection);
        float x = newDir.x;

        //float x = Input.GetAxisRaw("Horizontal");
        //float x = joystick.Horizontal;

        if (x > 0)
        {
            MoveRight();
        }
        else if (x < 0)
        {
            MoveLeft();
        }


        if (Input.GetKey("d"))
        {
            MoveRight();

        }
        if (Input.GetKey("a"))
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            MoveBack();
        }
    }

    public void MoveRight()
    {
        RB.AddForce(sideforces * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    public void MoveLeft()
    {
        RB.AddForce(-sideforces * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    public void MoveBack()
    {
        RB.AddForce(0, 0, breakForce * Time.deltaTime, ForceMode.VelocityChange);
    }

    public void Break()
    {
        Debug.Log("Break Works");
    }

}
