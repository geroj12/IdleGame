using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    [SerializeField] private Player player;

    private void Update()
    {
        CheckNextLevelCondition();
    }
 
    public void CheckNextLevelCondition()
    {
        if (player.currentExp >= player.maxExp)
        {
            NextLevel();
        }
    }

    public void NextLevel()
    {
        player.currentExp = 0;
        player.currentLevel += 1;
        player.maxExp += 10;
    }
}
