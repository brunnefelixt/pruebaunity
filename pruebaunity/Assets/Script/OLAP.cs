using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OLAP : MonoBehaviour
{
    public string etiquetaObjeto = "Red";
    public GameObject objetoParaActivarDesactivar;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(etiquetaObjeto))
        {
            objetoParaActivarDesactivar.SetActive(true);
        }
    }
    
}