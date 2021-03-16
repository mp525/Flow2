using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RagdollHandler : MonoBehaviour
{
    void Start()
    {
        GoRagdoll(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            GoRagdoll(true);
        }
    }

    public void GoRagdoll(bool v)
    {
        if (v == true)
        {
            // disable animator
            GetComponent<Animator>().enabled = false;
            GetComponent<FindPlayer>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
            Destroy(gameObject, 3);
        }

        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in rigidbodies)
        {
            if (rb.gameObject != gameObject)
            {
                rb.useGravity = v;
                rb.isKinematic = !v;
            }
        }
        
    }
}
