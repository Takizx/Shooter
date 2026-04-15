using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimento : MonoBehaviour
{
    public float magnitude=0.1f;

    public bool emX=false;
    public bool emZ=false;
    public bool emY=false;

    void Start()
    {
        emX = (Random.value>0.6f);
        emY = (Random.value>0.6f);
        emZ = (Random.value>0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        if(emY){
        gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * magnitude, Space.World);

        }
        if(emX){
        gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * magnitude, Space.World);
            
        }
        if(emZ){
        gameObject.transform.Translate(Vector3.back * Mathf.Cos(Time.timeSinceLevelLoad) * magnitude, Space.World);
            
        }




    }
}
