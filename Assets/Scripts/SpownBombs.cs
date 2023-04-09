using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownBombs : MonoBehaviour
{
    public GameObject bomb;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!EndLevel.loose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-2.3f, 2.3f), 6f), Quaternion.identity);
            yield return new WaitForSeconds(1f);

        }
    }
}
