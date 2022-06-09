using System.Collections;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Animator playerAnimator;

  
    public void Update()
    {
        playerAnimator.SetFloat("AttackSpeedMultiplier", player.attackSpeed);
        if (player.currentState == "Battle")
        {
            
            playerAnimator.SetBool("Attack", true);
        }
        else
        {
            playerAnimator.SetBool("Attack", false);
        }
         
    }  
}
