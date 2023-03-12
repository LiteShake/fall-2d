using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayerOnContact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch( other.tag )
        {
            case "Enemy":

                SceneManager.LoadScene("MainGame");
                break;

            case "Singularity":

                StartCoroutine( SlowMotion( 30.0f ) );
                break;
                
            default: break; 
        }
    }

    IEnumerator SlowMotion( float slowTime )
    {
        Time.timeScale = 0.4f;
        yield return new WaitForSeconds( slowTime );
        Time.timeScale = 1.0f;
    }
}
