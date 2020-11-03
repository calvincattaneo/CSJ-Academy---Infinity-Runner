using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public int Score;
    public int CoinScore;

    public Text scoreText;
    public Text CoinText;

    public float ScorePerSecond;
    public bool PlayerIsAlive;
    
    public static GameController current;

    public GameObject GameOverPanel;
    public Button RestartBt;

    void Start() {
        current = this;
        PlayerIsAlive = true;
    }

    float ScoreUpdated;
    void Update() {
        if(PlayerIsAlive) {
            ScoreUpdated += ScorePerSecond * Time.deltaTime;
            Score = (int)ScoreUpdated;

            scoreText.text = Score.ToString();
        }
        
    }

    public void AddScore(int value) {
        CoinScore += value;
        CoinText.text = CoinScore.ToString();
    }
    public void RestartGame() {
        SceneManager.LoadScene(0);
    }

}
