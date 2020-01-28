using UnityEngine;
using UnityEngine.SceneManagement;

public class menus : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
