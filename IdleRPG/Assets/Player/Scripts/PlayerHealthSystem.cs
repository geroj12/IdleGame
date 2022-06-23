using System.Collections;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour
{
    [SerializeField] private Player player;

    private void Start()
    {
        StartCoroutine(RegenerateHealth());
    }

    IEnumerator RegenerateHealth()
    {
        while (true)
        {
            if (player.currentHealth < player.maxHealth)
            {
                player.currentHealth += player.healthRegenerationValue;
                yield return new WaitForSecondsRealtime(1f);
            }
            else
            {
                yield return null;
            }
        }        
    }
}
