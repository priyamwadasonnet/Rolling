using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text ScoreText;

    private void Start()
    {
        score = 0;
    }

    public void AddPoints(int newScore)
    {
        score += newScore;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        if (ScoreText != null)
        {
            ScoreText.text = "" + score.ToString();

        }
        else
        {
            Debug.LogError("Score script: Text reference is missing!"); // Log error if the reference is not set
        }
    }


    private void FixedUpdate()
    {
        UpdateScoreText();
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("PreviousSceneScore", score);
    }
}
