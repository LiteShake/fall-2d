using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyBars : MonoBehaviour
{
    // Unity Data
    // Renderer enemyRenderer;

    // Vanilla data
    float speed = 6.9f;

    // Start is called before the first frame update
    void Start()
    {
        // enemy = GetComponent<Rigidbody2D>();
        // xCoord = - 3 + Random.Range(0, 3.69f);
    }

    // Update is called once per frame
    void Update()
    {
        // move from -3 to 0.69
        var step = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, 8), step);
        
        if( transform.position.y > 7 )
        {
            Debug.Log("Moved out !");
            Destroy( this.gameObject );

        }
    }
}
