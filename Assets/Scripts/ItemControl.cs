using UnityEngine;
using System.Collections;

public class ItemControl : MonoBehaviour {
	float itemspeed=700f;

	void Start () {
		rigidbody2D.gravityScale=0;
		rigidbody2D.AddForce(new Vector2(Random.Range(0,100),Random.Range(0,100)).normalized*itemspeed);
	}


}
