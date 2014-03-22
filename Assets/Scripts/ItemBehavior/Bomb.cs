using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {
	public Transform bombExplosion;

	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag=="Player"){
			Instantiate(bombExplosion,transform.position,Quaternion.identity);
			GameObject.Destroy(gameObject);
		}
	}
}
