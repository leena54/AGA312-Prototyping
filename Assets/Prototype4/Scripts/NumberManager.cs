using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberManager : MonoBehaviour
{
    public enum Difficulty
    {
        EASY, MEDIUM, HARD
    }

    public List<Tables> tables;
    public List<GameObject> pickups;
    public GameObject pickupPrefab;
    public Difficulty currentDifficulty;

    void Start()
    {
        GenerateNumbers();
    }


    void Update()
    {
        
    }

    public void GenerateNumbers()
    {
        int spawnCount = tables.Count * 2;
        for (int i = 0; i < spawnCount; i++)
        {
            GameObject go = Instantiate(pickupPrefab, new Vector3(Random.Range(-5, 5), 0.5f, Random.Range(-5, 5)), transform.rotation);
            go.GetComponent<Pickup>().myNumber = GetRandomNumbers();
            go.name = "Ingredient" + go.GetComponent<Pickup>().myNumber.ToString();
            go.GetComponentInChildren<TextMeshPro>().text = go.GetComponent<Pickup>().myNumber.ToString();
            pickups.Add(go);
        }

        SetTables();
    }

    void SetTables()
    {
        for(int i = 0; i < tables.Count; i++)
        {
            int answer = pickups[0].GetComponent<Pickup>().myNumber * pickups[1].GetComponent<Pickup>().myNumber ;
            tables[i].myNumber = answer;
            tables[i].GetComponentInChildren<TextMeshPro>().text = answer.ToString();
        }

    }

    int GetRandomNumbers()
    {
        switch (currentDifficulty)
        {
            case Difficulty.EASY:
                return (Random.Range(1, 10));
            case Difficulty.MEDIUM:
                return (Random.Range(1, 20));
            case Difficulty.HARD:
                return (Random.Range(1, 100));
            default:
                return (Random.Range(1, 10));
        }
    }
}
