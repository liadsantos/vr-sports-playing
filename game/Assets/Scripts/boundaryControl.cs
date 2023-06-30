using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaryControl : MonoBehaviour
{
    public float xRange;
    public float zRange;
    public float xRangeN;
    public float zRangeN;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -xRangeN) {
            transform.position = new Vector3(-xRangeN, transform.position.y, transform.position.z);
        }
        else if (transform.position.z > zRange) {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        else if (transform.position.z < -zRangeN) {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRangeN);
        } 
    }
}
