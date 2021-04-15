using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class erikaMovement : MonoBehaviour
{
    float x;
    float z;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        z = 0;
        Screen.lockCursor = true;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(Input.GetAxis("Horizontal")/2, 0, Input.GetAxis("Vertical")/2));
    	this.transform.Rotate(new Vector3(0, 5 * Input.GetAxis("Mouse X"), 0));
    }
}
