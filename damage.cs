using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int damageAmount;

    void OnTriggerEnter(Collider other)   
    
    {
        Health health = other.GetComponent<Health>();
        if (health!=null)
        {
            health.TakeDamage(1);
            Debug.Log("Has been hit!");

        }
    } 
  
}