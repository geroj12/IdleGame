using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Player playerHealth;
    [SerializeField] private Image fillImage;
  

    public void Update()
    {
        float fillValue = (float)playerHealth.currentHealth / (float)playerHealth.maxHealth;
        fillImage.fillAmount = fillValue;
    }

}
