using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
public class NewMonoBehaviourScript : MonoBehaviour
{

    public GameObject player;

    public float moveSpeed = 150f;
    public float detectionRadius = 10f;

    public float damageAmount = 10f;


     public float timer;



    private void Start()
    {
        player = GameObject.Find("crocodile");
    }



    // Update is called once per frame
    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceToPlayer <= detectionRadius)
        {
            MoveTowardsPlayer();
        }

        timer += Time.deltaTime;
        if (timer >= 2)
        {
            timer = 0;
            moveSpeed += 1;
            Debug.Log("Speeding Up");
        }

    }



    //the procedure that lets the enemy move to the player
    private void MoveTowardsPlayer()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;

        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}
