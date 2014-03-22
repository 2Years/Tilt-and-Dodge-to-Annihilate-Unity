using UnityEngine;
using System.Collections;

public class Ice : MonoBehaviour {
    public GameObject IceExplosion;
    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            Instantiate(IceExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
