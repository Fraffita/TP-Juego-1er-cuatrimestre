using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorEscalones : MonoBehaviour
{
    public GameObject Escalones;
    public float RangoCreacion = 14f;
    void Start()
    {
        Invoke("Creando", 0);
    }


    public void Creando()
    {
        Vector3 SpawnPosition = new Vector3(0, 0, 0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3(-9.7f, 1.7f, SpawnPosition.z);

        GameObject Escalon = Instantiate(Escalones, SpawnPosition, Quaternion.identity);
    }
}
