using UnityEngine;
using System.Collections;

public class cameraManagement : MonoBehaviour {

	public float ptage;
	public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate(0,target.position.y * ptage-transform.position.y,0);
	}
}
