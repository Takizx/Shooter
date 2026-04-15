using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float velocidade=30.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * velocidade * Time.deltaTime, Space.World);
    }
}
