using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public Transform PlayerTarget;
    
    
    private NavMeshAgent enemy;


    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
       enemy.SetDestination(PlayerTarget.position); 
    }
}
