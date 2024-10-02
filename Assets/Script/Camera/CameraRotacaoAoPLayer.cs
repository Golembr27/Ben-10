using UnityEngine;

public class CameraRotacaoAoPLayer : MonoBehaviour
{
    public Transform jogador; // Refer�ncia ao jogador
    public float velocidadeRotacao = 5f;// Velocidade de rota��o da c�mera
    private Vector3 offset; // Offset da c�mera em rela��o ao jogador

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.rotation = Quaternion.Euler(-jogador.position.y, jogador.position.x, 0);

    }
}
