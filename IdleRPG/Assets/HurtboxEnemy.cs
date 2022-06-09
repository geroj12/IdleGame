using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtboxEnemy : MonoBehaviour
{
    [SerializeField] private Enemy enemy;

    public void EnemyTakeDamage(int dmg)
    {
        enemy.currentHealth -= dmg;
    
    }   
}
