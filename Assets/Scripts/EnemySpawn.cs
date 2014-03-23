using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
{
    public Transform enemy;
    public Transform Main;
    public float boxSize = 80;
    public int t_ernd = 5, t_incrnd = 7, t_box = 12;
    float incrnd = 3;

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemy, new Vector3(Random.Range(-510, 510), Random.Range(-318, 285), 0), Quaternion.identity);
        }
        StartCoroutine("Spawn_ernd");
        StartCoroutine("Spawn_incrnd");
        StartCoroutine("Spawn_box");
        StartCoroutine("Spawn_law");
    }

    void Update()
    {

    }
    IEnumerator Spawn_ernd()
    {
        while (true)
        {
            yield return new WaitForSeconds(t_ernd);
            for (int i = 0; i < 3; i++)
            {
                Instantiate(enemy, new Vector3(Random.Range(-510, 510), Random.Range(-318, 285), 0), Quaternion.identity);
            }
        }
    }
    IEnumerator Spawn_incrnd()
    {
        while (true)
        {
            yield return new WaitForSeconds(t_incrnd);
            for (int i = 0; i < incrnd; i++)
            {
                Instantiate(enemy, new Vector3(Random.Range(-510, 510), Random.Range(-318, 285), 0), Quaternion.identity);
            }
            if (incrnd < 30)
            {
                incrnd += 2;
            }
        }
    }
    IEnumerator Spawn_box()
    {
        while (true)
        {
            yield return new WaitForSeconds(t_box);

            Instantiate(enemy, Main.position + new Vector3(0, boxSize, 0), Quaternion.identity);
            Instantiate(enemy, Main.position + new Vector3(0, -boxSize, 0), Quaternion.identity);
            Instantiate(enemy, Main.position + new Vector3(boxSize, 0, 0), Quaternion.identity);
            Instantiate(enemy, Main.position + new Vector3(-boxSize, 0, 0), Quaternion.identity);
            Instantiate(enemy, Main.position + new Vector3(boxSize, boxSize, 0), Quaternion.identity);
            Instantiate(enemy, Main.position + new Vector3(boxSize, -boxSize, 0), Quaternion.identity);
            Instantiate(enemy, Main.position + new Vector3(-boxSize, boxSize, 0), Quaternion.identity);
            Instantiate(enemy, Main.position + new Vector3(-boxSize, -boxSize, 0), Quaternion.identity);
        }
    }
    IEnumerator Spawn_law()
    {

        yield return new WaitForSeconds(3);
        for (int i = -550; i < 550; i += 30)
        {
            Instantiate(enemy, Main.position + new Vector3(i, 300, 0), Quaternion.identity);
        }

    }
}
