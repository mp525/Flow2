 using UnityEngine;

using UnityEngine.UI;
 public class Respawn : MonoBehaviour {
 
     public GameObject spawnPoint;
     

     private int currentHealth = 100; 
    private int maxhealth = 100; 
      [SerializeField] private HealthDisplay healthDisplay;

    private void OnCollisionEnter(Collision other) {
         if(other.transform.tag == "Void")
         {
              TakeDamage(110);
              if (healthDisplay.GetCurrentHealth()<0)
              {
                    this.transform.position = spawnPoint.transform.position;
              }
         if (healthDisplay.GetCurrentHealth()<0.1)
        {
            healthDisplay.SetCurrentHealth(100);
        }
             
         }

         if(other.transform.tag == "plane")
         {
              TakeDamage(80);
              if (healthDisplay.GetCurrentHealth()<0)
              {
                    this.transform.position = spawnPoint.transform.position;
              }
         if (healthDisplay.GetCurrentHealth()<0.1)
        {
            healthDisplay.SetCurrentHealth(100);
        }
             
         }
         if(other.transform.tag == "zombie")
         {
              TakeDamage(34);
              if (healthDisplay.GetCurrentHealth()<0)
              {
                    this.transform.position = spawnPoint.transform.position;
              }
         if (healthDisplay.GetCurrentHealth()<0.1)
        {
            healthDisplay.SetCurrentHealth(100);
        }
             
         }
         if(other.transform.tag == "health")
         {
            healthDisplay.SetCurrentHealth(healthDisplay.GetCurrentHealth()+50);
            if (healthDisplay.GetCurrentHealth()>100)
            {
               healthDisplay.SetCurrentHealth(100);

            }
            
         }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthDisplay.SetCurrentHealth(healthDisplay.GetCurrentHealth() - damage);
       
    }
     
 }