using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSwitch2 : MonoBehaviour
{
    float tiempo;

    public GameObject camara;
    public GameObject sigCamara;

    public GameObject planetaRepresentado;

    public Vector3 diferenciaCamara;

    public bool mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        camara.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= 6 )
        {
            tiempo = 0;
            camara.SetActive(false);
            sigCamara.SetActive(true);
        }

        if(!mainCamera) transform.position = planetaRepresentado.transform.position + diferenciaCamara;

    }
}
