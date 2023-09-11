using UnityEngine;

public class regreso : MonoBehaviour
{
    public Transform puntoDeRespawn; // Arrastra el punto de respawn desde la jerarquía de Unity.

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Coloca al jugador en la posición del punto de respawn.
            GameObject jugador = collision.gameObject; // El jugador es el objeto que colisionó.

            if (puntoDeRespawn != null)
            {
                jugador.transform.position = puntoDeRespawn.position;
            }
        }
    }
}