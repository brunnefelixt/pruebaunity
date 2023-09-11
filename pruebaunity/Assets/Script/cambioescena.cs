using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioescena : MonoBehaviour
{
    public string nombre;
  
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
    
        SceneManager.LoadScene(nombre);
    

        }
    }
}