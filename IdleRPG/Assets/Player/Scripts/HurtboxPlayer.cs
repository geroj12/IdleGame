using UnityEngine;

public class HurtboxPlayer : MonoBehaviour
{
    [SerializeField] private Player player;

    public void TakeDamage(int dmg)
    {
        player.currentHealth -= dmg;
    }
}
