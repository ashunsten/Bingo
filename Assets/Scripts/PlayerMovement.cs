using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float forwardAccelaration =2000f;
    public float sideAccelaraton =500f;
    public Vector3 Offset = new Vector3();

    public int remainingLife;
    


    // Start is called before the first frame update
    void Start()
    {
        remainingLife = 3;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, forwardAccelaration * Time.deltaTime);

        if(Input.GetKey("right"))
		{
            rigidBody.AddForce(sideAccelaraton * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("left"))
        {
            rigidBody.AddForce(-sideAccelaraton * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.touchCount> 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.position.x < 500)
            {
                rigidBody.AddForce(-sideAccelaraton * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else
            {
                rigidBody.AddForce(sideAccelaraton * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        if (rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if(Input.GetKey("a"))
        {
            Time.timeScale = 0f;
        }

    }
}
