using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public GameObject point;  
    public GameObject plane;

    public int speed;
    private float dist;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dist=Vector3.Distance(transform.position, point.transform.position);
        
        Go();

    }
    void Go(){
        transform.Translate(Vector3.left * speed * Time.deltaTime);

    }
    
}
