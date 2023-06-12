using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour





{
    private int score;
    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;


    public void Awake(){
        Application.targetFrameRate = 60;
        Pause();
    }


    public void Play(){
        score = 0;
        scoreText.text = score.ToString();
        Time.timeScale = 1f;
        player.enabled = true;
        gameOver.SetActive(false);
        playButton.SetActive(false);
        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for (int i = 0; i < pipes.Length; i++){
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause(){
        Time.timeScale = 0f;
        player.enabled = false;        
    }

    
    public void GameOver(){
        //Debug.Log("Game Over");
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }


    
    public void IncreaseScore()
    {
        score++;
        //Debug.Log(score);
        scoreText.text = score.ToString();

    }
}
 