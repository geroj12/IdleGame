using UnityEngine;
using Aleksey;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public PlayerData playerData;
    public static Player instance;
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
    public int maxActionPoints = 5;
    public int strength = 0;
    public int defense = 0;

    [Header("Offense")]
    public int damageValue = 0;
    public float attackSpeed = 0.0f;

    [Header("Defense")]
    public int maxHealth = 100;
    public int healthRegenerationValue = 1;
    public int maxHealthRegenerationValue = 2;
    public float currentHealth = 0;


    [Header("PlayerClothing")]
    [SerializeField] private SpriteRenderer headGear;
    [SerializeField] private SpriteRenderer bodyGear;
    [SerializeField] private SpriteRenderer bottomGear;

    private void Awake()
    {
        InitPlayer();
    }

    private void Start()
    {
        TransferPlayerData();
    }
    
    void Update()
    {
        HandleInput(); 
        InitCloth();
        HandleStates();
        Die();    
    }

    private void TransferPlayerData()
    {
        healthRegenerationValue = playerData.SetHpRegen();
        Name = playerData.SetPlayerName();
        currentHealth = playerData.SetHealth();
        MovementSpeed = playerData.SetMovementSpeed();
        this.transform.localPosition = playerData.SetSpawnPosition(new Vector2(playerData.startPosX, playerData.startPosY));
    }

    private void InitPlayer()
    {
        maxActionPoints = 5;
        currentHealth = maxHealth;

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void HandleStates()
    {
        HandleHealthRegenStates();
        HandleActionPointsInputCondition(); 
    }

    private int HandleHealthRegenStates()
    {
        if (currentState == "Idle")
        {
            healthRegenerationValue = maxHealthRegenerationValue;
        }
        else if (currentState != "Idle")
        {
            healthRegenerationValue = 1;
        }
        return healthRegenerationValue;
    }

    private void HandleActionPointsInputCondition()
    {
        if (Input.GetKeyDown(KeyCode.E) && actionPoints > 0 && strength <5)
        {
            IncreaseStrength();
        }

        if (Input.GetKeyDown(KeyCode.Q) && actionPoints > 0 && defense <5)
        {
            IncreaseDefense();
        }
    }

    private void IncreaseStrength()
    {
        strength += 1;
        actionPoints -= 1;
        damageValue += 3;
        attackSpeed += 0.1f;
    }

    private void IncreaseDefense()
    {
        defense += 1;
        actionPoints -= 1;
        maxHealth += 10;
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
