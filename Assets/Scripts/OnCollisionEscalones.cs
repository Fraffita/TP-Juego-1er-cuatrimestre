using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEscalones : MonoBehaviour
{
    public GameObject Escalon;
    public Material Verde;
    public Material Rojo;
    bool tocado;
    float posZ;

    void Start()
    {
       posZ = Random.Range(-6.5f, 5.5f);
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && tocado == false) {

          
                Instantiate(gameObject, new Vector3(transform.position.x - 8, transform.position.y, posZ), Quaternion.identity);
                Escalon.gameObject.GetComponent<Renderer>().material = Verde;
                StartCoroutine("cambiocolor");
                tocado = true;


        }

    }

    IEnumerator cambiocolor()
    {
        yield return new WaitForSeconds(3f);
        Escalon.gameObject.GetComponent<Renderer>().material = Rojo;
        Destroy(Escalon, 2);
    }

}

