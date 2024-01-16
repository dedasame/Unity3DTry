using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int count = 0;
    [SerializeField] Text coinText;

    [SerializeField] AudioSource coinSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("collectible"))
        {
            Destroy(other.gameObject);
            count++;
            coinText.text = "Coins : " + count;
            coinSound.Play();
        }    
    }



}
