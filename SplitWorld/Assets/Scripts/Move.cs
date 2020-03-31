using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.5f;
    private bool player2;


    private void Start()
    {

        if(this.gameObject.name == "Player2")
        {
            player2 = true;
        }
        else
        {
            player2 = false;
        }
    }

    void Update()
    {
        move();
    }


    void move()
    {
        if(player2)
        {
            if (Input.GetKey(KeyCode.Keypad4))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Keypad6))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Keypad8))
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Keypad5))
            {
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Keypad7))
            {
                transform.Rotate(-Vector3.up * (speed * 10) * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Keypad9))
            {
                transform.Rotate(Vector3.up * (speed * 10) * Time.deltaTime);
            }

        }
        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(-Vector3.up * (speed * 10) * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(Vector3.up * (speed * 10) * Time.deltaTime);
            }

        }
    }

    
}

