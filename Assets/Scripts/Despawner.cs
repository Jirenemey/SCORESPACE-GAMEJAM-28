using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        Destroy(collision.gameObject);
        Debug.Log("Destroyed " + collision.gameObject.name);
    }
}
