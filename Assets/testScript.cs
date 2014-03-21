using UnityEngine;
using System.Collections;

public class testScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate(0,1,0);
	}
	void OnCollisionStay2D(Collision2D hit){
		print ("aaa");
	}
}
