using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class malo : MonoBehaviour
{
    public int spd;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ZM"))
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        transform.position -= new Vector3(spd*Time.deltaTime,0,0);
    }
}
