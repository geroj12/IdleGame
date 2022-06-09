using UnityEngine;

public class ExperienceSystem : MonoBehaviour
{
    [SerializeField] private Player player;

    public float  GainExp(int expAmount)
    {
        player.currentExp += expAmount;
        return expAmount;
    }
}
