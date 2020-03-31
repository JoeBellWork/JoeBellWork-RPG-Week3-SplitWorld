using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player, player2;
    public Transform reciever;

    private bool playerIsOverLapping = false;
    private bool playerIsOverLapping2 = false;
    // Update is called once per frame
    void Update()
    {
        if(playerIsOverLapping)
        {
            Vector3 portalToPlayer = player.position - transform.position;
            
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);
            

            if (dotProduct <0f)
            {
                float rotationDiff = Quaternion.Angle(transform.rotation, reciever.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f,rotationDiff,0f) * portalToPlayer;
                player.position = reciever.position + positionOffset;

                playerIsOverLapping = false;
            }

           
        }

        if(playerIsOverLapping2)
        {
            Vector3 portalToPlayer2 = player2.position - transform.position;
            float dotProduct2 = Vector3.Dot(transform.up, portalToPlayer2);

            if (dotProduct2 < 0f)
            {
                float rotationDiff2 = Quaternion.Angle(transform.rotation, reciever.rotation);
                rotationDiff2 += 180;
                player2.Rotate(Vector3.up, rotationDiff2);

                Vector3 positionOffset2 = Quaternion.Euler(0f, rotationDiff2, 0f) * portalToPlayer2;
                player2.position = reciever.position + positionOffset2;

                playerIsOverLapping2 = false;
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && other.name == "Player1")
        {
            playerIsOverLapping = true;
        }

        if (other.tag == "Player" && other.name == "Player2")
        {
            playerIsOverLapping2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && other.name == "Player1")
        {
            playerIsOverLapping = false;
        }

        if (other.tag == "Player" && other.name == "Player2")
        {
            playerIsOverLapping2 = false;
        }
    }
}
