using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Paused();
        }
    }

    public void Paused()
    {
        paused = !paused;
        pausePanel.SetActive(paused);

        if (paused)
        {

            Time.timeScale = 0;
        }

        else
        {

            Time.timeScale = 1;
        }


    }

}
