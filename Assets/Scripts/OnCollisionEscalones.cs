using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEscalones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //MeshRenderer renderer = GetComponent<MeshRenderer>();
        //renderer.material = new Material(Shader.Find("Verde"));
        if (collision.gameObject.tag == "Untagged") {
            gameObject.SetActive(false); 
        }

        else
        {
            Debug.Log("No pasa nada");
        }
        //renderer.material = new Material(Shader.Find("Rojo"));
    }

}

