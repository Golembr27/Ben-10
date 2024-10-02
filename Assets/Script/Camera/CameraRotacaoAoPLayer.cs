using UnityEngine;

public class CameraRotacaoAoPLayer : MonoBehaviour
{
    public Transform jogador; // Referência ao jogador
    public float velocidadeRotacao = 5f;// Velocidade de rotação da câmera
    private Vector3 offset; // Offset da câmera em relação ao jogador

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
