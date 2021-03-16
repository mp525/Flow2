using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Blast : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;
    [SerializeField] private float blastRadius = 6f;
    //[SerializeField] private float proximityRadius = 1.5f;
    [SerializeField] private float explosionForce = 10005f;
    public LayerMask targetLayerMask = new LayerMask();

    public Animator anim;
    
    public void SmashEvent(string s){
        
        Destroy(Instantiate(explosionPrefab, transform.position, Quaternion.identity), 3.0f);
        Explode();
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.E)){
            anim.SetTrigger("Smash");
            /* var colliders = Physics.OverlapSphere(transform.position, proximityRadius, targetLayerMask);
                if (colliders.Length > 0)
                    {
                        Explode();
                    } */
        }
        if(Input.GetKeyUp(KeyCode.E)){
            anim.ResetTrigger("Smash");
           
        }
    }

    void Explode() 
    {
        var colliders = Physics.OverlapSphere(transform.position, blastRadius, targetLayerMask);

        if (colliders.Length == 0) return;

            

            foreach (Collider col in colliders) 
            {
                var ragdoll = col.GetComponentInParent<RagdollHandler>();
                if (ragdoll) 
                    ragdoll.GoRagdoll(true);

                var navMeshAgent = col.GetComponentInParent<NavMeshAgent>();
                if (navMeshAgent)
                    navMeshAgent.enabled = false;

                var rigidbody = col.GetComponent<Rigidbody>();

                if (rigidbody == null) return; 

                Vector3 dir = col.transform.position - transform.position;

                rigidbody.AddForce(dir * explosionForce, ForceMode.Impulse);
            }

            
    }
}
