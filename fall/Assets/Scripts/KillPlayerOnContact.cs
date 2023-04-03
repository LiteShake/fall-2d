using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayerOnContact : MonoBehaviour
{

    private Boolean contactKill = true ;
    public GameObject singu_label;
    public GameObject ayu_label;

    private Renderer singu_rend, ayu_rend;
        
    // Start is called before the first frame update
    void Start()
    {
        singu_rend = singu_label.GetComponent<Renderer>();
        ayu_rend = ayu_label.GetComponent<Renderer>();

        singu_rend.enabled = false;
        ayu_rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Enemy":

                if (!contactKill)
                {
                    break;
                }
                SceneManager.LoadScene("MainGame");
                break;

            case "Powerups":

                print("ooooooo");
                switch (other.name)
                {
                    case "Singularity":
                        print("eeeee");
                            StartCoroutine(SlowMotion(12.0f));
                            break;

                    case "Tulsi":
                        StartCoroutine(Tulsi(10f));
                        break;

                    default: break;
                } break;
                
            default: break; 
        }
    }

    IEnumerator SlowMotion( float slowTime )
    {
        singu_rend.enabled = true;
        Time.timeScale = 0.4f;
        yield return new WaitForSeconds( slowTime - 5 );

        for( int i = 0; i< 20; i++ )
        {
            singu_rend.enabled = ! singu_rend.enabled;
            yield return new WaitForSeconds(0.25f);
        }

        Time.timeScale = 1.0f;
        singu_rend.enabled = false;
    }

    IEnumerator Tulsi( float time )
    {
        ayu_rend.enabled = true;
        //gameObject.
        contactKill = false ;
        yield return new WaitForSeconds(time - 5) ;

        for( int i = 0; i < 10 ; i++ )
        {
            ayu_rend.enabled = !ayu_rend.enabled;
            yield return new WaitForSeconds(0.5f);
        }
        contactKill = true ;
        ayu_rend.enabled = false;
    }
}
