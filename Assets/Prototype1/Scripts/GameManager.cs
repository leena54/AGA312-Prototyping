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

        

        private void Update()
        {
            

            speed += increaseRate * Time.deltaTime;
            speedText.text = "Speed:" + speed.ToString("F2");

            

        }
    }
}
