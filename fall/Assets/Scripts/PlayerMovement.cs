using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerBody;

    float dirX;
    float speed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector2 accn = Input.acceleration ;


        playerBody.velocity = new Vector2(accn.x * speed, 0f);// * Time.unscaledDeltaTime;
    }
}
