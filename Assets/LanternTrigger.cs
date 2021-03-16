using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class LanternTrigger : MonoBehaviour
{
    public BoxCollider collider;
    public GameObject player;

    public Transform lanternTransform;

     [SerializeField] private float proximityRadius = 1.5f;
    public LayerMask targetLayerMask = new LayerMask();

    [SerializeField] private GameObject explosionPrefab;

    public GameObject next;

    public GameObject winSpawn;

    public GameObject win;

    public GameObject portalWin;

     //public AudioSource audioData;

    void Start()
    {
        //audioData = GetComponent<AudioSource>();
    }

    void FixedUpdate(){
        var colliders = Physics.OverlapSphere(transform.position, proximityRadius, targetLayerMask);
        
        if (colliders.Length > 0)
        {
          Dissappear();
        }
    }

    public void Dissappear(){
        //audioData.Play();
        var colliders = Physics.OverlapSphere(transform.position, proximityRadius, targetLayerMask);
        if (colliders.Length == 0) return;

        Destroy(Instantiate(explosionPrefab, transform.position, Quaternion.identity), 3.0f);

        gameObject.SetActive(false);

        if(next.name.Equals("WinSpawn")){
            player.transform.position = winSpawn.transform.position;
            win.SetActive(true);
            portalWin.SetActive(true);
        }

        next.SetActive(true);

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, proximityRadius);
    }

}
