using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    [SerializeField] private Transform targetLocation;
    private NavMeshAgent meshAgent;
    void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        meshAgent.destination = targetLocation.position;   
    }
}
