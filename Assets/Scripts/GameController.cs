using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public int Score;
    public Text scoreText;
    public float ScorePerSecond;
    public static GameController current;

    void Start() {
        current = this;
    }

    float ScoreUpdated;
    void Update() {
        ScoreUpdated += ScorePerSecond * Time.deltaTime;
        Score = (int)ScoreUpdated;

        scoreText.text = Score.ToString();
    }

    public void AddScore(int value) {
        ScoreUpdated += value;
    }
}
