using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject overlay;
    [SerializeField] Text timer;
    float duration = 10f;
    float countdown = 0f;
    public Snake snake;

    // Start is called before the first frame update
    void Start()
    {
        overlay.SetActive(false);
        countdown = duration;
        timer.gameObject.SetActive(true);
        timer.text = "Timer: 10s";
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= 1 * Time.deltaTime;
        timer.text = "Timer: " + countdown.ToString("0") + "s";
        if (countdown <= 0f) {
            if (snake.numFishes == 0) {
                overlay.SetActive(true);
                timer.text = "Timer: 0s";
            } else {
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    public void ResetState()
    {
        countdown = duration;
        timer.text = "Timer: 10s";
    }
}
