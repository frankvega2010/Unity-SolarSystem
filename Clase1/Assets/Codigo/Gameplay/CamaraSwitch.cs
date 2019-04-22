using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSwitch : MonoBehaviour
{
    public float velocidadGiro;
    public float radio;
    public GameObject camara;
    public GameObject sigCamara;
    public GameObject planetaRepresentado;

    private float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        camara.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= 6)
        {
            tiempo = 0;
            camara.SetActive(false);
            sigCamara.SetActive(true);
        }

        camara.transform.position = new Vector3(
            planetaRepresentado.transform.position.x + radio * Mathf.Cos(tiempo),
            camara.transform.position.y,
            planetaRepresentado.transform.position.z + radio * Mathf.Sin(tiempo));

        transform.rotation = Quaternion.Euler(0, tiempo * -velocidadGiro, 0);
    }
}
