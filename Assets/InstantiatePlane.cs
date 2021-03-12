using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePlane : MonoBehaviour
{   
      float distance =0;
      float Timer = 10;
     public GameObject PrefabPlaneWithMotion;
     public GameObject player;

     GameObject planeClone;
    // Update is called once per frame
    private void Start() {
        player=GameObject.FindWithTag("Player");
    }
     void Update()
 {
     Timer -= Time.deltaTime;

     if (Timer <= 0f)
     {
          distance=541-player.transform.position.z;
          Debug.Log(distance);
         if (distance>80)
         {
         Timer = 10f;     
         planeClone = Instantiate(PrefabPlaneWithMotion, new Vector3(487,14,541), transform.rotation) as GameObject;
           
         }
     }
 }
}
