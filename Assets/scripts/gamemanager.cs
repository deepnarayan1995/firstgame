using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public float interval;
    bool gamehasended = false;

    public GameObject completeUI, gameover;
    public void GameOverOutofEnergy()
    {
        if(gamehasended == false)
        {
            gameover.SetActive(true);
            gamehasended = true;
            Debug.Log("GAme ovER");
            //Invoke("Restart", interval);
        }        
    }

    public void GameOverOutofHealth()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("GAme ovER");
            Invoke("Restart", interval);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void complete()
    {
        completeUI.SetActive(true);
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menus");
    }

    

}
