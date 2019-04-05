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
            float f = 28.0f;

            for (int i = 1; i < 9;i++)
            {
                
                GameObject planetaClonado = Instantiate(planeta, new Vector3(i * 6.0f, 0, 0), Quaternion.identity);

                switch (i)
                {
                    case 1:
                        escala = new Vector3(1,1,1);
                        break;
                    case 2:
                        escala = new Vector3(3, 3, 3);
                        break;
                    case 3:
                        escala = new Vector3(3.5f, 3.5f, 3.5f);
                        break;
                    case 4:
                        escala = new Vector3(1.8f, 1.8f, 1.8f);
                        break;
                    case 5:
                        escala = new Vector3(6, 6, 6);
                        break;
                    case 6:
                        escala = new Vector3(5.5f, 5.5f, 5.5f);
                        break;
                    case 7:
                        escala = new Vector3(3, 3, 3);
                        break;
                    case 8:
                        escala = new Vector3(2.9f, 2.9f, 2.9f);
                        break;
                    default:
                    break;
                }

                planetaClonado.transform.localScale = escala;
                planetaClonado.GetComponent<MeshRenderer>().material = materialesPlanetas[i];
                planetaClonado.GetComponent<Planeta>().radio = 8 * i;
                planetaClonado.GetComponent<Planeta>().velocidadGiro = f / 20;
                planetaClonado.GetComponent<Planeta>().velocidadRotEje = f / 10;
                planetaClonado.GetComponent<Planeta>().tieneLuna = false;
                planetaClonado.GetComponent<Planeta>().tieneAnillo = false;
                // planetaClonado.GetComponent<Planeta>().sol = sol;

                //t.GetComponent<MeshRenderer>().material = materialesPlanetas[i];
                // planetaClonado.transform.localScale = new Vector3();
                f--;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
