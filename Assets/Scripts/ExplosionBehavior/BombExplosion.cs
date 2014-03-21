using UnityEngine;
using System.Collections;

public class BombExplosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.localScale=new Vector3(0,0,0);
		Invoke("destroy",3);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(transform.localScale != new Vector3(1,1,1)){
			transform.localScale += new Vector3(0.1f,0.1f,0.1f);
		}
	}
	void destroy(){
		GameObject.Destroy(gameObject);
	}

	}
