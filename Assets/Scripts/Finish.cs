using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    //tetiklendiðinde oyunu bitirmek için
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //bir sonraki sahneye geçirir.
        }
        
    }

}
