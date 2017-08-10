using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	// public variable that will show up in editor as an editable property
	//	public float speed;
	//private variable with type Rigidbody called rb
	private Rigidbody rb;
	//called on the first frame that the script is active, often first frame of game 
	void Start () 
	{
		//variable to hold a reference to the attatched rigidbody component
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizonal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizonal, 0.0f, moveVertical);

		rb.AddForce (movement);

	}
}