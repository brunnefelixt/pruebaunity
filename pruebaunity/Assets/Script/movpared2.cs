using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movpared2 : MonoBehaviour
{
    public float velocidad = 20f;
    public float distanciaMaxima = 2.0f;

    private Vector3 puntoInicial;
    private Vector3 puntoFinal;
    private bool direccionPositiva = false; // Cambiamos la dirección inicial

    // Start is called before the first frame update
    void Start()
    {
        puntoInicial = transform.position;
        puntoFinal = puntoInicial - Vector3.right * distanciaMaxima; // Invertimos la dirección
    }

    // Update is called once per frame
    void Update()
    {
        if (direccionPositiva)
        {
            transform.position = Vector3.MoveTowards(transform.position, puntoFinal, velocidad * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, puntoInicial, velocidad * Time.deltaTime);
        }
        if (transform.position == puntoFinal)
        {
            direccionPositiva = false;
        }
        else if (transform.position == puntoInicial)
        {
            direccionPositiva = true;
        }
    }
}