using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioSource Music;

    void OnTriggerEnter(Collider other)
    {
        GetComponent<BoxCollider>().enabled = false;
        Music.Play();
    }
}
