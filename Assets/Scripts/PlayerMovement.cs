using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 6f;
	public Rigidbody theRigidBody;
	// Use this for initialization
	void Start () {
		theRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
        float inputX2 = Input.GetAxis("Horizontal2");
        theRigidBody.velocity = new Vector3(inputX*moveSpeed, inputY *moveSpeed,1);
        transform.Rotate(0, 0, 2 * inputX2);
        if (Input.GetKeyDown("up"))
        {
            transform.Rotate(90, 0, 0);
        }
        if (Input.GetKeyDown("down"))
        {
            transform.Rotate(-90, 0, 0);
        }
    }
}
