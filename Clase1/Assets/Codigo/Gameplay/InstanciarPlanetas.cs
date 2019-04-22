using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarPlanetas : MonoBehaviour
{
    public GameObject planeta;
    public Material material;
    public Material[] materialesPlanetas;

    private Vector3 escala;
    // Start is called before the first frame update
    void Start()
    {
        if(planeta)
        {
            for (int i = 1; i < 9;i++)
            {
                GameObject planetaClonado = Instantiate(planeta, new Vector3(i * 6.0f, 0, 0), Quaternion.identity);

                Planeta planetaInstanciado = planetaClonado.GetComponent<Planeta>();
                MeshRenderer planetaMesh = planetaClonado.GetComponent<MeshRenderer>();
                switch (i)
                {
                    case 1:
                        escala = new Vector3(1,1,1);
                        planetaInstanciado.radio = 9;
                        planetaInstanciado.velocidadGiro = 6;
                        planetaInstanciado.velocidadRotEje = 10;
                        break;
                    case 2:
                        escala = new Vector3(3, 3, 3);
                        planetaInstanciado.radio = 18;
                        planetaInstanciado.velocidadGiro = 2;
                        planetaInstanciado.velocidadRotEje = 7;
                        break;
                    case 3:
                        escala = new Vector3(3.5f, 3.5f, 3.5f);
                        planetaInstanciado.radio = 36;
                        planetaInstanciado.velocidadGiro = 1.7f;
                        planetaInstanciado.velocidadRotEje = 8;
                        break;
                    case 4:
                        escala = new Vector3(1.8f, 1.8f, 1.8f);
                        planetaInstanciado.radio = 50;
                        planetaInstanciado.velocidadGiro = 1;
                        planetaInstanciado.velocidadRotEje = 5;
                        break;
                    case 5:
                        escala = new Vector3(6, 6, 6);
                        planetaInstanciado.radio = 70;
                        planetaInstanciado.velocidadGiro = 0.7f;
                        planetaInstanciado.velocidadRotEje = 6;
                        break;
                    case 6:
                        escala = new Vector3(5.5f, 5.5f, 5.5f);
                        planetaInstanciado.radio = 90;
                        planetaInstanciado.velocidadGiro = 0.5f;
                        planetaInstanciado.velocidadRotEje = 9;
                        break;
                    case 7:
                        escala = new Vector3(3, 3, 3);
                        planetaInstanciado.radio = 110;
                        planetaInstanciado.velocidadGiro = 0.3f;
                        planetaInstanciado.velocidadRotEje = 6;
                        break;
                    case 8:
                        escala = new Vector3(2.9f, 2.9f, 2.9f);
                        planetaInstanciado.radio = 130;
                        planetaInstanciado.velocidadGiro = 0.18f;
                        planetaInstanciado.velocidadRotEje = 4;
                        break;
                    default:
                    break;
                }

                planetaClonado.transform.localScale = escala;
                planetaMesh.material = materialesPlanetas[i];
                planetaInstanciado.tieneLuna = false;
                planetaInstanciado.tieneAnillo = false;
            }
        }
        
    }
}
