using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEscalones : MonoBehaviour
{
    public GameObject Escalon;
    public Material Verde;
    public Material Rojo;

    private float posX;
    private float posY;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            Escalon.gameObject.GetComponent<Renderer>().material = Verde;
            StartCoroutine("cambiocolor");

            Instantiate(Escalon, new Vector3(-20, 2, 5), Quaternion.identity);

        }

    }

    IEnumerator cambiocolor()
    {
        yield return new WaitForSeconds(3f);
        Escalon.gameObject.GetComponent<Renderer>().material = Rojo;
        Escalon.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

}

