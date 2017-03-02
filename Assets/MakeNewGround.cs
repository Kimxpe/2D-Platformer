using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeNewGround : MonoBehaviour {

	public bool makeGround;
	public GameObject groundPrefab;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag ("Ground")) {
			makeGround = false;
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.CompareTag ("Ground")) {
			makeGround = true;
		}
	}

	void OnTriggerStay2D (Collider2D other) {
		if (other.CompareTag ("Ground")) {
			makeGround = false;
		}
	}


	void Update () {
		if (makeGround) {
			//make some ground
			Instantiate (groundPrefab, transform.position, Quaternion.identity); //Quaternion.identity for no rotation

		}
	}
}
