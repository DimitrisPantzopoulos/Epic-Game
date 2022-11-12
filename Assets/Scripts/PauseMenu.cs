using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject pauseMenuUI;

        
        

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
    {
        if (!GameIsPaused)
        {
            GameIsPaused = !GameIsPaused;
            Time.timeScale = 0f;
            pauseMenuUI.SetActive(true);
        }
        else
        {
            GameIsPaused = !GameIsPaused;
            Time.timeScale = 1f;
            pauseMenuUI.SetActive(false);
        }
    }
    }
    
    public void Resume(){
        GameIsPaused = !GameIsPaused;
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        
        
    } 

    public void Pause(){
        GameIsPaused = !GameIsPaused;
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
    }

    public void MainMenuButton(){
    Time.timeScale = 1f;
    SceneManager.LoadScene("Mainmenu");

    }

    public void SettingsButton(){

    }
}
