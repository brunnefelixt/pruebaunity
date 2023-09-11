using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OLAPP : MonoBehaviour
{
    public string etiquetaObjeto = "Pink";
    public GameObject objetoParaActivarDesactivar;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(etiquetaObjeto))
        {
            objetoParaActivarDesactivar.SetActive(true);
        }
    }
}
