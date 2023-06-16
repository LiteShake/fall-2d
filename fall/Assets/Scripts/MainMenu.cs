using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField]
    private GameObject CreditsUI;

    [SerializeField]
    private GameObject OptionsUI;

    [SerializeField]
    private GameObject MainUI;

    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Quit()
    {
        Debug.Log("QUIT FIRED !");

        Application.Quit();
    }

    public void CreditsBack()
    {
        CreditsUI.SetActive(false);
        MainUI.SetActive(true);
    }
    
    public void OptionsBack()
    {
        OptionsUI.SetActive(false);
        MainUI.SetActive(true); 
    }

    public void Credits()
    {
        CreditsUI.SetActive(true);
        MainUI.SetActive(false);
    }

    public void Options()
    {
        OptionsUI.SetActive(true);
        MainUI.SetActive(false);
    }
}
