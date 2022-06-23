using UnityEngine;

public class EnemyHitbox : MonoBehaviour
{
    [SerializeField] private Enemy enemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("DoDmgToPlayer");
            collision.gameObject.GetComponent<HurtboxPlayer>().TakeDamage(enemy.damageValue);
        }
    }
}
