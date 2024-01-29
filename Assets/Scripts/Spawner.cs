using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject temp1;
    public GameObject temp2;
    public GameObject temp3;
    public GameObject temp4;
    public GameObject temp5;
    public Player player;
    public Vector3 spawnPosition;
    private float chance;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
        spawnPosition.x = 10.0f;
        spawnPosition.y = 0.0f;
    }

    void SpawnChance()
    {
        chance = Random.Range(0.0f, 100.0f);

        if(chance < 50.0f){
            Instantiate(temp1, transform.position, transform.rotation);
        } else if(chance > 50.0f && chance < 75.0f){
            Instantiate(temp2, transform.position, transform.rotation);
        } else if(chance > 75.0f && chance < 85.0f){
            Instantiate(temp3, transform.position, transform.rotation);
        } else if(chance > 85.0f && chance < 93.0f){
            Instantiate(temp4, transform.position, transform.rotation);
        } else {
            Instantiate(temp5, transform.position, transform.rotation);
        }
    }

    IEnumerator Spawn(){
        while(player.lives > 0){
            SpawnChance();
            yield return new WaitForSeconds(10/player.songSpeed);
        }
    }

}
