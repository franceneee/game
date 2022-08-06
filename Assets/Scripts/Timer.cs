using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] Text timer;
    float duration = 10f;
    float countdown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        countdown = duration;
        timer.gameObject.SetActive(true);
        Debug.Log("timer started");
        timer.text = "Timer: 10s";
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= 1 * Time.deltaTime;
        Debug.Log(countdown);
        timer.text = "Timer: " + countdown.ToString("0") + "s";
        if (countdown <= 0f)
        {
            countdown = duration;
            timer.gameObject.SetActive(false);
            SceneManager.LoadScene("GameOver");
        }
    }
}
