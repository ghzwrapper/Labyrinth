using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour {

	public float jumpForce = 5.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Ray ray = new Ray (transform.position, Vector3.down);
			if (Physics.Raycast (ray, 1.0f)) {
				GetComponent <Rigidbody>().AddForce (Vector3.up * jumpForce * 50.0f);
			}
		}
	}
}
