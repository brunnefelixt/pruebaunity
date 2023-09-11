using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OLAPM : MonoBehaviour
{
    public string etiquetaObjeto = "Mora";
    public GameObject objetoParaActivarDesactivar;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(etiquetaObjeto))
        {
            objetoParaActivarDesactivar.SetActive(true);
        }
    }
} 
