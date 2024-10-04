using System;
using UnityEngine;

public class CameraRotacaoAoPLayer : MonoBehaviour
{
    public int poderSeguir = 0;
    public Transform player; // Refer�ncia ao jogador
    public float velocidadeRotacao = 5f;// Velocidade de rota��o da c�mera
    private Vector3 offset; // Offset da c�mera em rela��o ao jogador

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        VerificarPosicaoPlayer();
        if(poderSeguir == 1)
        {
            transform.rotation = Quaternion.LookRotation(player.position - transform.position);
        }
    }
    
    public void VerificarPosicaoPlayer()
    {
        if(player.position.x >= -10 || player.position.x <= 10)
        {
            poderSeguir = 0;
        }
        if(player.position.x <= -10 || player.position.x >= 10)
        {
            poderSeguir = 1;
        }
    }
}
