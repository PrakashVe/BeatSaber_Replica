using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{

    public LayerMask layer;
    private Vector3 previousPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.forward, out Hit ,1 , layer))
        {
            if (Vector3.Angle (transform.position- previousPos, Hit.transform.up)> 130)
            {
                Destroy(Hit.transform.gameObject);
            }
        }
        previousPos = transform.position;

        
    }
}
