using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour
{

    [SerializeField] AudioSource deadSound;

    //A�a�� d��erse 

    bool dead = false;
    private void Update()
    {
        if(transform.position.y < -1f && !dead)
        {
            Die();
        }
    }

    //Player'la temasa ge�en nesneye g�re �lmesi

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("enemy"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false; //y�r�mesini engeller
            Die();    
        }
    }

    void Die()
    { 
        Invoke(nameof(ReloadLevel),1.3f); //bekleyip metodu �a��r�r
        dead = true;
        deadSound.Play();
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //var olan level adini alip bastan yukler.
    }





}
