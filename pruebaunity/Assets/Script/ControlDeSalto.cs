using UnityEngine;

public class ControlDeSalto: MonoBehaviour
{
    public float Jumpv = 0.4f;
    public Rigidbody rb; // Fuerza del salto
    public float thrust = 10;
    bool m_isGrounded; // Indica si el personaje está en el suelo

    // Función que se llama al inicio del juego
    void Start()
    {
        // Obtener el componente Rigidbody del personaje
        rb = GetComponent<Rigidbody>();
        m_isGrounded = true;
    }

    // Función que se llama en cada frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&m_isGrounded==true){
            Jump();
        }
    }
    public void Jump(){
        m_isGrounded = false;
        rb.AddForce(0,thrust,0, ForceMode.Impulse);
    }

    void OnCollision(Collision other){
        if (other.gameObject.CompareTag("Ground")){
            m_isGrounded = true;
        }
    }
}
