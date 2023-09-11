using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OLAPB : MonoBehaviour
{
    public string etiquetaObjeto = "Blue";
    public GameObject objetoParaActivarDesactivar;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(etiquetaObjeto))
        {
            objetoParaActivarDesactivar.SetActive(true);
        }
    }
}
