using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
    public float velocidade = 3.0f;
    public float gravidade = 9.8f;

    private CharacterController meuControle;

    void Start()
    {
            meuControle = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movimentoZ = Input.GetAxis("Vertical") * Vector3.forward * velocidade * Time.deltaTime;

        Vector3 movimentoX = Input.GetAxis("Horizontal") * Vector3.right * velocidade * Time.deltaTime;

        Vector3 movimento = transform.TransformDirection(movimentoZ+movimentoX);

        movimento.y -= gravidade * Time.deltaTime;

        meuControle.Move(movimento);
    }
}
