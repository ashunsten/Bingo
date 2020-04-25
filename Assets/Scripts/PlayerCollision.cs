using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle" && movement.remainingLife<=0)
        {
            Debug.Log("Collision");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        else if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.remainingLife -= 1;
        }
    }
}
