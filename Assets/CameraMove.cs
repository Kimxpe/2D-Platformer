﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public Transform playerTransform;


	void Start () {
		//transform.position = new Vector3 (playerTransform.position.x, transform.position.y, transform.position.z);
	}
	

	void Update () {
		transform.position = new Vector3 (playerTransform.position.x, transform.position.y, transform.position.z);
	}
}
