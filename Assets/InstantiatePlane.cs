using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePlane: MonoBehaviour {
    float distance = 0;
    float Timer = 1;
    public GameObject PrefabPlaneWithMotion;
    public GameObject player;

    GameObject planeClone;
    // Update is called once per frame
    private void Start() {
        player = GameObject.FindWithTag("Player");
    }
    void Update() {
        Timer -= Time.deltaTime;

        if (Timer <= 0f) {
            float r = Random.Range(0, 3);
            
            if (r == 1) {
                distance = 541 - player.transform.position.z;
                Debug.Log(distance);
                if (distance > 80) {
                    Timer = 4f;
                    planeClone = Instantiate(PrefabPlaneWithMotion, new Vector3(487, 14, 541), transform.rotation) as GameObject;
                }
                }
               if (r!=1)
               {
                    Timer = 4f;
                    float randomx = Random.Range(400, 600);
                    if (randomx > 483 & randomx < 490) {
                        randomx = +15;
                    }

                    float randomy = Random.Range(14, 30);
                    if (randomy > 12 & randomy < 15) {
                        randomx = +5;
                    }
                    planeClone = Instantiate(PrefabPlaneWithMotion, new Vector3(randomx, randomy, 541), transform.rotation) as GameObject; 
               }
                  
                
            }
        }



    }

