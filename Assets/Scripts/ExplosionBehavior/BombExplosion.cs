using UnityEngine;
using System.Collections;

public class BombExplosion : MonoBehaviour {
	Vector3 Pos { get; set; }
	// Use this for initialization
	void Start () {
		transform.localScale=new Vector3(0,0,0);
		Invoke("destroy",3);
		Pos=transform.position;
	}
	
	// Update is called once per frame
	void Update(){
	//	transform.position=Pos;
	}
	void FixedUpdate () {
		if(transform.localScale != new Vector3(1,1,1)){
			transform.localScale += new Vector3(0.1f,0.1f,0.1f);
		}
	}
	void destroy(){
		GameObject.Destroy(gameObject);
	}

	void OnCollisionStay2D(Collision2D hit){
		if(hit.gameObject.tag=="Enemy"){
			Destroy(hit.gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D hit){
		if(hit.gameObject.tag=="Enemy"){
			Destroy(hit.gameObject);
		}
	}
}
