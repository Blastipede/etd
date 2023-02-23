using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{private Vector3 MoveForce;
public float MoveSpeed=50;
public float MaxSpeed=15;
public float Drag=0.98f;
public float SteerAngle=20;
public float Traction=1f;
public float maxfuel=50f;
public float dptrt=1f;
public GameObject text;
public int zomkills;
public Text kills;

    
    void Start()
    {
        text.SetActive(false);
    }

    
    void Update()
    {
        MoveForce+= transform.forward*MoveSpeed*Input.GetAxis("Vertical")*Time.deltaTime;
        transform.position+=MoveForce*Time.deltaTime;
        //drag
        MoveForce*=Drag;
        MoveForce=Vector3.ClampMagnitude(MoveForce,MaxSpeed);
        //steer
        float steerInput=Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up*steerInput*MoveForce.magnitude*SteerAngle*Time.deltaTime);
        //traction
        Debug.DrawRay(transform.position,MoveForce.normalized*3);
        Debug.DrawRay(transform.position,transform.forward*3,Color.blue);
        MoveForce=Vector3.Lerp(MoveForce.normalized,transform.forward,Traction*Time.deltaTime)*MoveForce.magnitude;
        //kills
        kills.text=zomkills.ToString();
    if(Input.GetKey(KeyCode.W)){
        Deplete();
    }
    if(maxfuel<=0)
    {
        MoveSpeed=0;
        text.SetActive(true);
    }
    
    }
    public void Deplete()
    {
        maxfuel-=dptrt*Time.deltaTime;
        
    }
public void OnTriggerEnter (Collider other)
{
if(other.CompareTag("zom"))
{   
  zomkills+=1;
}


}
}