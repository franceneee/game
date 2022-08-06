using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("CatGame");
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("Home");
    }
}