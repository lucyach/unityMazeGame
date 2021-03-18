using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBlock : MonoBehaviour
{
    public float speed;
    public float leftWall;
    public float rightWall;
    public Vector3 startPos;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        speed = 8;
        leftWall = transform.position.x;
        rightWall = leftWall+10;
        startPos = transform.position;
        return null;
    }

    // Update is called once per frame
    IEnumerator Update()
    {
        // transform.Translate(speed*Time.deltaTime*Vector3.right);
        yield return StartCoroutine("goRight");
    }

    IEnumerator goRight()
    {
        transform.position = Vector3.Lerp(startPos, startPos + 10*(Vector3.right), 2);
        return null;
    }
}
