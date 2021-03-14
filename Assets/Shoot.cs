using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float damage=10f;
    public float range=100f;
    public Camera fpsCam;
    
        public AudioClip[] clips;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        { 
            ShootIt();
            SoundManager.Instance.RandomSoundEffect(clips);

        }
    }
    void ShootIt(){
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward,out hit, range)){

           if( hit.transform.name.Contains("Zombie")){
                hit.transform.gameObject.SetActive(false);

           }else
           {
               Debug.Log(hit.transform.name);
           }
          
        }
    }
}
