using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {
	public Transform bombExplosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter2D(Collision2D collision){
//		print (collision.gameObject.tag);
		if(collision.gameObject.tag=="Player"){
//			print ("sss");
			Instantiate(bombExplosion,transform.position,Quaternion.identity);
			GameObject.Destroy(gameObject);
		}
	}
}
