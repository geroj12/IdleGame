using TMPro;
using UnityEngine;

public class CharacterUI : MonoBehaviour
{
    [SerializeField] private Player player;
    public TextMeshProUGUI playerNameUI;   
    public TextMeshProUGUI playerHealthUI;
    public TextMeshProUGUI playerHealthRegenUI;
    public TextMeshProUGUI playerTraveledDistanceUI;

    public TextMeshProUGUI playerMovementSpeedUI;
    public TextMeshProUGUI playerExpUI;
    public TextMeshProUGUI playerMaxExpUI;
    public TextMeshProUGUI playerLevelUI;
    public TextMeshProUGUI playerStateUI;

    public TextMeshProUGUI playerApUI;
    public TextMeshProUGUI playerStrUI;
    public TextMeshProUGUI playerDefenseUI;

    public TextMeshProUGUI playerDamageValueUI;
    public TextMeshProUGUI playerAttackSpeedUI;

    public GameObject afterBattleUI;

    private void Update()
    {
        playerNameUI.text = "NAME: " + player.Name.ToString();
        playerHealthUI.text = "HP: " + player.currentHealth.ToString();
        playerHealthRegenUI.text = "HPr: " + player.healthRegenerationValue.ToString()
            + "hp/s";
        playerTraveledDistanceUI.text = "DIST: " + player.traveledDistance.ToString()
            + "m";

        playerLevelUI.text = "LEVEL: " + player.currentLevel.ToString();
        playerMovementSpeedUI.text = "SPD: " + player.MovementSpeed.ToString()
            + " m/s";
        playerExpUI.text = "EXP: " + player.currentExp.ToString();
        playerMaxExpUI.text = "MAX EXP: " + player.maxExp.ToString();
        playerStateUI.text = "STATE: " + player.currentState.ToString();

        playerApUI.text = "AP: " + player.actionPoints.ToString();
        playerStrUI.text = "STR: " + player.strength.ToString();
        playerDefenseUI.text = "DEX: " + player.defense.ToString();

        playerDamageValueUI.text = "DMG: " + player.damageValue.ToString();
        playerAttackSpeedUI.text = "SPD: " + player.attackSpeed.ToString();

        CheckIfPlayerInBattle();
    }

    private void CheckIfPlayerInBattle()
    {
        if (player.inBattle == true)
        {
            afterBattleUI.SetActive(false);
        }else if(player.inBattle == false)
        {
            afterBattleUI.SetActive(true);
        }


    }
}
