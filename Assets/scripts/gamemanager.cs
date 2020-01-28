using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public float interval;
    bool gamehasended = false;

    public GameObject completeUI;
    public void gameover()
    {
        if(gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("GAme ovER");
            Invoke("Restart", interval);
        }        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void complete()
    {
        completeUI.SetActive(true);
    }

}
