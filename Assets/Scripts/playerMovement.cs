using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public GameObject player;
	private Vector2 mSpeed = new Vector2(0,180);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) == true) {
			player.gameObject.rigidbody2D.AddForce(mSpeed);
		}
	}
}
