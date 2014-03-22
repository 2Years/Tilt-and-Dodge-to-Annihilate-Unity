using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	public float enemyspeed=100;
	void Update () {
		follow ();

	}

	void follow(){
		Transform main=GameObject.FindGameObjectWithTag("Player").transform;
		Quaternion enemyrotation=Quaternion.LookRotation(transform.position-main.position,Vector3.forward);
		enemyrotation.x=0;
		enemyrotation.y=0;
		transform.rotation=Quaternion.Slerp(transform.rotation,enemyrotation,Time.deltaTime*10);
		transform.Translate(Vector3.up*Time.deltaTime*enemyspeed);
	}




}