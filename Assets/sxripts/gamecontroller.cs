using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamecontroller : MonoBehaviour
{public float dprt;
public float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {timer-=dprt*Time.deltaTime;
    if(timer<=0)
    {
        SceneManager.LoadScene("SampleScene");
    }
        
    }
}
