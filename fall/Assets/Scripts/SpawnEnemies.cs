using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class SpawnEnemies : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyBar;
    float xCoord;

    public TextMeshProUGUI scoreCard;
    private int score;

    // Use this for initialization
    void Start()
    {

        StartCoroutine(wait_time());
        score = 0;
        scoreCard.text = "";
    }

    IEnumerator wait_time()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.69f);
            // Debug.Log("hello");
            xCoord = Random.Range( -3.0f, 0.69f );
            Instantiate(enemyBar, new Vector2( xCoord, -7 ),Quaternion.identity );
            
            score = score + 1;
            scoreCard.text = "" + score;
        }
    }
}