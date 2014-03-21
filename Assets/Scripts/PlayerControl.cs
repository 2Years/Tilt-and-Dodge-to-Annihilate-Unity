using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public float sensitivaty=300f,angSpd=10f,tiltLim=0.01f;
	float alarm=0.05f;
	float deltaX=0f,deltaY=0f,firstX,firstY,angle=0;

	void start(){
		firstX=transform.position.x;
		firstY=transform.position.y;
	}
	void calRotation(float x, float y){
		deltaX=x-firstX;
		deltaY=y-firstY;
		angle=Mathf.Atan2(deltaY,deltaX)*Mathf.Rad2Deg;
		angle=angle-90;
		if(angle<0){
			angle=360+angle;
		}
		Vector3 temp=transform.eulerAngles;
		temp.z=angle;
		Quaternion targetAng=Quaternion.Euler(temp);
//		float angleDif=Quaternion.Angle(transform.rotation,targetAng);
		transform.rotation=Quaternion.Slerp(transform.rotation,targetAng,angSpd);
//		print (angleDif);
	}
	void keepIn(){
		if(transform.position.x>640){
			Vector2 temp=transform.position;
			temp.x=640;
			transform.position=temp;
		}
		if(transform.position.x<-640){
			Vector2 temp=transform.position;
			temp.x=-640;
			transform.position=temp;
		}
		if(transform.position.y>360){
			Vector2 temp=transform.position;
			temp.y=360;
			transform.position=temp;
		}
		if(transform.position.y<-360){
			Vector2 temp=transform.position;
			temp.y=-360;
			transform.position=temp;
		}
	}
	void Update () {
		transform.Translate(new Vector2(Input.acceleration.x,Input.acceleration.y)*Time.deltaTime*sensitivaty,Space.World);
		keepIn ();
		alarm-=Time.deltaTime;
		if(alarm<0){
			calRotation(transform.position.x,transform.position.y);
			alarm=0.05f;
			firstX=transform.position.x;
			firstY=transform.position.y;

		}

	}
}
