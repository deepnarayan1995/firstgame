using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BreakButton : MonoBehaviour
{
    float holdtime;
    public playermovement player;

    public void OnPointerDown()
    {
        StartCoroutine("StartBreaking");
    }

    public void OnPointerUp()
    {
        StopCoroutine("StartBreaking");
    }


    IEnumerator StartBreaking()
    {
        for(holdtime = 0f; holdtime <= 100f; holdtime += Time.deltaTime)
        {
            player.MoveBack();
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }

}
