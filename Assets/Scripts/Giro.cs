using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    public float velocidade=180.0f;
    public bool rotacaoX=false;
    public bool rotacaoY=false;
    public bool rotacaoZ=false;

    // Start is called before the first frame update
    void Start()
    {
        rotacaoX=(Random.value>0.7f);
        rotacaoY=(Random.value>0.7f);
        rotacaoZ=(Random.value>0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        if(rotacaoY){
            gameObject.transform.Rotate(Vector3.up * velocidade * Time.deltaTime, Space.World);
        }
        if(rotacaoZ){
            gameObject.transform.Rotate(Vector3.back * velocidade * Time.deltaTime, Space.World);
        }
        if(rotacaoX){
            gameObject.transform.Rotate(Vector3.right * velocidade * Time.deltaTime, Space.World);
        }
    }
}
