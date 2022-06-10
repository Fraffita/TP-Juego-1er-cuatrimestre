using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEscalones : MonoBehaviour
{
    public GameObject Escalon;
    public Material Verde;
    public Material Rojo;
    GameObject GameManager;
   //public GameObject spawnN2;
   //public GameObject spawnN3;

    GameObject player;


    GameObject ultPlataforma1;
    GameObject ultPlataforma2;

    bool tocado;
    float posZ;
    float posX;
    float posZ2;
    keepTrack keepTrack;


    void Start()
    {
        posZ = Random.Range(-6.5f, 5.5f);
        posX = Random.Range(-81.5f, -69.5f);
        GameManager = GameObject.FindGameObjectWithTag("GameController");
        keepTrack = GameManager.GetComponent<keepTrack>();
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {

    }

    IEnumerator cambiocolor()
    {
        yield return new WaitForSeconds(3f);
        Escalon.gameObject.GetComponent<Renderer>().material = Rojo;
        Destroy(Escalon, 1);
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Player" && tocado == false)
        {

            //       // Instantiate(gameObject, new Vector3(transform.position.x - 8, transform.position.y, posZ), Quaternion.identity);
            Escalon.gameObject.GetComponent<Renderer>().material = Verde;
            StartCoroutine("cambiocolor");
            tocado = true;

        }

        //    keepTrack.Score++;
        //    Debug.Log(keepTrack.Score);
        //    Debug.Log("AwA");
        //    Debug.Log(tocado);

        //} 

    }
}

/* if (score < 7)
            {

                Instantiate(gameObject, new Vector3(transform.position.x - 8, transform.position.y, posZ), Quaternion.identity);
                Escalon.gameObject.GetComponent<Renderer>().material = Verde;
                StartCoroutine("cambiocolor");
                tocado = true;

            }

            if(score == 7)
            {
                ultPlataforma1 = Instantiate(gameObject, new Vector3(posX, 0.4f, 18), Quaternion.identity);
            }
            else if (score > 7)
            {

                Instantiate(gameObject, new Vector3(posX, transform.position.y, ultPlataforma1.transform.position.z +8  ), Quaternion.identity);
                Escalon.gameObject.GetComponent<Renderer>().material = Verde;
                StartCoroutine("cambiocolor");
                tocado = true;

            }

            if (score == 14)
            {
                ultPlataforma2 = Instantiate(gameObject, new Vector3(posX, 0.4f, 18), Quaternion.identity);
            }

            else if (score >= 14)
            {

                Instantiate(gameObject, new Vector3(ultPlataforma2.transform.position.x - 10, transform.position.y, posZ), Quaternion.identity);
                Escalon.gameObject.GetComponent<Renderer>().material = Verde;
                StartCoroutine("cambiocolor");
                tocado = true;

            } */
