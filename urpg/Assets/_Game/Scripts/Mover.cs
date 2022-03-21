using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour{
    
    
    NavMeshAgent playerAgent;

    private void Start() {
        playerAgent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        if(Input.GetMouseButtonDown(0)) {
            MoveToCursor();
        }
    }

    private void MoveToCursor() {
        RaycastHit hitInfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hitInfo)) {
            playerAgent.SetDestination(hitInfo.point);
        }
    }

}
