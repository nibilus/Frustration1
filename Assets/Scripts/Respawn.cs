using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform player;
    public AudioSource Doh;
    public GameObject TheRedScreen;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = spawnPoint.transform.position;
            Physics.SyncTransforms();
            Doh.Play(); TheRedScreen.SetActive(true);
            TheRedScreen.GetComponent<Animation>().Play("RedScreen_Anim");
        }
    }
}
