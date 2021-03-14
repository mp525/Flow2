using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
public class TeleportStuff : MonoBehaviour
{
    public GameObject tp;
     public GameObject tp2;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
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
