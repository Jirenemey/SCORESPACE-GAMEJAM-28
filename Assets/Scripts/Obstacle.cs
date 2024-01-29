using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Player player;
    public bool hit = false;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        
    }
    void Update()
    {
        transform.position -= new Vector3(1.0f/60.0f * player.songSpeed, 0.0f);
    }
}
