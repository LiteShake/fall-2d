using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TulsiScript : MonoBehaviour
{
    //public Camera cam;
    //private Vignette vig;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.name == "Tulsi" )
        {
            // Debug.Log("Touchhh");
            StartCoroutine(SlowMotion(10f, 0.4f));
        }
    }

    IEnumerator SlowMotion( float seconds, float scale )
    {
        //Time.timeScale = scale;
        Debug.Log("Reduced speed to " + scale);
        yield return new WaitForSeconds(  seconds );
        Debug.Log("This works !");
        //Time.timeScale = 1f;
        //yield return new WaitForSeconds( 30 ) ;
    }
}
