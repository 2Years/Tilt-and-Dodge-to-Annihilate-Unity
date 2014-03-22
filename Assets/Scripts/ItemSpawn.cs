using UnityEngine;
using System.Collections;

public class ItemSpawn : MonoBehaviour {
	public float itemNumber=5;
	public Transform[] items;
	GameObject[] item_on_scene;
	// Use this for initialization
	void Start () {
		for(int i=0;i<itemNumber;i++){
			Instantiate(items[Random.Range(0,items.Length)],new Vector3(Random.Range(-510,510),Random.Range(-318,289),0),Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		item_on_scene=GameObject.FindGameObjectsWithTag("Item");
		if(item_on_scene.Length<itemNumber){
            Instantiate(items[Random.Range(0, items.Length)], new Vector3(Random.Range(-510, 510), Random.Range(-318, 289), 0), Quaternion.identity);
		}

	}
}
