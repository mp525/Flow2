using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class WinGameLevel : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) {
       
         if (other.gameObject.tag == "Win"){
          SceneManager.LoadScene (3);
        
         }
    }
}
