using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100; // Salud máxima del enemigo
    private int currentHealth;  // Salud actual del enemigo
    public Slider healthBar; // Barra de vida asignada desde el Inspector
    public GameObject canva;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    private void Update(){
        healthBar.transform.position = Camera.main.WorldToScreenPoint(transform.position + Vector3.up * 2.2f);

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHealthBar();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Desactivar el GameObject del enemigo en lugar de destruirlo
        gameObject.SetActive(false);
        Destroy(gameObject);
        canva.SetActive(true);
        
        // Programar la reaparición después de 5 segundos
        Invoke("Respawn", 2f);
    }

    private void Respawn()
    {
        // Restaurar la salud y reactivar el GameObject del enemigo
        currentHealth = maxHealth;
        UpdateHealthBar();
        gameObject.SetActive(true);

        // Puedes configurar la posición de reaparición del enemigo aquí según tus necesidades
    }

    private void UpdateHealthBar()
    {
        // Actualizar la barra de vida con la salud actual
        if (healthBar != null)
        {
            healthBar.value = (float)currentHealth / maxHealth;
        }
        
    }
}
