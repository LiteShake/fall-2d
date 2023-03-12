using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class SingularityScript : MonoBehaviour
{
    //public Camera cam;
    //private Vignette vig;
    // Start is called before the first frame update
    void Start()
    {
        // vig = 
        StartCoroutine(SlowMotion( 10f, 0.4f ));
        StartCoroutine(SlowMotion( 10f, 1.0f ));
        //Time.timeScale = 0.4f;
        //StartCoroutine(SlowMotion( 10f ));
        //Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.name == "Singularity" )
        {
            
        }
    }

    IEnumerator SlowMotion( float seconds, float scale )
    {
        Time.timeScale = scale;
        Debug.Log("Reduced speed to " + scale);
        yield return new WaitForSeconds(  seconds );
        Debug.Log("This works !");
        //yield return new WaitForSeconds( 30 ) ;
    }
}
