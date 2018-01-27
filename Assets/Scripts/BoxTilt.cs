using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTilt : MonoBehaviour {

	public float maxRotation = 20.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxis ("Horizontal");
		float verticalInput = Input.GetAxis ("Vertical");

		// Calculate the desired horizontal angle
		float horizontalAngleGoal = 0;

		if (Mathf.Abs (horizontalInput) > 0.1f) {
			horizontalAngleGoal = maxRotation * -1.0f * horizontalInput;
		}

		// Calculate the desired vertical angle
		float verticalAngleGoal = 0;

		if (Mathf.Abs (verticalInput) > 0.1f) {
			verticalAngleGoal = maxRotation * verticalInput;
		}

		Vector3 targetRotation = new Vector3 (verticalAngleGoal, 0, horizontalAngleGoal);

		// Use Lerp (linear interpolation) to do a fast->slow "snap" to the new rotation
		transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler (targetRotation), Time.deltaTime * 3.0f);

		// Alternate control scheme
		//transform.Rotate (targetRotation * Time.deltaTime);
	}
}
