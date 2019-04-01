using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarPlanetas : MonoBehaviour
{
    public GameObject planeta;
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
            for (int i = 0; i < 8;i++)
            {
                GameObject planetaClonado = Instantiate(planeta, new Vector3(i * 6.0f, 0, 0), Quaternion.identity);

                switch (i)
                {
                    case 0:
                        escala = new Vector3(3,3,3);
                        break;
                    case 1:
                        escala = new Vector3(5, 5, 5);
                        break;
                    case 2:
                        escala = new Vector3(3, 3, 3);
                        break;
                    case 3:
                        escala = new Vector3(1, 1, 1);
                        break;
                    case 4:
                        escala = new Vector3(4, 4, 4);
                        break;
                    case 5:
                        escala = new Vector3(2, 2, 2);
                        break;
                    case 6:
                        escala = new Vector3(6, 6, 6);
                        break;
                    case 7:
                        escala = new Vector3(3, 3, 3);
                        break;
                    default:
                    break;
                }

                planetaClonado.transform.localScale = escala;
                planetaClonado.GetComponent<MeshRenderer>().material = material;
               // planetaClonado.transform.localScale = new Vector3();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
