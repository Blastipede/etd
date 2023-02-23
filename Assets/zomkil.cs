using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zomkil : MonoBehaviour
{public GameObject kilfx;
 
void OnTriggerEnter (Collider other)
{
if(other.CompareTag("Player"))
{   
    //destroyingzom
    Destroy(gameObject);
    //instantiatingzomblood
    Instantiate(kilfx,transform.position,transform.rotation);
    
}
}

   
 

}
