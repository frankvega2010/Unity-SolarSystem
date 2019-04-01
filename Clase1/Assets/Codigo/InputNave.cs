using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputNave : MonoBehaviour
{
    //public GameObject nave;
    float tiempo;
    private Rigidbody rig;
    private float force;
    private Vector3 navePosition;

    //Transform t = Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
    //t.GetComponent<Tito>().edad = i;
    //t.GetComponent<MeshRenderer>().material = mat;

    

    //Input.GetKet(KeyCode.A)

    //Input.GetKetDown(KeyCode.Alpha1
    

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        force = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //tiempo += Time.deltaTime;

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        navePosition = new Vector3(horizontal * force,0, vertical * force);

        rig.AddForce(navePosition,ForceMode.Impulse);

        //transform.position = new Vector3(transform.position.x + horizontal * 10 * Time.deltaTime,
        //        transform.position.y ,
        //        transform.position.z + vertical * 10 * Time.deltaTime);

        if (Input.GetKey("space"))
        {
            //Debug.Log("space key was pressed");
            //rig.AddForce(Vector3.up*force,ForceMode.Impulse);
            
        }
    }
}
