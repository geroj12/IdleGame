using UnityEngine;

namespace Aleksey
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerDataScriptableObject", order = 0)]
    public class PlayerData : ScriptableObject
    {

        [Header("Player Stats")]
        public string pName = "";
        public int health = 0;
        public float moveSpeedValue = 0;
        public int hpRegenValue = 0;

        [Header("Init")]
        public float startPosX = 0f;
        public float startPosY = 0f;

        [Header("Clothing")]
        public Sprite playerHead;
        public Sprite playerBody;
        public Sprite playerBottom;

        public int SetHpRegen()
        {
            return hpRegenValue;
        }

        public float SetMovementSpeed()
        {
            return moveSpeedValue;
        }
   
        public string SetPlayerName()
        {
            return pName;
        }

        public int SetHealth()
        {
            return health;
        } 

        public Vector2 SetSpawnPosition(Vector2 vector2)
        {
            return vector2;
        }

    }

}
