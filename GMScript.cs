using JetBrains.Annotations;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
public class GMScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector3 enemyPos1;
    public GameObject gemPrefab;
    public GameObject gemPrefabRed;
    public List<Vector3> gemPosList;
    public List<Vector3> gemPosList2;
    public int score;
    public Vector3 despicable;
    public GameObject Player;

    public float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(enemyPrefab, enemyPos1, Quaternion.identity);

        for (int i = 0; i < gemPosList.Count; i++)
        {
            Instantiate(gemPrefab, gemPosList[i], Quaternion.identity);
            Instantiate(gemPrefabRed, gemPosList2[i], Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            Debug.Log("A gem has spawned!");
            timer = 0;
            despicable = new Vector3(Random.Range(-33, 31), Random.Range(-25, 25), 0);
            Instantiate(gemPrefab, despicable, Quaternion.identity);
        }

        if (score >= 10)
        {
            Debug.Log("You WIN!");
            Time.timeScale = 0;
            Destroy(Player);
        }

    }
    
}
