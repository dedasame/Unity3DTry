using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour
{
    //Player'la temasa ge�en nesneye g�re �lmesi

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("enemy"))
        {
            Die();    
        }
    }

    void Die()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent <PlayerMovement>().enabled = false; //y�r�mesini engeller
        Invoke(nameof(ReloadLevel),1.3f); //bekleyip metodu �a��r�r    
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //var olan level adini alip bastan yukler.
    }





}
