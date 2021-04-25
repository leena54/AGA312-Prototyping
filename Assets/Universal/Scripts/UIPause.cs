
using UnityEngine;
using UnityEngine.UI;


public class UIPause : MonoBehaviour
{
    bool paused = false;
    public GameObject pausePanel;


    void Start()
    {
        paused = false;
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        paused = !paused;
        pausePanel.SetActive(paused);
        Time.timeScale = paused ? 0 : 1;

        //if (paused)
        //{

        //    Time.timeScale = 0;
        //}

        //else
        //{

        //    Time.timeScale = 1;
        //}
    }

}
