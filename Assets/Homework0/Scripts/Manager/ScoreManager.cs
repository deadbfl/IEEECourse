using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [SerializeField] private TMP_Text scoreText;

    private int score;

    private void Awake()
    {
        instance = this;
    }
    public void IncreaseScore()
    {
        score++;

        scoreText.SetText(score.ToString());
    }
}
