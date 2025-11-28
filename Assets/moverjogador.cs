using UnityEngine;
using UnityEngine.InputSystem;

public class MoverJogador : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidade = 80f;   // ajusta aqui: 20 = rápido, 50 = muito rápido, 80+ = absurdamente rápido

    private Vector3 input;

    void Update()
    {
        input = Vector3.zero;

        if (Keyboard.current.wKey.isPressed)
            input += Vector3.forward;

        if (Keyboard.current.sKey.isPressed)
            input += Vector3.back;

        if (Keyboard.current.aKey.isPressed)
            input += Vector3.left;

        if (Keyboard.current.dKey.isPressed)
            input += Vector3.right;

        // Normaliza para evitar andar mais rápido na diagonal
        input = input.normalized;
    }

    void FixedUpdate()
    {
        // Movimento REAL do Rigidbody (aqui a velocidade funciona MESMO)
        rb.linearVelocity = input * velocidade + new Vector3(0, rb.linearVelocity.y, 0);
    }
}
