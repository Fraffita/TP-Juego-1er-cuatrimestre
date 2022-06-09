using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEscalones : MonoBehaviour
{
    public GameObject Escalon;
    public Material Verde;
    public Material Rojo;
    public GameObject GameManager;
    public GameObject spawnN2;
    public GameObject spawnN3;

    bool tocado;
    float posZ;
    float posX;
    float posZ2;

    void Start()
    {
       posZ = Random.Range(-6.5f, 5.5f);
        posX = Random.Range(-81.5f, -69.5f);
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && tocado == false) {

                int score = GameManager.GetComponent<keepTrack>().Score;
               


            if (score < 7)
            {
                score++;
                Instantiate(gameObject, new Vector3(transform.position.x - 8, transform.position.y, posZ), Quaternion.identity);
                Escalon.gameObject.GetComponent<Renderer>().material = Verde;
                StartCoroutine("cambiocolor");
                tocado = true;
                
            }

            if(score == 7)
            {
                GameObject ultPlataforma = Instantiate(gameObject, new Vector3(posX, 0.4f, 18), Quaternion.identity);
            }
            else if (score > 7)
            {

               

            }

            else if (score >= 14)
            {



            }

        }

    }

    IEnumerator cambiocolor()
    {
        yield return new WaitForSeconds(3f);
        Escalon.gameObject.GetComponent<Renderer>().material = Rojo;
        Destroy(Escalon, 1);
    }

}

