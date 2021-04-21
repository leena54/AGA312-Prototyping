using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberManager : Singleton<NumberManager>
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
        
        int spawnCount = tables.Count * 4;
        for (int i = 0; i < spawnCount; i++)
        {
            GenerateNumbers();
        }
        SetTables();
    }

    public void GenerateNumbers()
    {
        
            GameObject go = Instantiate(pickupPrefab, new Vector3(Random.Range(-5, 5), 0.5f, Random.Range(-5, 5)), transform.rotation);
            go.GetComponent<Pickup>().myNumber = GetRandomNumbers();
            go.name = "Ingredient" + go.GetComponent<Pickup>().myNumber.ToString();
            go.GetComponentInChildren<TextMeshPro>().text = go.GetComponent<Pickup>().myNumber.ToString();
            pickups.Add(go);

    }

    void SetTables()
    {
        for(int i = 0; i < tables.Count; i++)
        {
            int answer = pickups[Random.Range(0,7)].GetComponent<Pickup>().myNumber * pickups[Random.Range(0,7)].GetComponent<Pickup>().myNumber;
            tables[i].myNumber = answer;
            tables[i].GetComponentInChildren<TextMeshPro>().text = answer.ToString();
        }
    }

    public void ResetTable(Tables _tables)
    {
        for (int i = 0; i < 2; i++)
        {
            GameObject go = Instantiate(pickupPrefab, new Vector3(Random.Range(-5, 5), 0.5f, Random.Range(-5, 5)), transform.rotation);
            go.GetComponent<Pickup>().myNumber = GetRandomNumbers();
            go.name = "Ingredient" + go.GetComponent<Pickup>().myNumber.ToString();
            go.GetComponentInChildren<TextMeshPro>().text = go.GetComponent<Pickup>().myNumber.ToString();
            pickups.Add(go);
        }
        int answer = pickups[Random.Range(0, 7)].GetComponent<Pickup>().myNumber * pickups[Random.Range(0, 7)].GetComponent<Pickup>().myNumber;
        _tables.myNumber = answer;
        _tables.GetComponentInChildren<TextMeshPro>().text = answer.ToString();

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
