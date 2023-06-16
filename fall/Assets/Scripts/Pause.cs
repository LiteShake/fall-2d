using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject pauseMenuGUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pausemenu()
    {
        pauseMenuGUI.SetActive(true);

        Time.timeScale = 0.0f;
        Debug.Log("PAUSE MENU");
    }
}
