using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    [SerializeField]
    GameObject pauseMenuGUI;

    Toggle graphicsToggle;
    Toggle AudioSlider;

    // Start is called before the first frame update
    public void Resume()
    {
        pauseMenuGUI.SetActive(false);

        Time.timeScale = 1;
    }
    
    public void MainMenu()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene("MainGame");
    }

}
