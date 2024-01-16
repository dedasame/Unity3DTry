using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour
{

    [SerializeField] AudioSource deadSound;

    //Aþaðý düþerse 

    bool dead = false;
    private void Update()
    {
        if(transform.position.y < -1f && !dead)
        {
            Die();
        }
    }

    //Player'la temasa geçen nesneye göre ölmesi

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("enemy"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false; //yürümesini engeller
            Die();    
        }
    }

    void Die()
    { 
        Invoke(nameof(ReloadLevel),1.3f); //bekleyip metodu çaðýrýr
        dead = true;
        deadSound.Play();
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //var olan level adini alip bastan yukler.
    }





}
