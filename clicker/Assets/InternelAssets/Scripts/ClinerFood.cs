using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClinerFood : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            Destroy(collision.gameObject);
        }
    }
}
