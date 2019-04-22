using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour
{
    public GameObject sol;
    public GameObject luna;
    public GameObject anillo1;
    public GameObject anillo2;
    public float radio;
    public float velocidadGiro;
    public float velocidadRotEje;
    public bool tieneLuna;
    public bool tieneAnillo;

    private float tiempo;
    private float tiempoSol;
    private float tiempoLuna;

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
