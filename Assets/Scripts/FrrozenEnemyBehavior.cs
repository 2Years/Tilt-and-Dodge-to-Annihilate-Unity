using UnityEngine;
using System.Collections;

public class FrrozenEnemyBehavior : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
