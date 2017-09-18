using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    float movementSpeed = 1f;

    Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start ()
    {
        //this code teleports the game object to a new location
        //transform.position = new Vector3(0,0,0);

        myRigidbody = GetComponent<Rigidbody2D>();


    }
	
	// Update is called once per frame
	void Update ()
    {
        // Don't use Input.GetKey, use GetButton and GetAxis!
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(new Vector3(0.1f, 0, 0));
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(new Vector3(-0.1f, 0, 0));
        //}
        // This method of movement doesn't use the physics system :(
        //transform.Translate(0.1f * horizontalInput, 0, 0);


        float horizontalInput = Input.GetAxis("Horizontal");
        myRigidbody.velocity = new Vector2(horizontalInput * movementSpeed, myRigidbody.velocity.y);

        Debug.Log("Horizontal input: " + horizontalInput);


        if (Input.GetButtonDown("Jump"))
        {
            // crappy jump logic
            transform.Translate(0, 5, 0);
        }
    }
}
