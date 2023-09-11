using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public int damagePerShot = 20; // Daño por disparo
    public float timeBetweenShots = 0.5f; // Tiempo entre disparos
    public LayerMask enemyLayer; // Capa de los enemigos

    private float timer; // Temporizador para controlar el tiempo entre disparos
    private Ray shootRay; // Rayo de disparo
    private RaycastHit shootHit; // Información sobre el impacto del rayo

    private void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetButtonDown("Fire1") && timer >= timeBetweenShots)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        timer = 0f;

        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;

        if (Physics.Raycast(shootRay, out shootHit, Mathf.Infinity, enemyLayer))
        {
            EnemyHealth enemyHealth = shootHit.collider.GetComponent<EnemyHealth>();

            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damagePerShot);
            }
        }
    }
}
