using UnityEngine;

[CreateAssetMenu(fileName ="EnemyData",menuName = "ScriptableObjects/EnemyDataScriptableObject",order = 1)]
public class EnemyData : ScriptableObject
{
    [Header("Enemy Stats")]
    public int expAmountToGain = 0;

}
