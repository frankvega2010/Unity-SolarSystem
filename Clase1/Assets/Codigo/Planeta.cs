using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour
{
    // public string nombrePlaneta;
    public float radio;
    public float velocidadGiro;
    float tiempo;
    float tiempoSol;
    float tiempoLuna;
    public float velocidadRotEje;
    public GameObject sol;
    public bool tieneLuna;
    public GameObject luna;

    public bool tieneAnillo;
    public GameObject anillo1;
    public GameObject anillo2;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Nombre del Planeta: " + nombrePlaneta);
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime * velocidadGiro;
        tiempoSol += Time.deltaTime;
        tiempoLuna += Time.deltaTime * 5;

        sol.transform.rotation = Quaternion.Euler(0, tiempoSol * 10, 0);

        transform.position = new Vector3(
            sol.transform.position.x + radio * Mathf.Cos(tiempo), 
            transform.position.y , 
            sol.transform.position.z + radio * Mathf.Sin(tiempo));

        transform.rotation = Quaternion.Euler(0, tiempoSol * velocidadRotEje, 0);

        if (tieneLuna)
        {
            luna.transform.position = new Vector3(
            transform.position.x + 6 * Mathf.Cos(tiempoLuna),
            luna.transform.position.y,
            transform.position.z + 6 * Mathf.Sin(tiempoLuna));
            luna.transform.rotation = Quaternion.Euler(0, tiempoSol * 5, 0);
        }

        if (tieneAnillo)
        {
            anillo1.transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z );

            anillo2.transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z);

            anillo1.transform.rotation = Quaternion.Euler(0, tiempoSol * 5, 0);
            anillo2.transform.rotation = Quaternion.Euler(0, tiempoSol * 5, 180);
        }

    }
}
