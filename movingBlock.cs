using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBlock : MonoBehaviour
{
    public float speed;
    public Vector3 startPos;
    public Vector3 endPos;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        speed = 8;
        startPos = transform.position;
        endPos = startPos + new Vector3(0, 0, -7);
        
        while (true) {
            yield return StartCoroutine(move(startPos, endPos, 2));
            yield return StartCoroutine(move(endPos, startPos, 2));
        }
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(speed*Time.deltaTime*Vector3.right);
        // yield return StartCoroutine("goRight");
    }

    IEnumerator move(Vector3 startPosVar, Vector3 endPosVar, float time)
    {
        float i = 0.0f;
        float rate = (1.0f/time);
        while (i < 1) {
            transform.position = Vector3.Lerp(startPosVar, endPosVar, i);
            i+=rate*Time.deltaTime;
            yield return null;
        }
    }
}
