using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FindPlayer : MonoBehaviour
{
    
    private Animator anim;
    private NavMeshAgent agent;
    [SerializeField] private float runSpeed = 7f;

    public GameObject player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        agent.speed = runSpeed;
        agent.destination = GameObject.FindWithTag("Player").transform.position;
        anim.SetFloat("Speed", runSpeed);
    }
}
