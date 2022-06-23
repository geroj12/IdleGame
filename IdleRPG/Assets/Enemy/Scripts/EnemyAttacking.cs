using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacking : MonoBehaviour
{
    [SerializeField] private Enemy enemy;
    [SerializeField] private Animator enemyAnimator;


    private void Update()
    {
        enemyAnimator.SetFloat("AttackSpeedMultiplier", enemy.attackSpeed);
        if (enemy.currentState == "Battle")
        {
            enemyAnimator.SetBool("Attack", true);
        }
        else
        {
            enemyAnimator.SetBool("Attack", false);
        }

    }
}
