using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
 using UnityEngine.SceneManagement;

public class Losing : MonoBehaviour
{

    public GameObject lose;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collision with: " + collider.gameObject.name);
        if(collider.gameObject.layer == 3 || collider.gameObject.tag == "Enemy"){
            Lose();
        }
        if (collider.gameObject.tag == "Win"){
          SceneManager.LoadScene (3);
        
         }
    }

    void Lose()
    {
        Debug.Log("lost");
        Time.timeScale = 0;
        lose.SetActive(true);
    }
}
