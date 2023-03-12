using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour
{

    private Vector2 camOrigPos = default;
    public float shakeFreq = 1f;

    // Start is called before the first frame update
    void Start()
    {
        camOrigPos= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camOrigPos + (Random.insideUnitCircle) / 30;//  * Time.deltaTime;
    }
}
