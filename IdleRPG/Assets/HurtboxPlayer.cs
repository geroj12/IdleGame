using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtboxPlayer : MonoBehaviour
{
    [SerializeField] private Player player;

    public void PlayerTakeDamage(int dmg)
    {
        player.currentHealth -= dmg;
    }
}
