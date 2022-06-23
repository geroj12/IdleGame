using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitbox : MonoBehaviour
{
    [SerializeField] private Player player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("DoDmgToEnemy");
            collision.gameObject.GetComponent<HurtboxEnemy>().TakeDamage(player.damageValue);
        }     
    }
}
