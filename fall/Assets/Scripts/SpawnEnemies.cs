using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class SpawnEnemies : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyBar;
    public TextMeshPro scoreCard;
    public TextMeshPro startCountdown;
    
    float xCoord;

    public int score;

    private bool canStart = false;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(CountDown());

        StartCoroutine(WaitTime());
        score = 0;
        scoreCard.text = "";
    }        


    IEnumerator CountDown()
    {
        for( int i = 5; i >= 0; i-- )
        {
            // Debug.Log(i);

            startCountdown.text = "" + i;
            yield return new WaitForSeconds(1);
        }

        startCountdown.text = ""; 
        // startCountdown.gameObject.SetActive(false);

        canStart= true;
    }

    IEnumerator WaitTime()
    {
        // int count = 0;
        // Infinite loop for continous spawning
        while (true)
        {
            
            yield return new WaitForSeconds(1f);
            if( !canStart ) { continue; }
            // Debug.Log("hello");
            xCoord = Random.Range( -3.0f, 0.69f );

            // Getting instantiated GameObject and changing speed according to score
            GameObject instantiated = (GameObject)Instantiate(enemyBar, new Vector2( xCoord, -7 ),Quaternion.identity );
            instantiated.GetComponent<MoveEnemyBars>().speed += (score / 10);

            score++;

            
            // Nice stuff
            if( score == 69 ) { 
                scoreCard.text = "" + score + " Nice hehe"; 
                continue; 
            }

            // Updating the score
            scoreCard.text = "" + score;
        }
    }
}