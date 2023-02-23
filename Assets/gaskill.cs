using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaskill : MonoBehaviour
{
    // Start is called before the first frame update
 
 public GameObject kilfx1;
 
public void OnTriggerEnter (Collider other)
{
if(other.CompareTag("toxic"))
{   
    //destroyingzom
    Destroy(gameObject);
    //instantiatingzomblood
    Instantiate(kilfx1,transform.position,transform.rotation);
    
}
}
}

