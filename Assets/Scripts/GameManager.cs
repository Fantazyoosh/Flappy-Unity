using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour



{

    private int score;
    // Start is called before the first frame update
    public void GameOver()
    {
        Debug.Log("game over");
    }

    // Update is called once per frame
    
    public void IncreaseScore()
    {
        score++;
        Debug.Log(score);
    }
}
 