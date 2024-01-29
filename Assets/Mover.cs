using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rb;

    void Update()
    {
        rb.velocity = new Vector3(1.0f, 0.0f);
    }
}
