using UnityEngine;
using UnityEngine.SceneManagement;

public class menus : MonoBehaviour
{

    public AudioClip buttonclick;
    public AudioSource iaudio;

    public void ButtonClickSound()
    {
        iaudio.volume = 1f;
        iaudio.PlayOneShot(buttonclick);
    }
    
    //public void start()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayButtonClick()
    {
        ButtonClickSound();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitButtonClick()
    {
        ButtonClickSound();
        Application.Quit();
    }

    public void GotoCredit()
    {
        SceneManager.LoadScene("CreditScene");
    }


}
