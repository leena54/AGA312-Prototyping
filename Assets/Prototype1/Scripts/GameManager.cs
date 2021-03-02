using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype1
{
    public class GameManager : Singleton<GameManager>
    {
        public int lives;

        public float speed;
        public float increaseRate;
        public Text speedText;

        public Text scoreText;
        public Text hiScoreText;
        public float scoreCount;
        public float hiScoreCount;
        public float pointsPerSecond;
        public bool scoreIncreasing;

        private void Update()
        {
            if(scoreIncreasing)
            {
                scoreCount += pointsPerSecond * Time.deltaTime;
            }

            if (scoreCount > hiScoreCount)
            {
                hiScoreCount = scoreCount;
            }

            speed += increaseRate * Time.deltaTime;
            speedText.text = "Speed:" + speed.ToString("F2");

            
            scoreText.text = "Score: " + scoreCount.ToString("F2");
            hiScoreText.text = "High Score: " + hiScoreCount;
        }
    }
}
