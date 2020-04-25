using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuUI : MonoBehaviour
{
    public bool isGamePaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if(!isGamePaused)
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        isGamePaused = true;
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
    }
    public void Resume()
    {
        isGamePaused = false;
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }


}
