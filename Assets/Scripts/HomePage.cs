using UnityEngine;

public class HomePage : MonoBehaviour
{
    public GameObject helpScreen;

    void Start() {
        helpScreen.SetActive(false);
    }

    public void OpenHelp()
    {
        helpScreen.gameObject.SetActive(true);
    }

    public void CloseHelp()
    {
        helpScreen.gameObject.SetActive(false);
    }
}
