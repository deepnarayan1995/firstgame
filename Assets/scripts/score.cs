using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;

    // Update is called once per frame
    void Update()
    {
        float p = (player.position.z) / 10;
        scoretext.text = p.ToString("0");
    }
}
