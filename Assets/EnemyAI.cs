
 using UnityEngine.AI;

 using UnityEngine;
 using System.Collections;
 
 public class EnemyAI : MonoBehaviour {

     float distance =22;
     private NavMeshAgent agent;
      private GameObject player;
      Animator anim;
        void Start(){
            anim =GetComponent<Animator>();
            player= GameObject.FindGameObjectWithTag("Player");;
     }
 void Update(){

    distance = Vector3.Distance(gameObject.transform.position,player.transform.position);

    if (distance<40f)
    {
     GetComponent<NavMeshAgent>().destination = player.transform.position;
        
    }
    if (distance<60)
    {
        float x =Random.Range(1,300);
        float y=Random.Range(1,300);;
        float z=Random.Range(-100,300);
    }
    else
    {
        
        GetComponent<NavMeshAgent>().destination=new Vector3(1,2,3);
    }


    if (distance<3f)
    {
        //Make animation

        anim.SetBool("Close",true);
        Debug.Log("arrrrrrg clap clap clap");

    }else
    {
        anim.SetBool("Close",false);
    }
 }
 
 
 }