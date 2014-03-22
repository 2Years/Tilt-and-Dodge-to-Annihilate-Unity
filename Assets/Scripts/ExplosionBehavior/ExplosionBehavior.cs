using UnityEngine;
using System.Collections;

public class ExplosionBehavior : MonoBehaviour {

    void OnCollisionStay2D(Collision2D hit)
    {
        if (hit.gameObject.tag == "Enemy")
        {
            Destroy(hit.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag == "Enemy")
        {
            Destroy(hit.gameObject);
        }
    }
}
