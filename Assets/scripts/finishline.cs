using UnityEngine;

public class finishline : MonoBehaviour
{
    public gamemanager gm;

    void OnTriggerEnter()
    {
        gm.complete();
    }
}
