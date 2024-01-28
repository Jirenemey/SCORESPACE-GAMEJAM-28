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
    private float chance;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Spawn());
    }

    void SpawnChance()
    {
        chance = Random.Range(0.0f, 100.0f);

        if(chance < 50.0f){
            Instantiate(temp1);
        } else if(chance > 50.0f && chance < 75.0f){
            Instantiate(temp2);
        } else if(chance > 75.0f && chance < 85.0f){
            Instantiate(temp3);
        } else if(chance > 85.0f && chance < 93.0f){
            Instantiate(temp4);
        } else {
            Instantiate(temp5);
        }
    }

    IEnumerator Spawn(){
        SpawnChance();
        yield return new WaitForSeconds(player.songSpeed);
    }

}
