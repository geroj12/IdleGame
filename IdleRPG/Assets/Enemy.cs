using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyData enemyData;
    public bool inBattle = false;

    public int maxHealth = 100;
    public int currentHealth = 0;

    public int damageValue = 0;
    public float attackSpeed = 0.0f;
    public string currentState = "";


    private void Start()
    {
        currentHealth = maxHealth;

    }

    private void Update()
    {
        Die();
    }


    public void Die()
    {
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
            GameObject.Find("Player").GetComponent<ExperienceSystem>().GainExp(enemyData.expAmountToGain);
        }
    }
    

}
