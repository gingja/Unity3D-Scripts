using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingEarth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, 55 * Time.deltaTime);

		transform.RotateAround (Vector3.forward, Vector3.down, 35 * Time.deltaTime);
	}
}
