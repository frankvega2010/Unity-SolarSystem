using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputNave : MonoBehaviour
{
    private float tiempo;
    private float force;
    private Vector3 navePosition;
    private Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        force = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        navePosition = new Vector3(horizontal * force,0, vertical * force);

        rig.AddForce(navePosition,ForceMode.Impulse);
    }
}
