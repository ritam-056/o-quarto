using UnityEngine;

public class SeguirJogador : MonoBehaviour
{
    [Header("Referência do Jogador")]
    public Transform jogador; // arraste o Player aqui no Inspetor

    [Header("Configurações de Distância")]
    public Vector3 offset = new Vector3(0f, 5f, -10f); // posição relativa da câmera

    [Header("Velocidade da Câmera")]
    public float velocidadeSuavizacao = 5f; // quanto maior, mais rápida a câmera segue

    void LateUpdate()
    {
        if (jogador == null)
            return;

        // posição desejada da câmera
        Vector3 posDesejada = jogador.position + offset;

        // mover a câmera suavemente
        transform.position = Vector3.Lerp(transform.position, posDesejada, velocidadeSuavizacao * Time.deltaTime);

        // opcional: manter a câmera olhando para o jogador
        // transform.LookAt(jogador);
    }
}
