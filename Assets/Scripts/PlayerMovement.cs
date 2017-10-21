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
		theRigidBody.velocity = new Vector3(inputX*moveSpeed, inputY *moveSpeed,1);
	}
}
