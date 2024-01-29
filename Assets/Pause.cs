using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Pause : MonoBehaviour
{
    private bool paused;
    public GameObject pauseMenu;

    void Awake(){
        paused = false;
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape) && paused == false){
            Time.timeScale = 0f;
            paused = true;
            pauseMenu.SetActive(true);
        } else if(Input.GetKeyDown(KeyCode.Escape) && paused == true){
            Time.timeScale = 1f;
            paused = false;
            pauseMenu.SetActive(false);
        }
    }
    
    // Start is called before the first frame update
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    public void Resume()
    {
        paused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
