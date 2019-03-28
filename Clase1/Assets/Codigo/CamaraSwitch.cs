using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSwitch : MonoBehaviour
{
    float tiempo;
    public GameObject camara;
    public GameObject camara2;
    bool camara1Active = true;
    bool camara2Active = false;
    //public bool camaraActiva;

    // Start is called before the first frame update
    void Start()
    {
        camara.SetActive(camara1Active);
        camara2.SetActive(camara2Active);
        //Debug.Log("Nombre del Planeta: ");
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 2)
        {
            
            camara.SetActive(!camara1Active);
            camara2.SetActive(!camara2Active);
            //camara.enabled = !camara.enabled;
            //camara2.enabled = !camara2.enabled;
            tiempo = 0;
        }
        //if (camaraActiva)
        //{
            
        //}
    }
}
