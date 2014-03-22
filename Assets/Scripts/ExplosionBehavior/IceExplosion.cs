using UnityEngine;
using System.Collections;

public class IceExplosion : MonoBehaviour {
    public GameObject FrozenEnemy;
	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(0, 0, 0);
        Invoke("Destroy",3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        if (transform.localScale != new Vector3(1, 1, 1))
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
    void Destroy()
    {
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag == "Enemy")
        {
            Instantiate(FrozenEnemy, hit.gameObject.transform.position, Quaternion.identity);
            Destroy(hit.gameObject);
        }
    }
}
