using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    AudioSource source;
    public GameObject PlayerSpawnPosition;
    private bool Isdead = false;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Isdead = true;
            if (Isdead){

                source.Play();

            }
            collision.gameObject.transform.position = PlayerSpawnPosition.transform.position;

            Isdead = false;
        }
    }
}
