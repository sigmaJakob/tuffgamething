using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerMovementScript : MonoBehaviour
{
    public Vector3 upDirection;
    public Vector3 downDirection;
    public Vector3 leftDirection;
    public Vector3 rightDirection;

    public GameObject gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position += upDirection;
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().position += downDirection;
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position += leftDirection;
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position += rightDirection;
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gem")
        {
            gameManager.GetComponent<GMScript>().score += 1;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Debug.Log("YOU LOSE");
            Time.timeScale = 0;
        }
        


    }
}
