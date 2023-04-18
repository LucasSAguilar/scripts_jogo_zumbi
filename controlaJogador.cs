using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlaJogador : MonoBehaviour
{

    public float Velocidade = 10;
    Vector3 direcao;


    // Update is called once per frame
    void Update()
    {

        float eixoX = Input.GetAxis("Horizontal");
        float eixoY = Input.GetAxis("Vertical");

        direcao = new Vector3(eixoX, 0, eixoY);



    

        

        if(direcao != Vector3.zero)
        {
            GetComponent<Animator>().SetBool("Movendo", true);
        } else {
            GetComponent<Animator>().SetBool("Movendo", false);
        }
    }

    void FixedUpdate()
    {
    GetComponent<Rigidbody>().MovePosition
    (GetComponent<Rigidbody>().position + 
    (direcao * Velocidade * Time.deltaTime));
    }

}
