using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed = 1;
    public GameObject Slicedprefab;
    GameObject currentloc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * speed;
        Object.Destroy(this.gameObject, 20.0f);
       
    }

    private void OnMouseDown()
    {

        currentloc = Instantiate(Slicedprefab);
        currentloc.transform.position = this.transform.position;
        Destroy(this.gameObject);
        Destroy(currentloc, 5.0f);

    }
}
