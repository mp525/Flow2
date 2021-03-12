using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        
         if (other.gameObject.tag == "first"){
             Debug.Log("Loading 1...");
          SceneManager.LoadScene (1);
         }
         if (other.gameObject.tag == "second"){
             Debug.Log("Loading 2...");
          SceneManager.LoadScene (2);
         }
         if (other.gameObject.tag == "third"){
          Debug.Log("Loading 3...");
          SceneManager.LoadScene (3);
          
         }
    }    
 }

