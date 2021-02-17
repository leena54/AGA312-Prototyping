using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : JMC
{
    public int lastRoundScore = 100;
    public int thisRoundScore = 150;
    public int lives = 5;
    void Start()
    {
        
        if(IsGameOver(lives))
        CheckScore();

    }

    void CheckScore()
    {
        print("Score difference is: " + PercentageChange(lastRoundScore, thisRoundScore).ToString("F2")+ "%");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
