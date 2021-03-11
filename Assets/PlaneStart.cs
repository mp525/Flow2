using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneStart : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.eulerAngles = new Vector3(
    gameObject.transform.eulerAngles.x,
    gameObject.transform.eulerAngles.y+90,
    gameObject.transform.eulerAngles.z
);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
