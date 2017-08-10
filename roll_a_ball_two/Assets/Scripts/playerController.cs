using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {
	// public variable that will show up in editor as an editable property
	public float speed;
	public Text countText;
	public Text winText;
	//private variable with type Rigidbody called rb
	private Rigidbody rb;
	private int count;

	//called on the first frame that the script is active, often first frame of game 
	void Start () 
	{
		//variable to hold a reference to the attatched rigidbody component
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizonal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizonal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("PickUp")) 
		{
			other.gameObject.SetActive (false);
			count += 1;
			SetCountText ();
		}

	}

	void SetCountText ()
	{
		countText.text = "Score: " + count.ToString ();
		if (count >= 13) 
		{
			winText.text = "You won!";
		}
	}
}
