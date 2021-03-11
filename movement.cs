using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public float angularSpeed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
        angularSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d")) {
            this.transform.Rotate(angularSpeed*Vector3.up);
        }
        if (Input.GetKey("a")) {
            this.transform.Rotate(angularSpeed*Vector3.down);
        }
        if (Input.GetKey("w")) {
            this.transform.Translate(speed*Time.deltaTime*Vector3.forward);
        }
        if (Input.GetKey("s")) {
            this.transform.Translate(speed*Time.deltaTime*Vector3.back);
        }
    }
}
