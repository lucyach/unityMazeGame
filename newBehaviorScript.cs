using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("horizontal") == 1) {
            this.transform.Translate(new Vector3(1, 0, 0));
        }
        if (Input.GetAxis("horizontal") == -1) {
            this.transform.Translate(new Vector3(-1, 0, 0));
        }
        if (Input.GetAxis("vertical") == 1) {
            this.transform.Translate(new Vector3(0, 0, 1));
        }
        if (Input.GetAxis("vertical") == -1) {
            this.transform.Translate(new Vector3(0, 0, -1));
        }
    }
}
