using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        Destroy(collision.gameObject);
        Debug.Log("Destroyed " + collision.gameObject.name);
    }
}
