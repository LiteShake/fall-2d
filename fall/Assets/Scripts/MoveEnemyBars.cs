using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyBars : MonoBehaviour
{

    Rigidbody2D enemy;
    float speed = 6.9f;

    float startRange = -3.0f;
    float endRange = 0.69f;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // move from -3 to 0.69
    }
}
