 using UnityEngine;
 using System.Collections;
 using UnityEngine.SceneManagement;

 public class Respawn : MonoBehaviour {
 
     public GameObject spawnPoint;
     public GameObject tp;
     public GameObject tp2;

    private void OnCollisionEnter(Collision other) {
         if(other.transform.tag == "Void")
         {
              this.transform.position = spawnPoint.transform.position;
         }

         if(other.transform.tag == "TP")
         {
              this.transform.position = tp.transform.position;
         }

         if(other.transform.tag == "l")
         {
              this.transform.position = tp2.transform.position;
         }
         if (other.gameObject.tag == "Win"){
          SceneManager.LoadScene (1);
         }
    }
     
 }