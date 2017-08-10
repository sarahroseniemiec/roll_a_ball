using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this code makes it so that the camera will follow the player without being a child of the player, since when it is a child it rotates with the ball movments.

public class cameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;	
	}
	
	// LateUpdate is called once per frame guaranteed to run after all items have been processed in update
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
