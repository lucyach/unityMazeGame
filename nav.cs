using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class nav : MonoBehaviour
{
    public GameObject destination;
    NavMeshAgent agent;
    static int cloneCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Ray correctMousePos = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit mostCorrectMousePos;
        if (Physics.Raycast(correctMousePos, out mostCorrectMousePos)) {
            agent.SetDestination(mostCorrectMousePos.point);
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject == destination && cloneCount < 15) {
            Instantiate(this.gameObject, this.transform.position, Quaternion.identity);
            cloneCount++;
            StartCoroutine(delay());
        }
    }

    IEnumerator delay() {
        yield return new WaitForSeconds(5);
    }
}
