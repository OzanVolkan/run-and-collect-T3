using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float scoreCounter;

    public Text scoreText;
    void Start()
    {
        scoreCounter = 0;
    }

    void Update()
    {
        scoreText.text = scoreCounter.ToString();
    }
}
