using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtboxEnemy : MonoBehaviour
{
    [SerializeField] private Enemy enemy;

    public void TakeDamage(int dmg)
    {
        enemy.currentHealth -= dmg;
    
    }   
}
