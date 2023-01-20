using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent _enemy;
    private Animator _enemyAnimator;
    public Transform playerTarget;

    // Start is called before the first frame update
    void Start()
    {
        _enemy = GetComponent<NavMeshAgent>();
        _enemyAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        _enemy.SetDestination(playerTarget.position);

        if(_enemy.remainingDistance < 4) 
            _enemyAnimator.SetBool("isAttacking", true);
        else
        {
            _enemyAnimator.SetBool("isWalking", true);
        }
    }
}
