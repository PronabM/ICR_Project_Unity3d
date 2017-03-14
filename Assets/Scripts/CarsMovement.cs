using UnityEngine;
using System.Collections;

public class CarsMovement : MonoBehaviour {

	public float t,x;

	// Use this for initialization
	void Start () {
		Destroy(gameObject,t);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		x -= (Time.time%10) * 0.006f; 
		rigidbody2D.velocity = new Vector2 (x, 0);

	}
}
