using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del enemigo
    public float boundary = 10f; // Límite donde el enemigo cambiará de dirección

    private bool movingRight = true; // Variable para rastrear la dirección del movimiento

    void Update()
    {
        
        // Mover el enemigo hacia adelante en su dirección actual
        Vector3 movement = movingRight ? Vector3.forward : -Vector3.forward;
        transform.Translate(movement * speed * Time.deltaTime);

        // Si el enemigo alcanza el límite, cambia de dirección
        if (Mathf.Abs(transform.position.z) >= boundary)
        {
            movingRight = !movingRight;
        }
    }
}
