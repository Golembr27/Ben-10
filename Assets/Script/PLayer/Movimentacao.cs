using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    private float forcaDePulo = 5f;
    private bool estaNoChao = true;
    private float gravidade = 9.81f;
    public float velocidadeDeQueda = 5f;
    private Vector3 velocidadeGravidade;
    private Vector3 posicaoAnterior;

    private int velocidadeDoPlayer = 5;
    private CharacterController controleDePersonagem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controleDePersonagem = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //O salto do Player
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
        {
            Pulo();
        }

        if ( transform.position.y != 0 /*!estaNoChao*/)
        {
            velocidadeGravidade.y -= gravidade * Time.deltaTime;
            controleDePersonagem.Move(velocidadeGravidade * Time.deltaTime);

            Vector3 posicaoAtual = transform.position;
            Vector3 posicaoDesejada = posicaoAtual + velocidadeGravidade * Time.deltaTime;
            transform.position = Vector3.Lerp(posicaoAnterior, posicaoDesejada, velocidadeDeQueda * Time.deltaTime);
            posicaoAnterior = posicaoAtual;
        }

        //Movimentação do Player
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moventacao = new Vector3 (horizontal, 0, vertical);

        controleDePersonagem.Move(moventacao * velocidadeDoPlayer * Time.deltaTime);
    }

    public void Pulo()
    {
        velocidadeGravidade = new Vector3(0, forcaDePulo, 0);
        estaNoChao = false;
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Chao"))
        {
            estaNoChao = true;
            velocidadeGravidade.y = 0;
        }
    }
}
