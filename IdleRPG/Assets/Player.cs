using UnityEngine;
using Aleksey;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public PlayerData playerData;
    public bool inBattle = false;

    [Header("Info")]
    public string Name = "";
    public float MovementSpeed = 0.01f;
    public int currentExp = 0;
    public int maxExp = 100;
    public float traveledDistance = 0.0f;
    public string currentState = "";
    public int currentLevel = 1;

    [Header("Attributes")]
    public int actionPoints = 0;
    public int strength = 0;
    public int defense = 0;

    [Header("Offense")]
    public int damageValue = 0;
    public float attackSpeed = 0.0f;

    [Header("Defense")]
    public int maxHealth = 100;
    public int healthRegenerationValue = 1;
    public float currentHealth = 0;


    [Header("PlayerClothing")]
    [SerializeField] private SpriteRenderer headGear;
    [SerializeField] private SpriteRenderer bodyGear;
    [SerializeField] private SpriteRenderer bottomGear;

    private void Start()
    {

        currentHealth = maxHealth;

        healthRegenerationValue = playerData.SetHpRegenSpeed();
        Name = playerData.SetPlayerName();
        currentHealth = playerData.SetHealth();
        MovementSpeed = playerData.SetMovementSpeed();
        this.transform.localPosition = playerData.SetSpawnPosition(new Vector2(playerData.startPosX, playerData.startPosY));
    
    }
    
    void Update()
    {
        HandleInput(); 
        InitCloth();
        Die();
    }


    


    void Die()
    {
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("SampleScene");
            
        }
    }


    void HandleInput()
    {
        if (Input.GetMouseButtonUp(0) && !inBattle)
        {
            currentState = "Walk";
        }

        if (Input.GetKeyDown(KeyCode.Space) && !inBattle)
        {
            currentState = "Idle";
        }
    }


    void InitCloth()
    {
        headGear.sprite = playerData.playerHead;
        bodyGear.sprite = playerData.playerBody;
        bottomGear.sprite = playerData.playerBottom;
    }
   
}
