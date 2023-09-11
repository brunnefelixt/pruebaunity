using UnityEngine;

public class movimientos : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 100.0f;

    private void Update()
    {
        // Obtener la entrada de movimiento horizontal y vertical.
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento en base a la dirección de la cámara.
        Vector3 movimiento = new Vector3(horizontal, 0.0f, vertical);
        movimiento = Camera.main.transform.TransformDirection(movimiento);
        movimiento.y = 0.0f; // Mantener el movimiento en el plano horizontal.

        // Aplicar el movimiento al transform del personaje.
        transform.Translate(movimiento * velocidadMovimiento * Time.deltaTime, Space.World);

        // Calcular la rotación del personaje.
        float rotacionY = horizontal * velocidadRotacion * Time.deltaTime;
        transform.Rotate(0, rotacionY, 0);
    }
}