using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomarblue : MonoBehaviour
{
    private GameObject objetoEnMano;
    private bool objetoAgarrado = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoAgarrado)
            {
                SoltarObjeto();
            }
            else
            {
                AgarrarObjeto();
            }
        }
    }

    void AgarrarObjeto()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3f))
        {
            if (hit.collider.CompareTag("Blue"))
            {
                objetoEnMano = hit.collider.gameObject;
                objetoEnMano.GetComponent<Rigidbody>().isKinematic = true;
                objetoEnMano.transform.SetParent(transform);
                objetoAgarrado = true;
            }
        }
    }

    void SoltarObjeto()
    {
        if (objetoEnMano != null)
        {
            objetoEnMano.GetComponent<Rigidbody>().isKinematic = false;
            objetoEnMano.transform.SetParent(null);
            objetoEnMano = null;
            objetoAgarrado = false;
        }
    }
}
