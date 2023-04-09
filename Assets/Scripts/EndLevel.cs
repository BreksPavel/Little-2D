using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public static bool loose = false;
    public GameObject restart;

    private void Awake()
    {
        loose = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bomb")
        {
            loose = true;
            restart.SetActive (true);
        }
    }
}
