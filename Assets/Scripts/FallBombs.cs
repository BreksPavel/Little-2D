using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBombs : MonoBehaviour
{
    [SerializeField] float fallSpeed = 6f;

    private void Update()
    {
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
        if(transform.position.y < -6 || EndLevel.loose)
        {
            Destroy(this.gameObject);
        }
    }
}
