using UnityEngine;
using UnityEngine.SceneManagement;

public class puerta: MonoBehaviour
{
    public string NuevoNivel; // Nombre de la escena que deseas cargar.

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Asegúrate de que el objeto que toca el objeto con este script tenga la etiqueta "Player".
        {
            // Cargar la escena cuando el jugador toque el objeto.
            SceneManager.LoadScene(NuevoNivel);
        }
    }
}