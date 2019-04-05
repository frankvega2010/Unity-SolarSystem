using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarPlanetas : MonoBehaviour
{
    public GameObject planeta;
    //public GameObject sol;
    Vector3 escala;
    public Material material;

    public Material[] materialesPlanetas;
    //List<Material> materialesPlanetas;

    //materialesPlanetas(1);

    //transform.localScale = new vector3(1,1,1);
    //Transform t = Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
    //t.GetComponent<Tito>().edad = i;
    //t.GetComponent<MeshRenderer>().material = mat;

    // Start is called before the first frame update
    void Start()
    {
        if(planeta)
        {
            for (int i = 1; i < 9;i++)
            {
                
                GameObject planetaClonado = Instantiate(planeta, new Vector3(i * 6.0f, 0, 0), Quaternion.identity);

                switch (i)
                {
                    case 1:
                        escala = new Vector3(1,1,1);
                        planetaClonado.GetComponent<Planeta>().radio = 9;
                        planetaClonado.GetComponent<Planeta>().velocidadGiro = 6;
                        planetaClonado.GetComponent<Planeta>().velocidadRotEje = 10;
                        break;
                    case 2:
                        escala = new Vector3(3, 3, 3);
                        planetaClonado.GetComponent<Planeta>().radio = 18;
                        planetaClonado.GetComponent<Planeta>().velocidadGiro = 2;
                        planetaClonado.GetComponent<Planeta>().velocidadRotEje = 7;
                        break;
                    case 3:
                        escala = new Vector3(3.5f, 3.5f, 3.5f);
                        planetaClonado.GetComponent<Planeta>().radio = 36;
                        planetaClonado.GetComponent<Planeta>().velocidadGiro = 1.7f;
                        planetaClonado.GetComponent<Planeta>().velocidadRotEje = 8;
                        break;
                    case 4:
                        escala = new Vector3(1.8f, 1.8f, 1.8f);
                        planetaClonado.GetComponent<Planeta>().radio = 50;
                        planetaClonado.GetComponent<Planeta>().velocidadGiro = 1;
                        planetaClonado.GetComponent<Planeta>().velocidadRotEje = 5;
                        break;
                    case 5:
                        escala = new Vector3(6, 6, 6);
                        planetaClonado.GetComponent<Planeta>().radio = 70;
                        planetaClonado.GetComponent<Planeta>().velocidadGiro = 0.7f;
                        planetaClonado.GetComponent<Planeta>().velocidadRotEje = 6;
                        break;
                    case 6:
                        escala = new Vector3(5.5f, 5.5f, 5.5f);
                        planetaClonado.GetComponent<Planeta>().radio = 90;
                        planetaClonado.GetComponent<Planeta>().velocidadGiro = 0.5f;
                        planetaClonado.GetComponent<Planeta>().velocidadRotEje = 9;
                        break;
                    case 7:
                        escala = new Vector3(3, 3, 3);
                        planetaClonado.GetComponent<Planeta>().radio = 110;
                        planetaClonado.GetComponent<Planeta>().velocidadGiro = 0.3f;
                        planetaClonado.GetComponent<Planeta>().velocidadRotEje = 6;
                        break;
                    case 8:
                        escala = new Vector3(2.9f, 2.9f, 2.9f);
                        planetaClonado.GetComponent<Planeta>().radio = 130;
                        planetaClonado.GetComponent<Planeta>().velocidadGiro = 0.18f;
                        planetaClonado.GetComponent<Planeta>().velocidadRotEje = 4;
                        break;
                    default:
                    break;
                }

                planetaClonado.transform.localScale = escala;
                planetaClonado.GetComponent<MeshRenderer>().material = materialesPlanetas[i];
                planetaClonado.GetComponent<Planeta>().tieneLuna = false;
                planetaClonado.GetComponent<Planeta>().tieneAnillo = false;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
