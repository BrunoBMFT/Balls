using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    int score = 0;

    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
    }
}
