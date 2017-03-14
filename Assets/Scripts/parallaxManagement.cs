using UnityEngine;
using System.Collections;

public class parallaxManagement : MonoBehaviour {

	public float x,y,realC,c;
	public Transform iobj,ipos;

	void Start () {
	
	}

	void FixedUpdate () {
		c -= Time.deltaTime;
		rigidbody2D.velocity = new Vector2 (x,y);
		if (c <= 0) {
			x-=0.2f;
			c = realC;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "instanceCreator") {
			Debug.Log ("Working");
			Instantiate (iobj, new Vector3 (ipos.transform.position.x, ipos.transform.position.y), iobj.rotation);	
		} 
		else if (other.tag == "instanceDeletor") {
			Destroy(gameObject);
		}
	}
}
