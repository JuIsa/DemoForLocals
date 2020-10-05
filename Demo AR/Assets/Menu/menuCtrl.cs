using UnityEngine;
using UnityEngine.SceneManagement;

public class menuCtrl : MonoBehaviour
{
    public void LoadOne()
    {
        SceneManager.LoadScene("house");
    }
    public void LoadTwo()
    {
        SceneManager.LoadScene("nesq");
    }
    public void LoadThree()
    {
        SceneManager.LoadScene("cola");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
