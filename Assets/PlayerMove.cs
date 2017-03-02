using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float speed = 10f;
	public float jumpForce = 500f;
	private float xSpeed;
	private Rigidbody2D rb;
	private Animator anim;
	private SpriteRenderer renderer;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		renderer = GetComponent<SpriteRenderer> ();
	}
	

	void Update () {

		if (Input.GetButtonDown ("Jump")) {
			rb.AddForce (new Vector2 (0, jumpForce)); //(0 (we don't want force on x at all), jumpForce)
		
		}


		xSpeed = Input.GetAxisRaw ("Horizontal") * speed;
		rb.velocity = new Vector2 (xSpeed, rb.velocity.y);
		anim.SetFloat ("Speed", Mathf.Abs (xSpeed)); //the absolute value of xspeed is going to be set to Speed

//		if (xSpeed > 0 && renderer.flipX) { //if it's greater than zero and it's flipped , don't flip it
//			renderer.flipX = false;
//		}
//
//		if (xSpeed < 0 && !renderer.flipX) {
//			renderer.flipX = true;
//		}

		if ((xSpeed > 0 && renderer.flipX) || (xSpeed < 0 && !renderer.flipX)) { //if it's one, make the other. If it's the other, make the opposite
			renderer.flipX = !renderer.flipX;
		}

	}
}
