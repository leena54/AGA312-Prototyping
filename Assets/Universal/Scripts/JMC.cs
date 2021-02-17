using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JMC : MonoBehaviour
{
    /// <summary>
    /// Use this to check if we should call game over
    /// </summary>
    /// <param name="_lives">The players current lives</param>
    /// <returns>If we are at Game Over or not</returns>
    public bool IsGameOver(int _lives)
    {
        return _lives == 0;
    }

    /// <summary>
    /// Works out the change in percentage between two scores 
    /// </summary>
    /// <param name="_Score1">The original score</param>
    /// <param name="_Score2">The new score</param>
    /// <returns>The percentage change between the scores</returns>
    public float PercentageChange(int _Score1, int _Score2)
    {
        float change = _Score2 - _Score1;
        return change / _Score1 * 100;
    }
}
