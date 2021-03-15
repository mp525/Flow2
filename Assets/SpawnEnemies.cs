using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    private float timestamp = 0f;

    void Start()
    {
        //Instantiate(prefab, transform.position, Quaternion.identity);
    }

    void FixedUpdate(){
        if(timestamp <= Time.time){
            timestamp = Time.time + 2f + (Time.time - timestamp);
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
